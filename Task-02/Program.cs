using UniversitySystem.Models;

List<Person> people = new List<Person>();

people.Add(new Student(
    "Ali",
    21,
    "S123",
    "Computer Science"
));

people.Add(new Professor(
    "Dr. Reza",
    45,
    "P456",
    "Software Engineering"
));

foreach (Person person in people)
{
    Console.WriteLine(person.GetDetails());
}
