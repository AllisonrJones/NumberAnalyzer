Console.WriteLine("Hello. Welcome to the number analyzer. Please enter your name");
string userName = Console.ReadLine();

bool y = true;
string response;
do
{

    Console.WriteLine("Okay " + userName + ", input a number between 1 and 100 to be analyzed");
    int userInput = int.Parse(Console.ReadLine());
    int modResult = userInput % 2;

    if (userInput <= 100 && userInput >= 1)
    {
        if (userInput < 60 && modResult != 0)
        {
            Console.WriteLine(userName + " " + userInput + " is odd and less than 60");

        }
        if (userInput >= 2 && userInput <= 24 && modResult != 1)
        {
            Console.WriteLine(userName + " is Even and less than 25");

        }
        if (userInput >= 26 && userInput <= 60 && modResult != 1)
        {
            Console.WriteLine(userName + " " + userInput + " is even and between 26 and 60 inclusive");
        }

        if (userInput > 60 && modResult != 1)
        {
            Console.WriteLine(userName + " " + userInput + " is Even and greater than 60");

        }
        if (userInput > 60 && modResult != 0)
        {
            Console.WriteLine(userName + " " + userInput + " is odd and greater than 60");
        }

    }
    else
    {
        Console.WriteLine(userName + " That is not a valid number");
      
    }

      Console.WriteLine("Would you like to enter another number? y or n");


        response = Console.ReadLine();

    } while (true);
