namespace Engine;

#warning Implement input parser
#warning Clean up comments

public class Game {
    public static Scene currentScene = new Scene();
    public static Dictionary<string, Item> inventory = new Dictionary<string, Item>();
    private static bool done = false;
    private static string? _currentInput;
    public static void run() {
        while (!done) {
            Console.WriteLine(currentScene.description());
            _currentInput = Console.ReadLine(); // use __ on __ -> use key on south
            _currentInput.Split(" "); // "use life ender on *troll"
            
            /* (caw) -> start -> " " -> getCmd
             if (cmd is "use") {
                -> (caw) -> " on " -> getItemName
                -> EOL -> getTarget
             } else {
                -> EOL -> getTarget
            }
            switch cmd {
                case "check":
                    break;
                case "use":
                    inventory[itemName].use(target);
                    break;
                case "move":
                    move[target]
                    break;
                default:
                    error;
                    
            }
            */
            // "use", "Life Ender", "on", "Troll"
            // inventory["Life Ender"].use("Troll");
            // Game logic
            // if _currentInput == north, Scene.north
            // if _currentInput == "use {name}", currentScene.sceneItems[name].use();
            // 
        }
    }
}

/*
commands:
check [target]
use [itemName] on [target]
move [target]

associated methods:
[check]
inventory[itemName].use(target)
*/

/** Game Logic Concrete Example  
    "pickup Life Ender" -> ["pickup", "Life", "Ender"] -> cmdString = "pickup"
        argString = "Life" + " " + "Ender"
        switch (cmdString) {
            ...
            case "pickup":
                pickupItem(argString);
            ...
            default:
                Console.Writeline("fuck your father");
        }
    */
