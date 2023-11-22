string studentName = "Sophia Johnson\n";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychollgy 101";



int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;


int course1Hours = 3;
int course2Hours = 3;
int course3Hours = 4;
int course4Hours = 4;
int course5Hours = 3;

Console.WriteLine("\nStudent: " + studentName);

Console.WriteLine("Course\t\t\tGrade\t\tCredit Hours");
Console.WriteLine(course1Name + $"\t\t{course1Grade}\t\t{course1Hours}");
Console.WriteLine(course2Name + $"\t\t{course2Grade}\t\t{course2Hours}");
Console.WriteLine(course3Name + $"\t\t{course3Grade}\t\t{course3Hours}");
Console.WriteLine(course4Name + $"\t{course4Grade}\t\t{course4Hours}");
Console.WriteLine(course5Name + $"\t\t{course5Grade}\t\t{course5Hours}\n");

double GPA1Multi = course1Grade * course1Hours;
double GPA2Multi = course2Grade * course2Hours;
double GPA3Multi = course3Grade * course3Hours;
double GPA4Multi = course4Grade * course4Hours;
double GPA5Multi = course5Grade * course5Hours;

double GPASum = GPA1Multi + GPA2Multi + GPA3Multi + GPA4Multi + GPA5Multi;
double hourSum = course1Hours + course2Hours + course3Hours + course4Hours + course5Hours;

double finalGPA = GPASum / hourSum;

Console.WriteLine($"Final GPA: \t\t{finalGPA}");