// Random random = new Random();

// int numberToGuess = 0;

// do {
//     numberToGuess = random.Next(10);
//     Console.WriteLine(numberToGuess);
// }
// while (numberToGuess != 7);

// int conditionNumber = random.Next(15);

// while (conditionNumber >= 4)
// {
//     Console.WriteLine(conditionNumber);
//     conditionNumber = random.Next(15);

// }


// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);


int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;
Random random = new Random();

do
{   
    damage = random.Next(10);
    monsterHealth = monsterHealth - damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

    if (monsterHealth <=1) continue;
    
    damage = random.Next(10);
    heroHealth = heroHealth - damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");

    if (heroHealth <= 1) continue;
    
    

} while (heroHealth >= 1 && monsterHealth >= 1);

Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!");
