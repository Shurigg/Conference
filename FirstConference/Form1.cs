﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstConference
{
    public partial class Form1 : Form
    {
        Geo g = new Geo();
        Graphics gr;
        Pen p;
        List<Shape> shapes = new List<Shape>();
        int Selected = -1;
        public Form1()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            string path = textBox1.Text;
            Filer f = new FileFiler(path, 1);
            shapes = g.loadFile(f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            gr.Clear(Color.White);
            if (shapes == null)
                return;
            int size = shapes.Count;
            for (int i = 0; i < size; i++)
            {
                shapes[i].Draw(gr, p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shapes.Add(new Line());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shapes.Add(new Circle());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shapes.Add(new Rectangle());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = textBox2.Text;
            Filer f = new FileFiler(path, 2);
            if (shapes == null)
                return;
            int size = shapes.Count;
            for (int i = 0; i < size; i++)
            {
                shapes[i].Save(f);
            }
            f.closeWR();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shapes.Add(new Square());
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                int size = shapes.Count;
                for (int i = size - 1; i >=0; i--)
                {
                    if (shapes[i].isSelected(e.X, e.Y))
                    {
                        Selected = i;
                        break;
                    }
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Selected = -1;
            Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selected != -1)
            {
                shapes[Selected].setPositions(e.X, e.Y);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            shapes.Clear();
        }
    }
}
