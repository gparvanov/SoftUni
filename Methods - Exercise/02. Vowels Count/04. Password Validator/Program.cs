using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool lengthIsOk = LengthOk(password);
            bool containsOnlyLettersDigit = ContainsOnlyLettersDigithOk(password);
            bool twoDigitsInThePassword = TwoDigitsInPassword(password);

            if (!lengthIsOk) Console.WriteLine("Password must be between 6 and 10 characters");
            if (!containsOnlyLettersDigit) Console.WriteLine("Password must consist only of letters and digits");
            if (!twoDigitsInThePassword) Console.WriteLine("Password must have at least 2 digits");

            if (lengthIsOk && containsOnlyLettersDigit && twoDigitsInThePassword) Console.WriteLine("Password is valid");
        }

        static bool LengthOk (string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool ContainsOnlyLettersDigithOk(string password)
        {            
            for (int i = 0; i < password.Length; i++)
            {
                if(!char.IsLetterOrDigit(password[i])) return false;
            }
            return true;
        }
        static bool TwoDigitsInPassword(string password)
        {
            int countDigits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] - '0' >= 0 && password[i] - '0' <= 9) countDigits++;
            }
            if (countDigits < 2) return false;
            else return true;
        }
    }
}
