Random random = new Random();

// int numberToGuess = 0;

// do {
//     numberToGuess = random.Next(10);
//     Console.WriteLine(numberToGuess);
// }
// while (numberToGuess != 7);

int conditionNumber = random.Next(15);

while (conditionNumber >= 4)
{
    Console.WriteLine(conditionNumber);
    conditionNumber = random.Next(15);

}