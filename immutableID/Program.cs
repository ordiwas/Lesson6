class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
    public Student(int id)
    {
        Id = id;
    }
    public string Name()
    { return FirstName + " " + LastName; }
    public static void Main()
    {
        Student s = new (12);
        s.FirstName = "bill";
        s.LastName = "ted";
        Console.WriteLine(s.Name());
        Console.WriteLine(s.Id);
        Student s2 = new Student(13, "al", "capone");
        Console.WriteLine(s2.Name());
        Console.WriteLine(s2.Id);
        Console.Read();
    }

    }