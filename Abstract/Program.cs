using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c = new WalkInCustomer();
            c.Enquiry();

            ICustomer c1 = new PlatiniumCustomer();
            c1.Enquiry();
            Console.WriteLine("Hello World!");
        }
    }

    public interface ICustomer
    {
        string Name { get; set; }
        void Enquiry();
        decimal Discount();
    } //planning

    public abstract class Customer : ICustomer
    {
        public string Name { get; set; }

        public void Enquiry()
        {
            Console.WriteLine("Explain him product");
        }

        public abstract decimal Discount();
    } //Define common logic

    public class WalkInCustomer : Customer
    {
        public override decimal Discount()
        {
            throw new NotImplementedException();
        }
    } //Full classes

    public class PlatiniumCustomer : Customer
    {
        public override decimal Discount()
        {
            throw new NotImplementedException();
        }
    } //Full classes
}
