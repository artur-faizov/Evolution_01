using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evolution_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<LifeForm> Coloni = new List<LifeForm>();
        Random rnd = new Random();
        int MaxX = 700;
        int MaxY = 500;


        private void timer1_Tick(object sender, EventArgs e)
        {
                Pen DrawPen = new Pen(Color.Black, 1);
                Pen ErasPen = new Pen(Color.White, 1);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                // создаем первую особь
                if (Coloni.Count == 0){
                    Coloni.Add(new LifeForm(Coloni, rnd));
                }

                // каждая особь делает шаг
                foreach (LifeForm lf in Coloni) { 
                    lf.Move(MaxX, MaxY);
                    //MessageBox.Show("X: " +lf.CurrentLocX +" Y: " + lf.CurrentLocY);
                }



                // рисуем все особи
                foreach (LifeForm lf in Coloni) 
                {
                    g.DrawRectangle(ErasPen, lf.OldLocX, lf.OldLocY, 2, 2);
                    g.DrawRectangle(DrawPen, lf.CurrentLocX, lf.CurrentLocY, 2, 2);
                }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = Coloni.Count;
            for (int i = 0; i < x; i++ )
            {
                if (Coloni.Count < 100)
                {
                    Coloni[i].Born(Coloni, rnd, i);
                }
            }
        }
    }
}
