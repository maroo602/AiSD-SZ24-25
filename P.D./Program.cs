using System;

namespace MS
{
    internal class NodeL
    {
        public NodeL n;
        public NodeL p;
        public int data;

        public NodeL(int liczba)
        {
            this.data = liczba;
        }
    }

    internal class List
    {
        public NodeL head;
        public NodeL tail;
        public int count = 0;

        //Dodałem warunek jeśli lista jest pusta do obu funkcji
        public NodeL AddFirst(int liczba)
        {
            var tmp = new NodeL(liczba);
            if (this.head == null)
            {
                this.head = tmp;
                this.tail = tmp;
            }
            else
            {
                tmp.n = this.head;
                this.head.p = tmp;
                this.head = tmp;
            }
            this.count++;
            return tmp;
        }

        public NodeL AddLast(int liczba)
        {
            var tmp = new NodeL(liczba);
            if (this.tail == null)
            {
                this.head = tmp;
                this.tail = tmp;
            }
            else
            {
                tmp.p = this.tail;
                this.tail.n = tmp;
                this.tail = tmp;
            }
            this.count++;
            return tmp;
        }

        //public NodeL AddLast(int liczba)
        //{
        //    var tmp = new NodeL(liczba);
        //    tmp.p = this.tail;
        //    this.tail.n = tmp;
        //    this.tail = tmp;
        //    this.count++;
        //    return tmp;
        //}
        //}
        public NodeL RemoveFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            var removeF = this.head;
            this.head = this.head.n; 
            this.head.p = null;     
            this.count--;
            return removeF;
        }
        public NodeL RemoveLast()
        {
            if (this.tail == null)
            {
                return null;
            }
            var removeL = this.tail;
            this.tail = this.tail.p;
            this.tail.n = null;
            this.count--;
            return removeL;
        }
        public string ToString()
        {
            if (this.head == null)
                return "Lista jest pusta.";

            var xdd = this.head;
            var wynik = new System.Text.StringBuilder();
            wynik.Append("Lista: ");

            while (xdd != null)
            {
                wynik.Append(xdd.data);
                if (xdd.n != null)
                    wynik.Append(", ");
                xdd = xdd.n;
            }

            wynik.Append(".");
            return wynik.ToString();
        }
        public int Get(int index)
        {
            var current = this.head;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                current = current.n;
                currentIndex++;
            }

            return current.data;
        }
        class Program
        {
            static void Main(string[] args)
            {
                var lista = new List();
                lista.AddFirst(0);
                lista.AddLast(25);
                lista.AddLast(50);
                //lista.RemoveFirst();
                //lista.RemoveLast();

                var current = lista.head;
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.n;
                }
                Console.WriteLine();
                Console.WriteLine(lista.ToString());
                Console.WriteLine(lista.Get(0));
            }
        }
    }
}
