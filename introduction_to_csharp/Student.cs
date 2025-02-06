using System;


class Student
{
    private static string first_name = "Ibrohimjon";
    private static string last_name = "Toshtemirov";
    private static int age = 18;
    private static bool is_student = true;
    private static string university = "MU";
    private static string department = "IT";
    private static string group = "IT-102";

    // I hope so
    private static double score = 99.9;
    private static char grade = 'S';

    public static void get_data()
    {
        Console.WriteLine("");
        Console.WriteLine(first_name + " " + last_name + " is " + age + " years old.");

        if (is_student)
        {
            Console.WriteLine("He is a student at " + university + " University.");
            Console.WriteLine("He is studying at " + department + " department in " + group + " group.");

            Console.WriteLine("");
            Console.WriteLine("Detailed: ");
            
            Console.WriteLine("First Name: " + first_name);
            Console.WriteLine("Last Name: " + last_name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Student: " + is_student);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Grade: " + grade);
        }
        else
        {
            Console.WriteLine("He is not a student.");
        }
        Console.WriteLine("");
    }
}