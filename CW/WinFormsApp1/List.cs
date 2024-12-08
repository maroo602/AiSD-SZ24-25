using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class List
    {
        public NodeL head;
        public NodeL tail;
        public int count;

        public void AddFirst(int liczba)
        {
            if (this.head == null)
            {
                var tmp = new NodeL();
                this.tail = tmp;
                this.head = tmp;
                tmp.data = liczba;
            }
            else
            {
                var tmp = new NodeL();
                tmp.n = this.head;
                this.head.p = tmp;
                this.head = tmp;
                this.count++;
                tmp.data = liczba;
            }
        }
        public void AddLast(int liczba)
        {
            if (this.head == null)
            {
                var tmp = new NodeL();
                this.tail = tmp;
                this.head = tmp;
                tmp.data = liczba;
            }
            else
            {
                var tmp = new NodeL(); //(1)
                tmp.p = this.tail; //(2)
                this.tail.n = tmp; //(3)
                this.tail = tmp; //(4)
                this.count++; //5
                tmp.data = liczba;
            }
        }
        public void RemoveLast()
        {
            this.tail = this.tail.p;
            this.tail.n = null;
            this.count--;
        }
        public void RemoveFirst()
        {
            this.head = this.head.n;
            this.head.p = null;
            this.count--;
        }
    }
}