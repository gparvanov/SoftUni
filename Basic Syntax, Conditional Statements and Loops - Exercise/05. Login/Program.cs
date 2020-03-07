using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string reversedUsername = "";
            for (int i = username.Length-1; i >=0; i--)
            {
                reversedUsername += username[i];
            }

            string loginPassword = Console.ReadLine();
            int attempts = 1;
            bool login = false; 
            while (reversedUsername != loginPassword && attempts <=3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                loginPassword = Console.ReadLine();
                if (reversedUsername == loginPassword)
                {
                    login = true; 
                    break;
                }
                attempts++;
            }

            if (attempts <= 3 && login)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
