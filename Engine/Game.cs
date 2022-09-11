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
            _currentInput = Console.ReadLine();
            string[] inputList = _currentInput.Trim().Split(" ");
            
            /*
            "use life ender on troll" 
            -> "use", "life", "ender", "on", "troll"
            -> "use", "life ender", "troll"
            -> subject.use(target)

            "move north"
            "check south"
            
            switch inputList.next() {
                case "check":
                    string target = inputList.next();
                    for stripe in inputList {
                        target += " " + stripe
                    }
                    GameAction.check(target);
                    break;
                case "use":
                    // subject is element(s) between "use" and "on"
                    // target is element(s) between "on" and null
                    subject.use(target);
                    break;
                case "move":
                    cmd = Command.move;
                    // target is element between "move" and null
                    GameAction.move(target);
                    break;
                default:
                    Console.WriteLine("Nope.");
            }
            */
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
