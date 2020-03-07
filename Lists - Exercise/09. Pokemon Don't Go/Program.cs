using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfRemovedElements = 0;
            while (pokemons.Count > 0)
            {
                int givenIndex = int.Parse(Console.ReadLine());                                
                if (givenIndex < 0)
                {
                    int lastElement = pokemons[pokemons.Count - 1];
                    sumOfRemovedElements += pokemons[0];
                    int removedElement = pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, lastElement);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedElement) pokemons[i] += removedElement;
                        else pokemons[i] -= removedElement;
                    }
                }
                else if (givenIndex > pokemons.Count - 1)
                {
                    int firstElement = pokemons[0];
                    sumOfRemovedElements += pokemons[pokemons.Count - 1];
                    int removedElement = pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(firstElement);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedElement) pokemons[i] += removedElement;
                        else pokemons[i] -= removedElement;
                    }
                }
                else
                {
                    int removedElement = pokemons[givenIndex];
                    sumOfRemovedElements += removedElement;
                    pokemons.RemoveAt(givenIndex);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedElement) pokemons[i] += removedElement;
                        else pokemons[i] -= removedElement;
                    }
                }
                if (pokemons.Count == 0) break;
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
