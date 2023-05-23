using System;

namespace Praktika3
{
    internal class Program
    {

        private static Employee[] Employees = new Employee[10];
        static void Main(string[] args)
        {
            Employees[0] = new("Петров Василий Иванович",2,50000);
            Employees[1] = new("Днепрова Наталья Дмитриевна", 5, 75000);
            Employees[2] = new("Желатинов Виктор Александрович",3,46000);
            Employees[3] = new("Зимова Анна Андреевна",1,78900);
            Employees[4] = new("Иващенко Сергей Федорович",4,45800);
            Employees[5] = new("Работина Алина Сергеевна",3,64000);
            Employees[6] = new("Фомин Алексей Викторович",5,56800);
            Employees[7] = new("Шумова Алиса Петровна",1,70000);
            Employees[8] = new("Кандратьев Павел Дмитриевич",2,87000);
            Employees[9] = new("Дорохов Михаил Геннадьевич",5,65900);

            Console.WriteLine("Введите букву задания:");
            string knopka =  Console.ReadLine();
            switch (knopka)
            {
                case "a":
                    list_employees();
                    break;
                case "b":
                    expences_salary();
                    break;
                case "c":
                    min_salary();
                    break;
                case "d":
                    max_salary();
                    break;
                case "e":
                    average_salary();
                    break;
                case "f":
                    fio_employees();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }
        }

        static void list_employees()
        {
            foreach (Employee emp in Employees)
            {
                if (emp != null)
                {
                    Console.WriteLine($"ID: {emp.Id}, ФИО: {emp.Fio}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");
                }
            }
            Console.WriteLine();
        }

        static void expences_salary()
        {
            int expences = 0;
            foreach (Employee emp in Employees)
            {
                expences += emp.Salary;
            }
            Console.WriteLine("Сумма затрат на зарплату равна " + expences);
            Console.WriteLine();
        }

        static void min_salary()
        {
            int min = Employees[0].Salary;
            string name = Employees[0].Fio;
            foreach(Employee emp in Employees)
            {
                if(emp.Salary < min)
                {
                    min = emp.Salary;
                    name = emp.Fio;
                }
            }
            Console.WriteLine($"У сотрудника с ФИО: {name} самая минимальная зарплата: {min}");
            Console.WriteLine();
        }

        static void max_salary()
        {
            int max = Employees[0].Salary;
            string name = Employees[0].Fio;
            foreach (Employee emp in Employees)
            {
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                    name = emp.Fio;
                }
            }
            Console.WriteLine($"У сотрудника с ФИО: {name} самая максимальная зарплата: {max}");
            Console.WriteLine();
        }

        static void average_salary()
        {
            int sum = 0;
            int counting = 0;
            foreach (Employee emp in Employees)
            {
                sum += emp.Salary;
                counting++;
            }
            Console.WriteLine("Средняя зарплата равна " + (sum /counting));
            Console.WriteLine();
        }
        static void fio_employees()
        {
            foreach(Employee emp in Employees)
            {
                if(emp != null)
                {
                    Console.WriteLine($"ФИО: {emp.Fio}");
                }
            }
            Console.WriteLine();
        }

       

    }
}
