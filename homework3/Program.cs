// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int N = Prompt("Введите N => ");
int q = 1;
int sq = q * q * q;

Console.WriteLine($"Куб числа {q} равен {sq}");

while (q < N) 
{
    q = q + 1;
    sq = q * q * q; 
        Console.WriteLine($"Куб числа {q} равен {sq}");
}
