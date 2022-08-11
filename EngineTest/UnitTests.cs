namespace EngineTest;

[TestClass]
public class EngineTest {
    private Scene myScene = new Scene();
    private Scene newScene = new Scene();
    private Scene nextScene = new Scene();
    private Scene lastScene = new Scene();
    [TestMethod]
    public void testSceneLinks() {
        Scene? sceneLinker = new Scene();
        myScene.link(Cardinal.East, newScene);
        newScene.link(Cardinal.South, nextScene);
        nextScene.link(Cardinal.West, lastScene);
        lastScene.link(Cardinal.North, myScene);
        Assert.AreEqual(lastScene, myScene[Cardinal.South]);
    }
    [TestMethod]
    public void testSceneItems() {
        myScene.addItem(new Item("Life Ender", GameAction.idle));
        myScene.addItem(new Item("Health Potion", GameAction.idle));
        myScene.addItem(new Item("Green Cap", GameAction.idle));
        //Assert.IsTrue(myScene.items.ContainsKey("Life Ender"));
    }
    [TestMethod]
    public void testListFormatter() {
        List<string> coolThings = new List<string>();
        coolThings.Add("whales");
        coolThings.Add("oranges");
        coolThings.Add("turtles");
        coolThings.Add("ice");
        Assert.AreEqual("whales, oranges, turtles and ice", Scribe.formatList(coolThings));
    }
}

