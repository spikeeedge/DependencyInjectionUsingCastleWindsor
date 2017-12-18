namespace DependencyInjectionUsingCastleWindsor
{
    using System;

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");

            Container.Register();

            var customer = Container.For<ICustomer>();
            
            Console.WriteLine("Container Registered");
            
            customer.FullName("Steve", "Smith");

            Console.ReadKey();

        }
    }
}
