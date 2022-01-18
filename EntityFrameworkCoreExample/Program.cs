using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Joe Ortiz",
    EmailAddress = "Joe.Ortiz@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new()
{
    FullName = "Jim Halpert",
    EmailAddress = "Jim.Halpert@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In Actuality: Execute any pending insert/update/delete)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
// allStudents = (from stu in dbContext.Students
//              select stu).ToList(); // Query syntax
foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}