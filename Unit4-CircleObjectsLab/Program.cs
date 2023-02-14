using Unit4_CircleObjectsLab;

bool doAgain = false;
do
{
    Console.WriteLine("Enter the radius of the circle:");
    double radius = double.Parse(Console.ReadLine());

    Circle circle = new Circle(radius);

    Console.WriteLine("Circumference: " + circle.CalculateFormattedCircumference());
    Console.WriteLine("Area: " + circle.CalculateFormattedArea());
    Console.WriteLine("Would you like to go again?");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "y")
    {
        doAgain = true;
    }
    else
    {
        doAgain = false;
    }
} while (doAgain == true);


Console.WriteLine("Goodbye");