namespace Engine;

public class GameAction {
    public static void idle() {  }
    public static void pickupItem(string itemName) {
        Game.inventory.Add(itemName, Game.currentScene.items[itemName]);
        Game.currentScene.removeItem(itemName);
    }
    public static void dropItem(string itemName) {
        Game.currentScene.addItem(Game.inventory[itemName]);
        Game.inventory.Remove(itemName);
    }
    
}
