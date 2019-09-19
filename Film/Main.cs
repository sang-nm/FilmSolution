using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            for (int i = 0; i < 8; i++)
            {
                Label lb = new Label();
                lb.Size = new Size(20, 20);
                switch (i)
                {
                    case 0:
                        {
                            lb.Text = "A";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 1:
                        {
                            lb.Text = "B";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 2:
                        {
                            lb.Text = "C";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 3:
                        {
                            lb.Text = "D";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 4:
                        {
                            lb.Text = "E";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 5:
                        {
                            lb.Text = "F";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 6:
                        {
                            lb.Text = "G";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    case 7:
                        {
                            lb.Text = "H";
                            flowLayoutPanel1.Controls.Add(lb);
                        }
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 13; j++)
                {
                    Button button = new Button();
                    if (j == 4 ^ j == 9)
                    {
                        var margin = button.Margin;
                        margin.Left = 20;
                        margin.Right = 20;
                        button.Margin = margin;
                    }
                    button.Text = lb.Text + (j + 1).ToString();
                    button.Size = new Size(70, 70);
                    button.Tag = i;
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }
    }
}
