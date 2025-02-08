using System;


class User
{
    public int id = new Random().Next(1, 1000);
    public string name;
    public string lastName;
    public string email;
    public string password;
    public int age;

    public User(string name, string lastName, string email, string password, int age)
    {
        this.name = name;
        this.lastName = lastName;
        this.email = email;
        this.password = password;
        this.age = age;
    }

    public static void printUser(User user)
    {
        Console.WriteLine("User ID: " + user.id);
        Console.WriteLine("Name: " + user.name);
        Console.WriteLine("Last Name: " + user.lastName);
        Console.WriteLine("Email: " + user.email);
        Console.WriteLine("Password: " + user.password);
        Console.WriteLine("Age: " + user.age);
    }
}