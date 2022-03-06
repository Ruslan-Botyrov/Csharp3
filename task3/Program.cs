// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    double answer = double.Parse(strInput);
    return answer;
}

double x1 = Prompt("Введите x1 => ");
double y1 = Prompt("Введите y1 => ");
double x2 = Prompt("Введите x2 => ");
double y2 = Prompt("Введите y2 => ");

double xq = (x1-x2)*(x1-x2);
double yq = (y1-y2)*(y1-y2);

double zq = Math.Sqrt(xq+yq);

Console.WriteLine(zq);
