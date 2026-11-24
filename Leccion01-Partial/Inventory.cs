namespace Leccion01Partial;

partial class Inventory {
    private List<string> items = new List<string>();

    public void Add(string obj) {
        items.Add(obj);
    }
}