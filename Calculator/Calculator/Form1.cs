using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        public static string command;

        public static long number;
        public static double numberf;

        public static string number1;
        public static string number2;

        public static string op;

        public static bool chr = true;
        public static bool siwtch = true;
        public static bool runOp = true;
        public static bool foi = false;
        public static bool doi = true;

        public static Color myRgbColor = Color.FromArgb(255, 125, 0);


        // <UI>

        // Button One
        private void btnOne_MouseHover(object sender, EventArgs e)
        {
            btnOne.BackColor = Color.Gray;
        }

        private void btnOne_MouseLeave(object sender, EventArgs e)
        {
            btnOne.BackColor = Color.White;
        }

        // Button Two
        private void btnTwo_MouseHover(object sender, EventArgs e)
        {
            btnTwo.BackColor = Color.Gray;
        }

        private void btnTwo_MouseLeave(object sender, EventArgs e)
        {
            btnTwo.BackColor = Color.White;
        }

        // Button Three
        private void btnThree_MouseHover(object sender, EventArgs e)
        {
            btnThree.BackColor = Color.Gray;
        }

        private void btnThree_MouseLeave(object sender, EventArgs e)
        {
            btnThree.BackColor = Color.White;
        }

        //Button Four
        private void btnFour_MouseHover(object sender, EventArgs e)
        {
            btnFour.BackColor = Color.Gray;
        }

        private void btnFour_MouseLeave(object sender, EventArgs e)
        {
            btnFour.BackColor = Color.White;
        }

        // Button Five
        private void btnFive_MouseHover(object sender, EventArgs e)
        {
            btnFive.BackColor = Color.Gray;
        }

        private void btnFive_MouseLeave(object sender, EventArgs e)
        {
            btnFive.BackColor = Color.White;
        }

        //Button Six
        private void btnSix_MouseHover(object sender, EventArgs e)
        {
            btnSix.BackColor = Color.Gray;
        }

        private void btnSix_MouseLeave(object sender, EventArgs e)
        {
            btnSix.BackColor = Color.White;
        }

        //Button Seven
        private void btnSeven_MouseHover(object sender, EventArgs e)
        {
            btnSeven.BackColor = Color.Gray;
        }

        private void btnSeven_MouseLeave(object sender, EventArgs e)
        {
            btnSeven.BackColor = Color.White;
        }

        //Button Eight
        private void btnEight_MouseHover(object sender, EventArgs e)
        {
            btnEight.BackColor = Color.Gray;
        }

        private void btnEight_MouseLeave(object sender, EventArgs e)
        {
            btnEight.BackColor = Color.White;
        }

        //Button Nine
        private void btnNine_MouseHover(object sender, EventArgs e)
        {
            btnNine.BackColor = Color.Gray;
        }

        private void btnNine_MouseLeave(object sender, EventArgs e)
        {
            btnNine.BackColor = Color.White;
        }

        //Button Zero
        private void btnZero_MouseHover(object sender, EventArgs e)
        {
            btnZero.BackColor = Color.Gray;
        }

        private void btnZero_MouseLeave(object sender, EventArgs e)
        {
            btnZero.BackColor = Color.White;
        }

        //Button Equal
        private void btnEqual_MouseHover(object sender, EventArgs e)
        {
            btnEqual.BackColor = Color.Gray;
        }

        private void btnEqual_MouseLeave(object sender, EventArgs e)
        {
            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(255, 125, 0);
            btnEqual.BackColor = myRgbColor;
        }

        //Button Plus
        private void btnPlus_MouseHover(object sender, EventArgs e)
        {
            btnPlus.BackColor = Color.Gray;
        }

        private void btnPlus_MouseLeave(object sender, EventArgs e)
        {
            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(255, 125, 0);
            btnPlus.BackColor = myRgbColor;
        }

        //Button Minus
        private void btnMinus_MouseHover(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.Gray;
        }

        private void btnMinus_MouseLeave(object sender, EventArgs e)
        {
            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(255, 125, 0);
            btnMinus.BackColor = myRgbColor;
        }

        //Button Multiplay
        private void btnMultiplay_MouseHover(object sender, EventArgs e)
        {
            btnMultiplay.BackColor = Color.Gray;
        }

        private void btnMultiplay_MouseLeave(object sender, EventArgs e)
        {
            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(255, 125, 0);
            btnMultiplay.BackColor = myRgbColor;
        }

        //Button Divide
        private void btnDivide_MouseHover(object sender, EventArgs e)
        {
            btnDivide.BackColor = Color.Gray;
        }

        private void btnDivide_MouseLeave(object sender, EventArgs e)
        {
            //Color myRgbColor = new Color();
            //myRgbColor = Color.FromArgb(255, 125, 0);
            btnDivide.BackColor = myRgbColor;
        }

        //Button Dot
        private void btnDot_MouseHover(object sender, EventArgs e)
        {
            btnDot.BackColor = Color.Gray;
        }
        private void btnDot_MouseLeave(object sender, EventArgs e)
        {
            btnDot.BackColor = Color.White;
        }

        //Button LeftOver
        private void btnLeftOver_MouseHover(object sender, EventArgs e)
        {
            btnLeftOver.BackColor = Color.Gray;
        }

        private void btnLeftOver_MouseLeave(object sender, EventArgs e)
        {
            btnLeftOver.BackColor = Color.LightGray;
        }

        //Button Clear
        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Gray;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.LightGray;
        }

        //Button Clear All
        private void btnClearAll_MouseHover(object sender, EventArgs e)
        {
            btnClearAll.BackColor = Color.Gray;
        }

        private void btnClearAll_MouseLeave(object sender, EventArgs e)
        {
            btnClearAll.BackColor = Color.LightGray;
        }

        // ---------------------------------------------------------------------

        // <UX>

        //Button Plus
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (runOp)
            {
                txt.Text += "+";
                siwtch = false;
                runOp = false;
            }
        }

        //Button Minus
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (runOp)
            {
                txt.Text += "-";
                siwtch = false;
                runOp = false;
            }
        }

        //Button Multiplay
        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            if (runOp)
            {
                txt.Text += "×";
                siwtch = false;
                runOp = false;
            }
        }

        //Button Divide
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (runOp)
            {
                txt.Text += "÷";
                siwtch = false;
                runOp = false;
            }
        }

        //Button LeftOver
        private void btnLeftOver_Click(object sender, EventArgs e)
        {
            if (runOp)
            {
                txt.Text += "%";
                siwtch = false;
                runOp = false;
            }
        }

        //Button Zero
        private void btnZero_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        //Button One
        private void btnOne_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }

        //Button Two
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        //Button Three
        private void btnThree_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        //Button Four
        private void btnFour_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        //Button Five
        private void btnFive_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        //Button Six
        private void btnSix_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        //Button Seven
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        //Button Eight
        private void btnEight_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        //Button Nine
        private void btnNine_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        //Button Dot
        private void btnDot_Click(object sender, EventArgs e)
        {
            txt.Text += ".";
            foi = true;
        }

        //Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt.Text != "")
                {
                    double tempd = Convert.ToDouble(txt.Text);
                    long tempi = Convert.ToInt64(txt.Text);

                    if (foi)
                    {
                        tempd /= 0.1;
                        foi = false;
                        txt.Text = Convert.ToString(tempd);
                    }
                    else
                    {
                        tempi /= 10;
                        txt.Text = Convert.ToString(tempi);
                    }

                    if (Convert.ToDouble(txt.Text) <= 1)
                    {
                        txt.Text = "";
                        command = "";
                        number = 0;
                        numberf = 0;
                        number1 = "";
                        number2 = "";
                        op = "";
                        chr = true;
                        siwtch = true;
                        runOp = true;
                        foi = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, Please Type True");
            }
        }

        //Button ClearAll
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            command = "";
            number = 0;
            numberf = 0;
            number1 = "";
            number2 = "";
            op = "";
            chr = true;
            siwtch = true;
            runOp = true;
            foi = false;
        }
    
        //Button Equal (Index_Calculator)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                command = txt.Text;
                if (command != "" && command != "0" && command != "+" && command != "-" && command != "×" && command != "÷" && command != "%")
                {
                    foreach (char ch in command)
                    {
                        if (ch != '+' && ch != '-' && ch != '×' && ch != '÷' && ch != '%')
                        {
                            if (ch == '.')
                            {
                                doi = false;
                            }
                            if (chr)
                            {
                                number1 += Convert.ToString(ch);
                            }
                            else
                            {
                                number2 += Convert.ToString(ch);
                            }
                        }
                        else
                        {
                            op += Convert.ToString(ch);
                            chr = false;
                        }
                    }

                    if (doi)
                    {
                        long temp1 = Convert.ToInt64(number1);
                        long temp2 = Convert.ToInt64(number2);

                        switch (op)
                        {
                            case "+":
                                number = temp1 + temp2;
                                break;
                            case "-":
                                number = temp1 - temp2;
                                break;
                            case "×":
                                number = temp1 * temp2;
                                break;
                            case "÷":
                                number = temp1 / temp2;
                                break;
                            case "%":
                                number = temp1 % temp2;
                                break;
                        }
                    }
                    else
                    {
                        double temp1 = Convert.ToDouble(number1);
                        double temp2 = Convert.ToDouble(number2);

                        switch (op)
                        {
                            case "+":
                                numberf = temp1 + temp2;
                                break;
                            case "-":
                                numberf = temp1 - temp2;
                                break;
                            case "×":
                                numberf = temp1 * temp2;
                                break;
                            case "÷":
                                numberf = temp1 / temp2;
                                break;
                            case "%":
                                numberf = temp1 % temp2;
                                break;
                        }
                    }

                    if (doi)
                    {
                        txt.Text = Convert.ToString(number);
                    }
                    else
                    {
                        txt.Text = Convert.ToString(numberf);
                    }

                    command = "";
                    number = 0;
                    numberf = 0;
                    number1 = "";
                    number2 = "";
                    op = "";
                    chr = true;
                    siwtch = true;
                    runOp = true;
                    foi = false;
                    doi = true;
    }
            }
            catch
            {
                MessageBox.Show("Error, Please Type True");
            }
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
