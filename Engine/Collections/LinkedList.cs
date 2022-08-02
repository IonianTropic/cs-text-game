namespace Engine.Collections;

/// <summary>
/// Implements a generic singly linked list.
/// </summary>
public class YLinkedList<T> {
    /// <summary>
    /// Contains private data for each list node.
    /// </summary>
    private class Node {
        // Node attributes
        public T data;
        public Node? next;
        /// <summary>
        /// Initializes a new instance of the Node class to the value indicated.
        /// </summary>
        public Node(T newData) {
            data = newData;
            next = null;
        }
    }
    // Linked List attributes
    private Node? head;
    private Node? current;
    public nuint count;
    /// <summary>
    /// Initializes a new instance of the YLinkedList class to the head indicated
    /// by a value of type <typeparamref name="T"/>.
    /// </summary>
    public YLinkedList(T newData) {
        head = new Node(newData);
        current = head;
        count = 1;
    }
    /// <summary>
    /// Inserts a Node to the beginning of the current YLinkedList indicated
    /// by a value of type <typeparamref name="T"/>.
    /// </summary>
    public void insertHead(T newData) {
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
        count++;
    }
    /// <summary>
    /// Removes a Node from the beginning of the current YLinkedList.
    /// </summary>
    public void removeHead() {
        if (head == null) return;

        head = head.next;
        count--;
    }
    // insert Node in after of the current Node
    public void insertAfter(T newData) {
        if (current == null) return;

        Node newNode = new Node(newData);
        newNode.next = current.next;
        current.next = newNode;
        count++;
    }
    // remove Node in after of the current Node
    public void removeAfter() {
        if (current == null) return;
        if (current.next == null) return;

        current.next = current.next.next;
        count--;
    }
    // traverse LinkedList by advancing node
    private T next() {
        if (current == null) { 
            throw new InvalidOperationException("end of LinkedList");
        }
        T currentData = current.data;
        current = current.next;
        return currentData;
    }
    public IEnumerator<T> GetEnumerator() {

        current = head;

        while (current != null) {
            yield return current.data;
            current = current.next;
        }
    }
}
