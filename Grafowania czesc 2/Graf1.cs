using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafowania_czesc_2
{
    internal class Graf1
    {
        List<NodeG1> nodes = new List<NodeG1>();
        List<Edge> edges = new List<Edge>();

        public Graf1(List<NodeG1> nodes, List<Edge> edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }
        public Graf1(List<Edge> edges)
        {
            this.edges = edges;
        }

        public int Join(Graf1 graf)
        {
            return 1;
        }

        public int ileNowychWezlow(Edge k)
        {
            int ile = 0;
            if (edges.Contains(k))
            {
                if (nodes.Contains(k.start))
                {
                    ile++;
                }
                if (nodes.Contains(k.end))
                {
                    ile++;
                }
            }
            return ile;
        }

        public void Add(Edge k)
        {
            if (!edges.Contains(k))
            {
                edges.Add(k);
                if (!nodes.Contains(k.start))
                {
                    nodes.Add(k.start);
                }
                if (!nodes.Contains(k.end))
                {
                    nodes.Add(k.end);
                }
            }
            return;

        }


        public Graf1 AlgorytmKruskala()
        {
            this.edges.OrderBy(k => k.weight).ToList();
            var grafy = new List<Graf1>() { new Graf1(edges[0]) };
            for(int i = 0; i < edges.Count; i++) {
                var k = edges[i];
                var l = -1;
                for(int j = 0; j < edges.Count; j++)
                {
                    var g = grafy[j];
                    switch (g.ileNowychWezlow(k))
                    {
                        case 0:
                            j = grafy.Count;
                            break;

                        case 1:
                            if (l == -1)
                            {
                                g.Add(k);
                                l = j;
                            }
                            else
                            {
                                grafy[l].Join(g);
                                grafy.RemoveAt(j);
                                j = grafy.Count;
                                break;
                            }

                        case 2:
                            grafy.Add(new Graf1(k));
                    }
                }
            }
            return grafy[0];
        }

        public List<int> AlgorytmDijkstry(NodeG1 start)
        {
            var tabelka = this.PrzygotujTabelke(start);
            var zbS = new List<NodeG1>();
            var kandydaci = tabelka.Where(e => !zbS.Contains(e.node));
            var kandydat = kandydaci.OrderBy(e=>e.dystans);
            this.edges.Where(k => k.start == kandydat.node).ToList;
        }

    }
}
