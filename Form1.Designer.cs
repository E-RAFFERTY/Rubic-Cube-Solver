namespace cuby_5
{
    partial class Cube_solver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cube_solver));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.moves_page = new System.Windows.Forms.TabPage();
            this.Solve_moves_textbox = new System.Windows.Forms.TextBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.Solve_final_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.Ra_button = new System.Windows.Forms.Button();
            this.R_button = new System.Windows.Forms.Button();
            this.La_button = new System.Windows.Forms.Button();
            this.L_button = new System.Windows.Forms.Button();
            this.Da_button = new System.Windows.Forms.Button();
            this.D_button = new System.Windows.Forms.Button();
            this.Ua_button = new System.Windows.Forms.Button();
            this.U_button = new System.Windows.Forms.Button();
            this.Ba_button = new System.Windows.Forms.Button();
            this.B_button = new System.Windows.Forms.Button();
            this.Fa_button = new System.Windows.Forms.Button();
            this.F_button = new System.Windows.Forms.Button();
            this.solver_page = new System.Windows.Forms.TabPage();
            this.time_check_button = new System.Windows.Forms.Button();
            this.Time_taken_lable = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.step_2_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.final_move_textbox = new System.Windows.Forms.TextBox();
            this.message_lable = new System.Windows.Forms.Label();
            this.step_page = new System.Windows.Forms.TabPage();
            this.back_button = new System.Windows.Forms.Button();
            this.shuffle_moves_textbox = new System.Windows.Forms.TextBox();
            this.step_through_button = new System.Windows.Forms.Button();
            this.solved_moves_textbox = new System.Windows.Forms.TextBox();
            this.test_button = new System.Windows.Forms.Button();
            this.final_edges = new System.Windows.Forms.Button();
            this.final_corners_button = new System.Windows.Forms.Button();
            this.Y_corners_button = new System.Windows.Forms.Button();
            this.yellow_cross_button = new System.Windows.Forms.Button();
            this.gb_edge_textbox = new System.Windows.Forms.TextBox();
            this.og_edge_textbox = new System.Windows.Forms.TextBox();
            this.br_edge_textbox = new System.Windows.Forms.TextBox();
            this.BO_edge_textbox = new System.Windows.Forms.TextBox();
            this.RB_edge_textbox = new System.Windows.Forms.TextBox();
            this.middle_edges = new System.Windows.Forms.Button();
            this.lable_zero = new System.Windows.Forms.Button();
            this.white_corners_buton = new System.Windows.Forms.Button();
            this.low_count_lable = new System.Windows.Forms.Label();
            this.white_cross_textbox = new System.Windows.Forms.TextBox();
            this.White_cross_button = new System.Windows.Forms.Button();
            this.Total_moves_done_lable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabcontrol.SuspendLayout();
            this.moves_page.SuspendLayout();
            this.solver_page.SuspendLayout();
            this.step_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.moves_page);
            this.tabcontrol.Controls.Add(this.solver_page);
            this.tabcontrol.Controls.Add(this.step_page);
            this.tabcontrol.Location = new System.Drawing.Point(1252, 3);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(484, 1152);
            this.tabcontrol.TabIndex = 0;
            // 
            // moves_page
            // 
            this.moves_page.BackColor = System.Drawing.Color.Silver;
            this.moves_page.Controls.Add(this.Solve_moves_textbox);
            this.moves_page.Controls.Add(this.solve_button);
            this.moves_page.Controls.Add(this.Solve_final_button);
            this.moves_page.Controls.Add(this.reset_button);
            this.moves_page.Controls.Add(this.shuffle_button);
            this.moves_page.Controls.Add(this.Ra_button);
            this.moves_page.Controls.Add(this.R_button);
            this.moves_page.Controls.Add(this.La_button);
            this.moves_page.Controls.Add(this.L_button);
            this.moves_page.Controls.Add(this.Da_button);
            this.moves_page.Controls.Add(this.D_button);
            this.moves_page.Controls.Add(this.Ua_button);
            this.moves_page.Controls.Add(this.U_button);
            this.moves_page.Controls.Add(this.Ba_button);
            this.moves_page.Controls.Add(this.B_button);
            this.moves_page.Controls.Add(this.Fa_button);
            this.moves_page.Controls.Add(this.F_button);
            this.moves_page.Location = new System.Drawing.Point(8, 46);
            this.moves_page.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.moves_page.Name = "moves_page";
            this.moves_page.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.moves_page.Size = new System.Drawing.Size(468, 1098);
            this.moves_page.TabIndex = 0;
            this.moves_page.Text = "Moves";
            this.moves_page.Click += new System.EventHandler(this.moves_page_Click);
            // 
            // Solve_moves_textbox
            // 
            this.Solve_moves_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Solve_moves_textbox.Location = new System.Drawing.Point(16, 749);
            this.Solve_moves_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Solve_moves_textbox.Multiline = true;
            this.Solve_moves_textbox.Name = "Solve_moves_textbox";
            this.Solve_moves_textbox.Size = new System.Drawing.Size(445, 343);
            this.Solve_moves_textbox.TabIndex = 15;
            this.Solve_moves_textbox.TextChanged += new System.EventHandler(this.Solve_moves_textbox_TextChanged);
            // 
            // solve_button
            // 
            this.solve_button.Location = new System.Drawing.Point(139, 594);
            this.solve_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(140, 56);
            this.solve_button.TabIndex = 14;
            this.solve_button.Text = "Solve";
            this.solve_button.UseVisualStyleBackColor = true;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // Solve_final_button
            // 
            this.Solve_final_button.Location = new System.Drawing.Point(139, 675);
            this.Solve_final_button.Name = "Solve_final_button";
            this.Solve_final_button.Size = new System.Drawing.Size(140, 56);
            this.Solve_final_button.TabIndex = 15;
            this.Solve_final_button.Text = "Load Cube";
            this.Solve_final_button.UseVisualStyleBackColor = true;
            this.Solve_final_button.Click += new System.EventHandler(this.Solve_final_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(231, 519);
            this.reset_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(140, 56);
            this.reset_button.TabIndex = 13;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // shuffle_button
            // 
            this.shuffle_button.Location = new System.Drawing.Point(39, 519);
            this.shuffle_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(140, 56);
            this.shuffle_button.TabIndex = 12;
            this.shuffle_button.Text = "Shuffle";
            this.shuffle_button.UseVisualStyleBackColor = true;
            this.shuffle_button.Click += new System.EventHandler(this.shuffle_button_Click);
            // 
            // Ra_button
            // 
            this.Ra_button.Location = new System.Drawing.Point(231, 440);
            this.Ra_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Ra_button.Name = "Ra_button";
            this.Ra_button.Size = new System.Drawing.Size(140, 56);
            this.Ra_button.TabIndex = 11;
            this.Ra_button.Text = "R\' Move";
            this.Ra_button.UseVisualStyleBackColor = true;
            this.Ra_button.Click += new System.EventHandler(this.Ra_button_Click);
            // 
            // R_button
            // 
            this.R_button.Location = new System.Drawing.Point(39, 438);
            this.R_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.R_button.Name = "R_button";
            this.R_button.Size = new System.Drawing.Size(140, 56);
            this.R_button.TabIndex = 10;
            this.R_button.Text = "R Move";
            this.R_button.UseVisualStyleBackColor = true;
            this.R_button.Click += new System.EventHandler(this.R_button_Click);
            // 
            // La_button
            // 
            this.La_button.Location = new System.Drawing.Point(231, 362);
            this.La_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.La_button.Name = "La_button";
            this.La_button.Size = new System.Drawing.Size(140, 56);
            this.La_button.TabIndex = 9;
            this.La_button.Text = "L\' Move";
            this.La_button.UseVisualStyleBackColor = true;
            this.La_button.Click += new System.EventHandler(this.La_button_Click);
            // 
            // L_button
            // 
            this.L_button.Location = new System.Drawing.Point(39, 362);
            this.L_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.L_button.Name = "L_button";
            this.L_button.Size = new System.Drawing.Size(140, 56);
            this.L_button.TabIndex = 8;
            this.L_button.Text = "L Move";
            this.L_button.UseVisualStyleBackColor = true;
            this.L_button.Click += new System.EventHandler(this.L_button_Click);
            // 
            // Da_button
            // 
            this.Da_button.Location = new System.Drawing.Point(234, 278);
            this.Da_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Da_button.Name = "Da_button";
            this.Da_button.Size = new System.Drawing.Size(140, 56);
            this.Da_button.TabIndex = 7;
            this.Da_button.Text = "D\' Move";
            this.Da_button.UseVisualStyleBackColor = true;
            this.Da_button.Click += new System.EventHandler(this.Da_button_Click);
            // 
            // D_button
            // 
            this.D_button.Location = new System.Drawing.Point(39, 278);
            this.D_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(140, 56);
            this.D_button.TabIndex = 6;
            this.D_button.Text = "D Move";
            this.D_button.UseVisualStyleBackColor = true;
            this.D_button.Click += new System.EventHandler(this.D_button_Click);
            // 
            // Ua_button
            // 
            this.Ua_button.Location = new System.Drawing.Point(234, 196);
            this.Ua_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Ua_button.Name = "Ua_button";
            this.Ua_button.Size = new System.Drawing.Size(140, 56);
            this.Ua_button.TabIndex = 5;
            this.Ua_button.Text = "U\' Move";
            this.Ua_button.UseVisualStyleBackColor = true;
            this.Ua_button.Click += new System.EventHandler(this.Ua_button_Click);
            // 
            // U_button
            // 
            this.U_button.Location = new System.Drawing.Point(39, 196);
            this.U_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.U_button.Name = "U_button";
            this.U_button.Size = new System.Drawing.Size(140, 56);
            this.U_button.TabIndex = 4;
            this.U_button.Text = "U Move";
            this.U_button.UseVisualStyleBackColor = true;
            this.U_button.Click += new System.EventHandler(this.U_button_Click);
            // 
            // Ba_button
            // 
            this.Ba_button.Location = new System.Drawing.Point(234, 111);
            this.Ba_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Ba_button.Name = "Ba_button";
            this.Ba_button.Size = new System.Drawing.Size(140, 56);
            this.Ba_button.TabIndex = 3;
            this.Ba_button.Text = "B\' Move";
            this.Ba_button.UseVisualStyleBackColor = true;
            this.Ba_button.Click += new System.EventHandler(this.Ba_button_Click);
            // 
            // B_button
            // 
            this.B_button.Location = new System.Drawing.Point(39, 111);
            this.B_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B_button.Name = "B_button";
            this.B_button.Size = new System.Drawing.Size(140, 56);
            this.B_button.TabIndex = 2;
            this.B_button.Text = "B Move";
            this.B_button.UseVisualStyleBackColor = true;
            this.B_button.Click += new System.EventHandler(this.B_button_Click);
            // 
            // Fa_button
            // 
            this.Fa_button.Location = new System.Drawing.Point(234, 33);
            this.Fa_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Fa_button.Name = "Fa_button";
            this.Fa_button.Size = new System.Drawing.Size(140, 56);
            this.Fa_button.TabIndex = 1;
            this.Fa_button.Text = "F\' Move";
            this.Fa_button.UseVisualStyleBackColor = true;
            this.Fa_button.Click += new System.EventHandler(this.Fa_button_Click);
            // 
            // F_button
            // 
            this.F_button.Location = new System.Drawing.Point(39, 33);
            this.F_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.F_button.Name = "F_button";
            this.F_button.Size = new System.Drawing.Size(140, 56);
            this.F_button.TabIndex = 0;
            this.F_button.Text = "F Move";
            this.F_button.UseVisualStyleBackColor = true;
            this.F_button.Click += new System.EventHandler(this.F_button_Click);
            // 
            // solver_page
            // 
            this.solver_page.AutoScroll = true;
            this.solver_page.BackColor = System.Drawing.Color.Silver;
            this.solver_page.CausesValidation = false;
            this.solver_page.Controls.Add(this.time_check_button);
            this.solver_page.Controls.Add(this.Time_taken_lable);
            this.solver_page.Controls.Add(this.hScrollBar1);
            this.solver_page.Controls.Add(this.step_2_button);
            this.solver_page.Controls.Add(this.button1);
            this.solver_page.Controls.Add(this.final_move_textbox);
            this.solver_page.Controls.Add(this.message_lable);
            this.solver_page.Location = new System.Drawing.Point(8, 46);
            this.solver_page.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.solver_page.Name = "solver_page";
            this.solver_page.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.solver_page.Size = new System.Drawing.Size(468, 1098);
            this.solver_page.TabIndex = 1;
            this.solver_page.Text = "Solver";
            this.solver_page.Click += new System.EventHandler(this.solver_page_Click);
            // 
            // time_check_button
            // 
            this.time_check_button.Location = new System.Drawing.Point(163, 818);
            this.time_check_button.Name = "time_check_button";
            this.time_check_button.Size = new System.Drawing.Size(150, 46);
            this.time_check_button.TabIndex = 21;
            this.time_check_button.Text = "Top Times";
            this.time_check_button.UseVisualStyleBackColor = true;
            this.time_check_button.Click += new System.EventHandler(this.time_check_button_Click);
            // 
            // Time_taken_lable
            // 
            this.Time_taken_lable.AutoSize = true;
            this.Time_taken_lable.Location = new System.Drawing.Point(10, 21);
            this.Time_taken_lable.Name = "Time_taken_lable";
            this.Time_taken_lable.Size = new System.Drawing.Size(344, 32);
            this.Time_taken_lable.TabIndex = 20;
            this.Time_taken_lable.Text = "Time Taken to solve you cube: ";
            this.Time_taken_lable.Click += new System.EventHandler(this.Time_taken_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(10, 694);
            this.hScrollBar1.Maximum = 2000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(450, 54);
            this.hScrollBar1.TabIndex = 2;
            // 
            // step_2_button
            // 
            this.step_2_button.Location = new System.Drawing.Point(163, 620);
            this.step_2_button.Name = "step_2_button";
            this.step_2_button.Size = new System.Drawing.Size(140, 56);
            this.step_2_button.TabIndex = 19;
            this.step_2_button.Text = "step";
            this.step_2_button.UseVisualStyleBackColor = true;
            this.step_2_button.Click += new System.EventHandler(this.step_2_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 1004);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 45);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // final_move_textbox
            // 
            this.final_move_textbox.Location = new System.Drawing.Point(42, 118);
            this.final_move_textbox.Multiline = true;
            this.final_move_textbox.Name = "final_move_textbox";
            this.final_move_textbox.Size = new System.Drawing.Size(394, 460);
            this.final_move_textbox.TabIndex = 8;
            // 
            // message_lable
            // 
            this.message_lable.AutoSize = true;
            this.message_lable.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_lable.Location = new System.Drawing.Point(2, 53);
            this.message_lable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.message_lable.Name = "message_lable";
            this.message_lable.Size = new System.Drawing.Size(450, 50);
            this.message_lable.TabIndex = 1;
            this.message_lable.Text = "Moves to your cube solve:";
            // 
            // step_page
            // 
            this.step_page.BackColor = System.Drawing.Color.Silver;
            this.step_page.Controls.Add(this.back_button);
            this.step_page.Controls.Add(this.shuffle_moves_textbox);
            this.step_page.Controls.Add(this.step_through_button);
            this.step_page.Controls.Add(this.solved_moves_textbox);
            this.step_page.Controls.Add(this.test_button);
            this.step_page.Controls.Add(this.final_edges);
            this.step_page.Controls.Add(this.final_corners_button);
            this.step_page.Controls.Add(this.Y_corners_button);
            this.step_page.Controls.Add(this.yellow_cross_button);
            this.step_page.Controls.Add(this.gb_edge_textbox);
            this.step_page.Controls.Add(this.og_edge_textbox);
            this.step_page.Controls.Add(this.br_edge_textbox);
            this.step_page.Controls.Add(this.BO_edge_textbox);
            this.step_page.Controls.Add(this.RB_edge_textbox);
            this.step_page.Controls.Add(this.middle_edges);
            this.step_page.Controls.Add(this.lable_zero);
            this.step_page.Controls.Add(this.white_corners_buton);
            this.step_page.Controls.Add(this.low_count_lable);
            this.step_page.Controls.Add(this.white_cross_textbox);
            this.step_page.Controls.Add(this.White_cross_button);
            this.step_page.Location = new System.Drawing.Point(8, 46);
            this.step_page.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.step_page.Name = "step_page";
            this.step_page.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.step_page.Size = new System.Drawing.Size(468, 1098);
            this.step_page.TabIndex = 2;
            this.step_page.Text = "step page";
            this.step_page.Click += new System.EventHandler(this.step_page_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(240, 844);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 46);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // shuffle_moves_textbox
            // 
            this.shuffle_moves_textbox.Location = new System.Drawing.Point(44, 815);
            this.shuffle_moves_textbox.Name = "shuffle_moves_textbox";
            this.shuffle_moves_textbox.Size = new System.Drawing.Size(199, 39);
            this.shuffle_moves_textbox.TabIndex = 17;
            this.shuffle_moves_textbox.Text = " ";
            // 
            // step_through_button
            // 
            this.step_through_button.Location = new System.Drawing.Point(250, 521);
            this.step_through_button.Name = "step_through_button";
            this.step_through_button.Size = new System.Drawing.Size(140, 56);
            this.step_through_button.TabIndex = 18;
            this.step_through_button.Text = "step";
            this.step_through_button.UseVisualStyleBackColor = true;
            this.step_through_button.Click += new System.EventHandler(this.step_through_button_Click);
            // 
            // solved_moves_textbox
            // 
            this.solved_moves_textbox.Location = new System.Drawing.Point(69, 954);
            this.solved_moves_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.solved_moves_textbox.Name = "solved_moves_textbox";
            this.solved_moves_textbox.Size = new System.Drawing.Size(303, 39);
            this.solved_moves_textbox.TabIndex = 0;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(239, 363);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(151, 46);
            this.test_button.TabIndex = 16;
            this.test_button.Text = "test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // final_edges
            // 
            this.final_edges.Location = new System.Drawing.Point(25, 711);
            this.final_edges.Name = "final_edges";
            this.final_edges.Size = new System.Drawing.Size(143, 50);
            this.final_edges.TabIndex = 14;
            this.final_edges.Text = "F edges";
            this.final_edges.UseVisualStyleBackColor = true;
            this.final_edges.Click += new System.EventHandler(this.final_edges_Click);
            // 
            // final_corners_button
            // 
            this.final_corners_button.Location = new System.Drawing.Point(21, 621);
            this.final_corners_button.Name = "final_corners_button";
            this.final_corners_button.Size = new System.Drawing.Size(151, 46);
            this.final_corners_button.TabIndex = 13;
            this.final_corners_button.Text = "F corners";
            this.final_corners_button.UseVisualStyleBackColor = true;
            this.final_corners_button.Click += new System.EventHandler(this.final_corners_button_Click_1);
            // 
            // Y_corners_button
            // 
            this.Y_corners_button.Location = new System.Drawing.Point(21, 531);
            this.Y_corners_button.Name = "Y_corners_button";
            this.Y_corners_button.Size = new System.Drawing.Size(151, 46);
            this.Y_corners_button.TabIndex = 12;
            this.Y_corners_button.Text = "Y corners";
            this.Y_corners_button.UseVisualStyleBackColor = true;
            this.Y_corners_button.Click += new System.EventHandler(this.Y_corners_button_Click);
            // 
            // yellow_cross_button
            // 
            this.yellow_cross_button.Location = new System.Drawing.Point(21, 426);
            this.yellow_cross_button.Name = "yellow_cross_button";
            this.yellow_cross_button.Size = new System.Drawing.Size(151, 46);
            this.yellow_cross_button.TabIndex = 11;
            this.yellow_cross_button.Text = "Y Cross";
            this.yellow_cross_button.UseVisualStyleBackColor = true;
            this.yellow_cross_button.Click += new System.EventHandler(this.yellow_cross_button_Click);
            // 
            // gb_edge_textbox
            // 
            this.gb_edge_textbox.Location = new System.Drawing.Point(361, 85);
            this.gb_edge_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.gb_edge_textbox.Name = "gb_edge_textbox";
            this.gb_edge_textbox.Size = new System.Drawing.Size(78, 39);
            this.gb_edge_textbox.TabIndex = 10;
            this.gb_edge_textbox.Text = "GR N";
            this.gb_edge_textbox.TextChanged += new System.EventHandler(this.gb_edge_textbox_TextChanged);
            // 
            // og_edge_textbox
            // 
            this.og_edge_textbox.Location = new System.Drawing.Point(373, 31);
            this.og_edge_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.og_edge_textbox.Name = "og_edge_textbox";
            this.og_edge_textbox.Size = new System.Drawing.Size(78, 39);
            this.og_edge_textbox.TabIndex = 9;
            this.og_edge_textbox.Text = "OG N";
            // 
            // br_edge_textbox
            // 
            this.br_edge_textbox.Location = new System.Drawing.Point(373, 733);
            this.br_edge_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.br_edge_textbox.Name = "br_edge_textbox";
            this.br_edge_textbox.Size = new System.Drawing.Size(66, 39);
            this.br_edge_textbox.TabIndex = 8;
            this.br_edge_textbox.Text = "BR N";
            this.br_edge_textbox.TextChanged += new System.EventHandler(this.br_edge_textbox_TextChanged);
            // 
            // BO_edge_textbox
            // 
            this.BO_edge_textbox.Location = new System.Drawing.Point(373, 150);
            this.BO_edge_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.BO_edge_textbox.Name = "BO_edge_textbox";
            this.BO_edge_textbox.Size = new System.Drawing.Size(60, 39);
            this.BO_edge_textbox.TabIndex = 7;
            this.BO_edge_textbox.Text = "BO N";
            // 
            // RB_edge_textbox
            // 
            this.RB_edge_textbox.Location = new System.Drawing.Point(380, 217);
            this.RB_edge_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.RB_edge_textbox.Name = "RB_edge_textbox";
            this.RB_edge_textbox.Size = new System.Drawing.Size(57, 39);
            this.RB_edge_textbox.TabIndex = 6;
            this.RB_edge_textbox.Text = "RB N";
            // 
            // middle_edges
            // 
            this.middle_edges.Location = new System.Drawing.Point(21, 310);
            this.middle_edges.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.middle_edges.Name = "middle_edges";
            this.middle_edges.Size = new System.Drawing.Size(160, 71);
            this.middle_edges.TabIndex = 5;
            this.middle_edges.Text = "M edges";
            this.middle_edges.UseVisualStyleBackColor = true;
            this.middle_edges.Click += new System.EventHandler(this.middle_edges_Click);
            // 
            // lable_zero
            // 
            this.lable_zero.Location = new System.Drawing.Point(212, 217);
            this.lable_zero.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lable_zero.Name = "lable_zero";
            this.lable_zero.Size = new System.Drawing.Size(121, 61);
            this.lable_zero.TabIndex = 4;
            this.lable_zero.Text = "L 0 ";
            this.lable_zero.UseVisualStyleBackColor = true;
            this.lable_zero.Click += new System.EventHandler(this.lable_zero_Click);
            // 
            // white_corners_buton
            // 
            this.white_corners_buton.Location = new System.Drawing.Point(21, 225);
            this.white_corners_buton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.white_corners_buton.Name = "white_corners_buton";
            this.white_corners_buton.Size = new System.Drawing.Size(147, 53);
            this.white_corners_buton.TabIndex = 3;
            this.white_corners_buton.Text = "W corners";
            this.white_corners_buton.UseVisualStyleBackColor = true;
            this.white_corners_buton.Click += new System.EventHandler(this.white_corners_buton_Click);
            // 
            // low_count_lable
            // 
            this.low_count_lable.AutoSize = true;
            this.low_count_lable.Location = new System.Drawing.Point(239, 153);
            this.low_count_lable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.low_count_lable.Name = "low_count_lable";
            this.low_count_lable.Size = new System.Drawing.Size(27, 32);
            this.low_count_lable.TabIndex = 2;
            this.low_count_lable.Text = "0";
            // 
            // white_cross_textbox
            // 
            this.white_cross_textbox.Location = new System.Drawing.Point(56, 72);
            this.white_cross_textbox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.white_cross_textbox.Name = "white_cross_textbox";
            this.white_cross_textbox.Size = new System.Drawing.Size(186, 39);
            this.white_cross_textbox.TabIndex = 1;
            this.white_cross_textbox.TextChanged += new System.EventHandler(this.white_cross_textbox_TextChanged);
            // 
            // White_cross_button
            // 
            this.White_cross_button.Location = new System.Drawing.Point(12, 150);
            this.White_cross_button.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.White_cross_button.Name = "White_cross_button";
            this.White_cross_button.Size = new System.Drawing.Size(169, 54);
            this.White_cross_button.TabIndex = 0;
            this.White_cross_button.Text = "W cross";
            this.White_cross_button.UseVisualStyleBackColor = true;
            this.White_cross_button.Click += new System.EventHandler(this.White_cross_button_Click);
            // 
            // Total_moves_done_lable
            // 
            this.Total_moves_done_lable.AutoSize = true;
            this.Total_moves_done_lable.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total_moves_done_lable.Location = new System.Drawing.Point(766, 309);
            this.Total_moves_done_lable.Name = "Total_moves_done_lable";
            this.Total_moves_done_lable.Size = new System.Drawing.Size(241, 45);
            this.Total_moves_done_lable.TabIndex = 1;
            this.Total_moves_done_lable.Text = "Moves count: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cube_solver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 1156);
            this.Controls.Add(this.Total_moves_done_lable);
            this.Controls.Add(this.tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "Cube_solver";
            this.Text = "Rubik\'s cube solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol.ResumeLayout(false);
            this.moves_page.ResumeLayout(false);
            this.moves_page.PerformLayout();
            this.solver_page.ResumeLayout(false);
            this.solver_page.PerformLayout();
            this.step_page.ResumeLayout(false);
            this.step_page.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabcontrol;
        private TabPage moves_page;
        private Button solve_button;
        private Button reset_button;
        private Button shuffle_button;
        private Button Ra_button;
        private Button R_button;
        private Button La_button;
        private Button L_button;
        private Button Da_button;
        private Button D_button;
        private Button Ua_button;
        private Button U_button;
        private Button Ba_button;
        private Button B_button;
        private Button Fa_button;
        private Button F_button;
        private TabPage solver_page;
        private Button button1;
        private Label message_lable;
        private TextBox solved_moves_textbox;
        private TextBox Solve_moves_textbox;
        private TabPage step_page;
        private TextBox white_cross_textbox;
        private Button White_cross_button;
        private Label low_count_lable;
        private Button white_corners_buton;
        private Button lable_zero;
        private Button middle_edges;
        private TextBox og_edge_textbox;
        private TextBox br_edge_textbox;
        private TextBox BO_edge_textbox;
        private TextBox RB_edge_textbox;
        private TextBox gb_edge_textbox;
        private Button yellow_cross_button;
        private Button Y_corners_button;
        private Button final_corners_button;
        private Button final_edges;
        private Button Solve_final_button;
        private Button test_button;
        private TextBox final_move_textbox;
        private TextBox shuffle_moves_textbox;
        private Button step_through_button;
        private Label Total_moves_done_lable;
        private Button step_2_button;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private HScrollBar hScrollBar1;
        private Button back_button;
        private Label Time_taken_lable;
        private Button time_check_button;
    }
}