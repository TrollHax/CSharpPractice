int[] intArray = { 1, 2, 3 };
double[] doubleArray = { 1.0, 2.0, 3.0 };
string[] stringArray = { "1", "2", "3" };

displayElements(intArray);
displayElements(doubleArray);
displayElements(stringArray);

Console.ReadKey();

static void displayElements<Thing>(Thing[] array)
{
    foreach (Thing item in array)
    {
        Console.Write(item);
    }
    Console.WriteLine();
}