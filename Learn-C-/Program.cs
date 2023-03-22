// string in c#

string name = "Muhammad Khuzain";
String fullName = "Muhammad Khuzain";

Console.WriteLine("Name = " + name);

// Concat Method
Console.WriteLine("Concat = " + String.Concat(name, fullName));

// ToUpper Method
Console.WriteLine("string.ToUpper() = " + name.ToUpper());

// ToLower Method
Console.WriteLine("string.ToLower() = " + name.ToLower());

// Replace Method
Console.WriteLine("string.Replace(' ', '-') = " + fullName.Replace(" ", "_"));

// Insert Method
Console.WriteLine("string.Insert(0, 'Mr. ') = "  + fullName.Insert(0, "Mr. "));

// Length Method
Console.WriteLine("string.Length = " + fullName.Length);

// Substring Method
Console.WriteLine("string.Substring(start, end) ex. (0,5) = " + name.Substring(0, 5));

/* Difference between String and string
 * overall string and String is same,
 * but string often use for declaring a variable, and
 * String is a Class to use full veatured
 */