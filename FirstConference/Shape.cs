using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FirstConference
{
    interface Shape
    {
        void Load(Filer type);
        void Draw(Graphics gr, Pen p);
        void Save(Filer type);
        bool isSelected(int dx, int dy);
    }
}
