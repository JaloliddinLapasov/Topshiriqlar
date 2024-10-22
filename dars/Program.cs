string name = null;
int? length = name?.Length; // Safely access Length without risk of null reference exception
Console.WriteLine(length); // Output: (null)
