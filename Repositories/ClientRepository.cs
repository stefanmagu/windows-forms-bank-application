using _2_1058_MAGUREANU_STEFAN.Constants;
using _2_1058_MAGUREANU_STEFAN.Entitites;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace _2_1058_MAGUREANU_STEFAN.Repositories
{
    public class ClientRepository
    {
        public List<Client> FetchDataClients()
        {
            List<Client> data = new List<Client>();

            using(OracleConnection connection = new OracleConnection(DataBaseConstants.ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM clients ORDER BY id_client";
                using(OracleCommand command = new OracleCommand(sql,connection)) 
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Client client = new Client();
                            client.Id = Convert.ToInt32(reader["id_client"]);
                            client.FirstName = reader["first_name"].ToString();
                            client.LastName = reader["last_name"].ToString();
                            client.Email = reader["email"].ToString();
                            client.PhoneNumber = reader["phone_number"].ToString();

                            data.Add(client);
                        }
                    }
                   
                }
                connection.Close();
            }
             
            return data;
        }

    }
}
