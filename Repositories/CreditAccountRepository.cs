using _2_1058_MAGUREANU_STEFAN.Constants;
using _2_1058_MAGUREANU_STEFAN.Entitites;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1058_MAGUREANU_STEFAN.Repositories
{
    public class CreditAccountRepository
    {

        public List<CreditAccount> FetchDataCreditAccounts(Client client)
        {
            List<CreditAccount> data = new List<CreditAccount>();

            using (OracleConnection connection = new OracleConnection(DataBaseConstants.ConnectionString))
            {
                connection.Open();

                string sql = $"SELECT * FROM credit_accounts WHERE id_client = {client.Id}";
                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            CreditAccount creditAccount = new CreditAccount();
                            creditAccount.IdAccount = Convert.ToInt32(reader["id_account"]);
                            creditAccount.IdClient = client.Id;
                            creditAccount.Sold = Convert.ToDouble(reader["sold"]);
                            creditAccount.LoanAmount = Convert.ToDouble(reader["loan_amount"]);
                            creditAccount.OpenDate = reader["open_date"].ToString();
                            creditAccount.CloseDate = reader["close_date"].ToString();
                            creditAccount.InterestRatePerMonth = Convert.ToDouble(reader["interest_rate_per_month"]);

                            data.Add(creditAccount);
                        }
                    }

                }
                connection.Close();
            }

            return data;
        }
        public void UpdateDataCreditAccount(CreditAccount creditAccount)
        {

            creditAccount.OpenDate.Replace('/', '-');
            creditAccount.CloseDate.Replace("/", "-");

            using (OracleConnection connection = new OracleConnection(DataBaseConstants.ConnectionString))
            {
                connection.Open();

                string sql =
                    $"UPDATE credit_accounts " +
                    $"SET sold = {creditAccount.Sold}, loan_amount = {creditAccount.LoanAmount}," +
                    $"open_date = TO_DATE('{creditAccount.OpenDate}','DD-MM-YYYY'), close_date = TO_DATE('{creditAccount.CloseDate}','DD-MM-YYYY'), " +
                    $"interest_rate_per_month = {creditAccount.InterestRatePerMonth} " +
                    $"WHERE id_account = {creditAccount.IdAccount}";
                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Edit succesfull", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit not succesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                connection.Close();
            }

        }

        public void DeleteDataCreditAccount(CreditAccount creditAccount)
        {
            using (OracleConnection connection = new OracleConnection(DataBaseConstants.ConnectionString))
            {
                connection.Open();

                string sql = $"DELETE FROM credit_accounts WHERE id_account = {creditAccount.IdAccount}";
                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete succesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete not succesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                connection.Close();
            }

        }


        public void AddDataCreditAccount(CreditAccount creditAccount)
        {
            creditAccount.OpenDate.Replace('/', '-');
            creditAccount.CloseDate.Replace("/", "-");

            using (OracleConnection connection = new OracleConnection(DataBaseConstants.ConnectionString))
            {
                connection.Open();

                string sql =
                    $"INSERT INTO credit_accounts(id_account,id_client,sold,loan_amount,open_date,close_date,interest_rate_per_month) " +
                    $"VALUES ({creditAccount.IdAccount},{creditAccount.IdClient},{creditAccount.Sold},{creditAccount.LoanAmount},TO_DATE('{creditAccount.OpenDate}','DD-MM-YYYY'),TO_DATE('{creditAccount.CloseDate}','DD-MM-YYYY'),{creditAccount.InterestRatePerMonth})";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added succesfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add operation not succesfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                connection.Close();
            }
        }
    }
}
