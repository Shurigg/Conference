using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConference
{
    class Square: Shape
    {
        int x, y, side, dx, dy;
        string name;
        public Square()
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
            type.wrInt(4);
            type.wrInt(x);
            type.wrInt(y);
            type.wrInt(side);
            type.wrString(name);
        }
        public bool isSelected(int mouseX, int mouseY)
        {
            if ((mouseX == x && y <= mouseY && mouseY <= y + side) || (mouseX == x + side && y <= mouseY && mouseY <= y + side) || (mouseY == y && x < mouseX && mouseX < x + side) || (mouseY == y + side && x < mouseX && mouseX < x + side))
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