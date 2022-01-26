using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int tres = 3;
            int cinco = 5;
            int uno = 1;
            int quince = 15;
            var sistema = new Sistema();
            result = sistema.Meta(tres);
            Console.WriteLine(result);
            result = sistema.Meta(cinco);
            Console.WriteLine(result);
            result = sistema.Meta(uno);
            Console.WriteLine(result);
            result =  sistema.Meta(quince);
            Console.WriteLine(result);
            
        }

    }
}
