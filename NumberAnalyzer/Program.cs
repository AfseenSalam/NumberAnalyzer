// See https://aka.ms/new-console-template for more information
int userInput;
bool isValid = true;
Console.WriteLine("Welcome to NUMBER ANALYZER - Decision Maker app!!");
Console.WriteLine("Enter the name:");
string? name = Console.ReadLine();
while (isValid)
{
    while (isValid)
    {
        Console.WriteLine($"{name} enter an integer ranges from 1 to 100 :");
        userInput = int.Parse(Console.ReadLine());
        if (userInput >= 1 && userInput <= 100)
        {
            isValid = false;
            int modValue = userInput % 2;
            if (modValue == 0)
            {
                if (userInput < 25)
                {
                    Console.WriteLine($"{userInput} is Even and less than 25.");
                }
                else if (userInput > 60)
                {
                    Console.WriteLine($"{userInput} is Even and greater than 60.");
                }
                else if (userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine($"{userInput} is Even and between 26 and 60 inclusive.");
                }
            }
            else
            {
                if (userInput < 60)
                {
                    Console.WriteLine($"{userInput} is Odd and less than 60.");
                }
                else if (userInput > 60)
                {
                    Console.WriteLine($"{userInput} is Odd and less than 60.");
                }
            }
        }

        else
        {
            Console.WriteLine($"{name} Please Enter the Valid number.");

        }
    }
    Console.WriteLine($"{name} Do you want to continue the program (yes or no):");
    string? userRequest = Console.ReadLine();
    
        if(userRequest == "yes")
        {
        Console.WriteLine("Continue");
        isValid = true; ;
        }else
    {
        Console.WriteLine("Good BYE");
        break;
    }
    
}