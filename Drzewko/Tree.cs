using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Drzewko
{
    internal class Tree
    {
        public TreeNode Root;

        public void Insert(int data)
        {
            if (Root != null)
            {
                Root.Insert(data);
            }
            else
            {
                Root = new TreeNode(data);
            }
        }

        public void InOrderTraversal()
        {
            if (Root != null)
            {
                Root.InOrderTraversal();
            }
        }
        public TreeNode Find(int data)
        {
            if (Root != null)
            {
                return Root.Find(data);
            }
            else
            {
                return null;
            }
        }
        TreeNode Min(TreeNode n)
        {
            var temp = n;
            while(temp != null)
            {
                temp = temp.LeftNode;
            }
            return temp;
        }

        void RemoveElement(TreeNode n)
        {
            switch (GetChildrenNumber(n))
            {
                case 0:
                    this.RemoveElement0(n);
                    break;
                case 1:
                    this.RemoveElement1(n);
                    break;
                case 2:
                    var k = this.Min(n.RightNode);
                    this.RemoveElement(k);
                    k.LeftNode = n.LeftNode;
                    n.LeftNode = null;
                    k.RightNode = n.RightNode;
                    n.RightNode = null;
                    k.Parent = n.Parent;
                    n.Parent = null;
                    break;
            }
        }

        void RemoveElement1(TreeNode n)
        {
            TreeNode dziecko = null;
            if(n.LeftNode == null)
            {
                dziecko = n.LeftNode;
            }
            else
            {
                dziecko = n.RightNode;
            }
            this.RemoveElement0(dziecko);
            if (Root != null)
            {
                if(Root.data > dziecko.data)
                {
                    Root.LeftNode = dziecko;
                }
                else
                {
                    Root.RightNode = dziecko;
                }
            }
            else
            {
                this.Root = dziecko;
            }
        }

        void RemoveElement0(TreeNode n)
        {
            if (this.Root == n)
            {
                this.Root = null;
            }
            else
            {
                TreeNode Parent = Root;
                if(Root.LeftNode == n)
                {
                    Root.LeftNode = null;
                }
                else if(Root.RightNode == n)
                {
                    Root.RightNode = null;
                }
                n.Parent = null;
            }
        }
        public int GetChildrenNumber(TreeNode n)
        {
            int temp = 0;
            if(n.LeftNode != null)
            {
                temp++;
            }
            if(n.RightNode != null)
            {
                temp++;
            }
            return temp;
        }
    }
}
