using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = Console.ReadLine().Split(" | ").ToList();
            var morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };            
            for (int i = 0; i < code.Count; i++)
            {
                string[] elements = code[i].Split(' '); 
                string newString = string.Empty;
                for (int k = 0; k < elements.Length; k++)
                {                 
                    if (morseAlphabetDictionary.ContainsValue(elements[k]))
                    {
                        var keys = morseAlphabetDictionary.Where(x => x.Value == elements[k]);
                        string key = "";
                        foreach (KeyValuePair<char,string> pair in keys)
                        {
                            key = pair.Key.ToString();
                            break;
                        }                        
                        newString += key.ToString().ToUpper();                        
                    }
                }
                code[i] = newString;
            }
            code = code.ToList();
            Console.WriteLine(string.Join(" ",code));
        }
    }
}
