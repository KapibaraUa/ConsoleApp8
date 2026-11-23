using System;

namespace Module3Part1Homework;

public class Website
{
    private string _name = String.Empty;
    private string _url = String.Empty;
    private string _description = String.Empty;
    private string _ipAddress = String.Empty;

    public Website()
    {
    }

    public Website(string name, string url, string description, string ipAddress)
    {
        SetName(name);
        SetUrl(url);
        SetDescription(description);
        SetIpAddress(ipAddress);
    }

    public void SetName(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Название сайта не может быть пустым.");
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetUrl(string url)
    {
        if (String.IsNullOrWhiteSpace(url))
            throw new ArgumentException("Путь к сайту не может быть пустым.");
        _url = url;
    }

    public string GetUrl()
    {
        return _url;
    }

    public void SetDescription(string description)
    {
        _description = description ?? String.Empty;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetIpAddress(string ipAddress)
    {
        if (String.IsNullOrWhiteSpace(ipAddress))
            throw new ArgumentException("IP-адрес не может быть пустым.");
        _ipAddress = ipAddress;
    }

    public string GetIpAddress()
    {
        return _ipAddress;
    }

    public void InputData()
    {
        Console.WriteLine("=== Ввод данных о веб-сайте ===");
        Console.Write("Введите название сайта: ");
        SetName(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите путь к сайту (URL): ");
        SetUrl(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите описание сайта: ");
        SetDescription(Console.ReadLine() ?? String.Empty);

        Console.Write("Введите IP-адрес сайта: ");
        SetIpAddress(Console.ReadLine() ?? String.Empty);
    }

    public void ShowData()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Веб-сайт: {_name}\nURL: {_url}\nОписание: {_description}\nIP-адрес: {_ipAddress}";
    }
}