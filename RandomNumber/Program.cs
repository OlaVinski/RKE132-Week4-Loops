
Random rnd = new Random();
//Random sisseehitatud klass oskab süsteemist numbri kätte saada

//int myRandomNum = rnd.Next(0, 11); //see tähendab, et väärtusi genereeritakse 0 -10
//viimane väärtus peab olema 1 võrra suurem

//Console.WriteLine($"My random number is: {myRandomNum}");

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 10; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");