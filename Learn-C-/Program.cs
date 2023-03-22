// If StateMent

Console.WriteLine("Enter your age : ");

string ageString = Console.ReadLine();

if (ageString !="")
    {
        int age = Convert.ToInt32(ageString);

        if (age > 100)
        {
            Console.WriteLine("You are too old");
        }
        else if (age >= 17)
        {
            Console.WriteLine("You can enter the party");
        }
        else if (age < 0)
        {
            Console.WriteLine("You have not born yet");
        }
        else
        {
            Console.WriteLine("You can not enter the party");
        }

    }

