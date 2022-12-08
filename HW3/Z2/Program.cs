// Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// Формула для расчета приложена в файле FORMULA.md


int x1 = Сoordinate("Введите координату X: ");
int y1 = Сoordinate("Введите координату Y: ");
int z1 = Сoordinate("Введите координату Z: ");
int x2 = Сoordinate("Введите координату X: ");
int y2 = Сoordinate("Введите координату Y: ");
int z2 = Сoordinate("Введите координату Z: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

/*Sqrt(double value): возвращает квадратный корень числа value
например double result = Math.Sqrt(16); -> 4 */

int Сoordinate(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double length = Math.Sqrt(Math.Pow(A, 2)+ Math.Pow(B, 2) + Math.Pow(C, 2));
Console.WriteLine($"Длинна {length}");

