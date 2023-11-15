// See https://aka.ms/new-console-template for more information
using PizzaStore;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer("Test Name ", "+45 5552341", "testMail@Zealand");
        customer.MakeOrder();
    }
}