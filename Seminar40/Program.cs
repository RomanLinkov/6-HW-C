Console.Clear();

int a = NumberInput("Введите сторону a: ");
int b = NumberInput("Введите сторону b: ");
int c = NumberInput("Введите сторону c: ");

bool result = true;

Comparison(a, b, c);
Comparison(b, a, c);
Comparison(c, a, b);

if (result) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");


void Comparison(int x1, int x2, int x3)
{
    if (x1>x2+x3) result = false;
}





int NumberInput(string msg)

{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}