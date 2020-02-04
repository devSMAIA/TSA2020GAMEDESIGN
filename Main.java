/* Jamison Bradfield - JATC PM; Chapter 19, Project 2
 * (Implement GenericStack using inheritance) In Listing 19.1, GenericStack is
 * implemented using composition. Define a new stack class that extends ArrayList.
 * Draw the UML diagram for the classes and then implement GenericStack.
 * Write a test program that prompts the user to enter five strings and displays them in
 * reverse order.
 */

public class Main {
    public static void main(String[] args) {
        GenericStack<String> stack = new GenericStack<String>();
        stack.push("One");
        stack.push("Two");
        stack.push("Three");
        stack.push("Three");

        System.out.println(stack.getSize());
        System.out.println(stack.peek());
        System.out.println(stack.pop());
        System.out.println(stack.peek());
        // What number is sitting on top of the stack? [ 4 ]
        System.out.println();
        stack.push("Five");

        while (!stack.isEmpty()) {
            System.out.println(stack.pop());
        }
    }

    static class GenericStack<E> extends java.util.ArrayList<E> {
        public boolean isEmpty() {
            return super.isEmpty();
        }

        public int getSize() {
            return size();
        }

        public Object peek(){
            return get(getSize() - 1);
        }

        public Object pop(){
            Object o = get(getSize() -1);
            remove(getSize() -1);
            return o;
        }

        public Object push(E o){
            add(o);
            return o;
        }

        public int search(Object o){
            return indexOf(o);
        }

        @Override
        public String toString(){
            return "Stack: " + toString();
        }
    }
}
