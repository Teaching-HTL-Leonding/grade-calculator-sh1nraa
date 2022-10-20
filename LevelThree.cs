Console.Clear();

//Grade Calculator
int firstTest = 0;
int secondTest = 0;
int oralExamPoints = 0;
int possiblePoints = 40;
double procentResult = 0;
int grade = 0;

Console.Write("Did you take part in the first test(Yes/No)? ");
string decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    firstTest = Convert.ToInt32(Console.ReadLine()!);
}
else{possiblePoints -=20;}

Console.Write("Did you take part in the second test(Yes/No)? ");
decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    secondTest = Convert.ToInt32(Console.ReadLine()!);
}
else{possiblePoints-=20;}

Console.Write("How many points did you get from your homework(0-20)? ");
int homeworkPoints = Convert.ToInt32(Console.ReadLine()!);

if(homeworkPoints> 0)
{
    possiblePoints+=20;
}

Console.Write("Did you do the oral exam(Yes/No)? ");
decision = Console.ReadLine()!;

if (decision == "Yes" || decision == "yes")
{
    Console.Write("How many points did you score(0-20)? ");
    oralExamPoints = Convert.ToInt32(Console.ReadLine()!);
    possiblePoints+=20;
}
else{possiblePoints-=20;}


procentResult= 100d*(firstTest+secondTest+homeworkPoints+oralExamPoints)/possiblePoints;

if (procentResult >= 89) { grade = 1; }
else if (procentResult >= 76 && procentResult < 89) { grade = 2; }
else if (procentResult >= 63 && procentResult < 76) { grade = 3; }
else if (procentResult >= 50 && procentResult < 63) { grade = 4; }
else if (procentResult < 50) {grade = 5;}

Console.WriteLine("Your Grade: "+ grade);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();