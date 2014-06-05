using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiskii
{
    public class Node
    {
        public string _inf; //значение в узле
        public Node _next; //следующий узел

        public Node(string inf, Node next)
        {
            this._inf = inf;
            this._next = next;
        }
    }

    public class MyList
    {
        public static Node _head;  //узел головы
        public static int _count;  // количество элементов в списке

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyList()
        {
            _head = null;
            _count = 0;
        }

        /// <summary>
        /// Добавляет элемент в начало списка
        /// </summary>
        /// <param name="element"></param>
        public void Add(string element)
        {
            Node x = new Node(element, _head);
            _head = x;

            _count++;
        }

        /// <summary>
        /// Удаляет элемент по указанному индексу
        /// </summary>
        /// <param name="index"></param>
       public void Delete(int index)
        {
            if (_head != null)
            {
                if (index == 0)
                { _head = _head._next; _count--; }

                else
                {
                    Node x = _head;
                    for (int i = 0; i < index - 1; i++)
                    { x = x._next; }

                    if (x._next != null)
                    { x._next = x._next._next; _count--; }
                }

            }
            else throw new IndexOutOfRangeException();

        }

        /// <summary>
        /// Возвращает узел по указанному индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
     /*   public Node NodeAt(int index)
        {
            if (index < _count)
            {
                Node p = _head;
                for (int i = 0; i < index; i++)
                {
                    p = p._next;
                }
                return p;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }*/

        public static Node p = new Node("", _head); 

        /// <summary>
        /// Индексация списка
        /// </summary>        
        public string this[int i]
        {
            set
            {
                if (_head != null)
                {
                    if (i == 0)
                    {
                        p = _head;
                        p._inf = value;
                    }
                    else
                    {
                        p = _head;
                        for (int k = 0; k < i; k++)
                            p = p._next;

                        p._inf = value;
                    }
                }
                else throw new ArgumentOutOfRangeException();
            }

            get
            {
                if (_head != null)
                {
                    if (i == 0)
                    {
                        p = _head;
                        return p._inf;
                    }
                    else
                    {
                        p = _head;
                        for (int k = 0; k < i; k++)
                            p = p._next;

                        return p._inf;
                    }
                }
                else throw new ArgumentOutOfRangeException();
            }

        }

        /// <summary>
        /// Возвращает элемент списка по указанному индексу
        /// </summary>
        /// 
   /*     public string ElementAt(int index)
        {
            if (_head._inf != null)
            {
                Node p = _head;
                if (index != 0)
                {
                    for (int i = 0; i < index; i++)
                    { p = p._next; }

                    return p._next._inf;
                }
                else return _head._inf;
            }
            else return "0";
        }
        */

        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        public int Count
        {
            get { return _count; }
            set
            {
                if (_count > 0)
                { _count = value; }

                else Console.WriteLine("Список пуст");
            }
        }

        /// <summary>
        /// Сортировка строк в списке по алфавиту
        /// </summary>
        public MyList SSort(MyList a)
        {
            if (_head != null)
            {
                bool ok = true;
                while (ok)
                {
                    ok = false;
                    for (int i = 0; i < a.Count - 1; i++)
                    {
                        for (int j = a.Count - 1; j > i; j--)
                        {
                            if (a[i].CompareTo(a[j]) > 0)
                            {
                                string tmp = a[i];
                                a[i] = a[j];
                                a[j] = tmp;
                                ok = true;
                            }
                        }
                    }
                }
                return a;
            }
            else return a;
        }
    }
}     

     
 
 