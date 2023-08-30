

using dlegat.practise;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    delegate void Food();
    static void Main(string[] args)
    {
        //delegate with no return type and 2 parameters
        // delegate void Calculate(int num, int num2);

        //delegate with no return and no parameter
        // delegate void Animal();

        //delegate with return type and parameters
        //delegate int Calculate(int num, int num2, int num90);

        //delegate with return type and parameter
        //delegate void Church(string name);


        //Method that is not in a class

        //void HelloWorld(string name)
        //{
        //    Console.WriteLine($"Hello World {name}");
        //}


        //Multicast Delegate
        //calculate += methods.Subtract;

        //calculates.Invoke(500, 300);
        // calculate(20, 30);

     

        //Action delegate: The Action delegate represents a method 
        //    that takes a specific number of input parameters 
        //        and does not return a value(void).

        //Action Delegate
        //Action<int, int> actionDelegate = methods.Add;
        //actionDelegate.Invoke(70, 10);



        //Func Types:The Func types represent delegates that return a value.
        //    The last type parameter specifies the return type, 
        //    while the preceding type parameters indicate the parameter types of the method. 
        //    The Func delegate types can have up to 16 type parameters, 
        //    with the last one being the return type.

        //Func<int, int, int> paramAndReturn = methods.FuncMethod;
        //Console.WriteLine(paramAndReturn(50, 50));

        //Delegate assignment


        //Action: The Action delegate represents a method that takes a specific number of
        //        input parameters and does not return a value(void).

        //      It can take from 0 to 16 input parameters of different types

        //Func: They can have up to 16 type parameters, 
        //        which indicate the parameter types of the method.




        //Method that is not in a class

        //Action<string> temmy = hello;
        //void hello(string name)
        //{
        //    Console.WriteLine($"Good morning {name}");
        //}



        Akoka akoka = new Akoka();

        //Multicast Delegate
        Food food = akoka.sayHello;
        food += akoka.sayName;
        food();




        //Func<int, int, int, int, int> retunparameters = akoka.Divide;

        //Console.WriteLine(retunparameters(500, 400, 40, 10));

        //Action<int, int> smith = akoka.Add;
        //smith.Invoke(24, 56);


    }
}
