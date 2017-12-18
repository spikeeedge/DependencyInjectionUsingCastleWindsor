namespace DependencyInjectionUsingCastleWindsor
{
    using System;

    public class Customer : ICustomer
    {
        public void FullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
