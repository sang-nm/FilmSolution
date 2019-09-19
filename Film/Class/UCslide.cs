using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Class
{
    class UCslide
    {
        public static Control pnl { get; set; } = null;
        public static int Top { get; set; }
        public static int Bot { get; set; }
        public static int Left { get; set; }
        public static int Right { get; set; }

        private static string random()
        {
            string[] location = new string[] { "Up", "Down", "Left", "Right" };
            Random ran = new Random();
            int index = ran.Next(location.Length);
            return location[index];
        }

        public static void Slide(frmMain main, Control panel)
        {
            Top = main.Top - 20;
            Bot = main.Bottom;
            Left = main.Left - 60;
            Right = main.Right;
            pnl = panel;   
            switch (random())
            {
                case "Up":
                    {
                        while (pnl.Bottom >= Top)
                        {
                            pnl.Location = new Point(pnl.Location.X, pnl.Location.Y - 2);
                            //Thread.Sleep(5);
                            main.Update();
                        }
                    }
                    break;

                case "Down":
                    {
                        while (pnl.Top <= Bot)
                        {
                            pnl.Location = new Point(pnl.Location.X, pnl.Location.Y + 2);
                            //Thread.Sleep(5);
                            main.Update();
                        }
                    }
                    break;

                case "Left":
                    {
                        while (pnl.Right >= Left)
                        {
                            pnl.Location = new Point(pnl.Location.X - 5, pnl.Location.Y);
                            //Thread.Sleep(5);
                            main.Update();
                        }
                    }
                    break;

                case "Right":
                    {
                        while (pnl.Left <= Right)
                        {
                            pnl.Location = new Point(pnl.Location.X + 5, pnl.Location.Y);
                            //Thread.Sleep(5);
                            main.Update();
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
