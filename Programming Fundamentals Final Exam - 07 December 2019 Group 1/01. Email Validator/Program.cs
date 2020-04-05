using System;
using System.Text;
using System.Linq;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder email = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while(command != "Complete")
            {
                string[] inputData = command.Split();

                if(inputData[0] == "Make")
                {
                    if (inputData[1] == "Upper") email = new StringBuilder(email.ToString().ToUpper());
                    else if (inputData[1] == "Lower") email = new StringBuilder(email.ToString().ToLower());
                    Console.WriteLine(email);
                }
                else if (inputData[0] == "GetDomain")
                {
                    int symbols = int.Parse(inputData[1]);
                    Console.WriteLine(string.Join("",email.ToString().ToArray().TakeLast(symbols)));
                }
                else if (inputData[0] == "GetUsername")
                {
                    int domain = email.ToString().IndexOf('@');
                    if (domain != -1)
                    {
                        string start = email.ToString().Substring(0,domain);
                        Console.WriteLine(start);
                    }
                    else Console.WriteLine($"The email {email} doesn't contain the @ symbol.");

                }
                else if ( inputData[0] == "Replace")
                {                    
                    while (email.ToString().Contains(inputData[1]))
                    {
                        email.Replace(inputData[1], "-");
                    }
                    Console.WriteLine(email);
                }
                else if ( inputData[0] == "Encrypt")
                {
                    string printText = email.ToString();
                    for (int i = 0; i < printText.Length; i++)
                    {
                        int ascii = printText[i];
                        Console.Write($"{ascii} ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}