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

        public void Join(Graf1 g1)
        {
            for(int i=0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }
        }

    }
}
