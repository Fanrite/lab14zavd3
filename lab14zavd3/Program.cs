using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Inputdata;

namespace lab14zavd3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, l = 3;
            bool flag = true;
            while (flag)
            {
                string output = "";
                
                Input.Inint(ref n,"Ведіть розмір массиву Х:");

                int[] x = new int[n];
                Input.Gen(ref x, n);
                output += "Вхідний массив Х:\n";
                Input.Printeri(x, n, ref output);


                Input.Inint(ref l, "Ведіть ширину рядка:");

                int[,] arr = new int[n, l];
                int y = 0;

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < l; j++)
                    {
                        if (y < n) arr[i, j] = x[y];
                        else arr[i, j] = 0;
                        y++;
                    }


                output += "\n\nВихідний массив А:\n";
                Input.Printer(arr, n, l, ref output);

                        //exit or begin 
                        if (MessageBox.Show(output + "\n\nПовторити?", "Результат", MessageBoxButtons.YesNo) == DialogResult.No)
                    flag = false;
            }

        }
    }
}
