using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator_Pro
{
    public partial class frmMain : Form
    {
        bool UpperCase = true, LowerCase = true, Numbers = false, Special = false, ExtraSpecial = false;
        int Length = 8, MinimumSpecial = 1, MinimumUpperCase = 1, MinimumLowerCase = 1, MinimumExtraSpecial = 1, MinimumNumbers = 1;
        int CharTypeCount = 2;
        int MaxCount;
        string LowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
        string UpperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string SpecialChar = "!@#$%^&*";
        string ExtraSpecialChar = "(){}[]<>,.;:";



        private void chbUpperCase_Click(object sender, EventArgs e)
        {
            if (UpperCase != LowerCase && UpperCase)
            {
                MessageBox.Show("At least one of A-Z or a-z must be enabled!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chbUpperCase.Checked = true;
                return;
            }
            UpperCase = !UpperCase;
            if (UpperCase) CharTypeCount++;
            else CharTypeCount--;
            check();

            btnGenerate_Click(null, null);
        }

        private void chbUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            btnAddMinimumUpperCase.Enabled = btnSubtractMinimumUpperCase.Enabled = chbUpperCase.Checked;
        }

        private void btnSubtractMinimumUpperCase_Click(object sender, EventArgs e)
        {
            if (MinimumUpperCase == 1) return;
            MinimumUpperCase--;
            lblMinimumUpperCaseCount.Text = MinimumUpperCase.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnAddMinimumUpperCase_Click(object sender, EventArgs e)
        {
            if (Length / CharTypeCount <= MinimumUpperCase)
                return;
            MinimumUpperCase++;
            lblMinimumUpperCaseCount.Text = MinimumUpperCase.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnSubtractMinimumLowerCase_Click(object sender, EventArgs e)
        {
            if (MinimumLowerCase == 1) return;
            MinimumLowerCase--;
            lblMinimumLowerCaseCount.Text = MinimumLowerCase.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnAddMinimumLowerCase_Click(object sender, EventArgs e)
        {
            if (Length / CharTypeCount <= MinimumLowerCase)
                return;
            MinimumLowerCase++;
            lblMinimumLowerCaseCount.Text = MinimumLowerCase.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnSubtractMinimumNumbers_Click(object sender, EventArgs e)
        {
            if (MinimumNumbers == 1) return;
            MinimumNumbers--;
            lblMinimumNumbersCount.Text = MinimumNumbers.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnAddMinimumNumbers_Click(object sender, EventArgs e)
        {
            if (Length / CharTypeCount <= MinimumNumbers)
                return;
            MinimumNumbers++;
            lblMinimumNumbersCount.Text = MinimumNumbers.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnSubtractMinimumSpecial_Click(object sender, EventArgs e)
        {
            if (MinimumSpecial == 1) return;
            MinimumSpecial--;
            lblMinimumSpecialCount.Text = MinimumSpecial.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnAddMinimumSpecial_Click(object sender, EventArgs e)
        {
            if (Length / CharTypeCount <= MinimumSpecial)
                return;
            MinimumSpecial++;
            lblMinimumSpecialCount.Text = MinimumSpecial.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnSubtractMinimumExtraSpecial_Click(object sender, EventArgs e)
        {
            if (MinimumExtraSpecial == 1) return;
            MinimumExtraSpecial--;
            lblMinimumExtraSpecialCount.Text = MinimumExtraSpecial.ToString();
            btnGenerate_Click(null, null);
        }

        private void btnAddMinimumExtraSpecial_Click(object sender, EventArgs e)
        {
            if (Length / CharTypeCount <= MinimumExtraSpecial)
                return;
            MinimumExtraSpecial++;
            lblMinimumExtraSpecialCount.Text = MinimumExtraSpecial.ToString();
            btnGenerate_Click(null, null);
        }

        private void chbLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            btnSubtractMinimumLowerCase.Enabled = btnAddMinimumLowerCase.Enabled = chbLowerCase.Checked;
        }

        private void chbLowerCase_Click(object sender, EventArgs e)
        {
            if (UpperCase != LowerCase && LowerCase)
            {
                MessageBox.Show("At least one of A-Z or a-z must be enabled!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chbLowerCase.Checked = true;
                return;
            }
            LowerCase = !LowerCase;
            if (LowerCase) CharTypeCount++;
            else CharTypeCount--;
            check();

            btnGenerate_Click(null, null);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Copy();
            MessageBox.Show("Copied");
        }

        private void chbNumbers_CheckedChanged(object sender, EventArgs e)
        {
            Numbers = !Numbers;
            btnAddMinimumNumbers.Enabled = btnSubtractMinimumNumbers.Enabled = chbNumbers.Checked;
            if (Numbers) CharTypeCount++;
            else CharTypeCount--;
            check();

            btnGenerate_Click(null, null);
        }

        private void chbSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            Special = !Special;
            btnSubtractMinimumSpecial.Enabled = btnAddMinimumSpecial.Enabled = chbSpecialChar.Checked;
            if (Special) CharTypeCount++;
            else CharTypeCount--;
            check();
            btnGenerate_Click(null, null);
        }

        private void chbExtraSpecial_CheckedChanged(object sender, EventArgs e)
        {
            ExtraSpecial = !ExtraSpecial;
            btnAddMinimumExtraSpecial.Enabled = btnSubtractMinimumExtraSpecial.Enabled = chbExtraSpecial.Checked;
            if (ExtraSpecial) CharTypeCount++;
            else CharTypeCount--;
            check();
            btnGenerate_Click(null, null);
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtPasswordLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void trbPasswordLength_Scroll(object sender, EventArgs e)
        {
            txtPasswordLength.Text = trbPasswordLength.Value.ToString();
            Length = trbPasswordLength.Value;
            btnGenerate_Click(null, null);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            check();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //1 = lower -- 2 = upper -- 3 = number -- 4 = Special -- 5 == extraSpecial
            StringBuilder Password = new StringBuilder();
            string chars = "";
            if (ExtraSpecial)
            {
                for (int i = 0; i < MinimumExtraSpecial; i++)
                    Password.Append(ExtraSpecialChar[rnd.Next(ExtraSpecialChar.Length)]);
                chars += ExtraSpecialChar;
            }
            if (Special)
            {
                for (int i = 0; i < MinimumExtraSpecial; i++)
                    Password.Append(SpecialChar[rnd.Next(SpecialChar.Length)]);
                chars += SpecialChar;
            }
            if (LowerCase)
            {
                for (int i = 0; i < MinimumLowerCase; i++)
                    Password.Append(LowerAlphabet[rnd.Next(LowerAlphabet.Length)]);
                chars += LowerAlphabet;
            }
            if (UpperCase)
            {
                for (int i = 0; i < MinimumUpperCase; i++)
                    Password.Append(UpperAlphabet[rnd.Next(UpperAlphabet.Length)]);
                chars += UpperAlphabet;
            }
            if (Numbers)
            {
                for (int i = 0; i < MinimumNumbers; i++)
                    Password.Append(rnd.Next(10));
                chars += "0123456789";
            }

            for (int i = Password.Length; i < Length; i++)
                Password.Append(chars[rnd.Next(chars.Length)]);

            //shuffle 
            for (int i = Password.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                char Temp = Password[i];
                Password[i] = Password[j];
                Password[j] = Temp;
            }
            txtPassword.Text = Password.ToString();
        }
        private void check()
        {
            MaxCount = Length / CharTypeCount;

            if (MinimumExtraSpecial > MaxCount) MinimumExtraSpecial = MaxCount;
            lblMinimumExtraSpecialCount.Text = MinimumExtraSpecial.ToString();

            if (MinimumSpecial > MaxCount) MinimumSpecial = MaxCount;
            lblMinimumSpecialCount.Text = MinimumSpecial.ToString();

            if (MinimumNumbers > MaxCount) MinimumNumbers = MaxCount;
            lblMinimumNumbersCount.Text = MinimumNumbers.ToString();

            if (MinimumLowerCase > MaxCount) MinimumLowerCase = MaxCount;
            lblMinimumLowerCaseCount.Text = MinimumLowerCase.ToString();

            if (MinimumUpperCase > MaxCount) MinimumUpperCase = MaxCount;
            lblMinimumUpperCaseCount.Text = MinimumUpperCase.ToString();

        }
    }
}
