using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public enum AccountType { Actual, Savings }
    public enum ВУЗ { КГУ, КАИ, КХТИ}
    public struct employee
    {
        public string name;
        public ВУЗ university;
    }
    public struct BankAccount
    {
        public long number;
        public decimal balance;
        public AccountType type;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            AccountType actualAccount;
            AccountType savingAccount;
            actualAccount = AccountType.Actual;
            savingAccount = AccountType.Savings;
            Console.WriteLine("Bank account type is {0}", actualAccount);
            Console.WriteLine("Bank account type is {0}", savingAccount);

            Console.WriteLine("Задание 3.2");
            BankAccount bankAccount;
            bankAccount.type = AccountType.Actual;
            bankAccount.balance = (decimal)10000.00;
            bankAccount.number = 123;
            Console.WriteLine("Account number {0}", bankAccount.number);
            Console.WriteLine("Account type {0}", bankAccount.type);
            Console.WriteLine("Account balance {0}", bankAccount.balance);

            Console.WriteLine("Домашнее задание 3.1");
            employee information_employee;
            information_employee.name = "Евгений";
            information_employee.university = ВУЗ.КГУ;
            Console.WriteLine("Имя сотрудника: {0}", information_employee.name);
            Console.WriteLine("ВУЗ: {0}", information_employee.university);

            Console.ReadKey();
        }
    }
}
