using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzewko
{
    internal class TreeNode
    {
        public int data;
        public TreeNode RightNode;
        public TreeNode LeftNode;
        public TreeNode Parent;

        public TreeNode(int value)
        {
            data = value;
        }

        public TreeNode(int value, TreeNode parent)
        {
            data = value;
            Parent = parent;
        }

        public void Insert(int value)
        {
            if(value >= data)
            {
                if(RightNode == null)
                {
                    RightNode = new TreeNode(value);
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                if(LeftNode == null)
                {
                    LeftNode = new TreeNode(value);
                }
                else
                {
                    LeftNode.Insert(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            if (LeftNode != null)
                LeftNode.InOrderTraversal();
            MessageBox.Show(data + " ");
            if (RightNode != null)
                RightNode.InOrderTraversal();
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;
            while(currentNode != null)
            {
                if(value == currentNode.data)
                {
                    MessageBox.Show("Znaleziono " + value + " w drzewie");
                    return currentNode;
                }
                else if(value == currentNode.data)
                {
                    currentNode = currentNode.RightNode;
                }
                else
                {
                    currentNode = currentNode.LeftNode;
                }
            }
            MessageBox.Show("Nie znaleziono wartości " + value + " w drzewie");
            return null;
        }
    }
}
