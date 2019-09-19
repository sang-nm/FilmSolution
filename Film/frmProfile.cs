using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class frmProfile : Form
    {
        public string TDN { get; set; }
        private string hoten { get; set; }
        private DateTime ngaysinh { get; set; }
        private string diachi { get; set; }
        private int cmnd { get; set; }
        private int sdt { get; set; }
        private string email { get; set; }
        private Image ImageByte { get; set; }

        SQLFilmDataContext filmDC = new SQLFilmDataContext();
        Table<ThongTinCaNhan> thongtincanhan;

        public frmProfile()
        {
            InitializeComponent();
        }

        public frmProfile(string ht, DateTime ns, string dc, int cm, int dt, string mail, Image image)
        {
            hoten = ht;
            ngaysinh = ns;
            diachi = dc;
            cmnd = cm;
            sdt = dt;
            email = mail;
            ImageByte = image;
            InitializeComponent();
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            pictureBox_Prof.BackgroundImage = null;

            thongtincanhan = filmDC.GetTable<ThongTinCaNhan>();

            txtHoTen.Text = hoten;
            dateNgaySinh.Value = ngaysinh;
            txtDiachi.Text = diachi;
            txtCMND.Text = cmnd.ToString();
            txtDT.Text = sdt.ToString();
            txtEmail.Text = email;
            
            //if (ImageByte != null)
            //{
            //    if (ImageFormat.Gif.Equals(ImageByte.RawFormat))
            //    {
            //        string Paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Images\\";
            //        ImageByte.Save(Paths + hoten + ".gif", ImageFormat.Gif);
            //        pictureBoxRegister.Load(Paths + hoten + ".gif");
            //    }
            //    else
            //    {
            //        pictureBoxRegister.Image = ImageByte;
            //    }
            //}
            pictureBox_Prof.Image = ImageByte;
        }

        private void button_ProfSave_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                errorReg.SetError((Control)item, "");
            }
            sstReg.Text = "";
            validate();
            if (!validate())
            {
                return;
            }
            else
            {
                
                ThongTinCaNhan ttcn = thongtincanhan.Single(tt => tt.TenDangNhap == TDN);
                ttcn.HoTen = txtHoTen.Text;
                ttcn.NgaySinh = dateNgaySinh.Value;
                ttcn.DiaChi = txtDiachi.Text;
                ttcn.CMND = Convert.ToInt32(txtCMND.Text);
                ttcn.SDT = Convert.ToInt32(txtDT.Text);
                ttcn.Email = txtEmail.Text;

                MemoryStream ms = new MemoryStream();
                pictureBox_Prof.Image.Save(ms, ImageFormat.Gif);
                
                ttcn.ImageByte = new Binary(ms.ToArray());
                filmDC.SubmitChanges();

                MessageBox.Show("Lưu thành công!", "Thông Báo");
            }

        }

        private bool validate()
        {
            if (txtHoTen.Text == "")
            {
                errorReg.SetError(txtHoTen, "Error");
                sstReg.Text = "Nhập họ tên";
                txtHoTen.Focus();
                return false;
            }
            else if (dateNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                errorReg.SetError(dateNgaySinh, "Error");
                sstReg.Text = "Nhập ngày sinh";
                dateNgaySinh.Focus();
                return false;
            }
            else if (txtDiachi.Text == "")
            {
                errorReg.SetError(txtDiachi, "Error");
                sstReg.Text = "Nhập địa chỉ";
                txtDiachi.Focus();
                return false;
            }
            else if (txtCMND.Text == "")
            {
                errorReg.SetError(txtCMND, "Error");
                sstReg.Text = "Nhập CMND";
                txtCMND.Focus();
                return false;
            }
            else if (txtDT.Text == "")
            {
                errorReg.SetError(txtDT, "Error");
                sstReg.Text = "Nhập số điện thoại";
                txtDT.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                errorReg.SetError(txtEmail, "Error");
                sstReg.Text = "Nhập email";
                txtEmail.Focus();
                return false;
            }
            else if (pictureBox_Prof.Image == null)
            {
                errorReg.SetError(pictureBox_Prof, "Error");
                sstReg.Text = "Nhập hình";
                pictureBox_Prof.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pictureBoxProf_Click(object sender, EventArgs e)
        {
            ClassImage.browse();
            if (ClassImage.fileImage != "")
            {
                pictureBox_Prof.BackgroundImage = null;
                pictureBox_Prof.Load(ClassImage.fileImage);
            }
        }
    }
}
