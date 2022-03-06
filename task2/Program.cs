// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int i = Prompt("Введите i => ");

if (i == 1) Console.WriteLine("Диапозон значений X и Y больше 0 до бесконечности");
else if (i == 2) Console.WriteLine("Диапозон значений X - меньше 0 и до бесконечности и Y больше 0 до бесконечности");
else if (i == 3)
Console.WriteLine("Диапозон значений X - меньше 0 и до бесконечности и Y меньше 0 до бесконечности");
else if (i == 4) Console.WriteLine("Диапозон значений X - больше 0 и до бесконечности и Y меньше 0 до бесконечности");
else Console.WriteLine("Всего 4 четверти");
