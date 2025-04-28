using System.Drawing;

var internationalPizzaDay23 = new DateTime(2023, 2, 9);
Console.WriteLine("Year is: " + internationalPizzaDay23.Year);
Console.WriteLine("Month is: " + internationalPizzaDay23.Month);
Console.WriteLine("Day is: " + internationalPizzaDay23.Day);
Console.WriteLine("Day of the week is: " + internationalPizzaDay23.DayOfWeek);
var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculatePerimeter());

Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

class Rectangle
{
    //const fields are implicitly static
    public const int NumberOfSides = 4;

    //a static property, belonging to the class as a whole
    public static int CountOfInstances { get; private set; }

    //a static field
    private static DateTime _firstUsed;

    //a static constructor
    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances;
    }

    //readonly property - can only be set in the constructor
    public int Width { get; }

    //achieving a similar behavior as properties give with using methods
    private int _height;
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    //expression-bodied methods
    //could not be made static as they use the state of an instance (width and height)
    public int CalculatePerimeter() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;

    //a get-only, expression-bodied property
    public string Description => $"A rectangle with width {Width} " +
        $"and height {_height}";

    //a static method, not using any state of an instance
    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";

    //can be made static
    public string NotUsingAnyState() => "abc";
}

