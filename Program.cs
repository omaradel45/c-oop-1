//// question 1
//using System;

//enum WeekDays
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Printing WeekDays Enum
//        Console.WriteLine("Days of the week:");
//        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
//        {
//            Console.WriteLine(day);
//        }

//        Console.WriteLine("\n---- Struct Example ----");
//    }
//}


//----------------------------------------------------------------------------------------------------------------------


////// question 2
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person[] people = new Person[3];

//        // Populate the array with data
//        people[0] = new Person { Name = "Alice", Age = 25 };
//        people[1] = new Person { Name = "Bob", Age = 30 };
//        people[2] = new Person { Name = "Charlie", Age = 22 };

//        Console.WriteLine("Details of all persons:");
//        foreach (var person in people)
//        {
//            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//        }
//    }

//    struct Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }
//}


//----------------------------------------------------------------------------------------------------------------------

//// question 3
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
//        string inputSeason = Console.ReadLine();

//        Season selectedSeason;
//        if (Enum.TryParse(inputSeason, true, out selectedSeason))
//        {
//            switch (selectedSeason)
//            {
//                case Season.Spring:
//                    Console.WriteLine("Spring: March to May");
//                    break;
//                case Season.Summer:
//                    Console.WriteLine("Summer: June to August");
//                    break;
//                case Season.Autumn:
//                    Console.WriteLine("Autumn: September to November");
//                    break;
//                case Season.Winter:
//                    Console.WriteLine("Winter: December to February");
//                    break;
//                default:
//                    Console.WriteLine("Unknown season");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid season name.");
//        }
//    }

//    enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }
//}


//----------------------------------------------------------------------------------------------------------------------

//question 4
//using System;

//[Flags]
//enum Permissions
//{
//    None = 0,
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Permissions userPermissions = Permissions.Read | Permissions.Write;
//        Console.WriteLine($"Initial Permissions: {userPermissions}");

//        userPermissions |= Permissions.Execute;
//        Console.WriteLine($"After Adding Execute: {userPermissions}");

//        userPermissions &= ~Permissions.Write;
//        Console.WriteLine($"After Removing Write: {userPermissions}");

//        Console.WriteLine("Check Permissions:");
//        Console.WriteLine($"Has Read: {(userPermissions.HasFlag(Permissions.Read) ? "Yes" : "No")}");
//        Console.WriteLine($"Has Write: {(userPermissions.HasFlag(Permissions.Write) ? "Yes" : "No")}");
//        Console.WriteLine($"Has Delete: {(userPermissions.HasFlag(Permissions.Delete) ? "Yes" : "No")}");
//        Console.WriteLine($"Has Execute: {(userPermissions.HasFlag(Permissions.Execute) ? "Yes" : "No")}");
//    }
//}

//----------------------------------------------------------------------------------------------------------------------

//// 5. Colors Enum Example
//using System;

//enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a color (Red, Green, Blue):");
//        string inputColor = Console.ReadLine();

//        if (Enum.TryParse(inputColor, true, out Colors selectedColor))
//        {
//            switch (selectedColor)
//            {
//                case Colors.Red:
//                case Colors.Green:
//                case Colors.Blue:
//                    Console.WriteLine("The color is a primary color.");
//                    break;
//                default:
//                    Console.WriteLine("The color is not a primary color.");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid color name.");
//        }
//    }
//}

//----------------------------------------------------------------------------------------------------------------------

//// 6. Point Struct and Distance
//using System.Drawing;
//using System;

//Console.WriteLine("Enter X and Y for Point 1:");
//double x1 = double.Parse(Console.ReadLine());
//double y1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter X and Y for Point 2:");
//double x2 = double.Parse(Console.ReadLine());
//double y2 = double.Parse(Console.ReadLine());

//Point p1 = new Point { X = (int)x1, Y = (int)y1 };
//Point p2 = new Point { X = (int)x2, Y = (int)y2 };
//double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
//Console.WriteLine($"Distance between points: {distance}");

//----------------------------------------------------------------------------------------------------------------------

//// question 7
//using System;

//Person[] persons = new Person[3];
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Enter Name and Age for Person {i + 1}:");
//    string name = Console.ReadLine();
//    int age = int.Parse(Console.ReadLine());
//    persons[i] = new Person { Name = name, Age = age };
//}

//Person oldest = persons[0];
//foreach (var p in persons)
//{
//    if (p.Age > oldest.Age)
//    {
//        oldest = p;
//    }
//}
//Console.WriteLine($"Oldest Person: Name = {oldest.Name}, Age = {oldest.Age}");


//    struct Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//struct Point
//{
//    public double X { get; set; }
//    public double Y { get; set; }
//}

//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//[Flags]
//enum Permissions
//{
//    None = 0,
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//enum Colors
//{
//    Red,
//    Green,
//    Blue
//}