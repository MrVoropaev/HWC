// Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// Формула для расчета приложена в файле FORMULA.md


int Сoordinate(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна {length}");



