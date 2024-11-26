using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafy_wstep
{
    internal class NodeG
    {
        List<NodeG> sasiedzi = new List<NodeG>();
        int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public void dodajSasiada(NodeG sasiad)
        {
            if(!this.sasiedzi.Contains(sasiad))
            {
                sasiedzi.Add(sasiad);
            }
        }

        public void podrozWglab(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            odwiedzone.Add(start);
            for(int i=0;i< this.sasiedzi.Count; i++)
            {
                if (!odwiedzone.Contains(sasiedzi[i]))
                {
                    odwiedzone.Add(sasiedzi[i]);
                    MessageBox.Show(Convert.ToString(sasiedzi[i].data));
                }
                podrozWglab(sasiedzi[i]);
            }
        }

        public void podrozWszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            odwiedzone.Add(start);
            Queue<NodeG> q = new Queue<NodeG>();
            q.Enqueue(start);
            while(q.Count > 0)
            {
                NodeG node = q.Dequeue();
                Console.Write(Convert.ToString(node.data)+ " ");
                foreach(NodeG x in sasiedzi)
                {
                    if (!odwiedzone.Contains(x)){
                        odwiedzone.Add(x);
                        q.Enqueue(x);
                    }
                }
            }
        }
    }
}
