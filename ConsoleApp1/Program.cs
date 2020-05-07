using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    List<Person> PersonArray = new List<Person>();
                    PersonArray.Add(new Person("Мужчина", 11, "Игорь", "Рак")); // void Add
                    List<Person> TempPersonArray = new List<Person>();
                    Person person2;
                    TempPersonArray.Add(person2 = new Person("Женщина", 12, "Ира", "Дева"));
                    TempPersonArray.Add(new Person("Мужчина", 15, "Виктор", "Телец"));
                    PersonArray.AddRange(TempPersonArray); // void AddRange
                    Console.WriteLine($"Результат работы BinarySearch ({PersonArray[PersonArray.BinarySearch(person2)].show()})"); // int BinarySearch
                    Console.WriteLine($"Результат работы IndexOf ({PersonArray.IndexOf(person2)})"); // int IndexOf
                    PersonArray.Insert(1, new Person("Женщина", 1, "Валя", "Стрелец")); //void Insert 
                    Console.WriteLine($"Результат работы Remove ({PersonArray.Remove(person2)})"); // bool Remove
                    PersonArray.RemoveAt(1); // void RemoveAt
                    Console.WriteLine("Результат сортировки по имени");
                    PrintList(PersonArray, '\t');
                    PersonArray.Sort((x, y) => string.Compare(x.name, y.name)); // void Sort по имени
                    PrintList(PersonArray, '\t');
                    break;
                case 2:
                    LinkedList<Animal> animals = new LinkedList<Animal>();

                    // 1 - С помощью значения
                    // 2 - С помощью узла

                    var firstNode = animals.AddFirst(new Animal("Тигр", 6, "Дымок", "Рыжий")); // AddFirst 1
                    LinkedListNode<Animal> node1; // AddFirst 2
                    animals.AddFirst(node1 = new LinkedListNode<Animal>(new Animal("Собака", 5, "Шарик", "Черный"))); 

                    var secondNode = animals.AddAfter(firstNode, new Animal("Пудель", 6, "Веревка", "Голубой")); //AddAfter 1
                    LinkedListNode<Animal> node2; //AddAfter 2
                    animals.AddAfter(firstNode,node2 = new LinkedListNode<Animal>(new Animal("Лошадь", 10, "Игорь", "Белый")));

                    var thitdNode = animals.AddBefore(secondNode, new Animal("Кот", 6, "Кириешка", "Рыжий")); //AddBefore 1
                    LinkedListNode<Animal> node3; // AddBefore 2
                    animals.AddBefore(secondNode, node3 = new LinkedListNode<Animal>(new Animal("Петух", 5, "Петух", "Коричневый")));

                    var fourNode = animals.AddLast(new Animal("Гусь", 3, "Виктор", "Белый")); //AddLast 1
                    LinkedListNode<Animal> node4; //AddLast 2
                    animals.AddLast(node4 = new LinkedListNode<Animal>(new Animal("Лев", 12, "Кактус", "Рыжий")));

                    animals.RemoveFirst(); //RemoveFirst
                    animals.RemoveLast(); //RemoveLast

                    PrintList(animals, '\n');
                    break;
                case 3:
                    Queue<Transport> transports = new Queue<Transport>();
                    transports.Enqueue(new Transport("Hetcback", "Audi", "Black")); //Enqueue
                    transports.Enqueue(new Transport("Sportcar", "Mercedes", "Blue"));
                    transports.Enqueue(new Transport("Track", "Lada", "White"));
                    transports.Dequeue().show(); //Dequeue
                    transports.Peek().show(); //Peek
                    PrintList(transports, '\n');
                    break;
                case 4:
                    Stack<Figure> figures = new Stack<Figure>();
                    figures.Push(new Figure("Квадрат", "Белый", 40)); // Push
                    figures.Push(new Figure("Треугольник", "Черный", 32));
                    figures.Push(new Figure("Круг", "Розовый", 36));
                    figures.Pop().show(); //Pop
                    figures.Peek().show(); // Peek
                    PrintList(figures, '\n');
                    break;
                case 5:
                    Dictionary<Person, Passport> dictionary = new Dictionary<Person, Passport>(); //Создание словаря              
                    dictionary.Add(new Person("Мужчина", 35, "Виктор", "Рак"), new Passport(2555,682667)); // Добавление первого элемента
                    KeyValuePair<Person, Passport> personDic = 
                        new KeyValuePair<Person, Passport>(new Person("Женщина", 12, "Ира", "Дева"),new Passport(2567, 268478));
                    dictionary.Add(personDic.Key, personDic.Value); // Добавление второго элемента
                    foreach (KeyValuePair<Person,Passport> item in dictionary)
                    {
                        Console.WriteLine($"{item.Key.show()} {item.Value.show()}");
                    }
                    break;
                default:
                    break;
            }
            static void PrintList(IEnumerable myList, char Separator) // Обычный метод прохоядщий список
            {
                foreach (AbstractShow obj in myList)
                    Console.Write($"{Separator} {obj.show()}");
                Console.WriteLine();
            }
        }
    }
}
