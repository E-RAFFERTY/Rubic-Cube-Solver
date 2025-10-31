using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace cuby_5
{
    internal class rubik_gen
    {
        public char[,,] cube;
       

        public List<TreeNode> gen_child_node(TreeNode parentNode)
        {
            List<TreeNode> childNodes = new List<TreeNode>();

            for (int i = 0; i < 12; i++)
            {
                rubik_gen newState = DeepCopy(parentNode.State);
                newState = GetMoveActions(i, newState);

                TreeNode childNode = new TreeNode(newState);//make it so that is doesnt do repeate moves so U Ua back to back 

                string move_name = move_add_to_list(i);
                string parentlastmove = lastmove_on_parent(parentNode);
               // childNode.manhatten_distance(childNode);//herehkbhcdhdchdhdjdjacjdhjdccdhj
                if (move_name.Length == parentlastmove.Length)
                {
                    parentNode.AddChild(childNode, move_name);

                    childNodes.Add(childNode);
                }
                else if ((move_name.Substring(0, 1) != parentlastmove))
                {
                    parentNode.AddChild(childNode, move_name);

                    childNodes.Add(childNode);
                }


            }
            return childNodes;
        }
        public string hex_vall(rubik_gen cuby)
        {
            string str = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        char c = cuby.GetSquareColor(i, j, k);
                        str += c;

                    }

                }

            }
            str = ConvertToHex(str);

            return str;

        }
       
       
        private static string lastmove_on_parent(TreeNode parentNode)
        {
            List<string> parents_moves = parentNode.move_done;
            if (parents_moves.Count > 0) { return parents_moves.Last().ToString(); }
            return "#list_empty";


        }
       
        static string ConvertToHex(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        private string move_add_to_list(int i)
        {
            switch (i)
            {
                case 0:
                    return "F";

                case 1:
                    return "Fa";

                case 2:
                    return "B";

                case 3:
                    return "Ba";

                case 4:
                    return "L";

                case 5:
                    return "La";

                case 6:
                    return "U";

                case 7:
                    return "Ua";

                case 8:
                    return "D";

                case 9:
                    return "Da";

                case 10:
                    return "R";

                case 11:
                    return "Ra";

                default:
                    break;
            }
            return "error";
        }


        private rubik_gen GetMoveActions(int num, rubik_gen curstate)//i need to add each move to a list of moves done by each state and get each child not to inhearit this list and add to it 
        {
            switch (num)
            {
                case 0:
                    curstate.F_move();
                    break;
                case 1:
                    curstate.Fa_move();
                    break;
                case 2:
                    curstate.B_move();
                    break;
                case 3:
                    curstate.Ba_move();
                    break;
                case 4:
                    curstate.L_move();
                    break;
                case 5:
                    curstate.La_move();
                    break;
                case 6:
                    curstate.U_move();
                    break;
                case 7:
                    curstate.Ua_move();
                    break;
                case 8:
                    curstate.D_move();
                    break;
                case 9:
                    curstate.Da_move();
                    break;
                case 10:
                    curstate.R_move();
                    break;
                case 11:
                    curstate.Ra_move();
                    break;
                default:
                    break;
            }

            return curstate;
        }


        private rubik_gen DeepCopy(rubik_gen original)
        {
            //makes a new blank rubik gen
            rubik_gen copied = new rubik_gen();

            // make it have the same dimentions that the cube has
            copied.cube = new char[6, 3, 3];

            // Copy the elements from the original cube state to the new one
            Array.Copy(original.cube, copied.cube, original.cube.Length);

            return copied;
        }



        public rubik_gen()
        {


            cube = new char[6, 3, 3];
            InitializeCube();
        }

        private void InitializeCube()
        {
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        cube[i, j, k] = ' '; // Initialize with empty squares
                    }
                }
            }
        }

        public void SetSquareColor(int x, int y, int z, char colour)
        {

            if (x >= 0 && x < 6 && y >= 0 && y < 3 && z >= 0 && z < 3)
            {
                cube[x, y, z] = colour;
            }
            else
            {
                throw new ArgumentException("Invalid square coordinates.");
            }
        }

        public char GetSquareColor(int x, int y, int z)
        {
            if (x >= 0 && x < cube.GetLength(0) && y >= 0 && y < cube.GetLength(1) && z >= 0 && z < cube.GetLength(2))
            {
                return cube[x, y, z];
            }
            else
            {
                throw new ArgumentException("Invalid square coordinates.");
            }
        }

        public void U_move()
        {
            // (0 - W)  ( 1 - G ) (2 - R )  (3 - B) ( 4 - O) (5 - Y)

            // g>r  b>o  r>b o>g
            // in the 3d array (this place is for the colour of the cube face you want, this is for what row you want starting from the top , this is what place you want in the row)
            topface_clockwise(5);//yellow face
            char t1 = GetSquareColor(1, 2, 0);
            char t2 = GetSquareColor(1, 2, 1);
            char t3 = GetSquareColor(1, 2, 2);
            char t4 = GetSquareColor(2, 2, 0);
            char t5 = GetSquareColor(2, 2, 1);
            char t6 = GetSquareColor(2, 2, 2);
            char t7 = GetSquareColor(3, 2, 0);
            char t8 = GetSquareColor(3, 2, 1);
            char t9 = GetSquareColor(3, 2, 2);
            char t10 = GetSquareColor(4, 2, 0);
            char t11 = GetSquareColor(4, 2, 1);
            char t12 = GetSquareColor(4, 2, 2);

            SetSquareColor(1, 2, 0, t10);//change chars not right
            SetSquareColor(1, 2, 1, t11);
            SetSquareColor(1, 2, 2, t12);
            SetSquareColor(2, 2, 0, t1);
            SetSquareColor(2, 2, 1, t2);
            SetSquareColor(2, 2, 2, t3);
            SetSquareColor(3, 2, 0, t4);
            SetSquareColor(3, 2, 1, t5);
            SetSquareColor(3, 2, 2, t6);
            SetSquareColor(4, 2, 0, t7);
            SetSquareColor(4, 2, 1, t8);
            SetSquareColor(4, 2, 2, t9);

        }

        public void Ua_move()
        {
            // (0 - W)  ( 1 - G ) (2 - R )  (3 - B) ( 4 - O) (5 - Y)
            U_move();
            U_move();
            U_move();
        }
        public void D_move()
        {
            topface_clockwise(0);//white face
            char t1 = GetSquareColor(3, 0, 0);
            char t2 = GetSquareColor(3, 0, 1);
            char t3 = GetSquareColor(3, 0, 2);
            char t4 = GetSquareColor(4, 0, 0);
            char t5 = GetSquareColor(4, 0, 1);
            char t6 = GetSquareColor(4, 0, 2);
            char t7 = GetSquareColor(1, 0, 0);
            char t8 = GetSquareColor(1, 0, 1);
            char t9 = GetSquareColor(1, 0, 2);
            char t10 = GetSquareColor(2, 0, 0);
            char t11 = GetSquareColor(2, 0, 1);
            char t12 = GetSquareColor(2, 0, 2);

            SetSquareColor(3, 0, 0, t4);
            SetSquareColor(3, 0, 1, t5);
            SetSquareColor(3, 0, 2, t6);
            SetSquareColor(4, 0, 0, t7);
            SetSquareColor(4, 0, 1, t8);
            SetSquareColor(4, 0, 2, t9);
            SetSquareColor(1, 0, 0, t10);
            SetSquareColor(1, 0, 1, t11);
            SetSquareColor(1, 0, 2, t12);
            SetSquareColor(2, 0, 0, t1);
            SetSquareColor(2, 0, 1, t2);
            SetSquareColor(2, 0, 2, t3);

        }
        public void Da_move()
        {
            D_move();
            D_move();
            D_move();
        }
        public void topface_anticlockwise(int face) // like U move
        {
            char[] temp2 = new char[9];

            // Store the values from the white face
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp2[i * 3 + j] = GetSquareColor(face, i, j);
                }
            }

            // Update the positions based on the specified rotation
            SetSquareColor(face, 0, 0, temp2[2]);
            SetSquareColor(face, 0, 1, temp2[5]);
            SetSquareColor(face, 0, 2, temp2[8]);
            SetSquareColor(face, 1, 0, temp2[1]);
            SetSquareColor(face, 1, 2, temp2[7]);
            SetSquareColor(face, 2, 0, temp2[0]);
            SetSquareColor(face, 2, 1, temp2[3]);
            SetSquareColor(face, 2, 2, temp2[6]);
        }
        public void topface_clockwise(int face)//like U'
        {
            char[] temp2 = new char[9];

            // Store the values from the white face
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp2[i * 3 + j] = GetSquareColor(face, i, j);
                }
            }

            // Update the positions based on the specified rotation
            SetSquareColor(face, 0, 0, temp2[6]);
            SetSquareColor(face, 0, 1, temp2[3]);
            SetSquareColor(face, 0, 2, temp2[0]);
            SetSquareColor(face, 1, 0, temp2[7]);
            SetSquareColor(face, 1, 2, temp2[1]);
            SetSquareColor(face, 2, 0, temp2[8]);
            SetSquareColor(face, 2, 1, temp2[5]);
            SetSquareColor(face, 2, 2, temp2[2]);
        }
        public void B_move()//work
        {

            topface_clockwise(3); //blue face clock wise
            char t1 = GetSquareColor(4, 0, 0);
            char t2 = GetSquareColor(4, 1, 0);
            char t3 = GetSquareColor(4, 2, 0);
            char t4 = GetSquareColor(5, 2, 0);
            char t5 = GetSquareColor(5, 2, 1);
            char t6 = GetSquareColor(5, 2, 2);
            char t7 = GetSquareColor(2, 2, 2);
            char t8 = GetSquareColor(2, 1, 2);
            char t9 = GetSquareColor(2, 0, 2);
            char t10 = GetSquareColor(0, 0, 0);
            char t11 = GetSquareColor(0, 0, 1);
            char t12 = GetSquareColor(0, 0, 2);

            SetSquareColor(4, 0, 0, t12);
            SetSquareColor(4, 1, 0, t11);
            SetSquareColor(4, 2, 0, t10);
            SetSquareColor(5, 2, 0, t1);
            SetSquareColor(5, 2, 1, t2);
            SetSquareColor(5, 2, 2, t3);
            SetSquareColor(2, 2, 2, t4);
            SetSquareColor(2, 1, 2, t5);
            SetSquareColor(2, 0, 2, t6);
            SetSquareColor(0, 0, 0, t9);
            SetSquareColor(0, 0, 1, t8);
            SetSquareColor(0, 0, 2, t7);
        }
        public void Ba_move()//work
        {
            B_move();
            B_move();
            B_move();
        }
        public void F_move()
        {
            topface_clockwise(1); //green face clock wise
            char t1 = GetSquareColor(0, 2, 0);
            char t2 = GetSquareColor(0, 2, 1);
            char t3 = GetSquareColor(0, 2, 2);
            char t4 = GetSquareColor(2, 0, 0);
            char t5 = GetSquareColor(2, 1, 0);
            char t6 = GetSquareColor(2, 2, 0);
            char t7 = GetSquareColor(5, 0, 2);
            char t8 = GetSquareColor(5, 0, 1);
            char t9 = GetSquareColor(5, 0, 0);
            char t10 = GetSquareColor(4, 2, 2);
            char t11 = GetSquareColor(4, 1, 2);
            char t12 = GetSquareColor(4, 0, 2);

            SetSquareColor(0, 2, 0, t10);
            SetSquareColor(0, 2, 1, t11);
            SetSquareColor(0, 2, 2, t12);
            SetSquareColor(2, 0, 0, t1);
            SetSquareColor(2, 1, 0, t2);
            SetSquareColor(2, 2, 0, t3);
            SetSquareColor(5, 0, 2, t4);
            SetSquareColor(5, 0, 1, t5);
            SetSquareColor(5, 0, 0, t6);
            SetSquareColor(4, 2, 2, t7);
            SetSquareColor(4, 1, 2, t8);
            SetSquareColor(4, 0, 2, t9);

        }

        public void Fa_move()
        {
            F_move();
            F_move();
            F_move();
        }
        public void Ra_move()
        {
            R_move();
            R_move();
            R_move();
        }
        public void L_move()
        {
            topface_clockwise(2);//red face turns
            char t1 = GetSquareColor(5, 0, 2);
            char t2 = GetSquareColor(5, 1, 2);
            char t3 = GetSquareColor(5, 2, 2);
            char t4 = GetSquareColor(3, 2, 0);
            char t5 = GetSquareColor(3, 1, 0);
            char t6 = GetSquareColor(3, 0, 0);
            char t7 = GetSquareColor(0, 0, 2);
            char t8 = GetSquareColor(0, 1, 2);
            char t9 = GetSquareColor(0, 2, 2);
            char t10 = GetSquareColor(1, 0, 2);
            char t11 = GetSquareColor(1, 1, 2);
            char t12 = GetSquareColor(1, 2, 2);

            SetSquareColor(5, 0, 2, t4);
            SetSquareColor(5, 1, 2, t5);
            SetSquareColor(5, 2, 2, t6);
            SetSquareColor(3, 2, 0, t7);
            SetSquareColor(3, 1, 0, t8);
            SetSquareColor(3, 0, 0, t9);
            SetSquareColor(0, 0, 2, t10);
            SetSquareColor(0, 1, 2, t11);
            SetSquareColor(0, 2, 2, t12);
            SetSquareColor(1, 0, 2, t1);
            SetSquareColor(1, 1, 2, t2);
            SetSquareColor(1, 2, 2, t3);
        }

        public void La_move()
        {
            L_move();
            L_move();
            L_move();
        }

        public void R_move()//work
        {
            topface_clockwise(4);

            char t1 = GetSquareColor(0, 0, 0);
            char t2 = GetSquareColor(0, 1, 0);
            char t3 = GetSquareColor(0, 2, 0);
            char t4 = GetSquareColor(1, 0, 0);
            char t5 = GetSquareColor(1, 1, 0);
            char t6 = GetSquareColor(1, 2, 0);
            char t7 = GetSquareColor(5, 0, 0);
            char t8 = GetSquareColor(5, 1, 0);
            char t9 = GetSquareColor(5, 2, 0);
            char t10 = GetSquareColor(3, 2, 2);
            char t11 = GetSquareColor(3, 1, 2);
            char t12 = GetSquareColor(3, 0, 2);

            SetSquareColor(0, 0, 0, t10);
            SetSquareColor(0, 1, 0, t11);
            SetSquareColor(0, 2, 0, t12);
            SetSquareColor(1, 0, 0, t1);
            SetSquareColor(1, 1, 0, t2);
            SetSquareColor(1, 2, 0, t3);
            SetSquareColor(5, 0, 0, t4);
            SetSquareColor(5, 1, 0, t5);
            SetSquareColor(5, 2, 0, t6);
            SetSquareColor(3, 2, 2, t7);
            SetSquareColor(3, 1, 2, t8);
            SetSquareColor(3, 0, 2, t9);
        }
       
        

    }
}
