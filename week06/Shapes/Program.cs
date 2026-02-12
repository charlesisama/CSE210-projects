using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        SquareShape sqr = new SquareShape("Blue", 4.0);
        string sqrColor = sqr.GetColor();
        double sqrArea = sqr.GetArea();

        Console.WriteLine($"the color of the paper is : {sqrColor} Area: {sqrArea}");
        Console.WriteLine("");

        RectangleShape rct = new RectangleShape("Yellow", 5.0, 3.5);
        string rctColor = rct.GetColor();
        double rctArea = rct.GetArea();

        Console.WriteLine($"the color of the paper is : {rctColor} Area: {rctArea}");
        Console.WriteLine("");

        CircleShape cir = new CircleShape("Green", 2.5);
        string cirColor = cir.GetColor();
        double cirArea = cir.GetArea();

        Console.WriteLine($"the color of the paper is : {cirColor} Area: {cirArea}");
        Console.WriteLine("");
        Console.WriteLine("==========================================");


        List<Shapes> shapeLists = new List<Shapes>();
        shapeLists.Add(sqr);
        shapeLists.Add(rct);
        shapeLists.Add(cir);

        foreach (Shapes shps in shapeLists)
        {
            Console.WriteLine($"The color of the paper is : {shps.GetColor()} Area: {shps.GetArea()}"); 
        }

        Console.WriteLine("==========================================");



    }
}