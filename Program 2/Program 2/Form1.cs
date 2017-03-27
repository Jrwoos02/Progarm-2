//Joshua Woosley
//Program 2
//Due 10/27/14
//CIS 199-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Defines the char's for all letters and one for the entered string on the program
            char charvariable;
            char L1, L2, L3, L4, L5, L6, L7, L8, L9, L10,
            L11, L12, L13, L14, L15, L16, L17, L18,
            L19, L20, L21, L22, L23, L24, L25, L26;
            L1 = 'A';
            L2 = 'B';
            L3 = 'C';
            L4 = 'D';
            L5 = 'E';
            L6 = 'F';
            L7 = 'G';
            L8 = 'H';
            L9 = 'I';
            L10 = 'J';
            L11 = 'K';
            L12 = 'L';
            L13 = 'M';
            L14 = 'N';
            L15 = 'O';
            L16 = 'P';
            L17 = 'Q';
            L18 = 'R';
            L19 = 'S';
            L20 = 'T';
            L21 = 'U';
            L22 = 'V';
            L23 = 'W';
            L24 = 'X';
            L25 = 'Y';
            L26 = 'Z';

            //If statement to test for just one letter entered and if not will throw an error.
            if (char.TryParse(NameText.Text, out charvariable)) { }
            else
            {
                MessageBox.Show("Only the first letter of your last name is required");
            }

            //set the output to clear each time the button is hit
            Output.Text=("");

            //Checks if freshman radio is checked and then tests for what letter was entered and gives the date for registering
            if (FreshmanRadio.Checked)
            {
                if (charvariable == L1 || charvariable == L2 || charvariable == char.ToLower(L1) || charvariable == char.ToLower(L2))
                    Output.Text = ("Thursday, November 13th at 2pm");
                if (charvariable == L3 || charvariable == L4 || charvariable == char.ToLower(L3) || charvariable == char.ToLower(L4))
                    Output.Text = ("Thursday, November 13th at 4pm");
                if (charvariable == L5 || charvariable == L6 || charvariable == char.ToLower(L5) || charvariable == char.ToLower(L6))
                    Output.Text = ("Friday, November 14th at 8:30am");
                if (charvariable >= L7 && charvariable <= L9 || charvariable >= char.ToLower(L7) && charvariable <= char.ToLower(L9))
                    Output.Text = ("Friday, November 14th at 10:00am");
                if (charvariable >= L10 && charvariable <= L12 || charvariable >= char.ToLower(L10) && charvariable <= char.ToLower(L12))
                    Output.Text = ("Friday, November 14th at 11:30am");
                if (charvariable >= L13 && charvariable <= L15 || charvariable >= char.ToLower(L13) && charvariable <= char.ToLower(L15))
                    Output.Text = ("Friday, November 14th at 2pm");
                if (charvariable >= L16 && charvariable <= L18 || charvariable >= char.ToLower(L16) && charvariable <= char.ToLower(L18))
                    Output.Text = ("Friday, November 14th at 4pm");
                if (charvariable == L19 || charvariable == L20 || charvariable == char.ToLower(L19) || charvariable == char.ToLower(L20))
                    Output.Text = ("Thursday, November 13th at 8:30am");
                if (charvariable == L21 || charvariable == L22|| charvariable == char.ToLower(L21) || charvariable == char.ToLower(L22))
                    Output.Text = ("Thursday, November 13th at 10:00am");
                if (charvariable >= L23 && charvariable <= L26|| charvariable >= char.ToLower(L23) && charvariable <= char.ToLower(L26))
                    Output.Text = ("Thursday, November 13th at 11:30am");
            }

            //Checks if sophomore radio is checked and then tests for what letter was entered and gives the date for registering
            if (SophomoreRadio.Checked)
            {
                if (charvariable == L1 || charvariable == L2 || charvariable == char.ToLower(L1) || charvariable == char.ToLower(L2)) 
                    Output.Text = ("Tuesday, November 11th at 2pm");
                if (charvariable == L3 || charvariable == L4 || charvariable == char.ToLower(L3) || charvariable == char.ToLower(L4))
                    Output.Text = ("Tuesday, November 11th at 4pm");
                if (charvariable == L5 || charvariable == L6 || charvariable == char.ToLower(L5) || charvariable == char.ToLower(L6))
                    Output.Text = ("Wednesday, November 12th at 8:30am");
                if (charvariable >= L7 && charvariable <= L9 || charvariable >= char.ToLower(L7) && charvariable <= char.ToLower(L9))
                    Output.Text = ("Wednesday, November 12th at 10:00am");
                if (charvariable >= L10 && charvariable <= L12 || charvariable >= char.ToLower(L10) && charvariable <= char.ToLower(L12))
                    Output.Text = ("Wednesday, November 12th at 11:30am");
                if (charvariable >= L13 && charvariable <= L15 || charvariable >= char.ToLower(L13) && charvariable <= char.ToLower(L15))
                    Output.Text = ("Wednesday, November 12th at 2pm");
                if (charvariable >= L16 && charvariable <= L18 || charvariable >= char.ToLower(L16) && charvariable <= char.ToLower(L18))
                    Output.Text = ("Wednesday, November 12th at 4pm");
                if (charvariable == L19 || charvariable == L20 || charvariable == char.ToLower(L19) || charvariable == char.ToLower(L20))
                    Output.Text = ("Tuesday, November 11th at 8:30am");
                if (charvariable == L21 || charvariable == L22 || charvariable == char.ToLower(L21) || charvariable == char.ToLower(L22))
                    Output.Text = ("Tuesday, November 11th at 10:00am");
                if (charvariable >= L23 && charvariable <= L26 || charvariable >= char.ToLower(L23) && charvariable <= char.ToLower(L26))
                    Output.Text = ("Tuesday, November 11th at 11:30am");
            }

            //Checks if junior radio is checked and then tests for what letter was entered and gives the date for registering
            if (JuniorRadio.Checked)
            {
                if (charvariable >= L1 && charvariable <= L4 || charvariable >= char.ToLower(L1) && charvariable <= char.ToLower(L4))
                    Output.Text = ("Monday, November 10th at 10:00am");
                if (charvariable >= L5 && charvariable <= L9 || charvariable >= char.ToLower(L5) && charvariable <= char.ToLower(L9))
                    Output.Text = ("Monday, November 10th at 11:30am");
                if (charvariable >= L10 && charvariable <= L15 || charvariable >= char.ToLower(L10) && charvariable <= char.ToLower(L15))
                    Output.Text = ("Monday, November 10th at 2:00pm");
                if (charvariable >= L16 && charvariable <= L18 || charvariable >= char.ToLower(L16) && charvariable <= char.ToLower(L18))
                    Output.Text = ("Monday, November 10th at 4:00pm");
                if (charvariable >= L19 && charvariable <= L26 || charvariable >= char.ToLower(L19) && charvariable <= char.ToLower(L26))
                    Output.Text = ("Monday, November 10th at 8:30am");
            }

            //Checks if senior radio is checked and then tests for what letter was entered and gives the date for registering
            if (SeniorRadio.Checked)
            {
                if (charvariable >= L1 && charvariable <= L4 || charvariable >= char.ToLower(L1) && charvariable <= char.ToLower(L4))
                    Output.Text = ("Friday, November 7th at 10:00am");
                if (charvariable >= L5 && charvariable <= L9 || charvariable >= char.ToLower(L5) && charvariable <= char.ToLower(L9))
                    Output.Text = ("Friday, November 7th at 11:30am");
                if (charvariable >= L10 && charvariable <= L15 || charvariable >= char.ToLower(L10) && charvariable <= char.ToLower(L15))
                    Output.Text = ("Friday, November 7th at 2:00pm");
                if (charvariable >= L16 && charvariable <= L18 || charvariable >= char.ToLower(L16) && charvariable <= char.ToLower(L18))
                    Output.Text = ("Friday, November 7th at 4:00pm");
                if (charvariable >= L19 && charvariable <= L26 || charvariable >= char.ToLower(L19) && charvariable <= char.ToLower(L26))
                    Output.Text = ("Friday, November 7th at 8:30am");
            }
            
        }
    }
}