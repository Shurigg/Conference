using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstConference
{
    class Rectangle : Shape
    {
        int x, y, width, height;
        string name;
        public Rectangle()
        {
            x = 350;
            y = 120;
            width = 300;
            height = 150;
            name = "Rectangle";
        }
        public void Load(Filer type)
        {
            this.x = type.rdInt();
            this.y = type.rdInt();
            this.width = type.rdInt();
            this.height = type.rdInt();
            this.name = type.rdString();
        }
        public void Draw(Graphics gr, Pen p)
        {
            gr.DrawRectangle(p, x, y, width, height);
        }
        public void Save(Filer type)
        {
            type.wrInt(3);
            type.wrInt(x);
            type.wrInt(y);
            type.wrInt(width);
            type.wrInt(height);
            type.wrString(name);
        }
        public bool isSelected(int dx, int dy)
        {
            if ((dx == x && y <= dy && dy <= y + height) || (dx == x + width && y <= dy && dy <= y + height) || (dy == y && x < dx && dx < x + width) || (dy == y + height && x < dx && dx < x + width))
                return true;
            else
                return false;
        }
    }
}