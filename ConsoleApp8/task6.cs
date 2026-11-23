using System;

namespace Module3Part1Homework;

public class Shop
{
    private string _name = String.Empty;
    private string _address = String.Empty;
    private string _profileDescription = String.Empty;
    private string _contactPhone = String.Empty;
    private string _email = String.Empty;

    public Shop()
    {
    }

    public Shop(string name, string address, string profileDescription, string contactPhone, string email)
    {
        SetName(name);
        SetAddress(address);
        SetProfileDescription(profileDescription);
        SetContactPhone(contactPhone);
        SetEmail(email);
    }

    public void SetName(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название магазина не может быть пустым.");
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(string address)
    {
        if (String.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Адрес магазина не может быть пустым.");
        _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetProfileDescription(string profileDescription)
    {
        _profileDescription = profileDescription ?? String.Empty;
    }

    public string GetProfileDescription()
    {
        return _profileDescription;
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
        Console.WriteLine("=== Ввод данных о магазине ===");
        Console.Write("Введите название магазина: ");
        SetName(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите адрес магазина: ");
        SetAddress(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите описание профиля магазина: ");
        SetProfileDescription(Console.ReadLine() ?? String.Empty);

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
        return $"Магазин: {_name}\nАдрес: {_address}\nПрофиль: {_profileDescription}\nТелефон: {_contactPhone}\nEmail: {_email}";
    }
}