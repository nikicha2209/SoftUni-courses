namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> accountBalances = new Dictionary<int, double>();
            string[] bankAccountTokens = Console.ReadLine().Split(',');

            for (int i = 0; i < bankAccountTokens.Length; i++)
            {
                int account = int.Parse(bankAccountTokens[i].Split('-').First());
                double balance = double.Parse(bankAccountTokens[i].Split('-').Last());
                accountBalances.Add(account, balance);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] tokens = command.Split();
                    if (tokens[0] != "Deposit" && tokens[0] != "Withdraw")
                    {
                        throw new ArgumentException("Invalid command!");
                    }

                    if (!accountBalances.Keys.Contains(int.Parse(tokens[1])))
                    {
                        throw new FormatException("Invalid account!");
                    }
                    switch (tokens[0])
                    {
                        case "Deposit":
                            Deposit(int.Parse(tokens[1]), double.Parse(tokens[2]), accountBalances);
                            break;

                        case "Withdraw":
                            Withdraw(int.Parse(tokens[1]), double.Parse(tokens[2]), accountBalances);
                            break;

                    }
                }

                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Enter another command");
            }

        }

        static void Withdraw(int accountNumber, double sum, Dictionary<int, double> bankAccounts)
        {
            if (sum > bankAccounts[accountNumber])
            {
                throw new ArgumentException("Insufficient balance!");
            }

            bankAccounts[accountNumber] -= sum;
            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:f2}");
        }

        static void Deposit(int accountNumber, double sum, Dictionary<int, double> bankAccounts)
        {
            bankAccounts[accountNumber] += sum;
            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:f2}");
        }
    }
}