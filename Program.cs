using StudentGrading;

// Initialize a list of students
List<Student> students =
[
    new Student("Shophia", [90, 86, 87, 98, 100, 94, 90]),
    new Student("Andrew", [92, 89, 81, 96, 90, 89]),
    new Student("Emma", [90, 85, 87, 98, 68, 89, 89, 89]),
    new Student("Logan", [90, 95, 87, 88, 96, 96]),
];

// Show an initial header
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

// To show the informations of each student
foreach(Student student in students)
{
    Console.WriteLine($"{student.getName()}\t\t{student.studentExamScore()}\t\t{student.studentGrade()}\t{student.studentGradeLetter()}\t{student.studentExtraCreditScore()} ({student.extraCredit():0.00} points)");
}