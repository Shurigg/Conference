﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstConference
{
    class Rectangle : Shape
    {
        int x, y, side;
        string name;
        public Rectangle()
        {
            x = 350;
            y = 120;
            side = 200;
            name = "Square";
        }
        public void Load(Filer type)
        {
            this.x = type.rdInt();
            this.y = type.rdInt();
            this.side = type.rdInt();
            this.name = type.rdString();
        }
        public void Draw(Graphics gr, Pen p)
        {
            gr.DrawRectangle(p, x, y, side, side);
        }
        public void Save(Filer type)
        {
            type.wrInt(x);
            type.wrInt(y);
            type.wrInt(side);
            type.wrString(name);
        }
    }
}