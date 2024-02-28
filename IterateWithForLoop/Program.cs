
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

string[] names = { "Alex", "Eddie", "David", "Michael" };

int x = 15;
Console.WriteLine(x);
for (x = 0; x < names.Length; x++)
{
    Console.WriteLine(x);
    if (names[x] == "David")
    {
        names[x] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

