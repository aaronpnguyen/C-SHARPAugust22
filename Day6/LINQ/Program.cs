List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// 1
IEnumerable<Eruption> containsChile = eruptions.Where(loc => loc.Location == "Chile");
Console.WriteLine(containsChile.First());

// 2
IEnumerable<Eruption> containsHawaii = eruptions.Where(l => l.Location == "Hawaiian Is").OrderBy(l => l.Year);
if (containsHawaii.Count() > 0) Console.WriteLine(containsHawaii.First());
else Console.WriteLine("No Hawaiian Is Eruption Found");

// 3
IEnumerable<Eruption> afterZealand = eruptions.Where(l => l.Year > 1900 && l.Location == "New Zealand").OrderBy(l => l.Year);
Console.WriteLine(afterZealand.First());

// 4
IEnumerable<Eruption> overMeters = eruptions.Where(l => l.ElevationInMeters > 2000);
PrintEach(overMeters, "Volcanos with an elevation over 2000m");

// 5
IEnumerable<Eruption> zStart = eruptions.Where(l => l.Volcano.StartsWith("Z"));
if (zStart.Count() > 0) PrintEach(zStart);
else Console.WriteLine("The count for volcanos that start with 'z' is: " + zStart.Count());
 
// 6 & 7
IEnumerable<Eruption> highestElevation = eruptions.OrderByDescending(l => l.ElevationInMeters);
Console.WriteLine(highestElevation.First().Volcano);

// 8
IEnumerable<Eruption> alphabetical = eruptions.OrderBy(l => l.Volcano);
PrintEach(alphabetical, "Volcanos in alphabetical order");

// 9
IEnumerable<Eruption> beforeSort = eruptions.Where(l => l.Year < 1000).OrderBy(l => l.Volcano);
PrintEach(beforeSort, "Volcano eruptions before 1000 CE");

// 10
foreach(var volcano in beforeSort)
{
    Console.WriteLine(volcano.Volcano);
}

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}