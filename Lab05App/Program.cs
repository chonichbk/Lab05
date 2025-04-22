using Lab05Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Animal[] arrAnimals;

        Console.Write("Введiть кiлькiсть тварин: ");
        int cntAnimals = int.Parse(Console.ReadLine());

        arrAnimals = new Animal[cntAnimals];

        for (int i = 0; i < cntAnimals; i++)
        {
            Console.WriteLine($"\nВведення даних для тварини #{i + 1}");

            Console.Write("Введiть iм'я тварини: ");
            string sName = Console.ReadLine();

            Console.Write("Введiть вид тварини: ");
            string sSpecies = Console.ReadLine();

            Console.Write("Введiть колiр тварини: ");
            string sColor = Console.ReadLine();

            Console.Write("Введiть вiк тварини (у роках): ");
            string sAge = Console.ReadLine();

            Console.Write("Введiть вагу тварини (у кг): ");
            string sWeight = Console.ReadLine();

            Console.Write("Чи є тварина дикою? (y-так, n-нi): ");
            ConsoleKeyInfo keyIsWild = Console.ReadKey(); Console.WriteLine();

            Console.Write("Чи може тварина лiтати? (y-так, n-нi): ");
            ConsoleKeyInfo keyCanFly = Console.ReadKey(); Console.WriteLine();

            Animal theAnimal = new Animal();

            theAnimal.Name = sName;
            theAnimal.Species = sSpecies;
            theAnimal.Color = sColor;
            theAnimal.Age = int.Parse(sAge);
            theAnimal.Weight = double.Parse(sWeight);
            theAnimal.IsWild = keyIsWild.Key == ConsoleKey.Y;
            theAnimal.CanFly = keyCanFly.Key == ConsoleKey.Y;

            arrAnimals[i] = theAnimal;
        }

        Console.WriteLine("\n------ Данi про тварин ------");

        foreach (Animal a in arrAnimals)
        {
            Console.WriteLine();
            Console.WriteLine("Iм'я: " + a.Name);
            Console.WriteLine("Вид: " + a.Species);
            Console.WriteLine("Колiр: " + a.Color);
            Console.WriteLine("Вiк: " + a.Age + " рокiв");
            Console.WriteLine("Вага: " + a.Weight.ToString("0.00") + " кг");
            Console.WriteLine(a.IsWild ? "Це дика тварина" : "Це домашня тварина");
            Console.WriteLine(a.CanFly ? "Тварина може лiтати" : "Тварина не може лiтати");
            Console.WriteLine("Вiк у 'тваринних роках': " + a.AnimalYears.ToString("0.0"));
        }

        Console.ReadKey();
    }
}
