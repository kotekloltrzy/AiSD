using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy_wstep
{
    internal class NodeG
    {
        List<NodeG> sasiedzi = new List<NodeG>();
        int data;

        NodeG(int liczba)
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
                }
                podrozWglab(sasiedzi[i]);
            }
        }

        public void podrozWszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            odwiedzone.Add(start);
            for(int i=0; i<this.sasiedzi.Count; i++)
            {

            }
        }

        public void chodHowmana(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
                odwiedzone.Add(start);
        }
    }
}
