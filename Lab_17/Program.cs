namespace Lab_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter task (1 - 3): ");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.Write("Enter size of array: ");
                        int size = int.Parse(Console.ReadLine());
                        int[] arr = new int[size];
                        Random r = new Random();
                        for(int i = 0; i < size; i++)
                        {
                            arr[i] = r.Next(0, 100);
                        }

                        Console.WriteLine("All array: ");
                        var allNumbers = arr.ToArray();
                        Console.WriteLine(string.Join(", ", allNumbers));

                        Console.WriteLine("Even numbers array: ");
                        var evenNumbers = arr.Where(num => num % 2 == 0).ToArray();
                        Console.WriteLine(string.Join(", ", evenNumbers));

                        Console.WriteLine("Odd numbers array: ");
                        var oddNumbers = arr.Where(num => num % 2 != 0).ToArray();
                        Console.WriteLine(string.Join(", ", oddNumbers));

                        Console.Write("Enter number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Numbers greater than your number: ");
                        var numbersGreater = arr.Where(num => num > number).ToArray();
                        Console.WriteLine(string.Join(", ", numbersGreater));

                        Console.Write("Enter min value: ");
                        int min = int.Parse(Console.ReadLine());
                        Console.Write("Enter max value: ");
                        int max = int.Parse(Console.ReadLine());
                        Console.WriteLine("Numbers in your range: ");
                        var numbersInRange = arr.Where(num => num >= min && num <= max).ToArray();
                        Console.WriteLine(string.Join(", ", numbersInRange));

                        Console.WriteLine("Numbers multiples of 7 and sort: ");
                        var multiplySeven = arr.Where(num => num % 7 == 0).OrderBy(num => num).ToArray();
                        Console.WriteLine(string.Join(", ", multiplySeven));

                        Console.WriteLine("Numbers multiples of 8 and sort: ");
                        var multiplyEight = arr.Where(num => num % 8 == 0).OrderByDescending(num => num).ToArray();
                        Console.WriteLine(string.Join(", ", multiplyEight));
                        break;
                    case 2:
                        string[] cities = { "Kyiv", "Lviv", "Ankara", "Amsterdam", "New York", "Neapol" };
                        
                        Console.WriteLine("All name of cities: ");
                        var print = cities.ToArray();
                        Console.WriteLine(string.Join(", ", print));

                        Console.Write("Enter length of city: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cities with current length: ");
                        var citiesLength = cities.Where(city => city.Length == length).ToArray();
                        Console.WriteLine(string.Join(", ", citiesLength));

                        Console.WriteLine("Cities which starts on A: ");
                        var startA = cities.Where(city => city.StartsWith("A")).ToArray();
                        Console.WriteLine(string.Join(", ", startA));

                        Console.WriteLine("Cities which ends on M: ");
                        var endM = cities.Where(city => city.EndsWith("m")).ToArray();
                        Console.WriteLine(string.Join(", ", endM));

                        Console.WriteLine("Cities which starts on N and ends on K: ");
                        var NM = cities.Where(city => city.StartsWith("N") && city.EndsWith("k")).ToArray();
                        Console.WriteLine(string.Join(", ", NM));

                        Console.WriteLine("Cities which starts on Ne: ");
                        var startNe = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city).ToArray();
                        Console.WriteLine(string.Join(", ", startNe));
                        break;
                    case 3:
                        Student[] students = new Student[]
                        {
                            new Student { FirstName = "Boris", LastName = "Johnson", Age = 21, School = "Oxford" },
                            new Student { FirstName = "Alex", LastName = "Brovar", Age = 19, School = "MIT" },
                            new Student { FirstName = "Rick", LastName = "Brown", Age = 22, School = "Harvard" },
                        };

                        Console.WriteLine("Information about students:");
                        foreach (var student in students)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var boris = students.Where(student => student.FirstName == "Boris").ToList();
                        Console.WriteLine("Students with the first name Boris:");
                        foreach (var student in boris)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var bro = students.Where(student => student.LastName.StartsWith("Bro")).ToList();
                        Console.WriteLine("Students with last name starting with Bro:");
                        foreach (var student in bro)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var older19 = students.Where(student => student.Age > 19).ToList();
                        Console.WriteLine("Students older than 19:");
                        foreach (var student in older19)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var between20and23 = students.Where(student => student.Age > 20 && student.Age < 23).ToList();
                        Console.WriteLine("Students between 20 and 23 years old:");
                        foreach (var student in between20and23)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var studentMIT = students.Where(student => student.School == "MIT").ToList();
                        Console.WriteLine("Students in MIT:");
                        foreach (var student in studentMIT)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }

                        var studentsOxfordOlder18 = students.Where(student => student.School == "Oxford" && student.Age > 18).OrderByDescending(student => student.Age).ToList();
                        Console.WriteLine("Sorted students in Oxford older than 18:");
                        foreach (var student in studentsOxfordOlder18)
                        {
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                            Console.WriteLine($"Age: {student.Age}");
                            Console.WriteLine($"School: {student.School}");
                            Console.WriteLine();
                        }
                        break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
    }
}