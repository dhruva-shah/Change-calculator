using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   
    class Program
    {
        public int x;
        double price1 = 2, price2 = 1, price3 = 0.25, price4 = 0.10, price5 = 0.50;
        void productrate(int item)
        {
            Program program = new Program();
            item = program.x;
            switch (x)
            {
                case 1: Console.WriteLine("\n Price:"+"$"+price1);
                    break;
                case 2:
                    Console.WriteLine("\n Price:"+ "$" + price2);
                    break;
                case 3:
                    Console.WriteLine("\n Price:"+ "$" + price3);
                    break;
                case 4:
                    Console.WriteLine("\n Price:"+ "$" + price4);
                    break;
                case 5:
                    Console.WriteLine("\n Price:"+ "$" + price5);
                    break;
            }
        }
        void calcchange(double changedue) 
        {
            int disperse20 = 0, disperse10 = 0, disperse5 = 0, disperse2 = 0, disperse1 = 0,
            disperse25F = 0, disperse10F = 0, disperse5F = 0;

        xyz:   do {
                changedue = Math.Round(changedue, 2);
                if (changedue>=20)
                {
                    changedue = changedue - 20;
                    disperse20++;
                    goto xyz;
                }
                if (changedue>=10)
                {
                    changedue = changedue-10;
                    disperse10++;
                    goto xyz;
                }
                if (changedue>=5)
                {
                    changedue = changedue - 5;
                    disperse5++;
                    goto xyz;
                }
                if (changedue >= 2)
                {
                    changedue = changedue - 2;
                    disperse2++;
                    goto xyz;
                }
                if (changedue >= 1)
                {
                    changedue = changedue - 1;
                    disperse1++;
                    goto xyz;
                }
                if (changedue >= 0.25)
                {
                    changedue = changedue - 0.25;
                    disperse25F++;
                    goto xyz;
                }
                if (changedue >= 0.10)
                {
                    changedue = changedue - 0.10;
                    disperse10F++;
                    goto xyz;
                }
                if (changedue >= 0.05)
                {
                    changedue = changedue - 0.05;
                    disperse5F++;
                     goto xyz;
                }
            } while (changedue!=0);
            Console.WriteLine("\n $20 " + disperse20 + "\n $10 " + disperse10 + "\n $5 " + disperse5 + "\n $2 " + disperse2 + "\n $1 " + disperse1 +
                       "\n $0.25" + disperse25F + "\n $0.10 " + disperse10F + "\n $0.05 " + disperse5F);
        }
 
        static void Main(string[] args)
        {
            double value=0.00;
            Console.WriteLine("Choose product \n 1. Pepsi \n 2.Chips \n 3. Snickers \n 4. Soda \n 5. Juice");
            Program prog = new Program();
            prog.x= Convert.ToInt32(Console.ReadLine());
            prog.productrate(prog.x);
            Console.WriteLine("Would you like to buy? 1. Yes 2.No");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 1)
            {
                Console.WriteLine("Enter the amount you are paying");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (prog.x==1) { value = prog.price1; }
                else if (prog.x == 2) {value = prog.price2; }
                else if (prog.x == 3) {value = prog.price3; }
                else if (prog.x == 4) {value = prog.price4; }
                else if(prog.x == 5) {value = prog.price5; }
                if (amount < value)
                {
                    Console.WriteLine("Not enough money");
                }
                else
                {
                    double change = amount-value;
                    Console.WriteLine("\n Your change due is " + change);
                    prog.calcchange(change);                   
                    Console.ReadKey();
                }

            }
            else {
                Console.WriteLine("Choose product \n 1. Pepsi \n 2.Chips \n 3. Snickers \n 4. Soda \n 5. Juice");
                Console.ReadKey();
            }

        }
    }
}
