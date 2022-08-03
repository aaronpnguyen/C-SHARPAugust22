// string[] arr = {"aaron", "jonathan"};

// foreach (string i in arr) {
//     Console.WriteLine(i);
// }

// List<string> bikes = new List<string>();

// string[] bikeArr = {"Kawasaki", "Triumph", "BMW", "Moto Guzzi", "Harley Davidson", "Suzuki"};
// foreach (string bike in bikeArr) {
//     bikes.Add(bike);
// }

// Console.WriteLine(bikes[2]);
// Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

// Console.WriteLine("The current manufacturers we have seen are:");
// for (var idx = 0; idx < bikes.Count; idx++) {
//     Console.WriteLine("-" + bikes[idx]);
// }

// bikes.Insert(2, "Yamaha");
// bikes.Remove("Suzuki");
// bikes.Remove("Yamaha");
// Console.WriteLine(bikes[0]);
// bikes.RemoveAt(0); //RemoveAt has no return value however
// Console.WriteLine(bikes[0]);
// The updated list can then be iterated through using a foreach loop
// Console.WriteLine("List of Non-Japanese Manufacturers:");
// foreach (string manu in bikes) {
//     Console.WriteLine("-" + manu);
// }

Dictionary<string, string> profile = new Dictionary<string, string>();

profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
// Console.WriteLine("Name - " + profile["Name"]);
// Console.WriteLine("From - " + profile["Location"]);
// Console.WriteLine("Favorite Language - " + profile["Language"]);

// foreach (KeyValuePair<string, string> entry in profile) {
//     Console.WriteLine(entry.Key + " - " + entry.Value);
// }

//The var keyword takes the place of a type in type-inference
foreach (var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}