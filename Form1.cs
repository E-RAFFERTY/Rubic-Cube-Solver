using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cuby_5
{
    public partial class Cube_solver : Form
    {


        private rubik_gen cube = new rubik_gen();
        private rubik_gen cube_to_solve = new rubik_gen();
        private rubik_gen solve_cube = new rubik_gen();
        
        
        private const int size = 128;//size of one square position like (0,0,0)//original =30
        private const int face_size = size * 3;//original is 90

        private Point mousepos = new Point(-1, -1);
        private Point current = new Point(0, 0);    // the initial point
        int x = 480;//190 these are the values before i changed them
        int y = 160;//10
        int time_count = 0;
        

        // initial values to start drawing each face of the cube X val
        private int draw_startx_cord(int i)
        {

            int start_x = x;
            if (i == 1) { start_x = x; }
            if (i == 2) { start_x = x + face_size; }
            if (i == 3) { start_x = x + (2 * face_size); }
            if (i == 4) { start_x = x - (face_size); }
            if (i == 5) { start_x = x; }
            return start_x;
        }
        // initial values to start drawing each face of the cube Y val
        int draw_starty_cord(int i)
        {
            int start_y = y;

            if (i == 1) { start_y = y + face_size; }
            if (i == 2) { start_y = y + face_size; }
            if (i == 3) { start_y = y + face_size; }
            if (i == 4) { start_y = y + face_size; }
            if (i == 5) { start_y = y + (2 * face_size); }
            return start_y;
        }
        // paints the net
        void cube_solver_paint(object sender, PaintEventArgs e)
        {
            //drawing the net
            Brush brush = Brushes.Black;
            Pen pen = new Pen(System.Drawing.Color.Black, 3);
            Graphics g = e.Graphics;
            int start_x = x;
            int start_y = y;
            // draws the grid
            for (int i = 0; i < 6; i++)
            {
                start_x = draw_startx_cord(i);
                start_y = draw_starty_cord(i);
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        char c = cube.GetSquareColor(i, j, k);
                        brush = what_col(c);
                        //colouring the net
                        g.FillRectangle(brush, start_x, start_y, size, size);
                        // out line of the square
                        g.DrawRectangle(pen, start_x, start_y, size, size);
                        start_x += size;
                    }
                    start_x = draw_startx_cord(i);
                    start_y += size;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Pen thick_pen = new Pen(System.Drawing.Color.Black, 6);
                start_x = draw_startx_cord(i);
                start_y = draw_starty_cord(i);
                g.DrawRectangle(thick_pen, start_x, start_y, face_size, face_size);
            }


            Invalidate();

        }
        // changes colour of the brush to match char
        Brush what_col(char c)
        {
            Brush brush = Brushes.Black;
            if (c == 'W') return brush = Brushes.White;
            if (c == 'Y') return brush = Brushes.Yellow;
            if (c == 'B') return brush = Brushes.Blue;
            if (c == 'O') return brush = Brushes.Orange;
            if (c == 'R') return brush = Brushes.Red;
            if (c == 'G') return brush = Brushes.Green;
            return brush = Brushes.Purple;


        }
        //fills square
        void draw_squares_fill(object sender, PaintEventArgs e)
        {

            Brush brush = Brushes.Black;
            Graphics g = e.Graphics;
            char c = cube.GetSquareColor(5, 0, 0);
            brush = what_col(c);

        }


        public Cube_solver()
        {
            InitializeComponent();
            //this.Width = 8 * size + 16;
            //this.Height = 8 * size + 39;
            this.ControlBox = false;
            this.DoubleBuffered = true;//less flickery
            cube_from_TextFile(cube);
            cube_from_TextFile(solve_cube);
            //timer1.Interval = 10; // 1 second is 1000
           // timer1.Tick += Time_Tick;




            this.Paint += new PaintEventHandler(cube_solver_paint);

        }
       
        private void Time_Tick (object sender, EventArgs e)
        {
            time_count++;
        }

       
        private void cube_textfile_button_Click(object sender, EventArgs e)
        {
            cube_from_TextFile(cube);
            Invalidate();



        }
       
        // reads the solved cube from file
        private static rubik_gen cube_from_TextFile(rubik_gen cube)
        {
            List<string> list = new List<string>();
            var logFile = File.ReadAllLines("C:\\Users\\RAFFEC\\OneDrive - The Kings School Chester\\A-Level Com\\NEA\\trial\\cube_trail\\compleatecube.txt");
            foreach (var s in logFile) list.Add(s);
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {

                        char color = char.Parse(list[count]);
                        cube.SetSquareColor(i, j, k, color);
                        count++;
                    }
                }
            }

            return cube;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void F_button_Click(object sender, EventArgs e)
        {
            cube.F_move();
            shuffle_moves_textbox.Text += "F ";
            Invalidate();
        }

        private void Fa_button_Click(object sender, EventArgs e)
        {
            cube.Fa_move();
            shuffle_moves_textbox.Text += "Fa ";
            Invalidate();
        }

        private void B_button_Click(object sender, EventArgs e)
        {
            cube.B_move();
            shuffle_moves_textbox.Text += "B ";
            Invalidate();
        }

        private void Ba_button_Click(object sender, EventArgs e)
        {
            cube.Ba_move();
            shuffle_moves_textbox.Text += "Ba ";
            Invalidate();
        }

        private void U_button_Click(object sender, EventArgs e)
        {
            cube.U_move();
            shuffle_moves_textbox.Text += "U";
            Invalidate();
        }

        private void Ua_button_Click(object sender, EventArgs e)
        {
            cube.Ua_move();
            shuffle_moves_textbox.Text += "Ua ";
            Invalidate();
        }

        private void D_button_Click(object sender, EventArgs e)
        {
            cube.D_move();
            shuffle_moves_textbox.Text += "D ";
            Invalidate();
        }

        private void Da_button_Click(object sender, EventArgs e)
        {
            cube.Da_move();
            
            shuffle_moves_textbox.Text += "Da ";
            Invalidate();
        }

        private void L_button_Click(object sender, EventArgs e)
        {
            cube.L_move();
            shuffle_moves_textbox.Text += "L ";
            Invalidate();
        }

        private void La_button_Click(object sender, EventArgs e)
        {
            cube.La_move();
            shuffle_moves_textbox.Text += "La ";
            Invalidate();
        }

        private void R_button_Click(object sender, EventArgs e)
        {
            cube.R_move();
            shuffle_moves_textbox.Text += "R ";
            Invalidate();
        }

        private void Ra_button_Click(object sender, EventArgs e)
        {
            cube.Ra_move();
            shuffle_moves_textbox.Text += "Ra ";
            Invalidate();
        }

        private void moves_page_Click(object sender, EventArgs e)
        {

        }
        // private void largest_manhat(TreeNode root)
        // {
        //     int n = root.manhatten_distance(root);
        // }

        private void shuffle_button_Click(object sender, EventArgs e)
        {
            string str = shuffle(cube);
            shuffle_moves_textbox.Text += str;
           
            Invalidate();
        }
        private string shuffle(rubik_gen cube)
        {
            Random ran = new Random();
            string str = "";
            int random_moves_amount = ran.Next(5, 16);
            for (int i = 0; i < random_moves_amount; i++)
            {
                int what_ran_move = ran.Next(0, 12);
                string s = index_move(what_ran_move, cube);
                str += s;
            }
            return str;

        }
        // does a move based of input value and adds the move ro a sting
        private static string index_move(int i, rubik_gen cube)
        {
            string str = "";
            switch (i)
            {

                case 0:
                    cube.F_move(); str += "F"; break;

                case 1:
                    cube.Fa_move(); str += "Fa"; break;

                case 2:
                    cube.B_move(); str += "B"; break;

                case 3:
                    cube.Ba_move(); str += "Ba"; break;

                case 4:
                    cube.L_move(); str += "L"; break;

                case 5:
                    cube.La_move(); str += "La"; break;

                case 6:
                    cube.U_move(); str += "U"; break;

                case 7:
                    cube.Ua_move(); str += "Ua"; break;

                case 8:
                    cube.D_move(); str += "D"; break;

                case 9:
                    cube.Da_move(); str += "Da"; break;

                case 10:
                    cube.R_move(); str += "R"; break;

                case 11:
                    cube.Ra_move(); str += "Ra"; break;
                default:
                    break;

            }
            return str + " ";

        }
       


        private void reset_button_Click(object sender, EventArgs e)
        {
            shuffle_moves_textbox.Text = "";
            solved_moves_textbox.Text = "";
            Total_moves_done_lable.Text = "";
            cube_from_TextFile(cube);
            Invalidate();
        }
        //my solving algarithm
        private void Solve()
        {
            DateTime time = DateTime.Now;// captures time i started solving

            //timer1.Start();
            Time_taken_lable.Text = "";
            final_move_textbox.Text = "";
            Solve_moves_textbox.Text = "";
            string shufmove = shuffle_moves_textbox.Text;

            rubik_gen original = cube;


            if (cube.hex_vall(cube) != solve_cube.hex_vall(solve_cube))//check if cube is already solved
            {
                White_cross_button.BackColor = Color.White;
                TreeNode root = new TreeNode(cube);
                string res;
                string ans;
                //white cross
                low_count_lable.Text = "0";
                //while (Convert.ToInt32(low_count_lable.Text) != 4)
                {


                    root = new TreeNode(cube);
                    GenerateChildNodesRecursive(root, 6);
                    res = find_white_cross(root);
                    ans = white_cross_textbox.Text;
                    string_to_move((ans += " "));

                    final_move_textbox.Text += " " + ans;
                    //sol_cube.white_cross(cube);
                    Invalidate();
                }


                //white corners
                Solve_moves_textbox.Text = "";
                low_count_lable.Text = "0";
                while (Convert.ToInt32(low_count_lable.Text) != 4)
                {
                    root = new TreeNode(cube);
                    //rubik_gen cubey = root.State;
                    //low_count_lable.Text = white_corner_val(root).ToString();
                    GenerateChildNodesRecursive(root, 6);
                    res = find_white_corner(root);
                    ans = white_cross_textbox.Text;
                    string_to_move((ans += " "));

                    final_move_textbox.Text += " " + ans;
                    Invalidate();
                }
                /////////////////////////////////////////////////////
                ///middle edges solver
                ///will check if a edge is in a optimal place
                string s = "temp";
                while (s.Length != 0)
                {


                    low_count_lable.Text = "0";
                    root = new TreeNode(cube);



                    bool has_move_made = false;// can only do one set of moves with each pass
                    root = new TreeNode(cube);
                    s = "";
                    List<string> listy = new List<string>();
                    //try and put the gr in place 
                    if (has_move_made == false)
                    {



                        listy = is_midle_edge_BR_in_correct_place(root, listy);
                        if (listy.Count != 4)
                        {
                            foreach (string str in listy)
                            {
                                s += str + " ";
                                //move_implicate(s, cube);
                                Invalidate();
                            }
                            has_move_made = true;
                        }

                    }

                    if (has_move_made == false)
                    {

                        listy.Clear();
                        listy = is_midle_edge_GO_in_correct_place(root, listy);
                        if (listy.Count != 4)
                        {
                            foreach (string str in listy)
                            {
                                s += str + " ";
                                //move_implicate(s, cube);
                                Invalidate();
                            }
                            has_move_made = true;
                        }
                    }


                    if (has_move_made == false)
                    {

                        listy.Clear();
                        listy = is_midle_edge_RG_in_correct_place(root, listy);
                        if (listy.Count != 4)
                        {
                            foreach (string str in listy)
                            {
                                s += str + " ";
                                //move_implicate(s, cube);
                                Invalidate();
                            }
                            has_move_made = true;
                        }
                    }

                    if (has_move_made == false)
                    {

                        listy.Clear();
                        listy = is_midle_edge_OB_in_correct_place(root, listy);

                        if (listy.Count != 4)
                        {
                            foreach (string str in listy)
                            {
                                s += str + " ";
                                //move_implicate(s, cube);
                                Invalidate();
                            }
                            has_move_made = true;
                        }
                    }





                    //this means the remaining edges to be solved have been swapped


                    if (cube.GetSquareColor(3, 1, 0) == 'R' && cube.GetSquareColor(2, 1, 2) == 'B' && s == "") { s = "Ua, Ba, U, B, U, L, Ua, La"; has_move_made = true; }



                    if (cube.GetSquareColor(4, 1, 0) == 'B' && cube.GetSquareColor(3, 1, 2) == 'O' && s == "") { s = "U, B, Ua, Ba, Ua, Ra, U, R"; has_move_made = true; }



                    if (cube.GetSquareColor(4, 1, 2) == 'G' && cube.GetSquareColor(1, 1, 0) == 'O' && s == "") { s = "U R Ua Ra Ua Fa U F"; has_move_made = true; }



                    if (cube.GetSquareColor(1, 1, 2) == 'R' && cube.GetSquareColor(2, 1, 0) == 'G' && s == "") { s = "U, F, Ua, Fa, Ua, La, U, L,"; has_move_made = true; }


                    Solve_moves_textbox.Text = s;
                    white_cross_textbox.Text = s;
                    ans = white_cross_textbox.Text;
                    string_to_move((ans += " "));

                    final_move_textbox.Text += " " + ans;
                    Invalidate();
                    //}
                }
                Solve_moves_textbox.Text = "";

                //yellow cross

                low_count_lable.Text = "0";
                root = new TreeNode(cube);
                int numd = count_yellow_cross(root);//how mnay peices are allready in a good spot
                while (numd < 4)
                {
                    GenerateChildNodesRecursive(root, 6);
                    res = find_yellow_cross(root);
                    ans = white_cross_textbox.Text;
                    string_to_move((ans += " "));

                    final_move_textbox.Text += " " + ans;
                    Invalidate();
                    root = new TreeNode(cube);
                    numd = count_yellow_cross(root);
                }

                //        // yellow corners
                // checks if the cube is in one of 3 patterns does different depending on what was asked
                root = new TreeNode(cube);
                int num = yellow_corners_val(root);
                while (num != 4)
                {

                    bool move_done = false;
                    root = new TreeNode(cube);
                    if (yellow_corners_val(root) == 1)//make it to check if move done true or fasle
                    {
                        if (cube.GetSquareColor(5, 0, 2) == 'Y' && move_done == false)//green face
                        {
                            Solve_moves_textbox.Text = "R U Ra U R U U Ra";
                            white_cross_textbox.Text = "R U Ra U R U U Ra";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(5, 0, 0) == 'Y' && move_done == false)//orange face
                        {
                            Solve_moves_textbox.Text = "B U Ba U B U U Ba";
                            white_cross_textbox.Text = "B U Ba U B U U Ba";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(5, 2, 0) == 'Y' && move_done == false)//blue face
                        {
                            Solve_moves_textbox.Text = "L U La U L U U La";
                            white_cross_textbox.Text = "L U La U L U U La";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(5, 2, 2) == 'Y' && move_done == false)//red face
                        {
                            Solve_moves_textbox.Text = "F U Fa U F U U Fa";
                            white_cross_textbox.Text = "F U Fa U F U U Fa";
                            move_done = true;
                        }
                        //yellow_corners_val(root) > 1 && yellow_corners_val(root) < 4
                    }
                    if (yellow_corners_val(root) == 2)
                    {
                        if (cube.GetSquareColor(1, 2, 2) == 'Y' && move_done == false)//green face
                        {
                            Solve_moves_textbox.Text = "R U Ra U R U U Ra";
                            white_cross_textbox.Text = "R U Ra U R U U Ra";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(4, 2, 2) == 'Y' && move_done == false)//orange face
                        {
                            Solve_moves_textbox.Text = "B U Ba U B U U Ba";
                            white_cross_textbox.Text = "B U Ba U B U U Ba";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(2, 2, 2) == 'Y' && move_done == false)//red face
                        {
                            Solve_moves_textbox.Text = "F U Fa U F U U Fa";
                            white_cross_textbox.Text = "F U Fa U F U U Fa";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(3, 2, 2) == 'Y' && move_done == false)//blue face
                        {
                            Solve_moves_textbox.Text = "L U La U L U U La";
                            white_cross_textbox.Text = "L U La U L U U La";
                            move_done = true;

                        }
                    }

                    if (yellow_corners_val(root) == 0)
                    {
                        if (cube.GetSquareColor(1, 2, 0) == 'Y' && move_done == false)//green face change
                        {
                            Solve_moves_textbox.Text = "R U Ra U R U U Ra";
                            white_cross_textbox.Text = "R U Ra U R U U Ra";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(4, 2, 0) == 'Y' && move_done == false)//orange
                        {
                            Solve_moves_textbox.Text = "B U Ba U B U U Ba";
                            white_cross_textbox.Text = "B U Ba U B U U Ba";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(2, 2, 0) == 'Y' && move_done == false)//red face change
                        {
                            Solve_moves_textbox.Text = "F U Fa U F U U Fa";
                            white_cross_textbox.Text = "F U Fa U F U U Fa";
                            move_done = true;
                        }
                        if (cube.GetSquareColor(3, 2, 0) == 'Y' && move_done == false)//blue face change
                        {
                            Solve_moves_textbox.Text = "L U La U L U U La";
                            white_cross_textbox.Text = "L U La U L U U La";
                            move_done = true;
                        }


                        // Solve_moves_textbox.Text = "R U Ra U R U U Ra";
                        // white_cross_textbox.Text = "R U Ra U R U U Ra";




                    }
                    // the while loop 
                    if (move_done == false)// default moves if none other pattern valid
                    {
                        Solve_moves_textbox.Text = "R U Ra U R U U Ra";
                        white_cross_textbox.Text = "R U Ra U R U U Ra";
                    }
                    ans = white_cross_textbox.Text;
                    string_to_move((ans += " "));

                    final_move_textbox.Text += " " + ans;
                    num = yellow_corners_val(root);
                    Invalidate();
                }

                //  //final corners

                root = new TreeNode(cube);
                rubik_gen temp = cube;
                while (final_corners_count(root) != 4)
                {
                    solve_final_corners_function();
                    Invalidate();
                }


                //
                //  ///   // final edges 
                temp = cube;
                int edge_count = count_final_edge(temp);
                while (edge_count != 4)
                {
                    string str = solved_final_edges(temp);
                    string_to_move((str += " "));
                    final_move_textbox.Text += $" {str} ";
                    Invalidate();
                    Solve_moves_textbox.Text = str;
                    white_cross_textbox.Text = str;
                    temp = cube;
                    edge_count = count_final_edge(temp);

                }

                string_to_move((shufmove += " "));
                Invalidate();
                tabcontrol.SelectedTab = solver_page;
                timer1.Stop();
                white_cross_textbox.Text = time_count.ToString();


                string str2 = final_move_textbox.Text;
                string inputs = "";
                string srt_temp = "";
                foreach (char c in str2)// adds each move takes out the spaces
                {
                    if (c == ' ')
                    {
                        if (srt_temp.Length == 0) { continue; }
                        else { inputs += srt_temp + " "; srt_temp = ""; }
                    }
                    else if (c == ',') { continue; }
                    else
                    {
                        srt_temp += c;
                    }

                }
                inputs = Remove_irrelivent_moves(inputs);// remove uuuu or l,L'
                low_count_lable.Text = inputs + " ";

                string notation = "";
                foreach (char c in inputs)
                {
                    if (c == 'a')
                    {
                        notation += '\'';
                    }
                    else
                    {
                        notation += c;
                    }
                }
                Solve_moves_textbox.Text = notation + " ";
                final_move_textbox.Text = notation + " ";
                DateTime current = DateTime.Now;// time solution finished solving
                TimeSpan time_passed = current - time;
                double t = time_passed.TotalSeconds;// decimal time 
                t = RoundToSignificantDigits(t);//3 SF
                Time_taken_lable.Text = $"Time Taken to solve your cube: {t.ToString()}";
                

               // StreamWriter sw = File.AppendText("C:\\Users\\RAFFEC\\OneDrive - The Kings School Chester\\A-Level Com\\NEA\\cuby4\\scrambled cubes\\time_taken_file.txt");
               // sw.WriteLine(t);
               // sw.Close();
            }
            else
            {
                MessageBox.Show("The cube is already solved");
            }
        }
        private double RoundToSignificantDigits( double d) { 
            if (d == 0)
                return 0;

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
            return scale * Math.Round(d / scale, 3);
        }

        private void solve_button_Click(object sender, EventArgs e)
        {
            Solve();
            
        }
        //cleaning moves 
        static string Remove_irrelivent_moves(string input)
        {
            string pattern = " U U U U ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " Ua U ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " U Ua ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " F Fa ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " Fa F ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " Ba B ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " B Ba ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " L La ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }
            pattern = " La L ";
            while (input.Contains(pattern))
            {
                input = input.Replace(pattern, " ");
            }




            return input;

        }
        static void GenerateChildNodesRecursive(TreeNode parentNode, int depth)
        {
            if (depth == 0)
                return;

            List<TreeNode> childNodes = parentNode.State.gen_child_node(parentNode);
            foreach (var childNode in childNodes)
            {
                GenerateChildNodesRecursive(childNode, depth - 1);
            }
        }


        //maybe so that the moves box and val wont update and return the 2nd best option 
        //string find_solved_cuby(TreeNode node, int depth)
        //{
        //    // Console.WriteLine(depth);
        //    foreach (var child in node.Children)
        //    {
        //        int num = 0;
        //        child.manhattern_distance = num;
        //
        //        List<string> moves = child.move_done.ToList();
        //        string currentMoves = string.Join(", ", moves);
        //
        //        int manhatval = Convert.ToInt32(manhat_val_textbox.Text);
        //        if (manhatval > num)//make it && current cube state != node
        //        {
        //
        //            manhat_val_textbox.Text = num.ToString();
        //
        //            lowest_moves_lable.Text = currentMoves;
        //            // Console.WriteLine(lowest_manhat_val);
        //            //Console.WriteLine(currentMoves);
        //        }
        //
        //        if (check_child_solved(child))//if it is compleatly solved
        //        {
        //            // Return the moves of the solved child
        //            return currentMoves;
        //        }
        //        else
        //        {
        //            string res = find_solved_cuby(child, depth + 1);
        //            if (!res.StartsWith("#"))
        //            {
        //                // If a solution is found, return it
        //                return res;
        //            }
        //        }
        //    }
        //
        //    // If no solution is found, return the moves with the lowest manhattan value
        //
        //    return $"#";
        //}

        private static bool check_child_solved(TreeNode child)
        {
            rubik_gen cube = child.State;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        char c = cube.GetSquareColor(i, j, k);
                        char col_should_be = what_colour_is_this_num(i);
                        if (c != col_should_be)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private static char what_colour_is_this_num(int n)
        {
            switch (n)
            {
                case 0:
                    return 'W'; 
                case 1:
                    return 'G'; 
                case 2:
                    return 'R'; 
                case 3:
                    return 'B'; 
                case 4:
                    return 'O'; 
                case 5:
                    return 'Y'; 
                default:
                    return 'X';
                    

            }
            
        }
        private static char string_to_char_colour(string n)
        {
            switch (n)
            {
                case "W":
                    return 'W'; 
                case "G":
                    return 'G'; 
                case "R":
                    return 'R'; 
                case "B":
                    return 'B'; 
                case "O":
                    return 'O'; 
                case "Y":
                    return 'Y'; 
                default:
                    return 'X';
                    


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = moves_page;
        }

        //this doesnt work
       // private void Check_close_Click(object sender, EventArgs e)
       // {
       //     TreeNode root = new TreeNode(cube);
       //     TreeNode solved_cube_node = new TreeNode(solve_cube);
       //     GenerateChildNodesRecursive(solved_cube_node, 4);
       //
       //     GenerateChildNodesRecursive(root, 4);
       //     bool checj = checkitall(root, solved_cube_node);
       //     //bool checj = IsNodeInTree(root, solved_cube_node);
       //     //is_in_both_graph_textbox.Text = checj.ToString();
       //     //write a function chatgpt to see if a node from root is in solved_cube_node and iff so return true call it here
       // }
       // private bool checkitall(TreeNode root, TreeNode solvedcube)
       // {
       //     foreach (var childNode in root.Children)
       //     {
       //         if (IsNodeInTree(childNode, solvedcube) == true) { return true; }
       //         else
       //         {
       //             bool check = checkitall(childNode, solvedcube);
       //             if (check == true) { return true; }
       //         }
       //     }
       //     return false;
       // }

        // didnt use this in my solution
        private bool IsNodeInTree(TreeNode nodeToFind, TreeNode treeRoot)
        {
            if (treeRoot == null)
                return false;
       
            if (AreNodesEqual(nodeToFind, treeRoot))
                return true;
       
            foreach (var childNode in treeRoot.Children)
            {
                if (IsNodeInTree(nodeToFind, childNode))
                    return true;
            }
       
            return false;
        }

        private bool AreNodesEqual(TreeNode node1, TreeNode node2)
        {
            bool ans = (node1.State).hex_vall(node1.State) == (node2.State).hex_vall(node2.State);
            return ans;
        }

        private void White_cross_button_Click(object sender, EventArgs e)
        {
          

        }

        private string find_white_cross(TreeNode node)
        {

            // Console.WriteLine(depth);
            foreach (var child in node.Children)
            {
                int num = whitecross_val(child);


                List<string> moves = child.move_done.ToList();
                string currentMoves = string.Join(" ", moves);

                int white_count = Convert.ToInt32(low_count_lable.Text);
                if (num > white_count)//make it && current cube state != node
                {

                    low_count_lable.Text = num.ToString();

                    white_cross_textbox.Text = currentMoves;
                    Solve_moves_textbox.Text = currentMoves;
                    // Console.WriteLine(lowest_manhat_val);
                    //Console.WriteLine(currentMoves);
                }
                string hh = find_white_cross(child);
            }
            return "#";
        }
        private static void move_implicate(string str, rubik_gen cube)
        {
           
            switch (str)
            {
                case "F":
                    cube.F_move(); break;

                case "Fa":
                    cube.Fa_move(); break;

                case "B":
                    cube.B_move(); break;

                case "Ba":
                    cube.Ba_move(); break;

                case "L":
                    cube.L_move(); break;

                case "La":
                    cube.La_move(); break;

                case "U":
                    cube.U_move(); break;

                case "Ua":
                    cube.Ua_move(); break;

                case "D":
                    cube.D_move(); break;

                case "Da":
                    cube.Da_move(); break;

                case "R":
                    cube.R_move(); break;

                case "Ra":
                    cube.Ra_move(); break;

                case "P":
                    cube.U_move(); break;
                default:
                    break;
            }
        }
        // count how many white edges correct
        static int whitecross_val(TreeNode cubed)
        {
            rubik_gen cube = cubed.State;
            int i = 0;
            char a = cube.GetSquareColor(0, 0, 1);
            char b = cube.GetSquareColor(3, 0, 1);

            char c = cube.GetSquareColor(0, 1, 2);
            char d = cube.GetSquareColor(2, 0, 1);

            char e = cube.GetSquareColor(0, 2, 1);
            char f = cube.GetSquareColor(1, 0, 1);

            char g = cube.GetSquareColor(0, 1, 0);
            char h = cube.GetSquareColor(4, 0, 1);

            if (a == 'W' && b == 'B') { i += 1; }
            if (c == 'W' && d == 'R') { i += 1; }
            if (e == 'W' && f == 'G') { i += 1; }
            if (g == 'W' && h == 'O') { i += 1; }


            return i;
        }
        // count how many white corners
        static int white_corner_val(TreeNode cubed)
        {
            rubik_gen cube = cubed.State;
            int i = 0;
            string wbo = "";
            wbo += cube.GetSquareColor(0, 0, 0);
            wbo += cube.GetSquareColor(3, 0, 2);
            wbo += cube.GetSquareColor(4, 0, 0);

            string wbr = "";

            wbr += cube.GetSquareColor(0, 0, 2);
            wbr += cube.GetSquareColor(3, 0, 0);
            wbr += cube.GetSquareColor(2, 0, 2);

            string wrg = "";
            wrg += cube.GetSquareColor(0, 2, 2);
            wrg += cube.GetSquareColor(2, 0, 0);
            wrg += cube.GetSquareColor(1, 0, 2);

            string wgo = "";
            wgo += cube.GetSquareColor(0, 2, 1);
            wgo += cube.GetSquareColor(1, 0, 0);
            wgo += cube.GetSquareColor(4, 0, 2);

            if (wbo == "WBO") { i++; }
            if (wbr == "WBR") { i++; }
            if (wrg == "WRG") { i++; }
            if (wgo == "WGO") { i++; }

            return i;

        }
        // find moves to solv white corners or the closes in the root node that is passed in
        private string find_white_corner(TreeNode node)
        {

            // Console.WriteLine(depth);
            foreach (var child in node.Children)
            {
                int num = white_corner_val(child);


                List<string> moves = child.move_done.ToList();
                string currentMoves = string.Join(" ", moves);
                int white_cross = whitecross_val(child);
                //if (white_cross < 4) { string h = find_white_corner(child); }

                int white_count = Convert.ToInt32(low_count_lable.Text);
                if ((white_cross > 3) && (num > white_count))//make it && current cube state != node
                {

                    low_count_lable.Text = num.ToString();

                    white_cross_textbox.Text = currentMoves;
                    Solve_moves_textbox.Text = currentMoves;
                    // Console.WriteLine(lowest_manhat_val);
                    //Console.WriteLine(currentMoves);
                }
                string hh = find_white_corner(child);
            }
            return "#";
        }

        private void step_page_Click(object sender, EventArgs e)
        {

        }

        private void white_cross_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void white_corners_buton_Click(object sender, EventArgs e)
        {
            
        }

        private void lable_zero_Click(object sender, EventArgs e)
        {
            low_count_lable.Text = "0";
        }
        private bool is_edge_correct(int i1, int i2, int j1, int j2, int k1, int k2, rubik_gen cube, char first, char second)
        {
            char one = cube.GetSquareColor(i1, j1, k1);
            char two = cube.GetSquareColor(i2, j2, k2);
            if (one == first && two == second) { return true; }

            return false;
        }

        private void middle_edges_Click(object sender, EventArgs e)//need to add somthing incase the cube edge is swapped
        {
           
         
        }
        // my precomputed moves to check pesition of edge put it where it need to be 
        private static List<string> is_midle_edge_GO_in_correct_place(TreeNode cubed, List<string> list)
        {
            string moves = "";

            rubik_gen cur_cube = cubed.State;
            for (int i = 0; i < 4; i++)
            {


                if (cur_cube.GetSquareColor(1, 2, 1) == 'G' && cur_cube.GetSquareColor(5, 0, 1) == 'O')
                {
                    //do function for GO right
                    //cubed.move_done.Add("U"); cubed.move_done.Add("R"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ra"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Fa"); cubed.move_done.Add("U"); cubed.move_done.Add("F");
                    moves += "U R Ua Ra Ua Fa U F";
                    list.Add("U"); list.Add("R"); list.Add("Ua"); list.Add("Ra"); list.Add("Ua"); list.Add("Fa"); list.Add("U"); list.Add("F");
                }
                if ((cur_cube.GetSquareColor(1, 2, 1) == 'G') && (cur_cube.GetSquareColor(5, 0, 1) == 'R'))
                {
                    //do function for GR left 
                    // cubed.move_done.Add("Ua"); cubed.move_done.Add("La"); cubed.move_done.Add("U"); cubed.move_done.Add("L"); cubed.move_done.Add("U"); cubed.move_done.Add("F"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Fa");
                    moves += "Ua, La, U, L, U, F, Ua, Fa";
                    list.Add("Ua"); list.Add("La"); list.Add("U"); list.Add("L"); list.Add("U"); list.Add("F"); list.Add("Ua"); list.Add("Fa");
                    //list.();
                }


                //this one does not work

                cur_cube.U_move();
                //cubed.move_done.Add("U");
                list.Add("U");
            }
            //if (moves.Length == 17) { return ""; }
            return list;
        }
        private static List<string> is_midle_edge_OB_in_correct_place(TreeNode cubed, List<string> list)
        {
            string moves = "";
            rubik_gen cur_cube = cubed.State;
            for (int i = 0; i < 4; i++)
            {
                if (cur_cube.GetSquareColor(4, 2, 1) == 'O' && cur_cube.GetSquareColor(5, 1, 0) == 'B')
                {
                    //OB right
                    // cubed.move_done.Add("U"); cubed.move_done.Add("B"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ba"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ra"); cubed.move_done.Add("U"); cubed.move_done.Add("R");
                    moves += "U, B, Ua, Ba, Ua, Ra, U, R";
                    list.Add("U"); list.Add("B"); list.Add("Ua"); list.Add("Ba"); list.Add("Ua"); list.Add("Ra"); list.Add("U"); list.Add("R");
                }
                if (cur_cube.GetSquareColor(4, 2, 1) == 'O' && cur_cube.GetSquareColor(5, 1, 0) == 'G')
                {
                    //OG left
                    moves += "Ua, Fa, U, F, U, R, Ua, Ra";
                    // cubed.move_done.Add("Ua"); cubed.move_done.Add("Fa"); cubed.move_done.Add("U"); cubed.move_done.Add("F"); cubed.move_done.Add("U"); cubed.move_done.Add("R"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ra");
                    list.Add("Ua"); list.Add("Fa"); list.Add("U"); list.Add("F"); list.Add("U"); list.Add("R"); list.Add("Ua"); list.Add("Ra");
                }



                cur_cube.U_move();
                //cubed.move_done.Add("U");
                list.Add("U");

            }

            return list;
        }
        private static List<string> is_midle_edge_RG_in_correct_place(TreeNode cubed, List<string> list)
        {
            string moves = "";
            rubik_gen cur_cube = cubed.State;
            for (int i = 0; i < 4; i++)
            {
                if (cur_cube.GetSquareColor(2, 2, 1) == 'R' && cur_cube.GetSquareColor(5, 1, 2) == 'G')
                {
                    //RG right
                    // cubed.move_done.Add("U"); cubed.move_done.Add("F"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Fa"); cubed.move_done.Add("Ua"); cubed.move_done.Add("La"); cubed.move_done.Add("U"); cubed.move_done.Add("L");

                    moves += "U, F, Ua, Fa, Ua, La, U, L, ";
                    list.Add("U"); list.Add("F"); list.Add("Ua"); list.Add("Fa"); list.Add("Ua"); list.Add("La"); list.Add("U"); list.Add("L");
                }
                if (cur_cube.GetSquareColor(2, 2, 1) == 'R' && cur_cube.GetSquareColor(5, 1, 2) == 'B')
                {
                    //BR left
                    //cubed.move_done.Add("Ua"); cubed.move_done.Add("Ba"); cubed.move_done.Add("U"); cubed.move_done.Add("B"); cubed.move_done.Add("U"); cubed.move_done.Add("L"); cubed.move_done.Add("Ua"); cubed.move_done.Add("La");
                    moves += "Ua, Ba, U, B, U, L, Ua, La, ";
                    list.Add("Ua"); list.Add("Ba"); list.Add("U"); list.Add("B"); list.Add("U"); list.Add("L"); list.Add("Ua"); list.Add("La");

                }


                cur_cube.U_move();
                // cubed.move_done.Add("U");
                list.Add("U");

            }

            return list;
        }
        private static List<string> is_midle_edge_BR_in_correct_place(TreeNode cubed, List<string> list)
        {
            string moves = "";
            rubik_gen cur_cube = cubed.State;
            for (int i = 0; i < 4; i++)
            {
                if (cur_cube.GetSquareColor(3, 2, 1) == 'B' && cur_cube.GetSquareColor(5, 2, 1) == 'R')
                {
                    //BR right
                    // cubed.move_done.Add("U"); cubed.move_done.Add("L"); cubed.move_done.Add("Ua"); cubed.move_done.Add("La"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ba"); cubed.move_done.Add("U"); cubed.move_done.Add("B");
                    moves += "U, L, Ua, La, Ua, Ba, U, B, ";
                    list.Add("U"); list.Add("L"); list.Add("Ua"); list.Add("La"); list.Add("Ua"); list.Add("Ba"); list.Add("U"); list.Add("B");

                }
                if (cur_cube.GetSquareColor(3, 2, 1) == 'B' && cur_cube.GetSquareColor(5, 2, 1) == 'O')
                {
                    //BO left
                    //cubed.move_done.Add("Ua"); cubed.move_done.Add("Ra"); cubed.move_done.Add("U"); cubed.move_done.Add("R"); cubed.move_done.Add("U"); cubed.move_done.Add("B"); cubed.move_done.Add("Ua"); cubed.move_done.Add("Ba");

                    moves += "Ua, Ra, U, R, U, B, Ua, Ba, ";
                    list.Add("Ua"); list.Add("Ra"); list.Add("U"); list.Add("R"); list.Add("U"); list.Add("B"); list.Add("Ua"); list.Add("Ba");

                }



                cur_cube.U_move();
                //cubed.move_done.Add("U");
                list.Add("U");

            }

            return list;
        }
        /// <summary>
        /// /////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yellow_cross_button_Click(object sender, EventArgs e)
        {
        }

        //high change that function below will result in a set of moves that is the same as the gievn root node
        private string find_yellow_cross(TreeNode node)
        {
            foreach (var child in node.Children)
            {
                int white_cor_val = white_corner_val(child);
                int white_cross = whitecross_val(child);
                int mid_edge_val = middle_edge_count(child);

                int num = count_yellow_cross(child);

                List<string> moves = child.move_done.ToList();
                string currentMoves = string.Join(", ", moves);

                //if (white_cross < 4) { string h = find_white_corner(child); }

                int yellow_cross_count = Convert.ToInt32(low_count_lable.Text);
                if ((white_cross > 3) && (white_cor_val > 3) && (mid_edge_val > 3) && (num > yellow_cross_count))//make it && current cube state != node
                {

                    low_count_lable.Text = num.ToString();

                    white_cross_textbox.Text = currentMoves;
                    Solve_moves_textbox.Text = currentMoves;
                    // Console.WriteLine(lowest_manhat_val);
                    //Console.WriteLine(currentMoves);
                }
                string hh = find_yellow_cross(child);
            }
            return "#";

        }
        // count how many yellow edges are there
        private int count_yellow_cross(TreeNode cubed)
        {
            rubik_gen cube = cubed.State;
            int i = 0;
            //char a = cube.GetSquareColor(1, 2, 1);//G
            char b = cube.GetSquareColor(5, 0, 1);//Y

            char c = cube.GetSquareColor(5, 1, 2);//Y
                                                  // char d = cube.GetSquareColor(2, 2, 1);//r

            char e = cube.GetSquareColor(5, 1, 0);//Y
            //char f = cube.GetSquareColor(4, 2, 1);//O

            char g = cube.GetSquareColor(5, 2, 1);//Y
            //char h = cube.GetSquareColor(3, 2, 1);//B

            if (b == 'Y') { i += 1; }
            if (c == 'Y') { i += 1; }
            if (e == 'Y') { i += 1; }
            if (g == 'Y') { i += 1; }

            return i;
        }
        // count how many middle edges correct
        private int middle_edge_count(TreeNode cubed)
        {
            rubik_gen cube = cubed.State;
            int i = 0;
            string rb = "";
            rb += cube.GetSquareColor(2, 1, 2);
            rb += cube.GetSquareColor(3, 1, 0);
            string bo = "";
            bo += cube.GetSquareColor(3, 1, 2);
            bo += cube.GetSquareColor(4, 1, 0);
            string og = "";
            og += cube.GetSquareColor(4, 1, 2);
            og += cube.GetSquareColor(1, 1, 0);
            string gr = "";
            gr += cube.GetSquareColor(1, 1, 2);
            gr += cube.GetSquareColor(2, 1, 0);
            if (rb == "RB") { i++; RB_edge_textbox.Text = "RB Y"; }
            if (bo == "BO") { i++; BO_edge_textbox.Text = "BO Y"; }
            if (og == "OG") { i++; og_edge_textbox.Text = "OG Y"; }
            if (gr == "GR") { i++; gb_edge_textbox.Text = "GR Y"; }
            return i;
        }
        // private void find_mid_edges(TreeNode node)
        // {
        //
        //     // Console.WriteLine(depth);
        //     foreach (var child in node.Children)
        //     {
        //         int num = middle_edge_count(child);
        //
        //
        //         List<string> moves = child.move_done.ToList();
        //         string currentMoves = string.Join(", ", moves);
        //         int white_cross = whitecross_val(child);
        //         int white_corner_val = whitecross_val(child);
        //         //if (white_cross < 4) { string h = find_white_corner(child); }
        //
        //         int white_count = Convert.ToInt32(low_count_lable.Text);
        //         if ((white_cross > 3) &&(white_corner_val>3)&& (num > white_count))//make it && current cube state != node
        //         {
        //
        //             low_count_lable.Text = num.ToString();
        //
        //             white_cross_textbox.Text = currentMoves;
        //             Solve_moves_textbox.Text = currentMoves;
        //             // Console.WriteLine(lowest_manhat_val);
        //             //Console.WriteLine(currentMoves);
        //         }
        //        find_mid_edges(child);
        //     }
        //     
        // }

        private void gb_edge_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        //note for this yellow corners dont have to be in the right spot just have a yellow side on the
        //the yellow face
        private void Y_corners_button_Click(object sender, EventArgs e)
        {
           

        }
        // count how many yellow corners are there
        private int yellow_corners_val(TreeNode cubed)
        {
            rubik_gen cube = cubed.State;
            int i = 0;

            char y1 = cube.GetSquareColor(5, 2, 2);
            char y2 = cube.GetSquareColor(5, 0, 2);
            char y3 = cube.GetSquareColor(5, 0, 0);
            char y4 = cube.GetSquareColor(5, 2, 0);

            if (y4 == 'Y') { i++; }
            if (y3 == 'Y') { i++; }
            if (y2 == 'Y') { i++; }
            if (y1 == 'Y') { i++; }

            return i;
        }

        private void final_corners_button_Click(object sender, EventArgs e)
        {


            rubik_gen temp = cube;
            string moves = final_corners_correct_move(temp);
            Solve_moves_textbox.Text = moves;
            white_cross_textbox.Text = moves;


        }
        // move tables 
        private string final_corners_correct_move(rubik_gen temp)
        {
            
            TreeNode root = new TreeNode(temp);
            

            temp = cube;

            string corners = what_two_corners_correct(temp);
            string return_string = "";
            //for (int i = 0; i < 4; i++)
            //{
            //    root = new TreeNode(temp);
            //    int county = final_corners_count(root);
            //    MessageBox.Show($"{county}");
            corners = what_two_corners_correct(temp);
            // if (corners.Length == 0) { }
            if (corners.Contains("O")) { return (return_string += " Fa L Fa R R F La Fa R R F F Ua "); }
            if (corners.Contains("G")) { return (return_string += " La B La F F L Ba La F F L L Ua "); }
            if (corners.Contains("R")) { return (return_string += " Ba R Ba L L B Ra Ba L L B B Ua "); }
            if (corners.Contains("B")) { return (return_string += " Ra F Ra B B R Fa Ra B B R R Ua "); }
            //return_string += "P ";
            //temp.U_move();
            //corners = what_two_corners_correct(temp);
            //}

            return "Ra F Ra B B R Fa Ra B B R R Ua ";

        }
        private bool is_this_edge_correct(TreeNode node, int i1, int i2, int j1, int j2, int k1, int k2)
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
        private string what_two_corners_correct(rubik_gen temp)
        {

            bool OGY = false;
            bool OBY = false;
            bool RBY = false;
            bool RGY = false;
            string return_string = "";

            TreeNode cubed = new TreeNode(temp);
            if (is_this_edge_correct(cubed, 4, 1, 2, 2, 2, 0)) { OGY = true; }// OGY
            if (is_this_edge_correct(cubed, 4, 3, 2, 2, 0, 2)) { OBY = true; }// OBY
            if (is_this_edge_correct(cubed, 2, 3, 2, 2, 2, 0)) { RBY = true; }// RBY
            if (is_this_edge_correct(cubed, 2, 1, 2, 2, 0, 2)) { RGY = true; }//RGY


            if (OGY == true && OBY == true) { return (return_string += "O"); }
            if (OGY == true && RGY == true) { return (return_string += "G"); }
            if (RBY == true && RGY == true) { return (return_string += "R"); }
            if (OBY == true && RBY == true) { return (return_string += "B"); }
            //temp.U_move();
            //return_string += "U";



            return "";
        }
        private int final_corners_count(TreeNode cube)
        {
            int i = 0;
            //doing only edge as at this point we know that the top face is yellow
            if (is_this_edge_correct(cube, 4, 1, 2, 2, 2, 0)) { i++; }//OGY
            if (is_this_edge_correct(cube, 4, 3, 2, 2, 0, 2)) { i++; }//OBY
            if (is_this_edge_correct(cube, 2, 3, 2, 2, 2, 0)) { i++; }//RBY
            if (is_this_edge_correct(cube, 2, 1, 2, 2, 0, 2)) { i++; }//RGY


            return i;
        }

        private void final_corners_button_Click_1(object sender, EventArgs e)
        {
           

        }
        private void solve_final_corners_function()
        {
            TreeNode root = new TreeNode(cube);
            rubik_gen temp = cube;

            int count = final_corners_count(root);
            //while (count != 4)
            //{
            if (count != 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    root = new TreeNode(cube);
                    temp = cube;
                    count = final_corners_count(root);
                    if (count == 2)
                    {
                        string moves = final_corners_correct_move(temp);
                        //MessageBox.Show($"{moves} this is what is returned");
                        final_move_textbox.Text += $" {moves} ";
                        string_to_move((moves += " "));
                        Invalidate();
                        break;
                        //count = final_corners_count(root);
                    }
                    else
                    {
                        cube.U_move();
                        final_move_textbox.Text += "U ";
                        Invalidate();
                    }

                }

            }
        }

        private void final_edges_Click(object sender, EventArgs e)
        {
           
        }
        // last step
        // move tables
        private string solved_final_edges(rubik_gen temp)
        {

            TreeNode current = new TreeNode(temp);
            string moves = "";
            bool is_solved = check_child_solved(current);
            int edge_count = count_final_edge(temp);
            if (is_solved == false)
            {
                if (edge_count == 0) { return "F F U L Ra F F La R U F F"; }
                else
                {
                    string what_edge = what_edge_correct(temp);
                    if (what_edge == "B")
                    {
                        if (temp.GetSquareColor(2, 2, 1) == 'G')
                        {
                            return "F F Ua L Ra F F La R Ua F F";
                        }
                        if (temp.GetSquareColor(4, 2, 1) == 'G')
                        {
                            return "F F U L Ra F F La R U F F";
                        }
                    }
                    if (what_edge == "O")
                    {
                        if (temp.GetSquareColor(3, 2, 1) == 'R')
                        {
                            return "L L U B Fa L L Ba F U L L";
                        }
                        if (temp.GetSquareColor(1, 2, 1) == 'R')
                        {
                            return "L L Ua B Fa L L Ba F Ua L L";
                        }
                    }
                    if (what_edge == "G")
                    {
                        if (temp.GetSquareColor(4, 2, 1) == 'B')
                        {
                            return "Ba Ba Ua R La Ba Ba Ra L Ua Ba Ba";
                        }
                        if (temp.GetSquareColor(2, 2, 1) == 'B')
                        {
                            return "Ba Ba U R La Ba Ba Ra L U Ba Ba";
                        }
                    }
                    if (what_edge == "R")
                    {
                        if (temp.GetSquareColor(1, 2, 1) == 'O')
                        {
                            return "R R Ua F Ba R R Fa B Ua R R";
                        }
                        if (temp.GetSquareColor(3, 2, 1) == 'O')
                        {
                            return "R R U F Ba R R Fa B U R R";
                        }
                    }
                }
            }
            return moves;
        }
        private string what_edge_correct(rubik_gen temp)
        {

            if (temp.GetSquareColor(3, 2, 1) == 'B') { return "B"; }
            if (temp.GetSquareColor(4, 2, 1) == 'O') { return "O"; }
            if (temp.GetSquareColor(1, 2, 1) == 'G') { return "G"; }
            if (temp.GetSquareColor(2, 2, 1) == 'R') { return "R"; }
            return "error";
        }
        private int count_final_edge(rubik_gen temp)
        {
            int i = 0;
            if (temp.GetSquareColor(3, 2, 1) == 'B') { i++; }
            if (temp.GetSquareColor(4, 2, 1) == 'O') { i++; }
            if (temp.GetSquareColor(1, 2, 1) == 'G') { i++; }
            if (temp.GetSquareColor(2, 2, 1) == 'R') { i++; }
            return i;
        }

        private void Solve_final_button_Click(object sender, EventArgs e)
        {
            shuffle_moves_textbox.Text = "";

            cube_to_solve = cube;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            
            DialogResult result = openFileDialog1.ShowDialog();

            // only do it if ok is recived
            if (result == DialogResult.OK)
            {
                // Open the selected file 
                string filePath = openFileDialog1.FileName;


                // Read the contents of the file into a list of strings to put each line into
                List<string> lines = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)// read all of the lines
                        {
                            lines.Add(line);
                        }
                    }

                    if (is_valid_file_selected(lines) == true)
                    {





                        // Do something with the list of strings, e.g., display them in a ListBox.
                        final_move_textbox.Text = "";
                        Solve_moves_textbox.Text = "";
                        int count = 0;

                        shuffle_moves_textbox.Text = lines[54] + " ";

                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                for (int k = 0; k < 3; k++)
                                {

                                    char line_char = string_to_char_colour(lines[count]);

                                    cube.SetSquareColor(i, j, k, line_char);
                                    count++;
                                    //MessageBox.Show(line_char.ToString());

                                }
                            }
                        }

                        Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("This file is not a valid cube file");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }

                
               
            }
        }
        // validation of the chosen cube text file
        private bool is_valid_file_selected(List<string> lines)
        {
            if(lines.Count != 55) {  return false;}
            string[] correct = { "W", "G", "R", "B", "O", "Y" };
            int correct_count = 0;
            for(int i = 4; i<53 ; i = i + 9)
            {
                if (lines[i] != correct[correct_count]) { return false; }
                correct_count++;
            }

            return true;
        }

        
        private void string_to_move(string str)
        {
            string h = "";

            foreach (char c in str)
            {
                if (c != ' ' && c != ',') { h += c; }
                if (c == ' ') { move_implicate(h, cube); h = ""; }
            }
        }

        private void test_button_Click(object sender, EventArgs e)
        {

          
        }

        //tried using a timer and thread delay but the foreach loop kept compleating too fast that it woulding give it the chance
        private async void step_through_button_Click(object sender, EventArgs e)
        {
            step_though();

        }

        private void step_2_button_Click(object sender, EventArgs e)
        {
            TreeNode curcube = new TreeNode(cube);
            if (check_child_solved(curcube) == false) { step_though(); }
            

        }
        //show each move to the net below
        private async void step_though()
        {
            
            string inputs = low_count_lable.Text;
            equeue<string> queue = new equeue<string>(200);


            string h = "";
            int count = 0;
            //TreeNode curcube = new TreeNode(cube);
            // bool issolve = check_child_solved(curcube);//treenide
            foreach (char c in inputs)
            {
                if (c != ' ' && c != ',') { h += c; }
                if (c == ' ')
                {
                    queue.Enqueue(h);
                    
                    h = "";
                    count++;
                }
            }
           
            
            int count2 = 0;
            for (int i =0; i< count; i++)
            {
                string move = queue.Dequeue();
                
                
                move_implicate(move, cube);
               
                count2++;
                Total_moves_done_lable.Text = $"Moves count: {count2}";
                Invalidate();
                int delay = hScrollBar1.Value;
                await Task.Delay(delay);


            }
            shuffle_moves_textbox.Text = "";
        }

        private void br_edge_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }

        private void Solve_moves_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Time_taken_Click(object sender, EventArgs e)
        {

        }

        // read the tree and file to work out quickest moves
        private void time_check_button_Click(object sender, EventArgs e)
        {
            Times_BimTree bst = new Times_BimTree();



            var logFile = File.ReadAllLines("\"C:\\Users\\RAFFEC\\OneDrive - The Kings School Chester\\A-Level Com\\NEA\\cuby4\\cuby_5\\scrambled cubes\\time_taken_file.txt\"");
            foreach (var s in logFile)
            {
                double num = Convert.ToDouble(s);
                bst.Insert(num);
                //Console.WriteLine(s);
            }

            Console.WriteLine("Inorder traversal of the BST:");
            string st = bst.Inorder();
            MessageBox.Show($"Quickest time to solve cube \n{st}");

           
        }

        private void solver_page_Click(object sender, EventArgs e)
        {

        }
    }
}



