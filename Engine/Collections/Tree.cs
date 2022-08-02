namespace Engine.Collections;

// Fields: attributes, properties, methods, or constructors
public class YTree<T> {
    private class Node {
        public T data;
        public Node? parent;
        public List<Node> children;
        private int Degree {
            get {
                return children.Count;
            }
        }
        public Node(T newData) {
            parent = null;
            data = newData;
            children = new List<Node>();
        }
        public Node(Node parentNode, T newData) {
            parent = parentNode;
            data = newData;
            children = new List<Node>();
        }
        public Node(T newData, IEnumerable<T> collection) {
            parent = null;
            data = newData;
            children = new List<Node>();
            foreach (T childData in collection) {
                children.Add(new Node(childData));
            }
        }
        public Node(Node parentNode, T newData, IEnumerable<T> collection) {
            parent = parentNode;
            data = newData;
            children = new List<Node>();
            foreach (T childData in collection) {
                children.Add(new Node(childData));
            }
        }
    }
    private Node root;
    private Node current;
    public T Data {
        get {
            return current.data;
        }
        set {
            current.data = value;
        }
    }
    public YTree(T newData) {
        root = new Node(newData);
        current = root;
    }
    private YTree(Node treeNode) {
        for (root = treeNode; root.parent != null; root = root.parent) {    }
        current = treeNode;
    }
    public void add(T newData) {
        current.children.Add(new Node(current, newData));
    }
    public void prev() {
        if (current.parent == null) return;
        current = current.parent;
    }
    public void next(int index) {
        current = current.children[index];
    }
    public void insert(T newData) {
        current.children.Add(new Node(newData));
    }
    public void delete(int index) {
        current.children.RemoveAt(index);
    }
    public IEnumerator<T> getBFS() {
        Queue<Node> nodeQueue = new Queue<Node>();
        yield return root.data;
        nodeQueue.Enqueue(root);
        while (nodeQueue.Count != 0) {
            Node currentNode = nodeQueue.Dequeue();
            
        }
    }
}
