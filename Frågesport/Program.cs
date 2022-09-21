 int summa = 0;


Console.WriteLine("Hello, welcome to my quiz! To start the game enter your name! (Answer by only using a, b or c)");
string name = Console.ReadLine();

Console.WriteLine($"Hi {name} the first question is what is 6 x 6? a= 30 b= 35 c= 36 ");
string answer1 = Console.ReadLine();



if (answer1 == "c") {
    summa++;
    Console.WriteLine("Correct answer!");
}   

else {
    Console.WriteLine("Wrong answer unfortunately! ");
}

Console.WriteLine("Onto the next question: Which animal is the fastest out of these three; a= lion b= giraffe  c= zebra ? ");
string answer2 = Console.ReadLine();


if (answer2 == "a") {
    summa++;
    Console.WriteLine("Correct answer!");
}

else {
    Console.WriteLine("Wrong answer!");
}

Console.WriteLine("Last question: Who is the president in USA currently?; a= Barack Obama b= Joe Biden c= Donald Trump");
string answer3 = Console.ReadLine();

if (answer3 == "b") {
    summa++;
    Console.WriteLine("Correct answer!") ;
}

else {
    Console.WriteLine ("Wrong answer!");
}


Console.WriteLine($"You have {summa} points");

if (summa == 0) {
    Console.WriteLine("You suck damn not even 1 right?");
}

else if (summa < 3) {
    Console.WriteLine("Okay you have some knowledge");
}

else  {
    Console.WriteLine("3 for 3 thats very good");
}


Console.WriteLine("Press enter to end the game");

Console.ReadLine();
