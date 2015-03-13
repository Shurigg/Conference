using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FirstConference
{
    abstract class Filer
    {
        abstract public int rdInt();
        abstract public double rdDouble();
        abstract public string rdString();
        abstract public void wrInt(int Int);
        abstract public void wrDouble(double Double);
        abstract public void wrString(string String);
        abstract public bool eof();
    }
}