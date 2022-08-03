namespace EngineTest;

[TestClass]
public class UITest {
    private Scene testScene = new Scene();
    [TestMethod]
    public void testSceneLinks() {
        testScene.east = new Scene();
        testScene.east.east = new Scene();
        testScene.east.east.south = new Scene();
        Scene midRoom = testScene.east.east.south.west = new Scene();
        midRoom.west = new Scene();
        midRoom.west.south = new Scene();
        midRoom.west.south.east = new Scene();
        midRoom.west.south.east.east = new Scene();
        Assert.Fail();
    }
    [TestMethod]
    public void testSceneItems() {
        testScene.sceneItems.Add("Life Ender", Item.Nail);
        testScene.sceneItems.Add("Health Potion", Item.Potion);
        testScene.sceneItems.Add("Green Cap", Item.Cap);
        Assert.IsTrue(testScene.sceneItems.ContainsKey("Life Ender"));
    }
}

