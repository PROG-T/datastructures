package LinkedList;

public class Node {
    private int data;
    private Node next;

    public Node(int data) {
        this.data  = data ; }

public int getData(){return data;}

public void setData(int data){this.data = data;}

public void setNext(Node next){ this.next = next;}

public Node getNext(){return next;}


public static void main(String[] args) {
    Node ten = new Node(10);
    Node twenty = new Node(20);
    Node thirty = new Node(30);
    Node forty = new Node(40);

    Node head = ten;
    head.setNext(twenty) ;
    twenty.setNext(thirty);
    thirty.setNext(forty);
    forty.setNext(null);

PrintLinkedList(head);

}

public static void PrintLinkedList(Node head){
    Node current = head;
    while (current!= null){
        System.out.println(current.getData());
       current = current.getNext();
    }
}
} 
