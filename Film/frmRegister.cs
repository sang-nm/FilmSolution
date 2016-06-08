﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (txtTen.Text == "")
            {
                errorReg.SetError(txtTen, "Error");
                sstReg.Text = "Nhập họ tên";
                txtTen.Focus();
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
            else if (ClassImage.fileImage == null || ClassImage.fileImage == "" || pictureBoxRegister.Image == Film.Properties.Resources.initial)
            {
                errorReg.SetError(pictureBoxRegister, "Error");
                sstReg.Text = "Nhập hình";
                pictureBoxRegister.Focus();
                return false;
            }
            else if (txtTDN.Text == "")
            {
                errorReg.SetError(txtTDN, "Error");
                sstReg.Text = "Nhập email";
                txtTDN.Focus();
                return false;
            }
            else if (txtMK.Text == "")
            {
                errorReg.SetError(txtMK, "Error");
                sstReg.Text = "Nhập password lần 1";
                txtMK.Focus();
                return false;
            }
            else if (txtMK2.Text == "")
            {
                errorReg.SetError(txtMK2, "Error");
                sstReg.Text = "Nhập password lần 2";
                txtMK2.Focus();
                return false;
            }
            else if (txtMK2.Text != txtMK.Text)
            {
                errorReg.SetError(txtMK2, "Error");
                sstReg.Text = "Password lần 2 không trùng password lần 1";
                txtMK2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
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
                string SQLComm = "SELECT * FROM QuanLyNhanSu";
                string[] DTReg = DataAccess.ExeReader(SQLComm, txtTDN.Text, 0);
                if (txtTDN.Text == DTReg[0])
                {
                    errorReg.SetError(txtTDN, "Error");
                    sstReg.Text = "Email đã tồn tại";
                    txtTDN.Focus();
                    return;
                }
                else
                {
                    DataAccess.NonQuery(string.Format("INSERT QuanLyNhanSu VALUES(N'{0}',N'{1}','User','Blocked')", txtTDN.Text, txtMK.Text));
                    string ImageIN = string.Format("INSERT ThongTinCaNhan VALUES(N'{0}',N'{1}',N'{2}',N'{3}',{4},{5},'{6}',@ImageB)", txtTDN.Text, txtTen.Text, dateNgaySinh.Value, txtDiachi.Text, Convert.ToInt32(txtCMND.Text), Convert.ToInt32(txtDT.Text), txtEmail.Text);
                    ClassImage.ImageIN(ImageIN);
                    MessageBox.Show("Đăng ký thành công", "Thông Báo");
                    resetForm();
                }
            }
        }

        private void btnCcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            ClassImage.browse();
            if (pictureBoxRegister.Image != null)
            {
                pictureBoxRegister.Load(ClassImage.fileImage);
            }
            else
            {
                MessageBox.Show("Please browse for an image file");
                return;
            }
        }

        public void resetForm()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                if (item is PictureBox)
                {
                    ((PictureBox)item).Image = Film.Properties.Resources.initial;
                }
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        //public void dangnhap()
        //{
        //    string sql = "select * from NhanVien";
        //    string[] arr = DataAccess.Exreader(sql, txtID.Text, 2);
        //    if (arr[2] == txtID.Text)
        //    {
        //        if (arr[3] == txtmatkhau.Text)
        //        {
        //            MessageBox.Show("thanh cong");
        //        }
        //        else
        //        {
        //            MessageBox.Show("tai khoan mat khau khong dung");
        //            txtID.Text = "";
        //            txtmatkhau.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("tai khoan mat khau khong dung");
        //        txtID.Text = "";
        //        txtmatkhau.Text = "";
        //    }

        //}
    }
}
