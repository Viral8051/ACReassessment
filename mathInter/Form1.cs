using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace mathInter
{
    public partial class Form1 : Form
    {
        //[DllImport("kernel32.dll", SetLastError = true)]
//[return: MarshalAs(UnmanagedType.Bool)]
//static extern bool AllocConsole();
        public Form1()
        {
             //AllocConsole(); // Open a new console window
             // Rest of your initialization code
            InitializeComponent();
            btnEnableDisable(false);
        }

        public void submitButton_Click(object sender, EventArgs e)
        {   
            string input = quetextBox.Text;
            string inputX = txtValueX.Text;
            string inputY = txtValueY.Text;

            /*if (btnCharVisiblity.Text == "Enabled")
            {
                // Require to check X & Y must be numeric value only
                if (!IsNumber(inputX) || !IsNumber(inputY))
                {
                    outputLabel.Text = "Number only allowed to enter for X or Y";
                    outputLabel.ForeColor = Color.Red;
                    return;
                }
            }*/

            //MessageBox.Show("Your Answer is : " + input);
            //outputLabel.Text = input; 

            try
            {
                Lexer lexer = new Lexer(input,inputX,inputY);
                List<Tokens> tokens = lexer.Get_Tokens();


                Parser parser = new Parser(tokens);

                AST astObj = parser.ParseExp();
                Console.WriteLine("this is parser value" + astObj);
                //Console.WriteLine(">> {0}", astObj.Eval());

                if (astObj == null)
                {
                    string errorMsg = ("Invalid Expression");
                    outputLabel.Text = errorMsg;
                }
                else
                {
                    string output = astObj.Eval().ToString();
                    outputLabel.Text = "Answer Is : " + output;
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine(ex.Message);
                outputLabel.Text = "Invalid Expression";
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void btnCharVisiblity_Click(object sender, EventArgs e)
        {
            if (btnCharVisiblity.Text == "Disabled")
            {
                // Button require to enable
                btnEnableDisable(true);
            }
            else
            {
                // Button require to Disable
                btnEnableDisable(false);
            }
        }

        private void btnEnableDisable(bool isEnable)
        {
            txtValueX.Text = string.Empty;
            txtValueY.Text = string.Empty;
            if (isEnable)
            {
                lblX.Visible = true;
                lblY.Visible = true;
                txtValueX.Visible = true;
                txtValueY.Visible = true;
                btnCharVisiblity.Text = "Enabled";
                btnCharVisiblity.BackColor = Color.OliveDrab;
            }
            else
            {
                lblX.Visible = false;
                lblY.Visible = false;
                txtValueX.Visible = false;
                txtValueY.Visible = false;
                btnCharVisiblity.Text = "Disabled";
                btnCharVisiblity.BackColor = Color.Chocolate;
            }
        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
