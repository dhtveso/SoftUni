using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradeComissions
{
    class tradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var turnover = decimal.Parse(Console.ReadLine());
            var comission = 0m;


            if (turnover <= 0)
            {
                Console.WriteLine("error");
            }
            if (town == "Sofia")
            {
                if (turnover > 10000)
                {
                    comission = 0.12m;
                }
                else if (turnover > 1000)
                {
                    comission = 0.08m;
                }
                else if (turnover > 500)
                {
                    comission = 0.07m;
                }
                else if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.05m;
                }

            }
            else if (town == "Varna")
            {
                if (turnover > 10000)
                {
                    comission = 0.13m;
                }
                else if (turnover > 1000)
                {
                    comission = 0.10m;
                }
                else if (turnover > 500)
                {
                    comission = 0.075m;
                }
                else if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.045m;
                }

            }
            else if (town == "Plovdiv")
            {
                if (turnover > 10000)
                {
                    comission = 0.145m;
                }
                else if (turnover > 1000)
                {
                    comission = 0.12m;
                }
                else if (turnover > 500)
                {
                    comission = 0.08m;
                }
                else if (turnover <= 500 && turnover > 0)
                {
                    comission = 0.055m;
                }

            }
            else
            {
                Console.WriteLine("error");
            }
            var totalComission = turnover * comission;
            Console.WriteLine(totalComission);
        }
    }
}
