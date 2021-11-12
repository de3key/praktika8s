using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ycheniki
    {
        public string FIO;
        public string group;
        public int ocenka;

        public override string ToString()
        {
            return FIO + " Оценка:" + ocenka + " Группа:" + group;
        }
    }
}
