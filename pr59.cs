using System;

namespace BankAccount
{
    class BankAccount
    {

        public string AccountNumber { get; } 
        public decimal Balance { get; private set; } 
        public string OwnerName { get; set; } 

        public BankAccount(string _AccountNumber, decimal _Balance, string _OwnerName)
        {
            if (string.IsNullOrWhiteSpace(_AccountNumber))
                throw new ArgumentException("Номер счета не может быть пустым.", nameof(_AccountNumber));
            if (_Balance < 0)
                throw new ArgumentOutOfRangeException(nameof(_Balance), "Баланс не может быть отрицательным.");
            AccountNumber = _AccountNumber;
            Balance = _Balance;
            OwnerName = _OwnerName;
        }

        public void Deposit(decimal money)
        {
            if (money <= 0)
                throw new ArgumentOutOfRangeException(nameof(money), "Сумма пополнения должна быть положительной.");

            Balance += money;
            Console.WriteLine($"Успешно пополнено: {money}. Текущий баланс: {Balance}");
        }

        public void Withdraw(decimal money)
        {
            if (money <= 0)
                throw new ArgumentOutOfRangeException(nameof(money), "Сумма снятия должна быть положительной.");

            if (Balance < money)
                throw new InvalidOperationException("Недостаточно средств на счете для выполнения операции.");

            Balance -= money;
            Console.WriteLine($"Успешно снято: {money}. Текущий баланс: {Balance}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount account = new BankAccount("2077 5896 412 53", 20000, "Екатерина");
                Console.WriteLine($"Номер счета: {account.AccountNumber}, Текущий баланс: {account.Balance}, Имя владельца: {account.OwnerName}");

                account.Deposit(5000);

                account.Withdraw(3000);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка выполнения операции: {ex.Message}");
            }
        }
    }
}
