using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentOyunu
{
    public partial class Form1 : Form
    {
        //System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer("C:/Users/acer/Downloads/Türk yabancı karışık ses paketi/Türk yabancı karışık ses paketi/aaaaaaaa-kikikiki.wav");
        //System.Media.SoundPlayer starSoundPlayer = new System.Media.SoundPlayer("C:/Users/acer/Downloads/Türk yabancı karışık ses paketi/Türk yabancı karışık ses paketi/01-oh-yeah (1).wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("CONGRATULATİONS");
            Close();
            //finishSoundPlayer.Play();
        }
        private void MoveToStart()
        {
            //starSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10,10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            
        }
    }
}
