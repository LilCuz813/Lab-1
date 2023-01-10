// See https://aka.ms/new-console-template for more information




Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("Enter Length");
double Length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Width");
double Width = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Height");
double Height = double.Parse(Console.ReadLine());

double area = Length * Width;
double perimeter = 2 * (Length + Width);
double volume = Length * Width * Height;
double surfaceArea = 2 * ((Width * Length) + (Height * Length) * (Height * Width));
Console.WriteLine("Area " + area);

Console.WriteLine("Perimeter " + perimeter);

Console.WriteLine("Volume " + volume);

Console.WriteLine("Surface Area " + surfaceArea);

if (area <= 250)
{
    Console.WriteLine("The room is small.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("The room is medium.");
}
else if (area >= 650)
{
    Console.WriteLine("The room is large.");
}

