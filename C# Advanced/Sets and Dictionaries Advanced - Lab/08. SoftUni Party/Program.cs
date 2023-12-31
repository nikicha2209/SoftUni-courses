namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resNumber = string.Empty;
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            while ((resNumber = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(resNumber[0]))
                {
                    vip.Add(resNumber);
                }

                else
                {
                    regular.Add(resNumber);
                }
            }

            while ((resNumber = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(resNumber[0]))
                {
                    vip.Remove(resNumber);
                }

                else
                {
                    regular.Remove(resNumber);
                }
            }

            Console.WriteLine(vip.Count + regular.Count);
            if (vip.Count > 0)
            {
                Console.WriteLine(string.Join("\n", vip));

            }

            if (regular.Count > 0)
            {
                Console.WriteLine(string.Join("\n", regular));
            }

        }
    }
}