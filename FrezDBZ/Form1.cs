using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml;
using System.Data.Common;
using System.IO;

namespace FrezDBZ
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;

        public Form1()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RezciDB"].ConnectionString);
            sqlConnection.Open();

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.типРезцаToolStripMenuItem.DropDownItems.Clear();

            var command = "SELECT RezecType, TypeName FROM TypeTable";

            SqlDataReader sqlreader = null;

            ToolStripItem item = null;

            try
            {

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                sqlreader = sqlCommand.ExecuteReader();


                while (sqlreader.Read())
                {
                    item = this.типРезцаToolStripMenuItem.DropDownItems.Add(Convert.ToString(sqlreader["TypeName"]));
                    item.Tag = Convert.ToString(sqlreader["RezecType"]);
                }

                //вытаскивание типов фрез ид бд
                //добавление каждого как элемент коллекции dropdownitems

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlreader != null && !sqlreader.IsClosed)
                {
                    sqlreader.Close();
                }

            }

        }

        private void типРезцаToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var command1 = "SELECT RezciTable.ID as [ID],TypeTable.TypeName as [Type], SteelTable.SteelGrade as [SteelGrade], SteelTable.SteelHardness as [SteelHardness]" +
                " FROM RezciTable JOIN TypeTable ON RezciTable.RezecType = TypeTable.RezecType" +
                " JOIN SteelTable ON RezciTable.StealGrade = SteelTable.SteelGradeID" +
                " WHERE RezciTable.RezecType = ";

            var command2 = "SELECT TypeTable.TypeImage as [image] FROM TypeTable" +
                " WHERE TypeTable.RezecType = ";


            var command3 = "SELECT TypeTable.TypeName as [TypeName], TypeTable.TypeDescription as [Description]" +
                " FROM TypeTable WHERE TypeTable.RezecType = ";


            SqlDataReader sqlreader = null;
            foreach (ToolStripDropDownItem item in типРезцаToolStripMenuItem.DropDownItems)
            {
                if (item.Selected)
                {
                    command1 += Convert.ToString(item.Tag);

                    command2 += Convert.ToString(item.Tag);

                    command3 += Convert.ToString(item.Tag);


                    try
                    {

                        SqlCommand sqlCommand = new SqlCommand(command3, sqlConnection);

                        sqlreader = sqlCommand.ExecuteReader();

                        sqlreader.Read();

                        this.RezecTypeName.Text = Convert.ToString(sqlreader["TypeName"]);
                        this.RezecTypeDescription.Text = Convert.ToString(sqlreader["Description"]);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {

                        if (sqlreader != null && !sqlreader.IsClosed)
                        {
                            sqlreader.Close();
                        }

                    }


                    try
                    {

                        SqlCommand sqlCommand = new SqlCommand(command2, sqlConnection);

                        sqlreader = sqlCommand.ExecuteReader();

                        MemoryStream memoryStream = new MemoryStream();
                        foreach (DbDataRecord record in sqlreader)
                            memoryStream.Write((byte[])record["image"], 0, ((byte[])record["image"]).Length);

                        Image image = Image.FromStream(memoryStream);

                        FrezPicture.Image = image;

                        memoryStream.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {

                        if (sqlreader != null && !sqlreader.IsClosed)
                        {
                            sqlreader.Close();
                        }

                    }

                    listView1.Items.Clear();
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(command1, sqlConnection);

                        sqlreader = sqlCommand.ExecuteReader();



                        ListViewItem listitem = null;


                        while (sqlreader.Read())
                        {
                            listitem = new ListViewItem(new string[]
                            {
                                Convert.ToString(sqlreader["Type"]),
                                Convert.ToString(sqlreader["SteelGrade"]),
                                Convert.ToString(sqlreader["SteelHardness"])

                            });
                            listitem.Tag = sqlreader["ID"];
                            listView1.Items.Add(listitem);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sqlreader != null && !sqlreader.IsClosed)
                        {
                            sqlreader.Close();
                        }

                    }


                    типРезцаToolStripMenuItem.HideDropDown();
                }
            }

        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}