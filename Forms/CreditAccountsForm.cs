using _2_1058_MAGUREANU_STEFAN.Entitites;
using _2_1058_MAGUREANU_STEFAN.Extensions;
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

namespace _2_1058_MAGUREANU_STEFAN
{
    public partial class CreditAccountsForm : Form
    {
        private Client _client;
        private CreditAccountRepository _creditAccountRepository;

        public CreditAccountsForm(Client client)
        {
            InitializeComponent();
            infoCreditAcountLabel.Text = $"Credit Accounts of id_client no.{client.Id}";
            _creditAccountRepository = new CreditAccountRepository();
            creditAccountsDataGridView.AutoGenerateColumns = true;
            creditAccountsDataGridView.DataSource = _creditAccountRepository.FetchDataCreditAccounts(client);

            creditAccountsDataGridView.AddButtonColumn("EditColumn", "Edit");
            creditAccountsDataGridView.AddButtonColumn("DeleteColumn", "Delete");
            _client = client;
        }

        private void creditAccountsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            CreditAccount creditAccount = (CreditAccount)creditAccountsDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (columnName.Equals("EditColumn"))
            {
                EditForm editForm = new EditForm(creditAccount);
                editForm.ShowDialog();
                creditAccountsDataGridView.DataSource = _creditAccountRepository.FetchDataCreditAccounts(_client);

            } else if(columnName.Equals("DeleteColumn")) {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to perform this action ?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    _creditAccountRepository.deleteDataCreditAccount(creditAccount);
                    creditAccountsDataGridView.DataSource = _creditAccountRepository.FetchDataCreditAccounts(_client);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            creditAccountsDataGridView.DataSource = _creditAccountRepository.FetchDataCreditAccounts(_client);
        }
    }
}
