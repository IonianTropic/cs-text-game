namespace Engine;

#warning Catch gameaction errors with either bool returns or exceptions
#warning Clean up comments and create documentation

/*
public delegate GameAction GameAction<in T>(object arg);
public delegate void GameAction();
GameAction;
Action<string> Use;
Func<bool> Use;
public static void useKey() {
    // unlock door
}
Item skullKey = new Item("Skull Key", useKey);

you're in room with stuff
>>> move south
Door is locked
>>> use key south

target:
"ghoul" -> scene.monsters["ghoul"]
"south" -> 
*/

public class GameAction {
    public static void idle(string voidMe) {  }
    public static void pickupItem(string itemName) {
        Game.inventory.Add(itemName, Game.currentScene.getItem(itemName));
        Game.currentScene.removeItem(itemName);
    }
    public static void dropItem(string itemName) {
        Game.currentScene.addItem(Game.inventory[itemName]);
        Game.inventory.Remove(itemName);
    }
    public static void move(string directionName) {
        Cardinal direct = directionName.toCardinal();
        if (Game.currentScene[direct] == null) return;
        if (Game.currentScene[direct] is Padlock) return;
        Game.currentScene = (Game.currentScene[direct] as Scene)!;
    }
}
