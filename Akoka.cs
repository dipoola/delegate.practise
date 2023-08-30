using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlegat.practise
{
    public class Akoka
    {
        public string name { get; set; }
        public string state { get; set; }
        public string region { get; set; }


        public void Details()
        {
            Console.WriteLine($"akoka is a location in lagos state lcd areas");
        }

        public void Add(int num1, int num2)
        {

            Console.WriteLine($" The result of this addition is { num1 + num2}");

        }

        public void Multiply(int num10, int num20)
        {

            Console.WriteLine($"The result of this multiplication is {num10 + num20}");

        }

        public void sayHello()
        {

            Console.WriteLine("hi aPI IN C# were about to write you!!!!");

        }


        public void sayName()
        {

            Console.WriteLine($"the only way to greet is to say good morning {name}");

        }
          

        public int Divide(int num1 ,int num2 ,int num3,  int num4)
        {
            return num1 / num2 / num3 / num4;
        }




    }
}
