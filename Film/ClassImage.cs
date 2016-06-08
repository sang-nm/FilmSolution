using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Film
{
    class ClassImage
    {
        public static string fileImage;
        public static void browse()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\Desktop");
            OFD.InitialDirectory = Path.GetFullPath(CombinedPath);
            
            OFD.Filter = "Image File(*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif|All Files(*.*)|*.*";
            OFD.FilterIndex = 1;
            OFD.ShowDialog();
            fileImage = OFD.FileName;
            //if (OFD.ShowDialog() == DialogResult.OK)
            //{
            //    if (OFD.CheckFileExists)
            //    {
            //        fileImage = OFD.FileName;
            //    }
            //    else
            //    {
            //        MessageBox.Show("File exist");
            //    }
            //}
        }

        public static void ImageIN(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=FELISSILVESTRIS\\SQLEXPRESS; Initial Catalog=SQLFILM; User ID=sa; Password=123456");
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter p = new SqlParameter("ImageB", SqlDbType.Image);
                p.Value = ChuyenByte(fileImage);
                conn.Open();
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        static byte[] ChuyenByte(string filename)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(@filename,
                               FileMode.OpenOrCreate, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;
        }

        public static Image ImageOUT(string IDName)
        {
            string sql = string.Format("SELECT * from ThongTinCaNhan where TenDangNhap='{0}'", IDName);
            byte[] gtrihinh = (byte[]) DataAccess.dataGetAll(sql).Rows[0][7];
            MemoryStream ms = new MemoryStream(gtrihinh);
            Image newimage = Image.FromStream(ms);
            return newimage;
        }
        
        public static void CBBoxload(ComboBox cbImage, string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=FELISSILVESTRIS\\SQLEXPRESS; Initial Catalog=SQLFILM;ID User=sa; Password=123456");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbImage.DisplayMember = "ImageID";
            cbImage.ValueMember = "ImageID";
            cbImage.DataSource = ds.Tables[0];
        }
    }
}
