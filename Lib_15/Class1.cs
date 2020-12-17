using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_15
{
    public class Task
    {
        public static int Task1(int x)
        {
            int y = 3 * x * x * x * x * x * x - 6 * x * x - 7;
            return y;
        }
        public static int Task2(int a, int b)
        {
            if (a > b) return a / b;
            else
            {
                MessageBox.Show("А должно быть больше B!");
                return 0;
            }
        }
    }
}
