using System;
namespace _01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
    public class ArrayStack<T> {
        private int count;
        private T[] elements;
        private const int initialCapacity = 4;

        public int Count { get { return count; } private set { } }

        public ArrayStack() {
            this.elements = new T[initialCapacity];
            this.Count = 0;
        }

        public void Push(T element) {
            this.Grow();
            this.elements[count] = element;
            this.count++;
        }
        public T Pop() {
            T element = elements[count];
            this.elements[count] = default;
            this.count--;

            return element;
        }
        public T[] ToArray() {
            T[] array = new T[this.Count];
            Array.Copy(this.elements, array, this.Count);
            return array;
        }
        public void Grow() {
            if(this.elements.Length == this.Count) {
                T[] extended = new T[this.elements.Length * 2];
                Array.Copy(this.elements, extended,this.elements.Length);
                this.elements = extended;
            }
        }
    }
}
