using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashsBigDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            String[] str = Console.ReadLine().Split();
            int[] primeCount = new int[(int)Math.Sqrt(100000)];
            int max;
            List<int> primeList = new List<int>();
            primeList.Add(2);
            for (int i = 3; i * i < 100000; i += 2)
            {
                if(IsPrime(i)) 
            }
        }

        bool IsPrime(int n)
        {
            for (int i = 2; i * i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
}
