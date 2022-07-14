//Console.WriteLine("Howdy Y'all!!");
//Console.ReadLine();


//string sentence;

//    Console.WriteLine("Hello, what's your name?");

//    sentence = Console.ReadLine();

//    Console.WriteLine($"Hi nice to meet you {sentence}");


//var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

    //foreach (var animal in animals)
    //{
    //    Console.WriteLine(animal);
    //}

//string question;

//    Random random = new Random();

//    int index = random.Next(animals.Length);

//    Console.WriteLine($"Hey {sentence}, what's your favorite color?");

//    question = Console.ReadLine();

//    Console.WriteLine($"Would you like a {question} {animals[index]}?");

//foreach (var animal in animals) 
//    { 
//        if (animal.Length >= 7)
//        {
//        Console.WriteLine(animal);
//        }
//    }



string[] greetings = { "Southern", "Chicago", "New York" };

Console.WriteLine($"Hi, please pick a regional greeting:");

foreach (string greeting in greetings)
    { 
        Console.WriteLine(greeting);
    }

string choice;

choice = Console.ReadLine();    

if (choice == "1")
    {
    Console.WriteLine($"You chose {greetings[0]}");    
    }
else if (choice == "2")
    {
    Console.WriteLine($"You chose {greetings[1]}");
    }
else if (choice == "3") 
    { 
    Console.WriteLine($"You chose {greetings[2]}");
    }
else 
{ Console.WriteLine("That is not a valid choice."); }

Console.ReadLine();
