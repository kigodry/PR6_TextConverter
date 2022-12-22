using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6___Текстовый_конвектор
{
    internal class Text
    {
        public static List<Figure> txt1;
        public static string txt;
        public static List<Figure> text(string path)
        {
            string[] lines = File.ReadAllLines(path);
            Figure f = new Figure();
            f.name = lines[0];
            f.x = lines[1];
            f.y = lines[2];
            Figure d = new Figure();
            d.name = lines[3];
            d.x = lines[4];
            d.y = lines[5];
            Figure e = new Figure();
            e.name = lines[6];
            e.x = lines[7];
            e.y = lines[8];
            List<Figure> list = new List<Figure>();
            list.Add(f);
            list.Add(d);
            list.Add(e);
            return list;
        }
    }
}
