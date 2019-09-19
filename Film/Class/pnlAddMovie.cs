using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace Film.Class
{
    public partial class pnlAddMovie : UserControl
    {
        frmMain main;
        SQLFilmDataContext filmDC = new SQLFilmDataContext();
        public int PhimID { get; set; }

        public pnlAddMovie(frmMain form)
        {
            InitializeComponent();

            main = form;
            form.MinimumSize = new Size(this.MinimumSize.Width + 50, this.MinimumSize.Height + 90);
            form.Resize += main_Resize;
            ResizeForm();
        }
        public pnlAddMovie(int ID, string title, string genre, string director, string stars, DateTime releasedate, string storyline, Image image, frmMain formMain) : this(formMain)
        {
            pictureBox_AddMovie.BackgroundImage = null;

            PhimID = ID;
            metroTextBox_Title.Text = title;
            metroTextBox_Genre.Text = genre;
            string[] itemlist = metroTextBox_Genre.Text.Split(',');
            foreach (var item in itemlist)
            {
                checkedListBox_Genres.SetItemChecked(checkedListBox_Genres.Items.IndexOf(item.Trim()), true);
                checkedListBox_Genres.SetItemCheckState(checkedListBox_Genres.Items.IndexOf(item.Trim()), CheckState.Checked);
            }
            metroTextBox_Director.Text = director;
            metroTextBox_Stars.Text = stars;
            metroDateTime_ReleaseDate.Value = releasedate;
            metroTextBox_Storyline.Text = storyline;
            pictureBox_AddMovie.Image = image;
        }
        void main_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = main.Width - 60;
            this.Height = main.Height - 85;
            this.Location = new Point(30, 53);
        }

        private bool validate()
        {
            if (metroTextBox_Title.Text == "")
            {
                metroToolTip_Movie.Show("Title cannot be empty!", metroTextBox_Title);
                metroTextBox_Title.Focus();
                return false;
            }
            else if (metroTextBox_Genre.Text == "")
            {
                metroToolTip_Movie.Show("Genre cannot be empty!", metroTextBox_Genre);
                return false;
            }
            //else if (metroTextBox_Director.Text == "")
            //{
            //    metroToolTip_Movie.Show("That password is incorrect", metroTextBox_Director);
            //    metroTextBox_Director.Focus();
            //    return false;
            //}
            //else if (metroTextBox_Stars.Text == "")
            //{
            //    metroToolTip_Movie.Show("That password is incorrect", metroTextBox_Stars);
            //    metroTextBox_Stars.Focus();
            //    return false;
            //}
            //else if (metroTextBox_Storyline.Text == "")
            //{
            //    metroToolTip_Movie.Show("That password is incorrect", metroTextBox_Storyline);
            //    metroTextBox_Storyline.Focus();
            //    return false;
            //}
            else if (pictureBox_AddMovie.Image == null)
            {
                metroToolTip_Movie.Show("Please browse for an image file", pictureBox_AddMovie);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pnlAddMovie_Load(object sender, EventArgs e)
        {

        }

        private void metroButton_Save_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_AddMovie.Image.Save(ms, ImageFormat.Gif);

                TbPhim update = filmDC.TbPhims.SingleOrDefault(up => up.MaPhim == PhimID);

                if (update != null)
                {
                    update.TenPhim = metroTextBox_Title.Text;
                    update.TheLoai = metroTextBox_Genre.Text;
                    update.DaoDien = metroTextBox_Director.Text;
                    update.DienVien = metroTextBox_Stars.Text;
                    update.NgayKhoiChieu = metroDateTime_ReleaseDate.Value;
                    update.MoTaPhim = metroTextBox_Storyline.Text;
                    update.ImgPhim = new Binary(ms.ToArray());

                    filmDC.SubmitChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    TbPhim film = new TbPhim
                    {
                        TenPhim = metroTextBox_Title.Text,
                        TheLoai = metroTextBox_Genre.Text,
                        DaoDien = metroTextBox_Director.Text,
                        DienVien = metroTextBox_Stars.Text,
                        NgayKhoiChieu = metroDateTime_ReleaseDate.Value,
                        MoTaPhim = metroTextBox_Storyline.Text,
                        ImgPhim = new Binary(ms.ToArray())
                    };

                    filmDC.TbPhims.InsertOnSubmit(film);
                    filmDC.SubmitChanges();

                    foreach (var item in Controls)
                    {
                        if (item is MetroFramework.Controls.MetroTextBox)
                        {
                            ((MetroFramework.Controls.MetroTextBox)item).Text = "";
                        }
                        if (item is MetroFramework.Controls.MetroDateTime)
                        {
                            ((MetroFramework.Controls.MetroDateTime)item).Value = DateTime.Now;
                        }
                        if (item is PictureBox)
                        {
                            ((PictureBox)item).Image = null;
                            ((PictureBox)item).BackgroundImage = Properties.Resources.initial;
                        }
                    }

                    MetroFramework.MetroMessageBox.Show(this, "Upload completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void metroButton_Cancel_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }

        private void checkedListBox_Genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox_Genre.Text = "";
            foreach (var item in checkedListBox_Genres.CheckedItems)
            {
                metroTextBox_Genre.Text += item.ToString() + ", ";
            }
            if (metroTextBox_Genre.Text != "")
            {
                metroTextBox_Genre.Text = metroTextBox_Genre.Text.Substring(0, metroTextBox_Genre.Text.Length - 2);
            }
        }
        // S 370, 164 L 666, 208 1018
        private void checkBox_Genre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Genre.Checked)
            {
                while (checkedListBox_Genres.Width < 366)
                {
                    checkedListBox_Genres.Size = new Size(checkedListBox_Genres.Width + 4, checkedListBox_Genres.Width / 2);

                    checkedListBox_Genres.Location = new Point(checkedListBox_Genres.Left - 4, checkedListBox_Genres.Location.Y);
                    //Thread.Sleep(1);
                }
            }
            else
            {
                while (checkedListBox_Genres.Width > 0)
                {
                    checkedListBox_Genres.Size = new Size(checkedListBox_Genres.Width - 4, checkedListBox_Genres.Width / 2);
                    checkedListBox_Genres.Location = new Point(checkedListBox_Genres.Left + 4, checkedListBox_Genres.Location.Y);
                    //Thread.Sleep(1);
                }
            }
        }

        private void pictureBox_AddMovie_Click(object sender, EventArgs e)
        {
            ClassImage.browse();
            if (ClassImage.fileImage != "")
            {
                pictureBox_AddMovie.BackgroundImage = null;
                pictureBox_AddMovie.Load(ClassImage.fileImage);
            }
        }
    }
}
