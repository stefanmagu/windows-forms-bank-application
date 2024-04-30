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
    public partial class MainForm : Form
    {
        public ClientRepository _clientRepository;

        public MainForm()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository();

            clientsDataGridView.AutoGenerateColumns = true;
            clientsDataGridView.DataSource = _clientRepository.FetchDataClients();

            clientsDataGridView.AddButtonColumn("CreditAccountsColumn", "Credit Accounts");
            
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            Client client = (Client)clientsDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (columnName.Equals("CreditAccountsColumn"))
            {
                var creditAccountsForm = new CreditAccountsForm(client);
                creditAccountsForm.ShowDialog();
            }
        }
    }
}
