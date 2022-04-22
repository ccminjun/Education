using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list= new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = 100;
            }
            for (int i = 0; i<list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<string> strlist = new MyList<string>();
            for (int i = 0; i < strlist.Length; i++)
            {
                strlist[i] = "Hello_"+ (i + 1);
            }
            for (int i = 0; i < strlist.Length; i++)
            {
                Console.Write($"{strlist[i]}\t");
            }

            MyList<object> objList = new MyList<object>();
            objList[0] = 111;
            objList[1] = 3.141592f;
            objList[2] = "Hello, wolrd";
        }
    }
}
