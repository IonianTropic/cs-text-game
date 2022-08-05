namespace Engine;

/// <summary>
/// Item class
/// </summary>
public class Item {
    public Action Use { get; } 
    public string Name { get; }
    public Item(string name, Action useFunc) {
        Name = name;
        Use = useFunc;
    }
}

