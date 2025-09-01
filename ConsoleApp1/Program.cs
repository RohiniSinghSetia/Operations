
var rand = new Random();
int score = 0;
int total = 0;

Console.WriteLine("Math Quiz - 2 Digit Numbers");
Console.WriteLine("Type 'x' to quit.\n");
var stopwatch = System.Diagnostics.Stopwatch.StartNew();
while (true)
{
    decimal a = rand.Next(1000, 10000)/100.00m;
    decimal b = rand.Next(1000, 10000)/100.00m;
    int op = rand.Next(1, 10);
    decimal correctAnswer;
    if (op % 2 == 0)
    {
        correctAnswer = a - b;
        Console.Write($"{a} - {b} = ");
    }
    else
    {
        correctAnswer = a + b;
        Console.Write($"{a} + {b} = ");
    }

    string input = Console.ReadLine();

    if (input?.ToLower() == "x")
        break;

    total++;

    if (decimal.TryParse(input, out decimal userAnswer))
    {
        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine($"Wrong. The correct answer was {correctAnswer}\n");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Try again.\n");
    }
}
stopwatch.Stop();
var totalTime = stopwatch.ElapsedMilliseconds/1000;
double averageTime = total == 0 ? (double)0 : (double)totalTime / total;
Console.WriteLine($"\nFinal Score: {score} out of {total} in {totalTime} seconds. On average, you took {averageTime:F1} per question.");
    
