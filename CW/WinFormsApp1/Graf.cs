using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    internal class Graf
    {
        List<NodeG> nodes = new List<NodeG>();
        List<Edge> edges = new List<Edge>();

        Element[] AlgorytmDijkstry(NodeG start)
        {
            var tabelka = this.przygotujTabelke(start);
            var zbS = new List<NodeG>();
            return tabelka;
        }

        List<Edge> ZnajdzNajmniejszyDystans(List<Element> tabelka, List<NodeG> zbS)
        {
            var kandydat = tabelka.Where(e => !zbS.Contains(e.wezel)).OrderBy(e => e.dystans).First();
            var a = this.edges.Where(k => k.start == kandydat.wezel && !zbS.Contains(k.end)).ToList();
            return a;
        }

        List<Edge> PrzygotujTabele(List<Element> tabelka, List <NodeG> zbS)
        {
            
        }
        
        
    }
}

