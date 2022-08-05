namespace Engine;

public class Game {
    public static Scene currentScene = new Scene(); // Game.currentScene
    public static Dictionary<string, Item> inventory = new Dictionary<string, Item>(10);
    public bool done;
    private string? _currentInput;
    public Game(Scene initalScene) {
        currentScene = initalScene;
    }
    public void run() {
        while (!done) {
            Console.WriteLine(currentScene.sceneDescription());
            _currentInput = Console.ReadLine();
            // Game logic
            // if _currentInput == north, Scene.north
            // if _currentInput == "use {name}", currentScene.sceneItems[name].use();
            // 
        }
        cleanUp();
    }
    private void cleanUp() {

    }
}

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
