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
    private Scene? _north;
    private Scene? _east;
    private Scene? _south;
    private Scene? _west;
    public Dictionary<string, Item> items;
    public Dictionary<string, Monster> monsters;
    public Scene() {
        _north = null;
        _south = null;
        _east = null;
        _west = null;
        items = new Dictionary<string, Item>(10);
        monsters = new Dictionary<string, Monster>(10);
    }
    /// <summary>
    /// Links together the specified Scene to the north of the current scene.
    /// </summary>
    /// <param name="northScene">the new north Scene.</param>
    /// <returns>
    /// Returns true on successful link, otherwise false.
    /// </returns>
    public bool linkNorth(Scene northScene) {
        if (_north == null) return false;
        _north = northScene;
        northScene._south = this;
        return true;
    }
    /// <summary>
    /// Links together the specified Scene to the south of the current scene.
    /// </summary>
    /// <param name="southScene">the new south Scene.</param>
    /// <returns>
    /// Returns true on successful link, otherwise false.
    /// </returns>
    public bool linkSouth(Scene southScene) {
        if (_south == null) return false;
        _south = southScene;
        southScene._north = this;
        return true;

    }
    /// <summary>
    /// Links together the specified Scene to the east of the current scene.
    /// </summary>
    /// <param name="eastScene">the new east Scene.</param>
    /// <returns>
    /// Returns true on successful link, otherwise false.
    /// </returns>
    public bool linkEast(Scene eastScene) {
        if (_east == null) return false;
        _east = eastScene;
        eastScene._west = this;
        return true;
    }
    /// <summary>
    /// Links together the specified Scene to the west of the current scene.
    /// </summary>
    /// <param name="westScene">the new west Scene.</param>
    /// <returns>
    /// Returns true on successful link, otherwise false.
    /// </returns>
    public bool linkWest(Scene westScene) {
        if (_west == null) return false;
        _west = westScene;
        westScene._east = this;
        return true;
    }
    /// <summary>
    /// Returns the Scene or object in a given direction.
    /// </summary>
    /// <param name="direction">the desired Cardinal direction.</param>
    public Scene? direction(Cardinal direction) {
        switch (direction) {
            case Cardinal.North:
                return _north;
            case Cardinal.South:
                return _south;
            case Cardinal.East:
                return _east;
            case Cardinal.West:
                return _west;
            default:
                throw new InvalidDataException();
        }
    }
    // Item Stuff:
    public void addItem(Item newItem) {
        items.Add(newItem.Name, newItem);
    }
    public bool removeItem(string itemName) {
        return items.Remove(itemName);
    }
    
    public void addMonster(Monster newMonster) {
        monsters.Add(newMonster.Name, newMonster);
    }
    public bool removeMonster(string monsterName) {
        return monsters.Remove(monsterName);
    }
    public List<string> cardinalStrings() {
        List<string> cardinalList = new List<string>();
        if (_north != null) cardinalList.Add("north");
        if (_south != null) cardinalList.Add("south");
        if (_east != null) cardinalList.Add("east");
        if (_west != null) cardinalList.Add("west");
        return cardinalList;
    }
    /* Example Scene Description
        * 
        * You're in a room with a door to the north, east, south and west.
        * The room contains a key, dagger and blue potion.
        * A snake blocks your path.
        * Doors: N, E, S, W
        * Items: key, dagger, blue potion
        * Enemies: Snake
    */
    /// <summary>
    /// Replace me with Scribe
    /// </summary>
    public string description() {
        string thisDescription = 
        "You're in a room with a door to the {0}.\n"
        + "On the ground you see a {1}.\n"
        + "A {2} blocks your path.";
        string itemString = Scribe.formatList(items.Keys);
        string monsterString = Scribe.formatList(monsters.Keys);
        String.Format(thisDescription, cardinalStrings(), itemString, monsterString);
        return thisDescription;
    }
}
