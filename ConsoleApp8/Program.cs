using System;

namespace Module3Part1Homework;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Website site = new Website();
            site.InputData();
            site.ShowData();
            site.SetIpAddress("192.168.1.1");
            Console.WriteLine($"Обновленный IP: {site.GetIpAddress()}\n");

            Journal journal = new Journal();
            journal.InputData();
            journal.ShowData();
            journal.SetContactPhone("+380501234567");
            Console.WriteLine($"Обновленный телефон: {journal.GetContactPhone()}\n");

            Shop shop = new Shop();
            shop.InputData();
            shop.ShowData();
            shop.SetEmail("support@shop.ua");
            Console.WriteLine($"Обновленный email: {shop.GetEmail()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка ввода данных: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}