//WhileLoop korral ei tea täpset numbrit mitu korda peab loop ringi käia
//kestab nii kaua kui tingimus saab täidetud

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4); //viimane väärtus, mida saab genereerida on 3
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        // loopActive = false;
        break;
    } else
    {
        Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a nice day!");
//Int32.Parse sest sisestatud info loetakse alati string formaadis ja seda peab eraldi arvuks parssima