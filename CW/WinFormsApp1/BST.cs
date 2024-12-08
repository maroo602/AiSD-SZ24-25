using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class BST
    {
        public NodeT root;
    }
    public NodeT znajdzRodzica(NodeT dziecko)
    {
        var rodzic = root;
        while (true)
        {
            if (dziecko.data < rodzic.data)
            {
                if (rodzic.lewa == null)
                {
                    return rodzic;
                }
                else
                {
                    rodzic = rodzic.lewa;
                }
            }
            if (dziecko.data >= rodzic.data)
            {
                if (rodzic.prawa == null)
                {
                    return rodzic;
                }
                else
                {
                    rodzic = rodzic.prawa;
                }
            }
        }

    }
    public void Add(int liczba)
    {
        var dziecko = new NodeT(liczba);
        if (this.root == null)
        {
            this.root = dziecko;
        }
        else
        {
            var rodzic = this.znajdzRodzica(dziecko);
            dziecko.rodzic = rodzic;
            if (dziecko.data < rodzic.data)
            {
                rodzic.lewa = dziecko;
            }
            else
            {
                rodzic.prawa = dziecko;
            }
        }

    }

    public NodeT usunBezdzietne()
    {
        var bezdzietny = this.root;
        while (true)
        {
            if (bezdzietny.lewa == null && bezdzietny.prawa == null)
            {
                var bezdzietnyReturn = bezdzietny;
                bezdzietny = null;
                return bezdzietnyReturn;
            }
            else if (bezdzietny.lewa != null)
            {
                bezdzietny = bezdzietny.lewa;
            }
            else if (bezdzietny.prawa != null)
            {
                bezdzietny = bezdzietny.prawa;
            }
        }
    }
}
