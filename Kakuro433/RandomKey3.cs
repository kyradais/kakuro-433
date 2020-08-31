using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class RandomKey3
    {
        public static Random rnd = new Random();
        public static int[,] tab = new int[100, 100];
        public static int i;
        public static int[,] random()
        {

            tab[1, 1] = 0;
            tab[1, 2] = 0;
            tab[1, 3] = 0;
            tab[1, 4] = 0;
            tab[1, 5] = 0;
            tab[1, 6] = 0;
            tab[1, 7] = 0;
            tab[1, 8] = 0;
            tab[2, 1] = 0;
            tab[2, 5] = 0;
            tab[3, 1] = 0;
            tab[3, 5] = 0;
            tab[4, 1] = 0;
            tab[4, 5] = 0;
            tab[5, 1] = 0;
            tab[5, 2] = 0;
            tab[5, 3] = 0;
            tab[5, 4] = 0;
            tab[5, 5] = 0;
            tab[5, 6] = 0;
            tab[5, 7] = 0;
            tab[5, 8] = 0;
            tab[6, 1] = 0;
            tab[6, 5] = 0;
            tab[7, 1] = 0;
            tab[7, 5] = 0;
            tab[8, 1] = 0;
            tab[8, 5] = 0;

            tab[2, 2] = rnd.Next(1, 5);
            tab[2, 3] = rnd.Next(1, 5);
            tab[2, 4] = rnd.Next(1, 5);

            tab[2, 6] = rnd.Next(1, 5);
            tab[2, 7] = rnd.Next(1, 5);
            tab[2, 8] = rnd.Next(1, 5);

            tab[3, 2] = rnd.Next(1, 5);
            tab[3, 3] = rnd.Next(1, 5);
            tab[3, 4] = rnd.Next(1, 5);

            tab[3, 6] = rnd.Next(1, 5);
            tab[3, 7] = rnd.Next(1, 5);
            tab[3, 8] = rnd.Next(1, 5);

            tab[4, 2] = rnd.Next(1, 5);
            tab[4, 3] = rnd.Next(1, 5);
            tab[4, 4] = rnd.Next(1, 5);

            tab[4, 6] = rnd.Next(1, 5);
            tab[4, 7] = rnd.Next(1, 5);
            tab[4, 8] = rnd.Next(1, 5);

            tab[6, 2] = rnd.Next(1, 5);
            tab[6, 3] = rnd.Next(1, 5);
            tab[6, 4] = rnd.Next(1, 5);

            tab[6, 6] = rnd.Next(1, 5);
            tab[6, 7] = rnd.Next(1, 5);
            tab[6, 8] = rnd.Next(1, 5);

            tab[7, 2] = rnd.Next(1, 5);
            tab[7, 3] = rnd.Next(1, 5);
            tab[7, 4] = rnd.Next(1, 5);

            tab[7, 6] = rnd.Next(1, 5);
            tab[7, 7] = rnd.Next(1, 5);
            tab[7, 8] = rnd.Next(1, 5);

            tab[8, 2] = rnd.Next(1, 5);
            tab[8, 3] = rnd.Next(1, 5);
            tab[8, 4] = rnd.Next(1, 5);

            tab[8, 6] = rnd.Next(1, 5);
            tab[8, 7] = rnd.Next(1, 5);
            tab[8, 8] = rnd.Next(1, 5);

            for (i = 2; i < 5; i++)
            {
                tab[1, 2] = tab[1, 2] + tab[i, 2];

                tab[1, 3] = tab[1, 3] + tab[i, 3];

                tab[1, 4] = tab[1, 4] + tab[i, 4];


                tab[1, 6] = tab[1, 6] + tab[i, 6];

                tab[1, 7] = tab[1, 7] + tab[i, 7];

                tab[1, 8] = tab[1, 8] + tab[i, 8];

            }

            //penjumlahan baris kiri
            for (i = 2; i < 5; i++)
            {
                tab[2, 1] = tab[2, 1] + tab[2, i];

                tab[3, 1] = tab[3, 1] + tab[3, i];

                tab[4, 1] = tab[4, 1] + tab[4, i];


                tab[6, 1] = tab[6, 1] + tab[6, i];

                tab[7, 1] = tab[7, 1] + tab[7, i];

                tab[8, 1] = tab[8, 1] + tab[8, i];

            }

            //penjumlahan kolom bawah
            for (i = 6; i < 9; i++)
            {
                tab[5, 2] = tab[5, 2] + tab[i, 2];

                tab[5, 3] = tab[5, 3] + tab[i, 3];

                tab[5, 4] = tab[5, 4] + tab[i, 4];


                tab[5, 6] = tab[5, 6] + tab[i, 6];

                tab[5, 7] = tab[5, 7] + tab[i, 7];

                tab[5, 8] = tab[5, 8] + tab[i, 8];

            }

            //penjumlahan baris kanan
            for (i = 6; i < 9; i++)
            {
                tab[2, 5] = tab[2, 5] + tab[2, i];

                tab[3, 5] = tab[3, 5] + tab[3, i];

                tab[4, 5] = tab[4, 5] + tab[4, i];


                tab[6, 5] = tab[6, 5] + tab[6, i];

                tab[7, 5] = tab[7, 5] + tab[7, i];

                tab[8, 5] = tab[8, 5] + tab[8, i];

            }



            return tab;
        }
    }
}
