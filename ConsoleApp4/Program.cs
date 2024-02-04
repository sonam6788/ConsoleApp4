// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
case 4:
    Console.WriteLine("pet status");
    Console.WriteLine("hunger : " + Convert.ToString(hunger));
    Console.WriteLine("health : " + Convert.ToString(health));
    Console.WriteLine("happiness : " + Convert.ToString(happiness));

    if (hunger <= 2 || health <= 2 || happiness <= 2)
    {
        Console.WriteLine("You pet helth is crictical");
    }
    break;
case 5:
    Console.WriteLine("Good bye!");
    return;
default:
    Console.WriteLine("invalid option");
    break;
}
