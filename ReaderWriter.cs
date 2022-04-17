/*2)	Create a simple user interface to accept account related information of a customer.
 * [ Account class from Lab session on Delegates and Events can be used].
 * Save the information about the customers in a file using StreamWriter and retrieve the information using StreamReader.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project7
{
    public class ReaderWriter
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Deposit");
            account.Deposit();
            Console.WriteLine("Reading the data from file");
            Console.WriteLine();
            account.ReaderFromFile();
            Console.WriteLine("Withdraw");
            account.Withdraw();
            Console.WriteLine("Reading the data from file");
            Console.WriteLine();
            account.ReaderFromFile();
        }
    }
    class Account
    {
        private double balance = 10000;
        String bank = String.Empty;
        String name = String.Empty;
        int account;
        double withdraw, deposit, totalbal;
        String myPath = @"D:\MyNewDir\Test.txt";

        public void Deposit()
        {
            string temp = "";
            StreamWriter writer = new StreamWriter(myPath, true);
            do
            {
                Console.WriteLine("If you want Enter / Exit : y/n");
                temp = Console.ReadLine().ToLower();
                if (temp != "n")
                {
                    Console.WriteLine("Enter Customer Name:");
                    name = Console.ReadLine();
                    writer.WriteLine(name);
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    writer.WriteLine(account);
                    Console.WriteLine("Enter Deposit Amount :");
                    deposit = Convert.ToDouble(Console.ReadLine());
                    writer.WriteLine(deposit);
                    totalbal = balance + deposit;
                }
            } while (temp != "n");
            writer.Close();
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Amount After Deposit  : " + totalbal);
        }
        public void Withdraw()
        {
            string temp = "";
            StreamWriter sw = new StreamWriter(myPath, true);
            do
            {
                Console.WriteLine("If you want Enter / Exit : y/n ");
                temp = Console.ReadLine().ToLower();
                if (temp != "n")
                {
                    Console.WriteLine("Enter Customer Name :");
                    name = Console.ReadLine();
                    sw.WriteLine(name);
                    Console.WriteLine("Enter Account Number  :");
                    account = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine(account);
                    Console.WriteLine("Enter Withdraw Amount :");
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    sw.WriteLine(withdraw);
                    if (withdraw <= balance)
                    {
                        totalbal = balance - withdraw;
                        Console.WriteLine("Customer Name: " + name);
                        Console.WriteLine("Account Number: " + account);
                        Console.WriteLine("Amount after Withdraw : " + totalbal);
                    }
                    else
                        Console.WriteLine("\n\nUnder balance");
                }
            } while (temp != "n");
            sw.Close();
        }
        public void ReaderFromFile()
        {
            StreamReader sr = new StreamReader(myPath);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
