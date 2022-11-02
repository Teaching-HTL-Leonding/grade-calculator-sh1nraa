Console.Clear();

//Grade Calculator

int firstTest = 0;
int secondTest = 0;
int oralExamPoints = 0;
int possiblePoints = 40;
double procentResult = 0;
int grade = 0;
int possibleHomeworkPoints = 20;

Console.Write("Did you take part in the first test(Yes/No)? ");
string decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    firstTest = Convert.ToInt32(Console.ReadLine()!);
}
else { possiblePoints -= 20; }

Console.WriteLine();

Console.Write("Did you take part in the second test(Yes/No)? ");
decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    secondTest = Convert.ToInt32(Console.ReadLine()!);
}
else { possiblePoints -= 20; }

Console.WriteLine();

Console.Write("How many points did you get from your homework(0-20)? ");
int homeworkPoints = Convert.ToInt32(Console.ReadLine()!);

if (homeworkPoints > 0)
{
    possiblePoints += 20;
}

Console.WriteLine();

Console.Write("Did you do the oral exam(Yes/No)? ");
decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    oralExamPoints = Convert.ToInt32(Console.ReadLine()!);
    possiblePoints += 20;
}
else { possiblePoints -= 20; }


procentResult = 100d * (firstTest + secondTest + homeworkPoints + oralExamPoints) / possiblePoints;

double procentResultTwo = 0;
int gradeTwo = 0;

if (homeworkPoints < 20)
{
    procentResultTwo = 100d * (firstTest + secondTest + possibleHomeworkPoints + oralExamPoints) / possiblePoints;

    if (procentResultTwo >= 89) { gradeTwo = 1; }
    else if (procentResultTwo >= 76 && procentResultTwo < 89) { gradeTwo = 2; }
    else if (procentResultTwo >= 63 && procentResultTwo < 76) { gradeTwo = 3; }
    else if (procentResultTwo >= 50 && procentResultTwo < 63) { gradeTwo = 4; }
    else if (procentResultTwo < 50) { gradeTwo = 5; }
}

if (procentResult >= 89) { grade = 1; }
else if (procentResult >= 76 && procentResult < 89) { grade = 2; }
else if (procentResult >= 63 && procentResult < 76) { grade = 3; }
else if (procentResult >= 50 && procentResult < 63) { grade = 4; }
else if (procentResult < 50) { grade = 5; }

Console.WriteLine();

Console.WriteLine("Your Grade: " + grade);

if (gradeTwo < grade)
{
    Console.WriteLine($"You could have gotten a {gradeTwo} if you had achieved all the points in the homework.");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();