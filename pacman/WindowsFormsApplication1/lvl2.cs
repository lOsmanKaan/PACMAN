using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
        }
        int sarıhayalet = 8;
        int kırmızıhayalet = 8;
        int pembehayaletx = 8;
        int pembehayalety = 8;

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    pacman.Location = new Point(pacman.Left - 10, pacman.Top);
                    break;
                case Keys.Right:
                    pacman.Location = new Point(pacman.Left + 10, pacman.Top);
                    break;
                case Keys.Up:
                    pacman.Location = new Point(pacman.Left, pacman.Top - 10);
                    break;
                case Keys.Down:
                    pacman.Location = new Point(pacman.Left, pacman.Top + 10);
                    break;

            }
            return base.ProcessDialogKey(keyData);
        }



        void kırmızıhayaletengeli()
        {
            if (pictureBox2.Bounds.IntersectsWith(label1.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label2.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label3.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label4.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label5.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label6.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label7.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label8.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label9.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label10.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label11.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label12.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label13.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label14.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label15.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label16.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label17.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label18.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label19.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label20.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label21.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }

        
        
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox5.Left += sarıhayalet;
            pictureBox2.Left += kırmızıhayalet;

            kırmızıhayaletengeli();
          







        }

        private void level1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(label1.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label2.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label3.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label4.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label5.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label6.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label7.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label8.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label9.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label10.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label11.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label12.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label13.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label14.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label15.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label16.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label17.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label18.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label19.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label20.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
            if (pictureBox2.Bounds.IntersectsWith(label21.Bounds))
            {
                kırmızıhayalet = -kırmızıhayalet;
            }
        }
    }
}
