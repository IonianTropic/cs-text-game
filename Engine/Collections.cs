
namespace Collections {
    class LinkedList<T> {
        private class Node {
            // Node contains data and maybe a next Node
            public T data;
            public Node? next;
            // Node constructor
            public Node(T newData) {
                data = newData;
                next = null;
            }
            
        }
        // Linked List has maybe a first node called head
        private Node? head;
        private Node? current;
        // Linked List constructor
        public LinkedList(T newData) {
            head = new Node(newData);
            Node current = head;
        }
        public void insertBeginning(T newData) {
            Node newNode = new Node(newData);
            newNode.next = head;
            head = newNode;
        }
        public void removeBeginning() {
            head = head.next;
        }
        public T next() {
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
}
