using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstConference
{
    class Rectangle : Shape
    {
        int x, y, width, height, dx, dy;
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
        public bool isSelected(int mouseX, int mouseY)
        {
            if ((mouseX == x && y <= mouseY && mouseY <= y + height) || (mouseX == x + width && y <= mouseY && mouseY <= y + height) || (mouseY == y && x < mouseX && mouseX < x + width) || (mouseY == y + height && x < mouseX && mouseX < x + width))
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