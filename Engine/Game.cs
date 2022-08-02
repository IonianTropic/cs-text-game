namespace Engine;

public class Game {
    private Scene currentScene;
    private string? currentInput;
    public Game() {
        currentScene = new Scene();
    }
    public void run() {
        for (;;) {
            Console.WriteLine(currentScene.sceneDescription);
            currentInput = Console.ReadLine();
            // Game logic
            // if currentInput == north, Scene.north
            // 
        }
    }
}
