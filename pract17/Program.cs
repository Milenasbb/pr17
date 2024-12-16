using System;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Xml.Linq;

class IndustrialOrganization
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Brunch { get; set; } //отрасль
    public int NumberOfEmployees { get; set; }//количество сотрудников
    public int Employees { get; set;}
    public double AverageNumberOfEmployeesPerArea() //среднее количество сотрудников на площадь 
    {
        return (double) NumberOfEmployees / Employees;
    }
    ~IndustrialOrganization()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Деструктор сработал. Объект «Промышленная организация» уничтожен");
        Console.ReadKey();
    }

    void GetInfo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Отрасль: {Brunch}");
        Console.WriteLine($"Площадь: {Employees}");
        Console.WriteLine($"Количество сотрудников,расчитаное на площадь: {NumberOfEmployees}");
    }
    public void SetInfo()
    {
        try
        {
            while (true)
            {

                while (true)
                {
                    Console.Write("Введите название промышленной организации: ");
                    string inputName = Console.ReadLine();
                    bool FlagError = false;
                    if (String.IsNullOrEmpty(inputName) || inputName[0] == ' ')
                    {
                        FlagError = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод размера количества сотрудников.Попробуйте ещё раз(");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (FlagError == false)
                    {
                        Name = inputName;
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Введите адрес промышленной организации: ");
                    string inputAddress = Console.ReadLine();
                    bool FlagError = false;
                    if (String.IsNullOrEmpty(inputAddress) || inputAddress[0] == ' ')
                    {
                        FlagError = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод размера количества сотрудников.Попробуйте ещё раз(");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (FlagError == false)
                    {
                        Address = inputAddress;
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Введите отрасль промышленной организации: ");
                    string inputBrunch = Console.ReadLine();
                    bool FlagError = false;
                    if (String.IsNullOrEmpty(inputBrunch) || inputBrunch[0] == ' ')
                    {
                        FlagError = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод размера количества сотрудников.Попробуйте ещё раз(");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (FlagError == false)
                    {
                        Brunch = inputBrunch;
                        break;
                    }


                }
                Console.Write("Введите количество сотрудников: ");
                int inputNumberOfEmployees;
                while (!Int32.TryParse(Console.ReadLine(), out inputNumberOfEmployees) || inputNumberOfEmployees < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Некорректный ввод размера количества сотрудников.Попробуйте ещё раз( ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                NumberOfEmployees = inputNumberOfEmployees;
                Console.Write("Введите площадь, определяемую для рассчёта количества сотрудников: ");
                int inputEmployees;
                while (!Int32.TryParse(Console.ReadLine(), out inputEmployees) || inputEmployees < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Некорректный ввод размера количества сотрудников.Попробуйте ещё раз( ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Employees = inputEmployees;
                GetInfo();
                //double area = 1000;
                double averageNumberOfEmployees = AverageNumberOfEmployeesPerArea();
                Console.WriteLine($"Среднее количество сотрудников на 1000 кв.метров пллощади: {averageNumberOfEmployees}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Нажмите W для продолжения программы...");
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (Console.ReadKey().Key != ConsoleKey.W)
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

    }

}

public class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Здравствуйте!\nПрактическая работа №18.\n");
        Console.WriteLine("Описание класса: Промышленная организация");
        IndustrialOrganization obj1 = new IndustrialOrganization();
        obj1.SetInfo();
        Console.ReadKey();
    }
}

