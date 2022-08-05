namespace EngineTest;

[TestClass]
public class EngineTest {
    private Scene startScene = new Scene();
    [TestMethod]
    public void testSceneLinks() {
        Scene? sceneLinker = new Scene();
        startScene.east = sceneLinker;
        sceneLinker.west = startScene.east;
        sceneLinker = new Scene();
        startScene.east.east = sceneLinker;
        sceneLinker.west = startScene.east.east;
        sceneLinker = null;
        Assert.Fail();
    }
    [TestMethod]
    public void testSceneItems() {
        startScene.addItem("Life Ender", GameAction.idle);
        startScene.addItem("Health Potion", GameAction.idle);
        startScene.addItem("Green Cap", GameAction.idle);
        Assert.IsTrue(startScene.sceneItems.ContainsKey("Life Ender"));
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

