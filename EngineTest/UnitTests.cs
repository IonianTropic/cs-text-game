namespace EngineTest;

[TestClass]
public class UITest {
    [TestMethod]
    public void testGetDescription() {
        
    }
    [TestMethod]
    public void testItem() {
        Item someItem = new Item("someName");
        Assert.AreEqual(someItem.itemName, "someName");
    }
}

