namespace Engine;

/*
class Door {  } or interface IDoor {  } or abstract class Door {  }
class Scene : Door {
    public Door? north;
    public Door? east;
    public Door? south;
    public Door? west;
}
class Lock : Door {
    public Scene lockside;
    public Scene 
}
*/

public class Scene {
    public Scene? north;
    public Scene? east;
    public Scene? south;
    public Scene? west;
    public Dictionary<string, Item> items;
    public Scene() {
        north = null;
        south = null;
        east = null;
        west = null;
        items = new Dictionary<string, Item>(10);
    }
    public void linkNorth(Scene northScene) {

    }
    public void linkSouth(Scene southScene) {

    }
    public void linkEast(Scene eastScene) {
        
    }
    public void linkWest(Scene westScene) {
        
    }
    public Scene? direction(Cardinal direction) {
        switch (direction) {
            case Cardinal.North:
                return north;
            case Cardinal.South:
                return south;
            case Cardinal.East:
                return east;
            case Cardinal.West:
                return west;
            default:
                throw new InvalidDataException();
        }
    }
    public void addItem(Item newItem) {
        items.Add(newItem.Name, newItem);
    }
    public bool removeItem(string itemName) {
        return items.Remove(itemName);
    }
    public List<string> cardinalStrings() {
        List<string> cardinalList = new List<string>();
        if (north != null) cardinalList.Add("north");
        if (south != null) cardinalList.Add("south");
        if (east != null) cardinalList.Add("east");
        if (west != null) cardinalList.Add("west");
        return cardinalList;
    }
    /* Example Scene Description
        * 
        * You enter a room with a door to the north, east, south and west.
        * The room contains a key, dagger and blue potion.
        * A snake blocks your path.
        * Doors: N, E, S, W
        * Items: key, dagger, blue potion
        * Enemies: Snake
    */
    /// <summary>
    /// Replace me with Scribe
    /// </summary>
    public string sceneDescription() {
        string thisDescription = "Doors: {0}\nItems: {1}";
        string doorString = "";
        if (north != null) {
            doorString = doorString + "N, ";
        }
        if (east != null) {
            doorString = doorString + "E, ";
        }
        if (south != null) {
            doorString = doorString + "S, ";
        }
        if (west != null) {
            doorString = doorString + "W, ";
        }
        string itemString = "";
        foreach (KeyValuePair<string, Item> item in items) {
            itemString = itemString + item.Key + ", ";
        }
        String.Format(thisDescription, doorString, itemString);
        return thisDescription;
    }
}




// nice