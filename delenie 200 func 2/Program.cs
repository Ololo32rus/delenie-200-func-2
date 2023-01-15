// напечатать мин число >200 кратное 17 

//int a;
//int b;
/*
int A()
{ 
Console.WriteLine($"Введите минимальное число от 200, которое кратно 17");
int a = int.Parse(Console.ReadLine( ));
    return a;
}
int C = A();
void B(int C)
{ 
while (C < 200)
{
    Console.WriteLine($"Введите минимальное число ОТ 200, кратное 17");
    C = int.Parse(Console.ReadLine());
} 
while (C > 199)
{
    
    Console.WriteLine($"Это число не кратно 17, попробуйте снвоа");
    C = int.Parse(Console.ReadLine());
    int b = C / 17;
    if (b == 12)
    {
        Console.WriteLine($" Минимальное число от 200 кратное 17 = {C} ");
    }

}
}
*/
/*
int a;
int b;
int A()
{
    Console.WriteLine($"Введите минимальное число от 200, которое кратно 17");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int C = A();

static int B(int C)
{
    while (C < 200)
    {
        Console.WriteLine($"Введите минимальное число ОТ 200, кратное 17");
        C = int.Parse(Console.ReadLine());
    }
    while (C > 199)
    {
        int b = C / 17;
        if (b == 12)
        {
            Console.WriteLine($" Минимальное число от 200 кратное 17 = {C} ");
        }
        break;
        Console.WriteLine($"Это число не кратно 17, попробуйте снвоа");
        C = int.Parse(Console.ReadLine());
    }
    return C;
}
Console.WriteLine(B(C));
*/

int a;
int b;
int A()
{
    Console.WriteLine($"Введите минимальное число от 200, которое кратно 17");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int C = A();

static int B(int C)
{
    bool c = true;
    while (C < 200)
    {
        Console.WriteLine($"Введите минимальное число ОТ 200, кратное 17");
        C = int.Parse(Console.ReadLine());
    }
    while (c)
    {

        double b = C / 17;
        if (b == 12)
        {
            Console.WriteLine($" Минимальное число от 200 кратное 17 = {C} ");
            c = false;
        }
        else
        {
            Console.WriteLine($"Это число не кратно 17, попробуйте снвоа");
            C = int.Parse(Console.ReadLine());
        }

    }
    return C;
}
Console.WriteLine(B(C));
