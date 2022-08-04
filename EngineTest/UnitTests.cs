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
        startScene.sceneItems.Add("Life Ender", Item.Nail);
        startScene.sceneItems.Add("Health Potion", Item.Potion);
        startScene.sceneItems.Add("Green Cap", Item.Cap);
        Assert.IsTrue(startScene.sceneItems.ContainsKey("Life Ender"));
    }
    [TestMethod]
    public void testListFormatter() {
        List<string> coolThings = new List<string>();
        //Assert.AreEqual(startScene.formatList(coolThings), "");
        coolThings.Add("whales");
        //Assert.AreEqual(startScene.formatList(coolThings), "whales");
        coolThings.Add("oranges");
        //Assert.AreEqual("whales and oranges", startScene.formatList(coolThings));
        coolThings.Add("turtles");
        Assert.AreEqual("whales, oranges and turtles", startScene.formatList(coolThings));
    }
}

