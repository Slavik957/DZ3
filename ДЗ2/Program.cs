// Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double GetDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1) , 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));
    return distance;
}
//-------------------------------

int x1 = Prompt("Пожалуйста введите x1: ");
int y1 = Prompt("Пожалуйста введите y1: ");
int z1 = Prompt("Пожалуйста введите z1: ");
int x2 = Prompt("Пожалуйста введите x2: ");
int y2 = Prompt("Пожалуйста введите y2: ");
int z2 = Prompt("Пожалуйста введите z2: ");

Console.Write($"Растояние между точками = {GetDistance(x1,y1,x2,y2,z1,z2)}");