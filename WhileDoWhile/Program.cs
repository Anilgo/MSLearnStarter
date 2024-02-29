Random random = new Random();

int numberToGuess = 0;

do {
    numberToGuess = random.Next(10);
    Console.WriteLine(numberToGuess);
}
while (numberToGuess != 7);