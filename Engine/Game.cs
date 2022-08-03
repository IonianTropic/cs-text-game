namespace Engine;

public class Game {
    private Scene currentScene;
    private string? currentInput;
    public Game(Scene initalScene) {
        currentScene = initalScene;
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
