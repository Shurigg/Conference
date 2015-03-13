using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FirstConference
{
    class FileFiler : Filer
    {
        StreamReader mStream;
        StreamWriter wStream;

        public FileFiler(string path, int type)
        {
            if (type == 1)
                mStream = new StreamReader(path);
            else
                wStream = new StreamWriter(path);
        }
        public override bool eof()
        {
            return !mStream.EndOfStream;
        }
        public override int rdInt()
        {
            string data = mStream.ReadLine();
            return Convert.ToInt32(data);
        }
        public override double rdDouble()
        {
            string data = mStream.ReadLine();
            return Convert.ToDouble(data);
        }
        public override string rdString()
        {
            return mStream.ReadLine();
        }
        public override void wrInt(int Int)
        {
            wStream.WriteLine(Convert.ToString(Int));
        }
        public override void wrDouble(double Double)
        {
            wStream.WriteLine(Convert.ToString(Double));
        }
        public override void wrString(string String)
        {
            wStream.WriteLine(String);
        }
        public override void closeWR()
        {
            wStream.Close();
        }
    }
}