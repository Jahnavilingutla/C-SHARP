using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Show the working of Multicast delegates to calculate the interest rate for the following categories:
//PARAMETERS - > BANKNAME,INTEREST RATE

//SBI
//2.70%
//HDFC Bank
//3.00% – 3.50%
//Kotak Mahindra Bank
//3.50%
//Axis Bank
//3.00% – 3.50%
//ICICI Bank
//3.00% – 3.50%
namespace C_SHARP
{
    public delegate void BankDelegates(string bankName, float interesrRate);
    public class Bank
    {
        public void SBI(string bankName, float interestRate)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(interestRate);
        }
        public void HDFC(string bankName, float interestRate)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(interestRate);
        }
        public void KOTAK(string bankName, float interestRate)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(interestRate);
        }
        public void AXIS(string bankName, float interestRate)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(interestRate);
        }
        public void ICICI(string bankName, float interestRate)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(interestRate);
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            BankDelegates rectDelegate = new BankDelegates(b.SBI);
            BankDelegates rectDelegate1 = new BankDelegates(b.HDFC);
            BankDelegates rectDelegate2 = new BankDelegates(b.KOTAK);
            BankDelegates rectDelegate3 = new BankDelegates(b.AXIS);
            BankDelegates rectDelegate4 = new BankDelegates(b.ICICI);

            rectDelegate("SBI", 2.70f);
            Console.WriteLine("--------------------------------");
            rectDelegate1("HDFC Bank", 3.0f);
            Console.WriteLine("--------------------------------");
            rectDelegate2("Kotak Mahindra Bank", 3.50f);
            Console.WriteLine("--------------------------------");
            rectDelegate3("Axis Bank", 3.50f);
            Console.WriteLine("--------------------------------");
            rectDelegate4("ICICI Bank", 3.50f);

            Console.ReadKey();
        }
    }

}


