



/* ax^2+bx+c =0;
 D = b^2 -4ac;
D >0 to x1,x2;
D=0 to x1;
D<0 to nema;
a !=0; */

using System.ComponentModel.Design;
using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; // на всякий випадок

Console.WriteLine("Завдання_1,ПЗ для розв'язання квадратного рівняння\t");
Console.WriteLine("Виконала Літошенко Софія, ІПЗ-21к\t");

int a, b,c;
Console.WriteLine("ax^2 + bx + c = 0");
Console.Write("Enter a: ");

/* Перевірки чи ввели все ок*/

if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Coeff 'a' must be a number");
    return;
}

Console.Write("Enter b: ");
if (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Coeff 'b' must be a number");
    return;
}

Console.Write("Enter c: ");
if (!int.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("Coeff 'c' must be a number");
    return;
}
/*---------------Ще одна робота з числами з умовами додатковими-----------------*/
double x;

 if (a != 0)
{
    int D = (int)Math.Pow(b, 2) - 4 * a * c;

    if (D < 0)
    {
        Console.WriteLine("Не має коренів");
        Console.WriteLine("D<0");
        return;
    }
    else if (D > 0)
    {
        Console.WriteLine("D>0");

        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"x1: {x1:0.0}");


        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"x2: {x2:0.0} ");
        /*Console.WriteLine(x1 + " " + x2);*/
        return;
    }
    else
    {
        Console.WriteLine("Має 1 корінь:");

        double x1 = -b / (2 * a);
        Console.WriteLine($"x1: {x1:0.0}");
        return;
    }


}
else if (b!= 0 && c!= 0)
{
     x = (double)-c / b;
    Console.WriteLine($"x: {x:0.0} ");
}
 else if(c==0)
{
    Console.WriteLine("x належить множині всіх дійсних чисел");
    
}
else
{
    Console.WriteLine("немає розв'язків");
    
}








