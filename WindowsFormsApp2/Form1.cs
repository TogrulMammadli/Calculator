using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        bool percent = false;
        char operation;
        double kew = 0;

        public Calculator()
        {
            InitializeComponent();
            MainScreen.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "0";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null)||MainScreen.Text==kew.ToString())
            {
                MainScreen.Text = "1";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "2";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "3";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "4";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "5";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "6";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "7";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "8";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((MainScreen.Text == "0" && MainScreen.Text != null) || MainScreen.Text == kew.ToString())
            {
                MainScreen.Text = "9";
            }
            else
            {
                MainScreen.Text = MainScreen.Text + "9";
            }
        }

        private void ArrowButton_Click(object sender, EventArgs e)
        {
            MainScreen.Text = MainScreen.Text.Remove(MainScreen.Text.Count() - 1, 1);
        }

        private void CE_Click(object sender, EventArgs e)
        {
            MainScreen.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            MainScreen.Text = "0";
            HelpScreen.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            HelpScreen.Text += MainScreen.Text;
            MainScreen.Text = (Math.Sqrt(Convert.ToDouble(HelpScreen.Text))).ToString();
            HelpScreen.Text = "√" + HelpScreen.Text;
        }

        private void buttonDelitNaX_Click(object sender, EventArgs e)
        {

            HelpScreen.Text += MainScreen.Text;
            var znam = new DataTable().Compute(HelpScreen.Text, null);
            double otvet = 1 / Convert.ToDouble(znam);
            HelpScreen.Text = "";
            MainScreen.Text = otvet.ToString();

        }

        private void buttonDelit_Click(object sender, EventArgs e)
        {
            if (operation == '=')
            {
                HelpScreen.Text = "";
            }
            bool owibka = false;
            if (operation == '/' && MainScreen.Text == "0")
            {
                MessageBox.Show("На ноль делить нельзя!!");
                owibka = true;
            }
            if (owibka == false)
            {
                HelpScreen.Text += MainScreen.Text + "/ ";
                MainScreen.Text ="0";
                operation = '/';
            }
        }

        private void buttonMultiplic_Click(object sender, EventArgs e)
        {
            if (operation == '=')
            {
                HelpScreen.Text = "";
            }
            bool owibka = false;
            if (operation == '/' && MainScreen.Text == "0")
            {
                MessageBox.Show("На ноль делить нельзя!!");
                owibka = true;
            }
            if (owibka == false)
            {

                HelpScreen.Text += MainScreen.Text + "*";
                MainScreen.Text = "0";
                operation = '*';
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            bool owibka = false;
            if (operation == '=')
            {
                HelpScreen.Text = "";
            }
            if (operation == '/' && MainScreen.Text == "0")
            {
                MessageBox.Show("На ноль делить нельзя!!");
                owibka = true;
            }
            if (owibka == false)
            {

                HelpScreen.Text += MainScreen.Text + "-";
                MainScreen.Text = "0";
                operation = '-';
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            bool owibka = false;
            if (operation=='=')
            {
                HelpScreen.Text = "";
            }

            if (operation == '/' && MainScreen.Text == "0")
            {
                MessageBox.Show("На ноль делить нельзя!!");
                owibka = true;
            }
            if (owibka == false)
            {
                kew = Convert.ToDouble(MainScreen.Text);

                HelpScreen.Text += MainScreen.Text + "+";
                MainScreen.Text = "0";
                operation = '+';
            }

        }

        private void buttonRovno_Click(object sender, EventArgs e)
        {

            bool owibka = false;
            if (operation == '/' && MainScreen.Text == "0")
            {
                MessageBox.Show("На ноль делить нельзя!!");
                owibka = true;
            }

            if (operation == '=')
            {
                 owibka = true;
                switch (GetLastOperation())
                {
                    case '+':
                       MainScreen.Text=( Convert.ToDouble(MainScreen.Text) + kew).ToString();
                        break;
                    case '-':
                        MainScreen.Text = (Convert.ToDouble(MainScreen.Text) -kew).ToString();
                        break;
                    case '/':
                        MainScreen.Text = (Convert.ToDouble(MainScreen.Text)/ kew).ToString();
                        break;
                    case '*':
                        MainScreen.Text = (Convert.ToDouble(MainScreen.Text) * kew).ToString();
                        break;
                }
            }

            if (owibka == false)
            {

                if (percent == true)
                {
                    MainScreen.Text = MainScreen.Text.Remove(0, 1);
                    double number = Convert.ToDouble(new DataTable().Compute(HelpScreen.Text, null));
                    MainScreen.Text = (number * Convert.ToDouble(MainScreen.Text) / 100).ToString();
                }

                if (percent == false)
                {
                    kew = Convert.ToDouble(MainScreen.Text);
                    HelpScreen.Text += MainScreen.Text;
                    string otvet;
                    otvet = new DataTable().Compute(HelpScreen.Text, null).ToString();
                  

                    MainScreen.Text = otvet;
                }
                percent = false;
                operation = '=';

            }


        }

        private void buttonZpty_Click(object sender, EventArgs e)
        {
            MainScreen.Text = MainScreen.Text + ".";

        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(MainScreen.Text);
            a = a * (-1);
            MainScreen.Text = a.ToString();

        }

        private void buttonPrcnt_Click_1(object sender, EventArgs e)
        {
            HelpScreen.Text += MainScreen.Text;
            MainScreen.Text = "%";
            percent = true;
        }

        private char GetLastOperation()
        {
            char operation='=';
            for (int i = HelpScreen.Text.Length-1; i >0 ; i--)
            {
                if (HelpScreen.Text[i]=='/')
                {
                    return operation = '/';
                }
                if (HelpScreen.Text[i] == '*')
                {
                    return operation = '*';
                }
                if (HelpScreen.Text[i] == '+')
                {
                    return operation = '+';
                }
                if (HelpScreen.Text[i] == '-')
                {
                    return operation = '-';
                }
            }
            return operation;
        }
    }

}
