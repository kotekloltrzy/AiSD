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
        public NodeG1 start;
        public NodeG1 end;
        public int weight;

        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();

        public Edge(NodeG1 start, NodeG1 end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }
}
