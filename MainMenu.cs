using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    public class MainMenu
    {
        private List<Animal> animals;

        public MainMenu()
        {
            animals = new List<Animal>();
        }

        public void ZooMenu()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие: \n1.Добавить животное \n2.Покормить животное \n3.Список животных \n4.Выход\n");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        AddAnimal();
                        break;

                    case "2":
                        FeedAnimal();
                        break;

                    case "3":
                        AnimalList();
                        break;

                    case "4":
                        Console.WriteLine("Всего хоро ше го!");
                        return;

                    default:
                        Console.WriteLine("Выберите пункт 1 - 4");
                        break;
                }
            }
        }

        public void AddAnimal()
        {
            Console.WriteLine("\nВведите имя льва: ");

            string name = Console.ReadLine();
            int counter;

            if (name == null || name.StartsWith(' '))
            {
                Console.WriteLine("Введите имя не начинающееся с пробела");
            }
            else
            {
                counter = animals.Count() + 1;

                string newname = counter.ToString() + ". " + name;

                Animal newAnimal = new Lion(newname);

                animals.Add(newAnimal);

                Console.WriteLine($"\nЛев {name} теперь живет в зоопарке");
            }
        } 

        public void FeedAnimal() 
        {
            Console.WriteLine("\nВыберите кого хотите покормить: ");
                        
            AnimalList();

            string choice = Console.ReadLine();

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Name.StartsWith(choice))
                {
                    animals[i].Eat();
                    break;
                }
                else
                {
                    Console.WriteLine("Не бывает такого цифра");
                }
            }
        }

        public void AnimalList()
        {
            if (animals.Any())
            {
                Console.WriteLine();
                foreach (var animal in animals)
                {
                    Console.Write($"{animal.Name}; ");
                }
                Console.WriteLine();
            }
            else { Console.WriteLine("Зоопарк пустой, не хих"); }
        }
    }
}
