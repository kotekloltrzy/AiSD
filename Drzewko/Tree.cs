using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewko
{
    internal class Tree
    {
        public TreeNode Root;

        public void Insert(int data)
        {
            if(Root != null)
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
    }
}
