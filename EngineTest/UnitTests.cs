namespace EngineTest;

[TestClass]
public class EngineTest {
    private Scene startScene = new Scene();
    [TestMethod]
    public void testSceneLinks() {
        Scene? sceneLinker = new Scene();
        startScene._east = sceneLinker;
        sceneLinker._west = startScene._east;
        sceneLinker = new Scene();
        startScene._east._east = sceneLinker;
        sceneLinker._west = startScene._east._east;
        sceneLinker = null;
        Assert.Fail();
    }
    [TestMethod]
    public void testSceneItems() {
        startScene.addItem(new Item("Life Ender", GameAction.idle));
        startScene.addItem(new Item("Health Potion", GameAction.idle));
        startScene.addItem(new Item("Green Cap", GameAction.idle));
        Assert.IsTrue(startScene.items.ContainsKey("Life Ender"));
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

