namespace Engine;

public class Game {
    private Scene currentScene;
    private string? currentInput;
    private bool done;
    public Game(Scene initalScene) {
        currentScene = initalScene;
        done = false;
    }
    public void run() {
        initalize();
        while (!done) {
            Console.WriteLine(currentScene.sceneDescription);
            currentInput = Console.ReadLine();
            // Game logic
            // if currentInput == north, Scene.north
            // 
        }
        cleanUp();
    }
    private void initalize() {

    }
    private void cleanUp() {

    }
}
