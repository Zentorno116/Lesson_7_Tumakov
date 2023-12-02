namespace Zamilov_T_R_Hometask_21._10._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 8.1 Тумаков");
            Account account1 = new Account("88005553535", 1234, AccountType.DEPOSIT);
            Account account2 = new Account("53535550088", 0, AccountType.CURRENT);

            account1.Transfer(account2, 5000);

            Console.WriteLine(account1);
            Console.WriteLine(account2);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Упражнение 8.2 Тумаков");
            string str = "Chuvak, alcohol is suck.";
            string reversedStr = ReverseString(str);

            Console.WriteLine(str);
            Console.WriteLine(reversedStr);
        }

        //Упражнение 8.2. Метод - Переворот букв.
        public static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            return new string(chars);
        }
    }

    enum AccountType
    {
        DEPOSIT,
        CURRENT
    }
}