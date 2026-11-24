namespace Lesson02;

#if DEBUG
partial class Inventory {
    public void PrintAll() {
        foreach(string item in items) {
            Console.WriteLine("[DEBUG] " + item);
        }
    }
}
#endif