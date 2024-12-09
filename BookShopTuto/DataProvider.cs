using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DataProvider
{
    private string connectionString = @"Data Source=DESKTOP-E1A4U7J\SQLSERVER2022;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True;";

    // Thực thi các câu lệnh không trả về dữ liệu (INSERT, UPDATE, DELETE)
    public int execNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return -1;
            }
        }
    }

    // Thực thi câu lệnh trả về DataTable (SELECT)
    public DataTable execQuery(string query, Dictionary<string, object> parameters = null)
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi truy vấn: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn: " + ex.Message);
            }
        }
        return dt;
    }

    // Thực thi câu lệnh trả về một giá trị đơn lẻ (SELECT COUNT, SUM, ...)
    public object execScalar(string query, Dictionary<string, object> parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                connection.Open();
                return command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
    }

    // Thực thi câu lệnh với giao dịch (Transaction)
    public bool execTransaction(List<string> queries, List<Dictionary<string, object>> paramList)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                for (int i = 0; i < queries.Count; i++)
                {
                    SqlCommand command = new SqlCommand(queries[i], connection, transaction);
                    if (paramList[i] != null)
                    {
                        foreach (var param in paramList[i])
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Lỗi SQL trong giao dịch: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Lỗi trong giao dịch: " + ex.Message);
                return false;
            }
        }
    }
}
