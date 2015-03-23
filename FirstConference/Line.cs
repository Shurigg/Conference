using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FirstConference
{
    class Line : Shape
    {
        int x1, y1, x2, y2, dx1, dy1, dx2, dy2;
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
            type.wrInt(1);
            type.wrInt(x1);
            type.wrInt(y1);
            type.wrInt(x2);
            type.wrInt(y2);
            type.wrString(name);
        }
        public bool isSelected(int mouseX, int mouseY)
        {
            if (x2 - x1 == 0)
                if (((mouseY >= y1 && mouseY <= y2) || (mouseY >= y2 && mouseY <= y1)) && (mouseX > x1 - 3) && (mouseX < x1 + 3))
                {
                    dx1 = mouseX - x1;
                    dy1 = mouseY - y1;
                    dx2 = mouseX - x2;
                    dy2 = mouseY - y2;
                    return true;
                }
            if (y2 - y1 == 0)
                if (((mouseX >= x1 && mouseX <= x2) || (mouseX >= x2 && mouseX <= x1)) && (mouseY > y1 - 3) && (mouseY < y1 + 3))
                {
                    dx1 = mouseX - x1;
                    dy1 = mouseY - y1;
                    dx2 = mouseX - x2;
                    dy2 = mouseY - y2;
                    return true;
                }
            if (x1 - x2 != 0 && y1 - y2 != 0)
                if (false)
                {
                    dx1 = mouseX - x1;
                    dy1 = mouseY - y1;
                    dx2 = mouseX - x2;
                    dy2 = mouseY - y2;
                    return true;
                }
            return false;
        }
        public void setPositions(int mouseX, int mouseY)
        {
            x1 = mouseX - dx1;
            y1 = mouseY - dy1;
            x2 = mouseX - dx2;
            y2 = mouseY - dy2;
        }
    }
}