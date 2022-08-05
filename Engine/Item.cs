namespace Engine;

public class Item {
    /*
    public void use() {
        switch (itemType) {
            case ItemType.Knife:
                useKnife();
                break;
            case ItemType.Nail:
                useNail();
                break;
            case ItemType.Key:
                useKey();
                break;
            case ItemType.Potion:
                usePotion();
                break;
            case ItemType.Cap:
                useCap();
                break;
            default:
                throw new InvalidDataException();
        }
    }
    */
    public Action Use { get; }
    public string Name { get; }
    public Item(string name, Action useFunc) {
        Name = name;
        Use = useFunc;
    }
}

public interface IItem {
    public void use();
}

public class Nail : IItem {
    public string itemName;
    public void use() {
        // attack
    }
    public Nail(string name) {
        itemName = name;
    }
}

public class Cap : IItem {
    public void use() {
        // attack
    }
    public Cap() {

    }
}

public enum ItemType {
    Knife,
    Nail,
    Key,
    Potion,
    Cap,
}

// Item lifeEnder = new Item("Life Ender", Nail);
// LifeEnder lifeEnder = new LifeEnder();
// void useNail() {
//         
// }
// Item lifeEnder = new Item("Life Ender", useNail);