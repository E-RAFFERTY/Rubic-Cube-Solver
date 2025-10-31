using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuby_5
{
    internal class TreeNode
    {
        public rubik_gen State { get; }
        public List<TreeNode> Children { get; }
        public List<string> move_done { get; }
        public int manhattern_distance;
        

        public TreeNode(rubik_gen state)
        {
            State = state;
            Children = new List<TreeNode>();
            if (move_done == null)
            {
                move_done = new List<string>();
            }
            manhattern_distance = 0;


        }

        public void AddChild(TreeNode child, string move)
        {
            Children.Add(child);
            child.move_done.AddRange(move_done);
            child.move_done.Add(move);
        }
        // ended up not useing this code
         public int manhatten_distance(TreeNode node)
         {
         
             int manhat_num = 0;
             int[,,] corners = { { { 0, 0, 0 }, { 3, 0, 2 }, { 4, 0, 0 } }, { { 0, 0, 2 }, { 3, 0, 0 }, { 2, 0, 2 } }, { { 0, 2, 1 }, { 1, 0, 0 }, { 4, 0, 2 } }, { { 0, 2, 2 }, { 2, 0, 0 }, { 1, 0, 2 } }, { { 5, 0, 0 }, { 1, 2, 0 }, { 4, 2, 2 } }, { { 1, 2, 2 }, { 5, 0, 2 }, { 2, 2, 0 } }, { { 5, 2, 2 }, { 2, 2, 2 }, { 3, 2, 0 } }, { { 5, 2, 0 }, { 4, 2, 0 }, { 3, 2, 2 } } };
             // should be WBO WBR WGO WRG YGO GYR YRB YOB
             int[,,] edges = { { { 3, 2, 1 }, { 5, 2, 1 } }, { { 3, 1, 0 }, { 2, 1, 2 } }, { { 3, 0, 1 }, { 0, 0, 1 } }, { { 3, 1, 2 }, { 4, 1, 0 } }, { { 1, 1, 0 }, { 4, 1, 2 } }, { { 1, 2, 0 }, { 5, 0, 1 } }, { { 1, 1, 2 }, { 2, 1, 0 } }, { { 1, 0, 0 }, { 0, 2, 1 } }, { { 5, 1, 2 }, { 2, 2, 1 } }, { { 2, 0, 1 }, { 0, 1, 2 } }, { { 0, 1, 0 }, { 4, 0, 1 } }, { { 4, 2, 1 }, { 5, 1, 0 } } };
         
             for (int i = 0; i < 8; i++)
             {
                 int i1 = corners[i, 0, 0];
                 int i2 = corners[i, 1, 0];
                 int i3 = corners[i, 2, 0];
                 int j1 = corners[i, 0, 1];
                 int j2 = corners[i, 1, 1];
                 int j3 = corners[i, 2, 1];
                 int k1 = corners[i, 0, 2];
                 int k2 = corners[i, 1, 2];
                 int k3 = corners[i, 2, 2];
                 int corner_count = manhat_val_corner(node, 5, i1, i2, i3, j1, j2, j3, k1, k2, k3);
                 manhat_num += corner_count;
             }
             for (int i = 0; i < 12; i++)
             {
                 int i1 = edges[i, 0, 0];
                 int i2 = edges[i, 1, 0];
                 int j1 = edges[i, 0, 1];
                 int j2 = edges[i, 1, 1];
                 int k1 = edges[i, 0, 2];
                 int k2 = edges[i, 1, 2];
                 int edge_count = manhat_val_edges(node, 5, i1, i2, j1, j2, k1, k2);
                 manhat_num += edge_count;
             }
             return manhat_num;
         }
        public static int manhat_val_corner(TreeNode node, int depth, int i1, int i2, int i3, int j1, int j2, int j3, int k1, int k2, int k3)
        {
            //if it is zero that means the peice is in the correct place
            if (is_corner_correct(node, i1, i2, i3, j1, j2, j3, k1, k2, k3) == true) { return 0; }
            foreach (var child in node.Children)
            {
        
                if (is_corner_correct(child, i1, i2, i3, j1, j2, j3, k1, k2, k3) == true)
                {
                    return 0;
                }
                else
                {
        
                    int res = manhat_val_corner(child, depth + 1, i1, i2, i3, j1, j2, j3, k1, k2, k3);
                }
            }
        
            return 6;//returning  means that is needs more that 3 moves for that peice to go to the correct spot so giving it a higher weight
        }
         public  int manhat_val_edges(TreeNode node, int depth, int i1, int i2, int j1, int j2, int k1, int k2)
         {
             if (is_edge_correct(node, i1, i2, j1, j2, k1, k2) == true) { return 0; }
             foreach (var child in node.Children)
             {
        
                 if (is_edge_correct(child, i1, i2, j1, j2, k1, k2) == true)
                 {
                     return depth;
                 }
                 else
                 {
        
                     int res = manhat_val_edges(child, depth + 1, i1, i2, j1, j2, k1, k2);
                 }
        
             }
             return 6;
         }


        public bool is_edge_correct(TreeNode node, int i1, int i2, int j1, int j2, int k1, int k2)
        {
            rubik_gen cube = node.State;

            char c1 = cube.GetSquareColor(i1, j1, k1);
            char col_should_be = what_colour_is_this_num(i1);

            char c2 = cube.GetSquareColor(i2, j2, k2);
            char col_should_be2 = what_colour_is_this_num(i2);
            if ((c1 == col_should_be) && (c2 == col_should_be2)) { return true; }

            return false;
        }
        static bool is_corner_correct(TreeNode node, int i1, int i2, int i3, int j1, int j2, int j3, int k1, int k2, int k3)
        {
            rubik_gen cube = node.State;
            char c1 = cube.GetSquareColor(i1, j1, k1);
            char col_should_be = what_colour_is_this_num(i1);

            char c2 = cube.GetSquareColor(i2, j2, k2);
            char col_should_be2 = what_colour_is_this_num(i2);

            char c3 = cube.GetSquareColor(i3, j3, k3);
            char col_should_be3 = what_colour_is_this_num(i3);

            if ((c1 == col_should_be) && (c2 == col_should_be2) && (c3 == col_should_be3)) { return true; }

            return false;
        }

        private static char what_colour_is_this_num(int n)
        {
            switch (n)
            {
                case 0:
                    return 'W'; break;
                case 1:
                    return 'G'; break;
                case 2:
                    return 'R'; break;
                case 3:
                    return 'B'; break;
                case 4:
                    return 'O'; break;
                case 5:
                    return 'Y'; break;
                default:
                    return 'X';
                    break;


            }
        }



        }
}
