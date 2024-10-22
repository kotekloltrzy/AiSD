using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe3._0
{
    internal class List
    {
        public Node head = new Node();
        public Node tail = new Node();
        public int count = 0;
        public Boolean isEmpty = true;

        public void AddFirst(int data)
        {
            if (isEmpty)
            {
                Node addNode = new Node();
                addNode.data = data;
                head = addNode;
                tail = addNode;
                count++;
                MessageBox.Show("Dodano " + head.data.ToString() + " do poczatku listy");
                isEmpty = false;
                return;
            }
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            count++;
            MessageBox.Show("Dodano " + head.data.ToString() + " do poczatku listy");
        }

        public void AddLast(int data)
        {
            if (isEmpty)
            {
                Node addNode = new Node();
                addNode.data = data;
                head = addNode;
                tail = addNode;
                count++;
                isEmpty = false;
                MessageBox.Show("Dodano " + tail.data.ToString() + " do konca listy");
                return;
            }
            Node newNode = new Node();
            newNode.data = data;
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
            count++;
            MessageBox.Show("Dodano " + tail.data.ToString() + " do konca listy");
        }

        public void RemoveFirst()
        {
            if (isEmpty)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
                count--;
                isEmpty = true;
                return;
            }
            head = head.next;
            head.prev = null;
            count--;
        }

        public void RemoveLast()
        {
            if(isEmpty)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
                count--;
                isEmpty = true;
                return;
            }
            tail = tail.prev;
            tail.next = null;
            count--;
        }

        public void Get(int n)
        {
            if (count==0 || n > count)
            {
                MessageBox.Show("Pozadana pozycja jest poza lista");
                return;
            }
            Node nodeCheck = head;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    MessageBox.Show(nodeCheck.data.ToString());
                    return;
                }
                nodeCheck = nodeCheck.next;
            }
        }
    }
}
