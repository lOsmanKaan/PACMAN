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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        void cangodown()
        {

            if (pacman.Bounds.IntersectsWith(label1.Bounds) && pacman.Top <= label1.Bottom)
            {
                cangoDown = false;
            }
          
            else   if (pacman.Bounds.IntersectsWith(label3.Bounds) && pacman.Top <= label3.Bottom)
            {
                cangoDown = false;
            }
            else  if (pacman.Bounds.IntersectsWith(label14.Bounds) && pacman.Top <= label4.Bottom)
            {
                cangoDown = false;
            }
            else  if (pacman.Bounds.IntersectsWith(label5.Bounds) && pacman.Top <= label5.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label6.Bounds) && pacman.Top <= label6.Bottom)
            {
                cangoDown = false;
            }
            else   if (pacman.Bounds.IntersectsWith(label7.Bounds) && pacman.Top <= label7.Bottom)
            {
                cangoDown = false;
            }
            if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Top <= label8.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label9.Bounds) && pacman.Top <= label9.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label10.Bounds) && pacman.Top <= label10.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label11.Bounds) && pacman.Top <= label11.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label12.Bounds) && pacman.Top <= label12.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label13.Bounds) && pacman.Top <= label13.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label14.Bounds) && pacman.Top <= label14.Bottom)
            {
                cangoDown = false;
            }
            else  if (pacman.Bounds.IntersectsWith(label15.Bounds) && pacman.Top <= label15.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label16.Bounds) && pacman.Top <= label16.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label17.Bounds) && pacman.Top <= label17.Bottom)
            {
                cangoDown = false;
            }
         
            else if (pacman.Bounds.IntersectsWith(label19.Bounds) && pacman.Top <= label19.Bottom)
            {
                cangoDown = false;
            }
            else if (pacman.Bounds.IntersectsWith(label20.Bounds) && pacman.Top <= label20.Bottom)
            {
                cangoDown = false;
            }
          
            else
            {
                cangoDown = true;
            }
            if (cangoDown)
            {

                pacman.Location = new Point(pacman.Left, pacman.Top + 10);
            }
            else
            {
                pacman.Top -= 8;
            }
        

           
        }
        void cangoup()
        {

            if (pacman.Bounds.IntersectsWith(label1.Bounds) && pacman.Top <= label1.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label2.Bounds) && pacman.Top <= label2.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label3.Bounds) && pacman.Top <= label3.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label4.Bounds) && pacman.Top <= label4.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label5.Bounds) && pacman.Top <= label5.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label6.Bounds) && pacman.Top <= label6.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label7.Bounds) && pacman.Top <= label7.Bottom)
            {
                cangoUp = false;
            }
            else  if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Top <= label8.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label9.Bounds) && pacman.Top <= label9.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label10.Bounds) && pacman.Top <= label10.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label11.Bounds) && pacman.Top <= label11.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label12.Bounds) && pacman.Top <= label12.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label13.Bounds) && pacman.Top <= label13.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label14.Bounds) && pacman.Top <= label14.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label15.Bounds) && pacman.Top <= label15.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label16.Bounds) && pacman.Top <= label16.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label17.Bounds) && pacman.Top <= label17.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label18.Bounds) && pacman.Top <= label18.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label19.Bounds) && pacman.Top <= label19.Bottom)
            {
                cangoUp = false;
            }
            else if (pacman.Bounds.IntersectsWith(label20.Bounds) && pacman.Top <= label20.Bottom)
            {
                cangoUp = false;
            }

            else
            {
                cangoUp = true;
            }
            if (cangoUp)
            {

                pacman.Location = new Point(pacman.Left, pacman.Top - 10);
            }
            else
            {
                pacman.Top += 8;
            }


        }

        void cangoright()
        {
            if (pacman.Bounds.IntersectsWith(label1.Bounds) && pacman.Left<=label1.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label2.Bounds) && pacman.Left <= label2.Right)
            {
                cangoRight = false;

            }
            else   if (pacman.Bounds.IntersectsWith(label3.Bounds) && pacman.Left <= label3.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label4.Bounds) && pacman.Left <= label4.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label5.Bounds) && pacman.Left <= label5.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label6.Bounds) && pacman.Left <= label6.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label7.Bounds) && pacman.Left <= label7.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Left <= label8.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Left <= label8.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label9.Bounds) && pacman.Left <= label9.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label10.Bounds) && pacman.Left <= label10.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label11.Bounds) && pacman.Left <= label12.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label13.Bounds) && pacman.Left <= label13.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label14.Bounds) && pacman.Left <= label14.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label15.Bounds) && pacman.Left <= label15.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label16.Bounds) && pacman.Left <= label16.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label17.Bounds) && pacman.Left <= label17.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label18.Bounds) && pacman.Left <= label18.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label19.Bounds) && pacman.Left <= label19.Right)
            {
                cangoRight = false;

            }
            else if (pacman.Bounds.IntersectsWith(label20.Bounds) && pacman.Left <= label20.Right)
            {
                cangoRight = false;

            }
          
            else
            {
                cangoRight = true;
            }
            if (cangoRight)
            {
                 pacman.Location = new Point(pacman.Left + 10, pacman.Top);
            }
            else
            {
                pacman.Left -= 6;
            }
        }

        void cangoleft()
        {
            if (pacman.Bounds.IntersectsWith(label1.Bounds) && pacman.Left <= label1.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label2.Bounds) && pacman.Left <= label2.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label3.Bounds) && pacman.Left <= label3.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label4.Bounds) && pacman.Left <= label4.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label5.Bounds) && pacman.Left <= label5.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label6.Bounds) && pacman.Left <= label6.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label7.Bounds) && pacman.Left <= label7.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Left <= label8.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label8.Bounds) && pacman.Left <= label8.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label9.Bounds) && pacman.Left <= label9.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label10.Bounds) && pacman.Left <= label10.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label11.Bounds) && pacman.Left <= label12.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label13.Bounds) && pacman.Left <= label13.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label14.Bounds) && pacman.Left <= label14.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label15.Bounds) && pacman.Left <= label15.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label16.Bounds) && pacman.Left <= label16.Right)
            {
                canGoLeft = false;

            }
          
            else if (pacman.Bounds.IntersectsWith(label18.Bounds) && pacman.Left <= label18.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label19.Bounds) && pacman.Left <= label19.Right)
            {
                canGoLeft = false;

            }
            else if (pacman.Bounds.IntersectsWith(label20.Bounds) && pacman.Left <= label20.Right)
            {
                canGoLeft = false;

            }

            else
            {
                canGoLeft = true;
            }
            if (canGoLeft)
            {
                pacman.Location = new Point(pacman.Left - 10, pacman.Top);

            }
            else
            {
                pacman.Left += 10;
            }
        
        
        }

        bool canGoLeft=true, cangoUp=true, cangoDown=true, cangoRight=true;
        protected override bool ProcessDialogKey(Keys keyData)
        {
           
            switch (keyData)
            {
                case Keys.Left:
  cangoleft();
              break;      

                  

                case Keys.Right: 
                    cangoright();
                     break;
                   
                    

                case Keys.Up:

                     cangoup();
                   


                    break;


                case Keys.Down:
                      
                               cangodown();
                  
                    break;

            }
            return base.ProcessDialogKey(keyData);
        }

        int sayac = 0;
        void yemler()
    {
        if (pacman.Bounds.IntersectsWith(label21.Bounds))
        {
            sayac++;
            label21.Visible = false;
        }

        if (pacman.Bounds.IntersectsWith(label22.Bounds))
        {
            sayac++;
            label22.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label23.Bounds))
        {
            sayac++;
            label23.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label24.Bounds))
        {
            sayac++;
            label24.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label25.Bounds))
        {
            sayac++;
            label25.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label26.Bounds))
        {
            sayac++;
            label26.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label27.Bounds))
        {
            sayac++;
            label27.Visible = false;
        }
        if (pacman.Bounds.IntersectsWith(label28.Bounds))
        {
            sayac++;
            label29.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label30.Bounds))
        {
            sayac++;
            label30.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label31.Bounds))
        {
            sayac++;
            label31.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label32.Bounds))
        {
            sayac++;
            label32.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label33.Bounds))
        {
            sayac++;
            label33.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label34.Bounds))
        {
            sayac++;
            label34.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label35.Bounds))
        {
            sayac++;
            label35.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label36.Bounds))
        {
            sayac++;
            label36.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label37.Bounds))
        {
            sayac++;
            label37.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label38.Bounds))
        {
            sayac++;
            label38.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label39.Bounds))
        {
            sayac++;
            label39.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label40.Bounds))
        {
            sayac++;
            label40.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label41.Bounds))
        {
            sayac++;
            label41.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label42.Bounds))
        {
            sayac++;
            label42.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label43.Bounds))
        {
            sayac++;
            label43.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label44.Bounds))
        {
            sayac++;
            label44.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label45.Bounds))
        {
            sayac++;
            label45.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label46.Bounds))
        {
            sayac++;
            label46.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label47.Bounds))
        {
            sayac++;
            label47.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label48.Bounds))
        {
            sayac++;
            label48.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label49.Bounds))
        {
            sayac++;
            label49.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label50.Bounds))
        {
            sayac++;
            label50.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label51.Bounds))
        {
            sayac++;
            label51.Visible = false;
        }
      
        else if (pacman.Bounds.IntersectsWith(label53.Bounds))
        {
            sayac++;
            label53.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label54.Bounds))
        {
            sayac++;
            label54.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label55.Bounds))
        {
            sayac++;
            label55.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label56.Bounds))
        {
            sayac++;
            label56.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label57.Bounds))
        {
            sayac++;
            label57.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label58.Bounds))
        {
            sayac++;
            label58.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label59.Bounds))
        {
            sayac++;
            label59.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label60.Bounds))
        {
            sayac++;
            label60.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label61.Bounds))
        {
            sayac++;
            label61.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label62.Bounds))
        {
            sayac++;
            label62.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label63.Bounds))
        {
            sayac++;
            label63.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label64.Bounds))
        {
            sayac++;
            label64.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label65.Bounds))
        {
            sayac++;
            label65.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label66.Bounds))
        {
            sayac++;
            label66.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label67.Bounds))
        {
            sayac++;
            label67.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label68.Bounds))
        {
            sayac++;
            label68.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label69.Bounds))
        {
            sayac++;
            label69.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label70.Bounds))
        {
            sayac++;
            label70.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label71.Bounds))
        {
            sayac++;
            label71.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label72.Bounds))
        {
            sayac++;
            label72.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label73.Bounds))
        {
            sayac++;
            label73.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label74.Bounds))
        {
            sayac++;
            label74.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label75.Bounds))
        {
            sayac++;
            label75.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label76.Bounds))
        {
            sayac++;
            label76.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label77.Bounds))
        {
            sayac++;
            label77.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label78.Bounds))
        {
            sayac++;
            label78.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label79.Bounds))
        {
            sayac++;
            label79.Visible = false;
        }
       
        else if (pacman.Bounds.IntersectsWith(label81.Bounds))
        {
            sayac++;
            label81.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label82.Bounds))
        {
            sayac++;
            label82.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label83.Bounds))
        {
            sayac++;
            label83.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label84.Bounds))
        {
            sayac++;
            label84.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label85.Bounds))
        {
            sayac++;
            label85.Visible = false;
        }
        else if (pacman.Bounds.IntersectsWith(label86.Bounds))
        {
            sayac++;
            label86.Visible = false;
        }
       
       
        
        }
        int sayacak = 0;
     
        private void Form1_Load(object sender, EventArgs e)
        {
           
            label17.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            label18.Visible = false;
            label20.Visible = false;
            timer4.Start();
            label88.Visible = false;
            timer6.Start();
            timer7.Start();


        }





        int a = 0; 
         private void timer1_Tick(object sender, EventArgs e)
        {




            ////////////////////////////// ///////

          

            if (a==0)
            {
                pictureBox2.Top -= 15;    
            }
            if (pictureBox2.Top <=label88.Bottom)
            {
                a = 1;
            }
            if (a==1)
            {
                pictureBox2.Left -= 15;
            }
            if (pictureBox2.Bounds.IntersectsWith(label12.Bounds))
            {
                a = 2;
            }
            if (a==2)
            {
                pictureBox2.Top += 15;
            }
            
             ////////////////////////////////////////////////////////////////////////////
          
        
        }
        

         private void timer2_Tick(object sender, EventArgs e)
         {

             if (pacman.Bounds.IntersectsWith(label21.Bounds))
             {
                 sayac++;
                 label21.Visible = false;
             }

          else   if (pacman.Bounds.IntersectsWith(label22.Bounds))
             {
                 sayac++;
                 label22.Visible = false;
             }
             else    if (pacman.Bounds.IntersectsWith(label23.Bounds))
             {
                 sayac++;
                 label23.Visible = false;
             }
             else  if (pacman.Bounds.IntersectsWith(label24.Bounds))
             {
                 sayac++;
                 label24.Visible = false;
             }
             else     if (pacman.Bounds.IntersectsWith(label25.Bounds))
             {
                 sayac++;
                 label25.Visible = false;
             }
             else    if (pacman.Bounds.IntersectsWith(label26.Bounds))
             {
                 sayac++;
                 label26.Visible = false;
             }
             else     if (pacman.Bounds.IntersectsWith(label27.Bounds))
             {
                 sayac++;
                 label27.Visible = false;
             }
             else   if (pacman.Bounds.IntersectsWith(label28.Bounds))
             {
                 sayac++;
                 label28.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label29.Bounds))
             {
                 sayac++;
                 label29.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label30.Bounds))
             {
                 sayac++;
                 label30.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label31.Bounds))
             {
                 sayac++;
                 label31.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label32.Bounds))
             {
                 sayac++;
                 label32.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label33.Bounds))
             {
                 sayac++;
                 label33.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label34.Bounds))
             {
                 sayac++;
                 label34.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label35.Bounds))
             {
                 sayac++;
                 label35.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label36.Bounds))
             {
                 sayac++;
                 label36.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label37.Bounds))
             {
                 sayac++;
                 label37.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label38.Bounds))
             {
                 sayac++;
                 label38.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label39.Bounds))
             {
                 sayac++;
                 label39.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label40.Bounds))
             {
                 sayac++;
                 label40.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label41.Bounds))
             {
                 sayac++;
                 label41.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label42.Bounds))
             {
                 sayac++;
                 label42.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label43.Bounds))
             {
                 sayac++;
                 label43.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label44.Bounds))
             {
                 sayac++;
                 label44.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label45.Bounds))
             {
                 sayac++;
                 label45.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label46.Bounds))
             {
                 sayac++;
                 label46.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label47.Bounds))
             {
                 sayac++;
                 label47.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label48.Bounds))
             {
                 sayac++;
                 label48.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label49.Bounds))
             {
                 sayac++;
                 label49.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label50.Bounds))
             {
                 sayac++;
                 label50.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label51.Bounds))
             {
                 sayac++;
                 label51.Visible = false;
             }
           
             else if (pacman.Bounds.IntersectsWith(label53.Bounds))
             {
                 sayac++;
                 label53.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label54.Bounds))
             {
                 sayac++;
                 label54.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label55.Bounds))
             {
                 sayac++;
                 label55.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label56.Bounds))
             {
                 sayac++;
                 label56.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label57.Bounds))
             {
                 sayac++;
                 label57.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label58.Bounds))
             {
                 sayac++;
                 label58.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label59.Bounds))
             {
                 sayac++;
                 label59.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label60.Bounds))
             {
                 sayac++;
                 label60.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label61.Bounds))
             {
                 sayac++;
                 label61.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label62.Bounds))
             {
                 sayac++;
                 label62.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label63.Bounds))
             {
                 sayac++;
                 label63.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label64.Bounds))
             {
                 sayac++;
                 label64.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label65.Bounds))
             {
                 sayac++;
                 label65.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label66.Bounds))
             {
                 sayac++;
                 label66.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label67.Bounds))
             {
                 sayac++;
                 label67.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label68.Bounds))
             {
                 sayac++;
                 label68.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label69.Bounds))
             {
                 sayac++;
                 label69.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label70.Bounds))
             {
                 sayac++;
                 label70.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label71.Bounds))
             {
                 sayac++;
                 label71.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label72.Bounds))
             {
                 sayac++;
                 label72.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label73.Bounds))
             {
                 sayac++;
                 label73.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label74.Bounds))
             {
                 sayac++;
                 label74.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label75.Bounds))
             {
                 sayac++;
                 label75.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label76.Bounds))
             {
                 sayac++;
                 label76.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label77.Bounds))
             {
                 sayac++;
                 label77.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label78.Bounds))
             {
                 sayac++;
                 label78.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label79.Bounds))
             {
                 sayac++;
                 label79.Visible = false;
             }
            
             else if (pacman.Bounds.IntersectsWith(label81.Bounds))
             {
                 sayac++;
                 label81.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label82.Bounds))
             {
                 sayac++;
                 label82.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label83.Bounds))
             {
                 sayac++;
                 label83.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label84.Bounds))
             {
                 sayac++;
                 label84.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label85.Bounds))
             {
                 sayac++;
                 label85.Visible = false;
             }
             else if (pacman.Bounds.IntersectsWith(label86.Bounds))
             {
                 sayac++;
                 label86.Visible = false;
             }
             
       

         
        
             
         }

         private void timer3_Tick(object sender, EventArgs e)
         {
               if (pacman.Bounds.IntersectsWith(label78.Bounds))
             {
                 sayac++;
                 label78.Visible = false;
             }
             if (pictureBox2.Bounds.IntersectsWith(label13.Bounds))
             {
                 a = 10;
             }
             if (a == 10)
             {
                 pictureBox2.Left -= 15;
             }
             if (pictureBox2.Bounds.IntersectsWith(label14.Bounds))
             {
                 a = 11;
             }
             if (a == 11)
             {
                 pictureBox2.Top-= 15;
             }
            
             if (pictureBox2.Bounds.IntersectsWith(label17.Bounds))
             {
                 a = 13;
             }
             if (a == 13)
             {
                 pictureBox2.Top += 15;
             }
             if (pictureBox2.Bounds.IntersectsWith(label18.Bounds))
             {
                 a = 14;
             }
             if (a == 14)
             {
                 pictureBox2.Left += 15;
             }
             if (pictureBox2.Bounds.IntersectsWith(label20.Bounds))
             {
                 a = 16;
             }
             if (a==16)
             {
                 pictureBox2.Top -= 15;
             }

         }

         private void button1_Click(object sender, EventArgs e)
         {
             
         }
         int x = 0;
         private void timer4_Tick(object sender, EventArgs e)
         {
             if (pacman.Bounds.IntersectsWith(label18.Bounds))
             {
                 pacman.Top -= 5;
             }
             if (pictureBox2.Bounds.IntersectsWith(pacman.Bounds) || pictureBox5.Bounds.IntersectsWith(pacman.Bounds))
             {
                 x++;

                 this.BackColor = Color.Red;
                 timer5.Start();
                 timer1.Stop();
                 timer2.Stop();
                 timer3.Stop();
                 timer4.Stop();
                 timer6.Stop();

             }
             if (x == 1)
             {

                 MessageBox.Show("game over");
                 Application.Exit();

             }
         }

         private void timer5_Tick(object sender, EventArgs e)
         {
            
           

         }
         int yanıpsönme = 0;
         private void timer5_Tick_1(object sender, EventArgs e)
         {
             yanıpsönme++;
             if (yanıpsönme % 2 == 0)
             {
                 pacman.Visible = true;
                 pictureBox2.Visible = true;
                 pictureBox5.Visible = true;

             }
             if (yanıpsönme % 2 == 1)
             {
                 pacman.Visible = false;
                 pictureBox2.Visible = false;
                 pictureBox5.Visible = false;
             }
         }
         int baslangıc = 0;

         private void timer6_Tick(object sender, EventArgs e)
         {
             if (baslangıc==0)
             {
                 pictureBox5.Top += 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label18.Bounds))
             {
                 baslangıc = 1;
             }
             if (baslangıc==1)
             {
                 pictureBox5.Left += 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label20.Bounds))
             {
                 baslangıc = 2;
             }
             if (baslangıc==2)
             {
                 pictureBox5.Top -= 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label88.Bounds))
             {
                 baslangıc = 3;
             }
             if (baslangıc==3)
             {
                 pictureBox5.Left -= 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label12.Bounds))
             {
                 baslangıc = 4;
             }
             if (baslangıc == 4)
             {
                 pictureBox5.Top += 15;
             }
             if(pictureBox5.Bounds.IntersectsWith(label13.Bounds))
             {
                 baslangıc = 5;
             }
             if (baslangıc == 5)
             {
                 pictureBox5.Left -= 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label14.Bounds))
             {
                 baslangıc = 6;
             }
             if (baslangıc == 6)
             {
                 pictureBox5.Top -= 15;
             }
             if (pictureBox5.Bounds.IntersectsWith(label17.Bounds))
             {
                 baslangıc = 7;
             }
             if (baslangıc == 7)
             {
                 pictureBox5.Top += 15;
             }
         }
         int kazanma = 0;
         private void timer7_Tick(object sender, EventArgs e)
         {
             if (label21.Visible==false &&
                label22.Visible==false &&
                 label23.Visible==false &&
                 label24.Visible==false &&
                 label25.Visible==false &&
                 label26.Visible==false &&
                 label27.Visible==false &&
                 label28.Visible==false &&
                 label29.Visible==false &&
                 label30.Visible==false &&
                 label31.Visible==false &&
                 label32.Visible==false &&
                 label33.Visible==false &&
                 label21.Visible==false &&
                  label34.Visible==false &&
                 label35.Visible==false &&
                 label36.Visible==false &&
                 label37.Visible==false &&
                 label38.Visible==false &&
                 label39.Visible==false &&
                 label40.Visible==false &&
                 label41.Visible==false &&
                 label42.Visible==false &&
                 label43.Visible==false &&
                 label44.Visible==false &&
                 label45.Visible==false &&
                  label46.Visible==false &&
                 label47.Visible==false &&
                 label48.Visible==false &&
                 label49.Visible==false &&
                 label50.Visible==false &&
                 label51.Visible==false &&
                 
                 label53.Visible==false &&
                 label54.Visible==false &&
                 label55.Visible==false &&
                 label56.Visible==false &&
                 label57.Visible==false &&
                  label58.Visible==false &&
                 label59.Visible==false &&
                 label60.Visible==false &&
                 label61.Visible==false &&
                 label62.Visible==false &&
                 label63.Visible==false &&
                 label64.Visible==false &&
                 label65.Visible == false &&
                 label66.Visible == false &&
                 label67.Visible == false &&
                 label68.Visible == false &&
                  label83.Visible == false &&
                 label84.Visible == false &&
                 label85.Visible == false &&
                 label86.Visible == false &&
                 label69.Visible==false )
             {
                 kazanma++;
             }
             if (kazanma==1)
             {
                 MessageBox.Show("kazandınız");
                 Application.Exit();
             }
         }
            }
       }

      





















      

        

        

