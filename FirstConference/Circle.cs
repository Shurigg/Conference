using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstConference
{
    class Circle : Shape
    {
        int x, y, dx, dy;
        int r;
        string name;
        public Circle()
        {
            x = 350;
            y = 120;
            r = 200;
            name = "Circle";
        }
        public void Load(Filer type)
        {
            this.x = type.rdInt();
            this.y = type.rdInt();
            this.r = type.rdInt();
            this.name = type.rdString();
        }
        public void Draw(Graphics gr, Pen p)
        {
            gr.DrawEllipse(p, x, y, r, r);
        }
        public void Save(Filer type)
        {
            type.wrInt(2);
            type.wrInt(x);
            type.wrInt(y);
            type.wrInt(r);
            type.wrString(name);
        }
        public bool isSelected(int mouseX, int mouseY)
        {
            if ((mouseX - x) * (mouseX - x) + (mouseY - y) * (mouseY - y) <= r * r)
            {
                dx = mouseX - x;
                dy = mouseY - y;
                return true;
            }
            else
                return false;
        }
        public void setPositions(int mouseX, int mouseY)
        {
            x = mouseX - dx;
            y = mouseY - dy;
        }
    }
}
