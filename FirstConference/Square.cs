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
        int x, y, side;
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
        public bool isSelected(int dx, int dy)
        {
            if ((dx == x && y <= dy && dy <= y + side) || (dx == x + side && y <= dy && dy <= y + side) || (dy == y && x < dx && dx < x + side) || (dy == y + side && x < dx && dx < x + side))
                return true;
            else
                return false;
        }
    }
}