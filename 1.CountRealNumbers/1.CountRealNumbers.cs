using System.Net.NetworkInformation;

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

SortedDictionary<int, int> numbersFriqency = new();

foreach (int number in numbers)
{
    if (numbersFriqency.ContainsKey(number))
    {
        numbersFriqency[number] += 1;
    }
    else
    {
        numbersFriqency.Add(number, 1);
    }
}
foreach (KeyValuePair<int, int> pair in numbersFriqency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}