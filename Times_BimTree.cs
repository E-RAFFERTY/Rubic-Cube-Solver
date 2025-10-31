using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuby_5
{
    internal class Times_BimTree
    {
        public Time_taken_node root;
        //public lis
        //public equeue = new equeue();
        int count = 0;
        string fastest_time = "";
        public Times_BimTree()
        {
            root = null;
        }

        public void Insert(double value)
        {
            root = incert_node(root, value);
        }

        // add a node by searching where it would fit the most
        private Time_taken_node incert_node(Time_taken_node root, double value)
        {
            if (root == null)
            {
                root = new Time_taken_node(value);
                return root;
            }

            if (value < root.data)
                root.left = incert_node(root.left, value);
            else if (value > root.data)
                root.right = incert_node(root.right, value);

            return root;
        }

        public bool Search(double value)
        {
            return search_for_node(root, value);
        }

        private bool search_for_node(Time_taken_node root, double value)// goes thorugh the tree
        {
            if (root == null)
                return false;

            if (root.data == value)
                return true;

            if (value < root.data)
                return search_for_node(root.left, value);
            else
                return search_for_node(root.right, value);
        }

        public string Inorder()
        {
            string str = In_order_search(root);
            return str;
            //Console.WriteLine();
        }

        private string In_order_search(Time_taken_node root)
        {
           

            if (root != null && count <5)//ony want the top 5 times
            {

                In_order_search(root.left);
                count++;
                fastest_time += $"{count}: {root.data}" + "\n";// new line
                Console.Write(root.data + " ");
                In_order_search(root.right);
                
            }
            return fastest_time;
        }
    }
}
