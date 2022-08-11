namespace Engine;

#warning Clean up comments
#warning Create documentation

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
    public Scene slateside;
    public Lock() {

    }
} 
    startScene <-> Lock <-> southScene
    use key
    void lock(Scene room) {}
    void unlock(IDoor door) {}
    startScene.linkSouth(southScene)
    startScene <-> startScene.south
    
    startScene.lock(south)
    lock(direction) {
        this.direction.locked = true
        room.(in direction of this) = null
    }
    Room1 <-> Door1 <-> Room2
    Room1 -> Door1 where Room2 -> Door1
    makeAndLinkScenes() -> isLocked = false
    lockScenes() -> isLocked = true

    key can be used on door containing lockedScene
    key.use -> use link function between currentScene and lockedScene
    key.use -> myScene.linkNorth(lockedScene | Lock.edScene)

    class SceneObj {
        class Door {
            
        }
        class Lock {
            
        }
        class DeadBody {
            onCheck(Scene.Add(Monster))
        }
        class Sign {

        }
    }
interface IDoor {
    public int niceFunc();
}
sealed class Lock : IDoor {
    public int niceFunc() {
        return 69;
    }
}
sealed class Scene : IDoor {
    public int niceFunc() {
        return 420;
    }
}
Door = Sealed( // everything that is a door
    Scene
    | Lock
    | ...
    ;)

Unlock Steps:
use key
key checks "is there a lock in this direction?"
If so:
    enterScene.linkNorth(Lock.exit)
    maybe auto move into next scene
Else: fuck off | "key cannot be used here"
Lock: enterScene.padlock(Cardinal.North)
*/
public interface IDoor {
    
}

public sealed class Padlock : IDoor {
    public Scene enter;
    public Scene exit;
    public Padlock(Scene enter, Scene exit) {
        this.enter = enter;
        this.exit = exit;
    }
}

public sealed class Scene : IDoor {
    private IDoor? _north;
    private IDoor? _south;
    private IDoor? _east;
    private IDoor? _west;
    private Dictionary<string, Item> _items;
    private Dictionary<string, Monster> _monsters;
    public IDoor? this[Cardinal direct] {
        get {
            switch (direct) {
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
        private set {
            switch (direct) {
                case Cardinal.North:
                    _north = value;
                    break;
                case Cardinal.South:
                    _south = value;
                    break;
                case Cardinal.East:
                    _east = value;
                    break;
                case Cardinal.West:
                    _west = value;
                    break;
                default:
                    throw new InvalidDataException();
            }
        }
    }
    public Scene() {
        _north = null;
        _south = null;
        _east = null;
        _west = null;
        _items = new Dictionary<string, Item>(5);
        _monsters = new Dictionary<string, Monster>(3);
    }
    public static explicit operator Scene?(Padlock? l) {
        return null;
    }
    /// <summary>
    /// Links together the specified Scene to the given direction of the current scene.
    /// </summary>
    /// <param name="northScene">the new north Scene.</param>
    /// <returns>
    /// Returns true on successful link, otherwise false.
    /// </returns>
    public bool link(Cardinal direct, Scene newScene) {
        if (this[direct] != null) return false;
        this[direct] = newScene;
        newScene[direct.reverse()] = this;
        return true;
    }
    public bool padlock(Cardinal direct) {
        if (this[direct] == null) return false;
        if (this[direct] is Padlock) return false;
        Scene exitScene = (this[direct] as Scene)!;
        Padlock newLock = new Padlock(this, exitScene);
        exitScene[direct.reverse()] = newLock;
        this[direct] = newLock;
        return true;
    }
    /*
    this <-> aPadlock <-> nextScene
    this <-> nextScene
    */
    public bool unlock(Cardinal direct) {
        if (this[direct] == null) return false;
        if (this[direct] is not Padlock) return false;
        Padlock oldLock = (this[direct] as Padlock)!;
        this.link(direct, oldLock.exit);
        return true;
    }
    // Item Stuff
    public void addItem(Item newItem) {
        _items.Add(newItem.Name, newItem);
    }
    public bool removeItem(string itemName) {
        return _items.Remove(itemName);
    }
    public Item getItem(string itemName) {
        return _items[itemName];
    }
    // Monster Stuff    
    public void addMonster(Monster newMonster) {
        _monsters.Add(newMonster.Name, newMonster);
    }
    public bool removeMonster(string monsterName) {
        return _monsters.Remove(monsterName);
    }
    public Monster getMonster(string monsterName) {
        return _monsters[monsterName];
    }
    public List<string> cardinalStrings() {
        List<string> cardinalList = new List<string>();
        if (_north != null) cardinalList.Add("north");
        if (_south != null) cardinalList.Add("south");
        if (_east != null) cardinalList.Add("east");
        if (_west != null) cardinalList.Add("west");
        return cardinalList;
    }
    /// <summary>
    /// Gives a description of the instance Scene.
    /// </summary>
    public string description() {
        string descString = "You're in a room with a door to the {}.\n";
        if (_items.Count > 0) descString += "On the ground you see a {}.\n";
        if (_monsters.Count > 0) descString += "A {} blocks your path.";
        string itemString = Scribe.formatList(_items.Keys);
        string monsterString = Scribe.formatList(_monsters.Keys);
        String.Format(descString, cardinalStrings(), itemString, monsterString);
        return descString;
    }
}
