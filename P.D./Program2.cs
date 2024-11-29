using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS
{
    internal class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int data;
        public NodeT(int liczba)
        {
            this.data = liczba;
        }
    }
    internal class BST
    {
        public NodeT root;

        public NodeT Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
                return dziecko;
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                dziecko.rodzic = rodzic;
                if (dziecko.data < rodzic.data)
                {
                    rodzic.lewe = dziecko;
                }
                else
                {
                    rodzic.prawe = dziecko;
                }
                return dziecko;
            }
        }
        NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var rodzic = this.root;
            while (true)
            {
                if (dziecko.data < rodzic.data)
                {
                    if (rodzic.lewe == null)
                    {
                        return rodzic;
                    }
                    else
                    {
                        rodzic = rodzic.lewe;
                    }
                }
                else
                {
                    if (rodzic.prawe == null)
                    {
                        return rodzic;
                    }
                    else
                    {
                        rodzic = rodzic.prawe;
                    }
                }
            }
        }
        //kasowanie wezla p.d.
    
    public void Wypisz(NodeT node)
    {
        if (node == null) {  
                return; 
            }
  

        Wypisz(node.lewe);
        Console.Write(node.data + " ");
        Wypisz(node.prawe);
    }
    public void Wypisz()
    {
        Console.WriteLine("Drzewo: ");
        Wypisz(root);
        Console.WriteLine();
    }

    public void Delete(int liczba)
    {
        root = DeleteNode(root, liczba);
    }
    private NodeT DeleteNode(NodeT root, int liczba)
    {
        if (root == null) return root;
        if (liczba < root.data)
            root.lewe = DeleteNode(root.lewe, liczba);
        else if (liczba > root.data)
            root.prawe = DeleteNode(root.prawe, liczba);
        else
        {
            if (root.lewe == null)
                return root.prawe;
            else if (root.prawe == null)
                return root.lewe;
            root.data = Min(root.prawe);

            root.prawe = DeleteNode(root.prawe, root.data);
        }

        return root;
    }

    private int Min(NodeT wezel)
    {
        int min = wezel.data;
        while (wezel.lewe != null)
        {
            min = wezel.lewe.data;
            wezel = wezel.lewe;
        }
        return min;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BST();

            bst.Add(8);
            bst.Add(3);
            bst.Add(1);
            bst.Add(4);
            bst.Add(2);
            bst.Add(9);
            bst.Wypisz();
            bst.Delete(3);
            bst.Wypisz();
        }
    }
}
