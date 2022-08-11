namespace Engine;

#warning Create documentation
#warning Clean up comments

/// <summary>
/// Item class
/// </summary>
public class Item {
    private string _name;
    private Action<string> _use;
    public string Name {
        get {
            return _name;
        } 
    }
    public Action<string> Use { 
        get {
            return _use;
        }
    }
    public Item(string name, Action<string> useFunc) {
        _name = name;
        _use = useFunc;
    }
}

// Example Item -- Life Ender
// lifeEnder = new Item("Life Ender", GameAction.fuckshitup);