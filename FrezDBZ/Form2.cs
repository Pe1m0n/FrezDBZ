using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrezDBZ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.comboBox5.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
        }


        #region find Kv

        private void TakeKmv(string s, double P, string s2)
        {

            switch (s)
            {
                case "Сталь":
                    Take_nv(s, s2);
                    this.Kmv = Math.Pow((P / 750), (this.nv));
                    break;

                case "Серый чугун":
                    Take_nv(s, s2);
                    this.Kmv = Math.Pow((P / 190), (this.nv));
                    break;

                case "Ковкий чугун":
                    Take_nv(s, s2);
                    this.Kmv = Math.Pow((P / 150), (this.nv));
                    break;

                case "Медные гетерогенные сплавы":
                    this.Kmv = 0.85;
                    break;

                case "Медные свинцовистые сплавы при основной гетерогенной структуре":
                    this.Kmv = 1.7;
                    break;

                case "Медные гомогенные сплавы":
                    this.Kmv = 2;
                    break;

                case "Медные сплавы с сожержание свинца < 10% при основной гомогенной структуре":
                    this.Kmv = 4;
                    break;

                case "Медь":
                    this.Kmv = 8;
                    break;

                case "Медные сплавы с содержание свинца > 15%":
                    this.Kmv = 12;
                    break;

                case "Силумин":
                    this.Kmv = 0.9;
                    break;

                case "Дюралюминий":
                    this.Kmv = 1.2;
                    break;


                default:
                    Take_nv(s, s2);
                    this.Kmv = Math.Pow((P / 750), (this.nv));
                    break;
            }

        }

        private void TakeKr(string s)
        {
            switch (s)
            {
                case "Сталь угреродистая C<0,6%":
                    this.Kr = 1;
                    break;

                case "Сталь углеродистая С>0,6%":
                    this.Kr = 0.9;
                    break;

                case "Сталь хромоникелевая, хромомолибденованадиевая":
                    this.Kr = 0.85;
                    break;

                case "Сталь хромомарганцовистая, хромокремнистая, хромокремнемарганцовистая, хромоникельмолибденовая, хромомолибденоалюминиевая":
                    this.Kr = 0.75;
                    break;

                case "Сталь хромованадиевая":
                    this.Kr = 0.825;
                    break;

                case "Сталь марганцовистая":
                    this.Kr = 0.875;
                    break;

                case "Сталь хромоникельвольфрамовая, хромомолибденовая":
                    this.Kr = 0.825;
                    break;

                case "Сталь хромоалюминиевая":
                    this.Kr = 0.775;
                    break;

                case "Сталь хромоникельванадиевая":
                    this.Kr = 0.8;
                    break;

                case "Быстрорежущие стали":
                    this.Kr = 0.65;
                    break;

                case "Серый чугун":
                    this.Kr = 1;
                    break;

                case "Ковкий чугун":
                    this.Kr = 1;
                    break;

                default:
                    this.Kr = 1;
                    break;

            }


        }
        private void Take_nv(string s, string s1)//s - обрабатываемый метериал, s1 - материал резца
        {
            if (s1 == "Быстрорежущая сталь")
            {
                switch (s)
                {
                    case "Сталь угреродистая C<0,6%":
                        this.nv = 1.75;
                        break;

                    case "Сталь углеродистая С>0,6%":
                        this.nv = 1.75;
                        break;

                    case "Сталь хромоникелевая, хромомолибденованадиевая":
                        this.nv = 1.75;
                        break;

                    case "Сталь хромомарганцовистая, хромокремнистая, хромокремнемарганцовистая, хромоникельмолибденовая, хромомолибденоалюминиевая":
                        this.nv = 1.5;
                        break;

                    case "Сталь хромованадиевая":
                        this.nv = 1.25;
                        break;

                    case "Сталь марганцовистая":
                        this.nv = 1.5;
                        break;

                    case "Сталь хромоникельвольфрамовая, хромомолибденовая":
                        this.nv = 1.25;
                        break;

                    case "Сталь хромоалюминиевая":
                        this.nv = 1.25;
                        break;

                    case "Сталь хромоникельванадиевая":
                        this.nv = 1.25;
                        break;

                    case "Быстрорежущие стали":
                        this.nv = 1.25;
                        break;

                    case "Серый чугун":
                        this.nv = 1.7;
                        break;

                    case "Ковкий чугун":
                        this.nv = 1.7;
                        break;

                    default:
                        this.nv = 1.75;
                        break;

                }

            }
            else
            {
                switch (s)
                {
                    case "Серый чугун":
                        this.nv = 1.25;
                        break;

                    case "Ковкий чугун":
                        this.nv = 1.25;
                        break;


                    default:
                        this.nv = 1;
                        break;
                }

            }
        }


        private string matherial_type(string s)
        {
            string s1;


            switch (s)
            {
                case "Т5К10" or "Т5К12В" or "Т14К8" or "Т15К6" or "Т30К4" or "ВК8" or "ВК6" or "ВК4" or "ВК3" or "ВК2":
                    s1 = "Твёрдый сплав";
                    break;

                case "Р18" or "Р6М5" or "9ХС" or "У12А" or "ХВГ":
                    s1 = "Быстрорежущая сталь";
                    break;

                default:
                    s1 = "Твёрдый сплав";
                    break;

            }



            return s1;
        }

        private void TakeKuv(string s, string s1)//s - обрабатываемый материал , s1 марка инстремента материала
        {
            switch (s)
            {
                case "Сталь конструкционная":

                    switch (s1)
                    {
                        case "Т5К12В":
                            this.Kuv = 0.35;
                            break;

                        case "Т5К10":
                            this.Kuv = 0.65;
                            break;

                        case "Т14К8":
                            this.Kuv = 0.8;
                            break;

                        case "Т15К6":
                            this.Kuv = 1;
                            break;

                        case "Т30К4":
                            this.Kuv = 1.4;
                            break;

                        case "ВК8":
                            this.Kuv = 0.4;
                            break;

                    }
                    break;

                case "Коррозионно-стойкие и жаропрочные стали":

                    switch (s1)
                    {

                        case "Т5К10":
                            this.Kuv = 1.4;
                            break;

                        case "Т15К6":
                            this.Kuv = 1.9;
                            break;

                        case "P18":
                            this.Kuv = 0.3;
                            break;

                        case "ВК8":
                            this.Kuv = 1;
                            break;

                    }
                    break;

                case "Сталь закаленная":

                    switch (s1)
                    {
                        case "Т15К6":
                            this.Kuv = 1;
                            break;

                        case "Т30К4":
                            this.Kuv = 1.25;
                            break;

                        case "ВК6":
                            this.Kuv = 0.9;
                            break;

                        case "ВК8":
                            this.Kuv = 0.8;
                            break;

                        case "ВК4":
                            this.Kuv = 1;
                            break;

                    }
                    break;

                case "Серый и ковкий чугун":

                    switch (s1)
                    {
                        case "ВК2":
                            this.Kuv = 1.25;
                            break;

                        case "ВК3":
                            this.Kuv = 1.15;
                            break;

                        case "ВК4":
                            this.Kuv = 1.1;
                            break;

                        case "ВК6":
                            this.Kuv = 1;
                            break;

                        case "ВК8":
                            this.Kuv = 0.83;
                            break;

                    }
                    break;

                case "Сталь, чугун, медные и алюминиевые сплавы":

                    switch (s1)
                    {
                        case "Р6М5":
                            this.Kuv = 1;
                            break;

                        case "ВК4":
                            this.Kuv = 2.5;
                            break;

                        case "ВК6":
                            this.Kuv = 2.7;
                            break;

                        case "9ХС":
                            this.Kuv = 0.6;
                            break;

                        case "ХВГ":
                            this.Kuv = 0.6;
                            break;

                        case "У12А":
                            this.Kuv = 0.5;
                            break;

                        default:
                            this.Kuv = 1;
                            break;

                    }
                    break;

                default:
                    this.Kuv = 1;
                    break;



            }
        }


        private void TakeKtu(int n)
        {
            switch (n)
            {
                case 1:
                    this.Ktu = 1;
                    break;

                case 3:
                    this.Ktu = 1.7;
                    break;

                case 5:
                    this.Ktu = 2;
                    break;

                case 8:
                    this.Ktu = 2.5;
                    break;

                case 10:
                    this.Ktu = 3;
                    break;

                case 15:
                    this.Ktu = 4;
                    break;

                default:
                    this.Ktu = 4;
                    break;

            }


        }

        private void TakeKtc(int n)
        {
            switch (n)
            {
                case 1:
                    this.Ktc = 1;
                    break;

                case 2:
                    this.Ktc = 1.4;
                    break;

                case 3:
                    this.Ktc = 1.9;
                    break;

                case 4:
                    this.Ktc = 2.2;
                    break;

                case 5:
                    this.Ktc = 2.6;
                    break;

                case 6:
                    this.Ktc = 2.8;
                    break;

                case 7:
                    this.Ktc = 3.1;
                    break;

                default:
                    this.Ktc = 3.1;
                    break;

            }


        }

        private void TakeKov(double d, double D, string s)// s - вид обработки
        {
            switch (s)
            {
                case "Наружное продольное точение":
                    this.Kov = 1;
                    break;
                case "Подрезание":
                    switch (d / D)
                    {
                        case <= 0.4:
                            this.Kov = 1.24;
                            break;
                        case > 0.4 and <= 0.7:
                            this.Kov = 1.18;
                            break;
                        case > 0.7:
                            this.Kov = 1.04;
                            break;
                        default:
                            this.Kov = 1;
                            break;

                    }
                    break;

                case "Отрезание":
                    this.Kov = 1;
                    break;

                case "Прорезание" or "Фасонное точение":
                    switch (d / D)
                    {
                        case >= 0.5 and < 0.8:
                            this.Kov = 0.96;
                            break;
                        case >= 0.8 and < 0.95:
                            this.Kov = 0.84;
                            break;
                        default:
                            this.Kov = 1;
                            break;

                    }
                    break;

                default:
                    this.Kov = 1;
                    break;
            }
        }

        private void TakeKfv(string s)
        {
            switch (s)
            {
                case "20":
                    this.Kfv = 1.4;
                    break;

                case "30":
                    this.Kfv = 1.2;
                    break;

                case "45":
                    this.Kfv = 1;
                    break;

                case "60":
                    this.Kfv = 0.9;
                    break;

                case "75":
                    this.Kfv = 0.8;
                    break;

                case "90":
                    this.Kfv = 0.7;
                    break;
                default:
                    this.Kfv = 1;
                    break;

            }

        }

        private void TakeKv()
        {

            try
            {

                TakeKr(this.comboBox1.Text);

                TakeKmv(this.comboBox1.Text, Double.Parse(this.textBox1.Text), matherial_type(this.comboBox2.Text));


                TakeKuv("Сталь, чугун, медные и алюминиевые сплавы", this.comboBox2.Text);

                TakeKtu(Int32.Parse(this.textBox2.Text));

                TakeKtc(Int32.Parse(this.textBox3.Text));

                TakeKov(Double.Parse(this.textBox4.Text), Double.Parse(this.textBox5.Text), this.comboBox3.Text);

                TakeKfv(this.comboBox4.Text);


                this.Kv = this.Kmv * this.Kuv * this.Ktu * this.Ktc * this.Kfv * this.Kr * this.Kov;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
            {
                this.label3.Text = "Прочтость обрабатываемой стали";
                this.label3.Visible = true;
                this.textBox1.Visible = true;
            }
            else
                if (comboBox1.Text.EndsWith("чугун"))
            {

                this.label3.Text = "Прочтость обрабатываемого чугуна";
                this.label3.Visible = true;
                this.textBox1.Visible = true;


            }
            else
            {
                this.label3.Visible = false;
                this.textBox1.Visible = false;
                this.textBox1.Text = "0";
            }

        }


        #endregion

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            this.cancalkCv = true;
            if (comboBox3.Text == "Наружное продольное точение")
            {
                comboBox5.Enabled = true;

                if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                {
                    comboBox2.Items.Add("Т15К6");
                }
                else
                {
                    switch (comboBox3.Text)
                    {
                        case "Ковкий чугун":
                            comboBox2.Items.Add("ВК8");
                            comboBox5.SelectedIndex = 0;
                            comboBox5.Enabled = false;
                            break;
                        case "Серый чугун":
                            comboBox2.Items.Add("ВК6");
                            break;

                        default:
                            comboBox2.Items.Add("Р18");
                            break;
                    }


                }

            }
            else
            {
                if (comboBox3.Text == "Подрезание" || comboBox3.Text == "Отрезание")
                {

                    if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                    {
                        comboBox2.Items.Add("Т5К10");
                        comboBox2.Items.Add("Р18");
                    }
                    else
                    {
                        switch (comboBox3.Text)
                        {
                            case "Ковкий чугун":
                                comboBox2.Items.Add("ВК6");

                                break;
                            case "Серый чугун":
                                comboBox2.Items.Add("ВК6");
                                break;
                        }
                    }
                }
                else
                {
                    if (comboBox3.Text == "Фасонное точение")
                    {

                        if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                        {
                            comboBox2.Items.Add("Р18");
                        }

                    }
                }

                comboBox5.SelectedIndex = 0;
                comboBox5.Enabled = false;
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }



        }

        private void findCv()
        {

            switch (this.comboBox3.Text)
            {
                case "Наружное продольное точение":
                    if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                    {
                        if (comboBox5.SelectedIndex == 0)
                        {
                            switch (comboBox2.Text)
                            {
                                case "Т15К6":
                                    switch (Double.Parse(this.textBox6.Text))
                                    {
                                        case <= 0.3:
                                            this.Cv = 420;
                                            this.y = 0.20;
                                            break;

                                        case > 0.3 and <= 0.7:
                                            this.Cv = 350;
                                            this.y = 0.35;
                                            break;

                                        case > 0.7:
                                            this.Cv = 340;
                                            this.y = 0.45;
                                            break;

                                    }
                                    this.x = 0.15;
                                    this.m = 0.20;
                                    break;

                                default:
                                    this.cancalkCv = false;
                                    break;

                            }

                        }
                        else
                        {

                            switch (comboBox2.Text)
                            {
                                case "Т15К6":
                                    switch (Double.Parse(this.textBox6.Text) - ((Double.Parse(this.textBox5.Text) - Double.Parse(this.textBox4.Text)) / 2))
                                    {
                                        case <= 0:
                                            this.Cv = 292;
                                            this.x = 0.30;
                                            this.y = 0.15;
                                            this.m = 0.18;

                                            break;
                                        case > 0:
                                            this.Cv = 292;
                                            this.x = 0.15;
                                            this.y = 0.30;
                                            this.m = 0.18;

                                            break;
                                    }
                                    break;

                                default:
                                    this.cancalkCv = false;
                                    break;
                            }

                        }
                    }
                    else
                    {
                        switch (comboBox3.Text)
                        {
                            case "Ковкий чугун":

                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "ВК8":
                                            switch (Double.Parse(this.textBox6.Text))
                                            {
                                                case <= 0.4:
                                                    this.Cv = 317;
                                                    this.x = 0.15;
                                                    this.y = 0.20;
                                                    this.m = 0.20;

                                                    break;

                                                case > 0.4:
                                                    this.Cv = 215;
                                                    this.x = 0.15;
                                                    this.y = 0.45;
                                                    this.m = 0.20;
                                                    break;

                                            }

                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;


                            case "Серый чугун":
                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "ВК6":
                                            switch (Double.Parse(this.textBox6.Text))
                                            {
                                                case <= 0.4:
                                                    this.Cv = 292;
                                                    this.x = 0.15;
                                                    this.y = 0.20;
                                                    this.m = 0.20;

                                                    break;

                                                case > 0.4:
                                                    this.Cv = 243;
                                                    this.x = 0.15;
                                                    this.y = 0.40;
                                                    this.m = 0.20;
                                                    break;

                                            }

                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {

                                        case "ВК6":
                                            switch (Double.Parse(this.textBox6.Text) - ((Double.Parse(this.textBox5.Text) - Double.Parse(this.textBox4.Text)) / 2))
                                            {
                                                case <= 0:
                                                    this.Cv = 324;
                                                    this.x = 0.40;
                                                    this.y = 0.20;
                                                    this.m = 0.28;

                                                    break;

                                                case > 0:
                                                    this.Cv = 324;
                                                    this.x = 0.20;
                                                    this.y = 0.40;
                                                    this.m = 0.28;
                                                    break;

                                            }

                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;

                            default:
                                if (comboBox1.Text.StartsWith("Мед"))
                                {
                                    switch (comboBox2.Text)
                                    {

                                        case "P18":
                                            switch (Double.Parse(this.textBox6.Text))
                                            {
                                                case <= 0.2:
                                                    this.Cv = 270;
                                                    this.x = 0.12;
                                                    this.y = 0.25;
                                                    this.m = 0.23;

                                                    break;

                                                case > 0.2:
                                                    this.Cv = 182;
                                                    this.x = 0.12;
                                                    this.y = 0.30;
                                                    this.m = 0.23;
                                                    break;

                                            }
                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                else
                                {
                                    if (comboBox1.Text.Contains("Силумин") || comboBox1.Text.Contains("Дюралюминий"))
                                    {
                                        switch (comboBox2.Text)
                                        {

                                            case "P18":
                                                switch (Double.Parse(this.textBox6.Text))
                                                {
                                                    case <= 0.2:
                                                        this.Cv = 485;
                                                        this.x = 0.12;
                                                        this.y = 0.25;
                                                        this.m = 0.28;

                                                        break;

                                                    case > 0.2:
                                                        this.Cv = 328;
                                                        this.x = 0.12;
                                                        this.y = 0.50;
                                                        this.m = 0.28;
                                                        break;

                                                }
                                                break;

                                            default:
                                                this.cancalkCv = false;
                                                break;

                                        }



                                    }
                                    else
                                    {
                                        this.cancalkCv = false;
                                    }


                                }

                                break;
                        }


                    }

                    break;

                case "Отрезание":
                    if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                    {
                        if (comboBox5.SelectedIndex == 0)
                        {
                            switch (comboBox2.Text)
                            {
                                case "Т5К10":
                                    this.Cv = 47;
                                    this.y = 0.80;
                                    this.m = 0.20;

                                    break;



                                case "Р18":
                                    this.Cv = 23.7;
                                    this.y = 0.66;
                                    this.m = 0.25;

                                    break;



                                default:
                                    this.cancalkCv = false;
                                    break;

                            }

                        }
                        else
                        {

                            switch (comboBox2.Text)
                            {
                                default:
                                    this.cancalkCv = false;
                                    break;
                            }

                        }
                    }
                    else
                    {
                        switch (comboBox3.Text)
                        {
                            case "Ковкий чугун":

                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "ВК6":
                                            this.Cv = 86;
                                            this.y = 0.4;
                                            this.m = 0.2;
                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;


                            case "Серый чугун":
                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "ВК6":
                                            this.Cv = 68.5;
                                            this.y = 0.4;
                                            this.m = 0.20;

                                            break;

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {
                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;

                            default:
                                if (comboBox1.Text.StartsWith("Мед"))
                                {
                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                else
                                {
                                    if (comboBox1.Text.Contains("Силумин") || comboBox1.Text.Contains("Дюралюминий"))
                                    {
                                        switch (comboBox2.Text)
                                        {

                                            default:
                                                this.cancalkCv = false;
                                                break;

                                        }



                                    }
                                    else
                                    {
                                        this.cancalkCv = false;
                                    }


                                }

                                break;
                        }


                    }
                    break;


                case "Фасонное точение":
                    if (comboBox1.Text.StartsWith("Сталь") || comboBox1.Text.EndsWith("стали"))
                    {
                        if (comboBox5.SelectedIndex == 0)
                        {
                            switch (comboBox2.Text)
                            {

                                case "Р18":
                                    this.Cv = 22.7;
                                    this.y = 0.50;
                                    this.m = 0.30;
                                    break;

                                default:
                                    this.cancalkCv = false;
                                    break;

                            }

                        }
                        else
                        {

                            switch (comboBox2.Text)
                            {
                                default:
                                    this.cancalkCv = false;
                                    break;
                            }

                        }
                    }
                    else
                    {
                        switch (comboBox3.Text)
                        {
                            case "Ковкий чугун":

                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;


                            case "Серый чугун":
                                if (comboBox5.SelectedIndex == 0)
                                {
                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;


                                    }
                                }
                                else
                                {

                                    switch (comboBox2.Text)
                                    {
                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                break;

                            default:
                                if (comboBox1.Text.StartsWith("Мед"))
                                {
                                    switch (comboBox2.Text)
                                    {

                                        default:
                                            this.cancalkCv = false;
                                            break;

                                    }

                                }
                                else
                                {
                                    if (comboBox1.Text.Contains("Силумин") || comboBox1.Text.Contains("Дюралюминий"))
                                    {
                                        switch (comboBox2.Text)
                                        {

                                            default:
                                                this.cancalkCv = false;
                                                break;

                                        }



                                    }
                                    else
                                    {
                                        this.cancalkCv = false;
                                    }


                                }

                                break;
                        }


                    }
                    break;

                default:

                    this.cancalkCv = false;

                    break;


            }

        }


        private void findT()
        {
            if (this.comboBox5.SelectedIndex == 0)
            {
                this.T = 60;

            }
            else
            {
                this.T = 40;
            }
        }


        private void TakeKmp(string s, double P)
        {
            switch (s)
            {
                case "Сталь":
                    this.Kmp = P / 750;
                    break;

                case "Серый чугун":
                    this.Kmp = P / 190;
                    break;

                case "Ковкий чугун":
                    this.Kmp = P / 150;
                    break;

                case "Медные гетерогенные сплавы":
                    this.Kmp = 0.875;
                    break;

                case "Медные свинцовистые сплавы при основной гетерогенной структуре":
                    this.Kmp = 0.675;
                    break;

                case "Медные гомогенные сплавы":
                    this.Kmp = 2;
                    break;

                case "Медные сплавы с сожержание свинца < 10% при основной гомогенной структуре":
                    this.Kmp = 0.675;
                    break;

                case "Медь":
                    this.Kmp = 0.9;
                    break;

                case "Медные сплавы с содержание свинца > 15%":
                    this.Kmp = 0.35;
                    break;

                case "Силумин":
                    this.Kmp = 1;
                    break;

                case "Дюралюминий":
                    this.Kmp = 2;
                    break;

                default:
                    this.Kmp = 1;
                    break;

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            TakeKv();

            findCv();

            findT();

            if (cancalkCv)
            {

                if (comboBox3.Text == "Наружное продольное точение")
                {

                    this.Vp = ((this.Cv / (Math.Pow(this.T, this.m) * Math.Pow((Double.Parse(this.textBox5.Text) - Double.Parse(this.textBox4.Text)) / 2, this.x) * Math.Pow(Double.Parse(this.textBox6.Text), this.y))) * this.Kv);

                }
                else
                    if (comboBox3.Text == "Отрезание" || comboBox3.Text == "Фасонное точение")
                {

                    this.Vp = ((this.Cv / (Math.Pow(this.T, this.m) * Math.Pow(Double.Parse(this.textBox6.Text), this.y))) * this.Kv);


                }

                this.label13.Text = this.Vp.ToString() + " мм/мин";

            }

            else
            {
                MessageBox.Show("Нет возможности подобрать коэфициент Cv с этими параментрами");
            }


        }






    }
}
