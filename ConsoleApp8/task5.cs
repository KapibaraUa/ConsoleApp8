using System;

namespace Module3Part1Homework;

public class Journal
{
    private string _name = String.Empty;
    private ushort _foundationYear;
    private string _description = String.Empty;
    private string _contactPhone = String.Empty;
    private string _email = String.Empty;

    public Journal()
    {
    }

    public Journal(string name, ushort foundationYear, string description, string contactPhone, string email)
    {
        SetName(name);
        SetFoundationYear(foundationYear);
        SetDescription(description);
        SetContactPhone(contactPhone);
        SetEmail(email);
    }

    public void SetName(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название журнала не может быть пустым.");
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetFoundationYear(ushort year)
    {
        if (year < 1600 || year > DateTime.Now.Year)
            throw new ArgumentException("Некорректный год основания журнала.");
        _foundationYear = year;
    }

    public ushort GetFoundationYear()
    {
        return _foundationYear;
    }

    public void SetDescription(string description)
    {
        _description = description ?? String.Empty;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetContactPhone(string phone)
    {
        if (String.IsNullOrWhiteSpace(phone))
            throw new ArgumentException("Контактный телефон не может быть пустым.");
        _contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return _contactPhone;
    }

    public void SetEmail(string email)
    {
        if (String.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException("Некорректный email.");
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public void InputData()
    {
        Console.WriteLine("=== Ввод данных о журнале ===");
        Console.Write("Введите название журнала: ");
        SetName(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите год основания: ");
        if (!UInt16.TryParse(Console.ReadLine(), out ushort year))
            throw new ArgumentException("Год основания должен быть целым положительным числом.");
        SetFoundationYear(year);

        Console.Write("Введите описание журнала: ");
        SetDescription(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите контактный телефон: ");
        SetContactPhone(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите email: ");
        SetEmail(Console.ReadLine() ?? String.Empty);
    }

    public void ShowData()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Журнал: {_name}\nГод основания: {_foundationYear}\nОписание: {_description}\nТелефон: {_contactPhone}\nEmail: {_email}";
    }
}