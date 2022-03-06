// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int N = Prompt("Введите N => ");
int q = 1;
int sq = q * q;
Console.WriteLine($"Квадрат числа {q} равен {sq}");
while (q < N) 
{
    q = q + 1;
    sq = q * q; 
        Console.WriteLine($"Квадрат числа {q} равен {sq}");
}





