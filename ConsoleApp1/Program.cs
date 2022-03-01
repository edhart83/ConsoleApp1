// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int inputMain = 0;
bool programStatus = true;
while (programStatus)
{
    Console.Clear();
    Console.WriteLine("Please select an option below:");
    Console.WriteLine("1) Convert Fahrenheit to Celcius");
    Console.WriteLine("2) Standard Calculator");
    Console.WriteLine("3) Exit");

    try
    {
        inputMain = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You selected option " + inputMain);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid entry. Please choose an option between 1-2 or 3 to terminate the program.");
    }

    switch (inputMain)
    {
        case 1:
            //Formula: °F = °C × (9 / 5) + 32
            Console.WriteLine("Enter a degree in Celsius to convert in Fahrenheit:");
            int inputCelsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fahrenheit value is: " + ((inputCelsius * 9 / 5) + 32));
            Console.WriteLine("-----------------\nPress any key to continue...");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Select an option: \n 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division");
            int inputCalcutor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected option " + inputCalcutor);
            Console.WriteLine("-----------------\nPress any key to continue...");
            Console.ReadKey();
            break;
        case 3:
            programStatus = false;
            break;
        default:
            Console.WriteLine("-----------------\nPress any key to continue...fdafdf");
            Console.ReadKey();
            break;
    }
}
