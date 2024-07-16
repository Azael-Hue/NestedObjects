using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "JohnDoe@gmail.com",
    FullName = "John Doe",
    OfficeLocation = "Westerfield 210"
};

Student stu1 = new Student()
{
    FirstName = "Jane",
    LastName = "Doe",
    DateOfBirth = new DateOnly(1999, 6, 15),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "555-555-5555",
    SchoolEmail = "studentMailTest@school.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");