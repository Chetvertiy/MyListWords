using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiskii
{
    class Program
    {
        public static MyList strList = new MyList();

        /// <summary>
        /// Удаляет различающиеся элементы
        /// </summary>
        static void SameLeft()
        {
            int i = 0;

            do
            {
                if (strList[i] == strList[i + 1])
                {
                    ++i;
                }

                if (strList[i] != strList[i + 1])
                {
                    strList.Delete(i);
                }
            } while (i < strList.Count - 1);

            if (strList[strList.Count - 1] != strList[strList.Count - 2])
            { strList.Delete(strList.Count - 1); }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\nВводите строки для записи в список (введите 0 для окончания записи)");

            string str;

            do
            {
                str = Console.ReadLine();
                strList.Add(str);

            } while (str != "0");


            strList = strList.SSort(strList);

            Console.WriteLine("\nstrList.SSort = ");

            for (int k = 0; k < strList.Count; k++)
            {
                Console.Write(" " + strList[k]);
            }

            SameLeft();

            Console.WriteLine("\nstrList (после SameLeft) = ");

            for (int k = 0; k <= strList.Count - 1; k++)
            {
                Console.Write(" " + strList[k]);
            }

            string finalStr = ""; int t = 0;

            for (t = 0; t < strList.Count; t++)
            {
                finalStr += strList[t];
            }

            Console.Write("\n\nСлово из одинаковых : {0} ", finalStr);

            Console.ReadKey();
        }
    }
}


        
    

                                                    
         
            

           
