using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Grafowania_czesc_2
{
    public class Edge
    {
        NodeG1 start;
        NodeG1 end;
        int weight;

        List<NodeG1> nodes = new List<NodeG1>();
        List<Edge> edges = new List<Edge>();

        public Edge(NodeG1 start, NodeG1 end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
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
    }
}
