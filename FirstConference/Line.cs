using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FirstConference
{
    class Line : Shape
    {
        int x1, y1, x2, y2;
        string name;
        public Line()
        {
            x1 = 350;
            x2 = 550;
            y1 = 220;
            y2 = 220;
            name = "Line";
        }
        public void Load(Filer type)
        {
            this.x1 = type.rdInt();
            this.y1 = type.rdInt();
            this.x2 = type.rdInt();
            this.y2 = type.rdInt();
            this.name = type.rdString();
        }
        public void Draw(Graphics gr, Pen p)
        {
            gr.DrawLine(p, new Point(x1, y1), new Point(x2, y2));
        }
        public void Save(Filer type)
        {
            type.wrInt(x1);
            type.wrInt(y1);
            type.wrInt(x2);
            type.wrInt(y2);
            type.wrString(name);
        }
    }
}