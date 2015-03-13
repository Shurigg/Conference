using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConference
{
    class Geo
    {
        public List<Shape> loadFile(Filer filer)
        {
            List<Shape> arr = new List<Shape>();
            Geo g = new Geo();
            while (filer.eof())
            {
                int header = filer.rdInt();
                Shape s = g.ChoiseType(header);
                s.Load(filer);
                arr.Add(s);
            }
            return arr;
        }

        public Shape ChoiseType(int type)
        {
            switch (type)
            {
                case 1:
                    return new Line();
                case 2:
                    return new Circle();
                case 3:
                    return new Rectangle();
                case 4:
                    return new Square();
                default: return null;
            }
        }
    }
}
