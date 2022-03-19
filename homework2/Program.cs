// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    double answer = double.Parse(strInput);
    return answer;
}

double x1 = Prompt("Введите x1 => ");
double y1 = Prompt("Введите y1 => ");
double z1 = Prompt("Введите y1 => ");
double x2 = Prompt("Введите x2 => ");
double y2 = Prompt("Введите y2 => ");
double z2 = Prompt("Введите y2 => ");

double xq = (x2-x1)*(x2-x1);
double yq = (y2-y1)*(y2-y1);
double zq = (z2-z1)*(z2-z1);

double iq = Math.Sqrt(xq+yq+zq);

Console.WriteLine(iq);