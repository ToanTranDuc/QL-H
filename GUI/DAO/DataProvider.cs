using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private static string connectionSTR = @"Data Source=LAPTOP\SQLEXPRESS1;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True; Encrypt=True;";
        internal static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; } 
        }
        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable Data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in ListPara)
                    {
                           if(para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para,parameter[i++]);
                        }
                    }
                }
                SqlDataAdapter Adapter = new SqlDataAdapter(command);
                Adapter.Fill(Data);
                connection.Close();
            }
            return Data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int Data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in ListPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i++]);
                        }
                    }
                }
                Data = command.ExecuteNonQuery();
                connection.Close();
            }
            return Data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object Data = null;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in ListPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i++]);
                        }
                    }
                }
                Data = command.ExecuteScalar();
                connection.Close();
            }
            return Data;
        }
    }
}
