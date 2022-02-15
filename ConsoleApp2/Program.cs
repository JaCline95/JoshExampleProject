using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<Human> humanLedger = new List<Human>();
        static void Main(string[] args)
        {
            List<Human> humanLedger = new List<Human>();
            bool breakLoop = true;

            do
            {
                Console.WriteLine();
                int result = GetLoopAnswer();

                switch (result)
                {
                    case 1:
                        CreateHuman();
                        break;
                    case 2:
                        RemoveHumans();
                        break;
                    case 3:
                        PrintHumans();
                        break;
                    case 4:
                        breakLoop = false;
                        break;
                }

                Console.WriteLine();

            } while (breakLoop);

        }

        private static void PrintHumans()
        {
            foreach (var human in humanLedger)
            {
                Console.WriteLine("Name: {0}, Weight: {1}", human.Name, human.Weight);
            }
        }

        private static void RemoveHumans()
        {
            humanLedger.Clear();
        }

        private static void CreateHuman()
        {
            Console.WriteLine("Please enter human name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter human weight: ");
            int.TryParse(Console.ReadLine(), out int weightResult);

            humanLedger.Add(new Human(name, weightResult));
        }

        private static int GetLoopAnswer()
        {
            Console.WriteLine("1. - Create Human");
            Console.WriteLine("2. - Remove Humans");
            Console.WriteLine("3. - Print ALL Humans");
            Console.WriteLine("4. - Exit Loop");

            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Human(string humanName, int humanWeight)
        {
            Name = humanName;
            Weight = humanWeight;
        }

        public void Speak()
        {
            Console.WriteLine("{0} weight a total of: {1}", Name, Weight);
        }
    }
}
