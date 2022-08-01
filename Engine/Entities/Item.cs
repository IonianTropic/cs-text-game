namespace Engine;
public class Item {
    public string itemName;
    public ItemType itemType;
    public Item(string nick) {
        itemName = nick;
    }
}

public enum ItemType {
    Weapon,
    Key,
    Potion,
    Armor,
}
