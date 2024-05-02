using _2_1058_MAGUREANU_STEFAN.Entitites;
using _2_1058_MAGUREANU_STEFAN.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1058_MAGUREANU_STEFAN.Forms
{
    public partial class AddCreditAccountForm : Form
    {
        private CreditAccountRepository _creditAccountRepository;
        private Client _client;
        public AddCreditAccountForm(Client client)
        {
            InitializeComponent();
            _creditAccountRepository = new CreditAccountRepository();
            _client = client;

            idClientAddTextBox.Text = Convert.ToString(client.Id);
            idClientAddTextBox.Enabled = false;
            idAccountAddTextBox.Text = Convert.ToString(_creditAccountRepository.GetLastIdAccountPlus1());      
            idAccountAddTextBox.Enabled = false;

        }

        private void submitAddButton_Click(object sender, EventArgs e)
        {
            CreditAccount creditAccount = new CreditAccount();
            if (performAllAddValidations(creditAccount))
            {

               _creditAccountRepository.AddDataCreditAccount(creditAccount);
                Close();
            }
            
        }

        public bool performAllAddValidations(CreditAccount creditAccount)
        {
            creditAccount.IdAccount = Convert.ToInt32(idAccountAddTextBox.Text);
            creditAccount.IdClient = Convert.ToInt32(idClientAddTextBox.Text);

            if (!double.TryParse(soldAddTextBox.Text, out double sold) || !double.TryParse(loanAmountAddTextBox.Text, out double loanAmount))
            {
                MessageBox.Show("Sold and Loan Amount must be numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (sold > loanAmount)
            {
                MessageBox.Show("Sold cannot be greater than Loan amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            creditAccount.Sold = sold;
            creditAccount.LoanAmount = loanAmount;

            if (!dateValidations(openDateAddTextBox.Text, closeDateAddTextBox.Text))
            {
                return false;
            }
            else
            {
                creditAccount.OpenDate = openDateAddTextBox.Text;
                creditAccount.CloseDate = closeDateAddTextBox.Text;
            }

            if (!double.TryParse(interestRateMonthTextBox.Text, out double interestRate))
            {
                MessageBox.Show("Invalid format for Interest rate/month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (interestRate < 0 || interestRate > 1)
            {
                MessageBox.Show("Interest rate/month must be greater than 0 and less then 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                creditAccount.InterestRatePerMonth = interestRate;
            }

            return true;

        }
        public bool dateValidations(string openDate, string closeDate)
        { //  format: DD/MM/YYYY (missing DD <= 31, MM <= 12 validations!)
            string[] openDateTemp = openDate.Trim().Split('/');
            string[] closeDateTemp = closeDate.Trim().Split('/');

            if (openDateTemp.Length != 3 || closeDateTemp.Length != 3 ||
                openDateTemp[0].Length != 2 || closeDateTemp[0].Length != 2 ||
                openDateTemp[1].Length != 2 || closeDateTemp[1].Length != 2 ||
                openDateTemp[2].Length != 4 || closeDateTemp[2].Length != 4
                )
            {
                MessageBox.Show("The format for Open date and Close date is DD/MM/YYYY!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((openDateTemp[0][0] == '0' && !int.TryParse(openDateTemp[0][1].ToString(), out int value1)) ||
                       (closeDateTemp[0][0] == '0' && !int.TryParse(closeDateTemp[0][1].ToString(), out int value2))
                     )
            {
                MessageBox.Show("The format for Open date and Close date is DD/MM/YYYY!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((openDateTemp[1][0] == '0' && !int.TryParse(openDateTemp[1][1].ToString(), out int value3)) ||
                       (closeDateTemp[1][0] == '0' && !int.TryParse(closeDateTemp[1][1].ToString(), out int value4))
                     )
            {
                MessageBox.Show("The format for Open date and Close date is DD/MM/YYYY!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(openDateTemp[0], out int value5) || !int.TryParse(closeDateTemp[0], out int value6) ||
                !int.TryParse(openDateTemp[1], out int value7) || !int.TryParse(closeDateTemp[1], out int value8) ||
                !int.TryParse(openDateTemp[2], out int value9) || !int.TryParse(closeDateTemp[2], out int value10)
                )
            {
                MessageBox.Show("The format for Open date and Close date is DD/MM/YYYY!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (value9 < 2000 || value10 < 2000)
            {
                MessageBox.Show("The year cannot be less than 2000!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
