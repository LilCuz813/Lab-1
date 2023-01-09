// See https://aka.ms/new-console-template for more information




Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("Enter Length");
double Length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Width");
double Width = double.Parse(Console.ReadLine());

double area = Length * Width;
double perimeter = Length + Width;

Console.WriteLine("Area " + Length * Width);

Console.WriteLine("Perimeter " + Length + Width);

if (area < 250)
{
    Console.WriteLine("The room is small.");


}
else if (area > 250 && area < 650)
{
    Console.WriteLine("The room is medium.");
}
else if (area > 650)
{
    Console.WriteLine("The room is large.");
}

