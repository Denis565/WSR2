using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    class SQLManager
    {
        public SqlConnection conection = new SqlConnection(@"Data Source=LAPTOP-TSGG5DA6\BALAEVDENES;Initial Catalog=Karting;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataSet dataSet;

        public void AddComboBox(ComboBox comboBox, string table, int columnNumber)
        {
            DataTable dataTable = ReturnTable($@"select count(*) as count from {table}");
            if (dataTable.Rows.Count > 0)
            {
                int numberOfRecords = Number_Records(table);
                dataAdapter = new SqlDataAdapter($@"select * from {table}", conection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < numberOfRecords; i++)
                {
                    comboBox.Items.Add(dataTable.Rows[i][columnNumber]);
                }
            }
        }

        public int Number_Records(string tables) => Convert.ToInt32(ReturnTable($@"select count(*) as count from {tables} ").Rows[0][0]);

        public DataTable ReturnTable(string sqlRequest)
        {
            try
            {
                dataAdapter = new SqlDataAdapter($@"{sqlRequest}", conection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }

        public bool performingProcedure_decimal(string[] value, string nameFunction, string[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand($@"{nameFunction}", conection))
            {
                try
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        string quantit = value[i].ToString();
                        if (quantit.Contains(','))
                        {
                            if (quantit.Split(new char[] { ',' })[1].Length == 1)
                            {
                                quantit = value[i].ToString().Replace(",", ".");
                            }
                        }

                        cmd.Parameters.Add(parameters[i], SqlDbType.VarChar).Value = quantit;
                    }
                    conection.Open();
                    cmd.ExecuteNonQuery();
                    conection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    conection.Close();
                    return false;
                }
            }
        }

        public bool performingProcedure(string[] value, string nameFunction, string[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand($@"{nameFunction}", conection))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i], SqlDbType.VarChar).Value = value[i];
                    }
                    conection.Open();
                    cmd.ExecuteNonQuery();
                    conection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    conection.Close();
                    return false;
                }
            }
        }

        public bool performingProcedure_Image(string[] value, string nameFunction, string[] parameters, byte [] imageData)
        {
            using (SqlCommand cmd = new SqlCommand($@"{nameFunction}", conection))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        if (parameters[i] == "Image")
                        {
                            cmd.Parameters.Add(parameters[i], SqlDbType.Image).Value = imageData;
                        }
                        else
                        {
                            cmd.Parameters.Add(parameters[i], SqlDbType.VarChar).Value = value[i];
                        }
                    }
                    conection.Open();
                    cmd.ExecuteNonQuery();
                    conection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    conection.Close();
                    return false;
                }
            }
        }
    }
}
