using System.Collections.Generic;

namespace MaterialToolkitChart {
    class FixedQueue<T> : Queue<T>{
        private Queue<T>    queue;
        private int         size;

        public FixedQueue() {
            queue = new Queue<T>();
        }

        public  FixedQueue(int size) {
            queue = new Queue<T>();
            this.size = size;
        }

        public new void Enqueue(T obj) {
            while(queue.Count > size) {
                queue.Dequeue();
            }
            queue.Enqueue(obj);
        }
    }
}
