namespace Leccion01Partial;

partial class Inventory {
    public void PrintAll() {
        foreach(string item in items) {
            Console.WriteLine(item);
        }
    }
}