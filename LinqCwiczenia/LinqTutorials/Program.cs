using System;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Task 1:");
            var task1Result = LinqTasks.Task1();
            foreach (var emp in task1Result)
            {
                Console.WriteLine($"{emp.Ename} - {emp.Job}");
            }

            Console.WriteLine("\nTask 2:");
            var task2Result = LinqTasks.Task2();
            foreach (var emp in task2Result)
            {
                Console.WriteLine($"{emp.Ename} - {emp.Job} - {emp.Salary}");
            }

            Console.WriteLine("\nTask 3:");
            var task3Result = LinqTasks.Task3();
            Console.WriteLine($"Max Salary: {task3Result}");

            Console.WriteLine("\nTask 4:");
            var task4Result = LinqTasks.Task4();
            foreach (var emp in task4Result)
            {
                Console.WriteLine($"{emp.Ename} - {emp.Salary}");
            }

            Console.WriteLine("\nTask 5:");
            var task5Result = LinqTasks.Task5();
            foreach (var item in task5Result)
            {
                Console.WriteLine($"Nazwisko: {item.GetType().GetProperty("Nazwisko").GetValue(item)}, Praca: {item.GetType().GetProperty("Praca").GetValue(item)}");
            }

            Console.WriteLine("\nTask 6:");
            var task6Result = LinqTasks.Task6();
            foreach (var item in task6Result)
            {
                Console.WriteLine($"Ename: {item.GetType().GetProperty("Ename").GetValue(item)}, Job: {item.GetType().GetProperty("Job").GetValue(item)}, Dname: {item.GetType().GetProperty("Dname").GetValue(item)}");
            }

            Console.WriteLine("\nTask 7:");
            var task7Result = LinqTasks.Task7();
            foreach (var item in task7Result)
            {
                Console.WriteLine($"Praca: {item.GetType().GetProperty("Praca").GetValue(item)}, LiczbaPracownikow: {item.GetType().GetProperty("LiczbaPracownikow").GetValue(item)}");
            }

            Console.WriteLine("\nTask 8:");
            var task8Result = LinqTasks.Task8();
            Console.WriteLine($"Is there a Backend programmer? {task8Result}");

            Console.WriteLine("\nTask 9:");
            var task9Result = LinqTasks.Task9();
            Console.WriteLine($"{task9Result.Ename} - {task9Result.Job} - {task9Result.HireDate}");

            Console.WriteLine("\nTask 10:");
            var task10Result = LinqTasks.Task10();
            foreach (var item in task10Result)
            {
                Console.WriteLine($"Ename: {item.GetType().GetProperty("Ename").GetValue(item)}, Job: {item.GetType().GetProperty("Job").GetValue(item)}, HireDate: {item.GetType().GetProperty("HireDate").GetValue(item)}");
            }

            Console.WriteLine("\nTask 11:");
            var task11Result = LinqTasks.Task11();
            foreach (var item in task11Result)
            {
                Console.WriteLine($"name: {item.GetType().GetProperty("name").GetValue(item)}, numOfEmployees: {item.GetType().GetProperty("numOfEmployees").GetValue(item)}");
            }

            Console.WriteLine("\nTask 12:");
            var task12Result = LinqTasks.Task12();
            foreach (var emp in task12Result)
            {
                Console.WriteLine($"{emp.Ename} - {emp.Salary}");
            }

            Console.WriteLine("\nTask 13:");
            int[] arr = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            var task13Result = LinqTasks.Task13(arr);
            Console.WriteLine($"Number appearing odd number of times: {task13Result}");

            Console.WriteLine("\nTask 14:");
            var task14Result = LinqTasks.Task14();
            foreach (var dept in task14Result)
            {
                Console.WriteLine($"{dept.Dname}");
            }

            Console.WriteLine("\nTask 15:");
            var task15Result = LinqTasks.Task15();
            foreach (var item in task15Result)
            {
                Console.WriteLine($"Praca: {item.GetType().GetProperty("Praca").GetValue(item)}, LiczbaPracownikow: {item.GetType().GetProperty("LiczbaPracownikow").GetValue(item)}");
            }

            Console.WriteLine("\nTask 16:");
            var task16Result = LinqTasks.Task16();
            foreach (var item in task16Result)
            {
                Console.WriteLine($"Emp: {item.GetType().GetProperty("Emp").GetValue(item).GetType().GetProperty("Ename").GetValue(item.GetType().GetProperty("Emp").GetValue(item))}, Dept: {item.GetType().GetProperty("Dept").GetValue(item).GetType().GetProperty("Dname").GetValue(item.GetType().GetProperty("Dept").GetValue(item))}");
            }
        }
    }
}
