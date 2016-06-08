using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Film
{
    class DataAccess
    {
        public static DataTable dt { get; set; }
        static SqlConnection conn = new SqlConnection("Data Source=FELISSILVESTRIS\\SQLEXPRESS; Initial Catalog=SQLFILM; User ID=sa; Password=123456");
        public static DataTable dataGetAll(string sqlcomm)
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(sqlcomm, conn);
                DA.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static void dataUpdate()
        {
            SqlDataAdapter adapt = new SqlDataAdapter();
            SqlCommandBuilder commbuilder = new SqlCommandBuilder(adapt);
            adapt.SelectCommand = new SqlCommand("SELECT * FROM QuanLyNhanSu", conn);
            adapt.Update(dt);
        }

        public static void NonQuery(string sqlcomm)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlcomm, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static string[] ExeReader(string sqlComm, string valueName, int index)
        {
            SqlCommand cmd = new SqlCommand(sqlComm, conn);
            conn.Open();
            SqlDataReader DR = cmd.ExecuteReader();
            string[] arr = new string[DR.FieldCount];
            try
            {
                while (DR.Read())
                {
                    if (valueName == DR[index].ToString())
                    {
                        for (int i = 0; i < DR.FieldCount; i++)
                        {
                            arr[i] = DR[i].ToString();
                        }
                        break;
                    }
                }DR.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return arr;
        }
    }
}
