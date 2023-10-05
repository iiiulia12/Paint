namespace Paint
{
    partial class PaintWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDRAW = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btnSEE = new System.Windows.Forms.Button();
            this.PenThick3 = new System.Windows.Forms.Button();
            this.PenThick2 = new System.Windows.Forms.Button();
            this.PenThick1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Black = new System.Windows.Forms.Button();
            this.Orange2 = new System.Windows.Forms.Button();
            this.Red1 = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Pink1 = new System.Windows.Forms.Button();
            this.Orange3 = new System.Windows.Forms.Button();
            this.Navy1 = new System.Windows.Forms.Button();
            this.Red3 = new System.Windows.Forms.Button();
            this.Aqua1 = new System.Windows.Forms.Button();
            this.Yellow3 = new System.Windows.Forms.Button();
            this.Green1 = new System.Windows.Forms.Button();
            this.Red2 = new System.Windows.Forms.Button();
            this.Orange1 = new System.Windows.Forms.Button();
            this.Yellow1 = new System.Windows.Forms.Button();
            this.Yellow2 = new System.Windows.Forms.Button();
            this.Green2 = new System.Windows.Forms.Button();
            this.Green3 = new System.Windows.Forms.Button();
            this.pick_color = new System.Windows.Forms.Button();
            this.Pink3 = new System.Windows.Forms.Button();
            this.Pink2 = new System.Windows.Forms.Button();
            this.Aqua2 = new System.Windows.Forms.Button();
            this.Aqua3 = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Navy2 = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.clearCanvasToolStripMenuItem,
            this.saveCanvasToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 100);
            this.contextMenuStrip1.Text = "Exist/Back";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // clearCanvasToolStripMenuItem
            // 
            this.clearCanvasToolStripMenuItem.Name = "clearCanvasToolStripMenuItem";
            this.clearCanvasToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.clearCanvasToolStripMenuItem.Text = "ClearCanvas";
            this.clearCanvasToolStripMenuItem.Click += new System.EventHandler(this.clearCanvasToolStripMenuItem_Click);
            // 
            // saveCanvasToolStripMenuItem
            // 
            this.saveCanvasToolStripMenuItem.Name = "saveCanvasToolStripMenuItem";
            this.saveCanvasToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.saveCanvasToolStripMenuItem.Text = "SaveCanvas";
            this.saveCanvasToolStripMenuItem.Click += new System.EventHandler(this.saveCanvasToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 732);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 28);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImage = global::Paint.Properties.Resources.depositphotos_178457096_stock_illustration_stationery_art_materials_set_of1;
            this.panel1.Controls.Add(this.btnDRAW);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btnSEE);
            this.panel1.Controls.Add(this.PenThick3);
            this.panel1.Controls.Add(this.PenThick2);
            this.panel1.Controls.Add(this.PenThick1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 108);
            this.panel1.TabIndex = 1;
            // 
            // btnDRAW
            // 
            this.btnDRAW.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDRAW.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDRAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDRAW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDRAW.Location = new System.Drawing.Point(279, 58);
            this.btnDRAW.Name = "btnDRAW";
            this.btnDRAW.Size = new System.Drawing.Size(51, 43);
            this.btnDRAW.TabIndex = 20;
            this.btnDRAW.Text = "1";
            this.btnDRAW.UseVisualStyleBackColor = false;
            this.btnDRAW.Click += new System.EventHandler(this.btnDRAW_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(670, 12);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(73, 72);
            this.btn_eraser.TabIndex = 8;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btnSEE
            // 
            this.btnSEE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSEE.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEE.Location = new System.Drawing.Point(279, 12);
            this.btnSEE.Name = "btnSEE";
            this.btnSEE.Size = new System.Drawing.Size(51, 49);
            this.btnSEE.TabIndex = 19;
            this.btnSEE.Text = "2";
            this.btnSEE.UseVisualStyleBackColor = false;
            this.btnSEE.Click += new System.EventHandler(this.btnOtherPainter_Click);
            // 
            // PenThick3
            // 
            this.PenThick3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PenThick3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PenThick3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenThick3.Image = global::Paint.Properties.Resources.Screenshot_2022_12_05_010452;
            this.PenThick3.Location = new System.Drawing.Point(336, 61);
            this.PenThick3.Name = "PenThick3";
            this.PenThick3.Size = new System.Drawing.Size(75, 23);
            this.PenThick3.TabIndex = 18;
            this.PenThick3.UseVisualStyleBackColor = true;
            this.PenThick3.Click += new System.EventHandler(this.PenThick3_Click);
            // 
            // PenThick2
            // 
            this.PenThick2.BackColor = System.Drawing.Color.White;
            this.PenThick2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PenThick2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PenThick2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenThick2.Image = global::Paint.Properties.Resources.Screenshot_2022_12_05_0107092;
            this.PenThick2.Location = new System.Drawing.Point(336, 45);
            this.PenThick2.Name = "PenThick2";
            this.PenThick2.Size = new System.Drawing.Size(75, 20);
            this.PenThick2.TabIndex = 17;
            this.PenThick2.UseVisualStyleBackColor = false;
            this.PenThick2.Click += new System.EventHandler(this.PenThick2_Click);
            // 
            // PenThick1
            // 
            this.PenThick1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PenThick1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PenThick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenThick1.Image = global::Paint.Properties.Resources.Screenshot_2022_12_05_004349;
            this.PenThick1.Location = new System.Drawing.Point(336, 12);
            this.PenThick1.Name = "PenThick1";
            this.PenThick1.Size = new System.Drawing.Size(75, 33);
            this.PenThick1.TabIndex = 16;
            this.PenThick1.UseVisualStyleBackColor = true;
            this.PenThick1.Click += new System.EventHandler(this.PenThick1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(1052, 38);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 33);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Exit.Location = new System.Drawing.Point(1052, 72);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(107, 33);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(25, 102);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(1052, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 33);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Paint.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(929, 12);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(73, 72);
            this.btn_color.TabIndex = 12;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.Black);
            this.panel4.Controls.Add(this.Orange2);
            this.panel4.Controls.Add(this.Red1);
            this.panel4.Controls.Add(this.White);
            this.panel4.Controls.Add(this.Pink1);
            this.panel4.Controls.Add(this.Orange3);
            this.panel4.Controls.Add(this.Navy1);
            this.panel4.Controls.Add(this.Red3);
            this.panel4.Controls.Add(this.Aqua1);
            this.panel4.Controls.Add(this.Yellow3);
            this.panel4.Controls.Add(this.Green1);
            this.panel4.Controls.Add(this.Red2);
            this.panel4.Controls.Add(this.Orange1);
            this.panel4.Controls.Add(this.Yellow1);
            this.panel4.Controls.Add(this.Yellow2);
            this.panel4.Controls.Add(this.Green2);
            this.panel4.Controls.Add(this.Green3);
            this.panel4.Controls.Add(this.pick_color);
            this.panel4.Controls.Add(this.Pink3);
            this.panel4.Controls.Add(this.Pink2);
            this.panel4.Controls.Add(this.Aqua2);
            this.panel4.Controls.Add(this.Aqua3);
            this.panel4.Controls.Add(this.Purple);
            this.panel4.Controls.Add(this.Navy2);
            this.panel4.Location = new System.Drawing.Point(34, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 95);
            this.panel4.TabIndex = 5;
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Black.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.Location = new System.Drawing.Point(204, 12);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(21, 24);
            this.Black.TabIndex = 27;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Orange2
            // 
            this.Orange2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orange2.FlatAppearance.BorderSize = 0;
            this.Orange2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange2.Location = new System.Drawing.Point(15, 39);
            this.Orange2.Name = "Orange2";
            this.Orange2.Size = new System.Drawing.Size(21, 24);
            this.Orange2.TabIndex = 17;
            this.Orange2.UseVisualStyleBackColor = false;
            this.Orange2.Click += new System.EventHandler(this.Orange2_Click);
            // 
            // Red1
            // 
            this.Red1.BackColor = System.Drawing.Color.Maroon;
            this.Red1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Red1.FlatAppearance.BorderSize = 0;
            this.Red1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red1.Location = new System.Drawing.Point(177, 63);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(21, 24);
            this.Red1.TabIndex = 23;
            this.Red1.UseVisualStyleBackColor = false;
            this.Red1.Click += new System.EventHandler(this.Red1_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Cursor = System.Windows.Forms.Cursors.Hand;
            this.White.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.White.FlatAppearance.BorderSize = 2;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.Location = new System.Drawing.Point(204, 41);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(21, 24);
            this.White.TabIndex = 21;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Pink1
            // 
            this.Pink1.BackColor = System.Drawing.Color.Purple;
            this.Pink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pink1.FlatAppearance.BorderSize = 0;
            this.Pink1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pink1.Location = new System.Drawing.Point(150, 63);
            this.Pink1.Name = "Pink1";
            this.Pink1.Size = new System.Drawing.Size(21, 24);
            this.Pink1.TabIndex = 26;
            this.Pink1.UseVisualStyleBackColor = false;
            this.Pink1.Click += new System.EventHandler(this.Pink1_Click);
            // 
            // Orange3
            // 
            this.Orange3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Orange3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orange3.FlatAppearance.BorderSize = 0;
            this.Orange3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange3.Location = new System.Drawing.Point(15, 17);
            this.Orange3.Name = "Orange3";
            this.Orange3.Size = new System.Drawing.Size(21, 24);
            this.Orange3.TabIndex = 17;
            this.Orange3.UseVisualStyleBackColor = false;
            this.Orange3.Click += new System.EventHandler(this.Orange3_Click);
            // 
            // Navy1
            // 
            this.Navy1.BackColor = System.Drawing.Color.Navy;
            this.Navy1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Navy1.FlatAppearance.BorderSize = 0;
            this.Navy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Navy1.Location = new System.Drawing.Point(123, 63);
            this.Navy1.Name = "Navy1";
            this.Navy1.Size = new System.Drawing.Size(21, 24);
            this.Navy1.TabIndex = 23;
            this.Navy1.UseVisualStyleBackColor = false;
            this.Navy1.Click += new System.EventHandler(this.Navy1_Click);
            // 
            // Red3
            // 
            this.Red3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Red3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Red3.FlatAppearance.BorderSize = 0;
            this.Red3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red3.Location = new System.Drawing.Point(177, 17);
            this.Red3.Name = "Red3";
            this.Red3.Size = new System.Drawing.Size(21, 24);
            this.Red3.TabIndex = 21;
            this.Red3.UseVisualStyleBackColor = false;
            this.Red3.Click += new System.EventHandler(this.Red3_Click);
            // 
            // Aqua1
            // 
            this.Aqua1.BackColor = System.Drawing.Color.Teal;
            this.Aqua1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aqua1.FlatAppearance.BorderSize = 0;
            this.Aqua1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aqua1.Location = new System.Drawing.Point(96, 63);
            this.Aqua1.Name = "Aqua1";
            this.Aqua1.Size = new System.Drawing.Size(21, 24);
            this.Aqua1.TabIndex = 23;
            this.Aqua1.UseVisualStyleBackColor = false;
            this.Aqua1.Click += new System.EventHandler(this.Aqua1_Click);
            // 
            // Yellow3
            // 
            this.Yellow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Yellow3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yellow3.FlatAppearance.BorderSize = 0;
            this.Yellow3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow3.Location = new System.Drawing.Point(42, 17);
            this.Yellow3.Name = "Yellow3";
            this.Yellow3.Size = new System.Drawing.Size(21, 24);
            this.Yellow3.TabIndex = 17;
            this.Yellow3.UseVisualStyleBackColor = false;
            this.Yellow3.Click += new System.EventHandler(this.Yellow3_Click);
            // 
            // Green1
            // 
            this.Green1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Green1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Green1.FlatAppearance.BorderSize = 0;
            this.Green1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green1.Location = new System.Drawing.Point(69, 63);
            this.Green1.Name = "Green1";
            this.Green1.Size = new System.Drawing.Size(21, 24);
            this.Green1.TabIndex = 20;
            this.Green1.UseVisualStyleBackColor = false;
            this.Green1.Click += new System.EventHandler(this.Green1_Click);
            // 
            // Red2
            // 
            this.Red2.BackColor = System.Drawing.Color.Red;
            this.Red2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Red2.FlatAppearance.BorderSize = 0;
            this.Red2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red2.Location = new System.Drawing.Point(177, 41);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(21, 24);
            this.Red2.TabIndex = 22;
            this.Red2.UseVisualStyleBackColor = false;
            this.Red2.Click += new System.EventHandler(this.Red2_Click);
            // 
            // Orange1
            // 
            this.Orange1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Orange1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orange1.FlatAppearance.BorderSize = 0;
            this.Orange1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange1.Location = new System.Drawing.Point(15, 63);
            this.Orange1.Name = "Orange1";
            this.Orange1.Size = new System.Drawing.Size(21, 24);
            this.Orange1.TabIndex = 16;
            this.Orange1.UseVisualStyleBackColor = false;
            this.Orange1.Click += new System.EventHandler(this.Orange1_Click);
            // 
            // Yellow1
            // 
            this.Yellow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Yellow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yellow1.FlatAppearance.BorderSize = 0;
            this.Yellow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow1.Location = new System.Drawing.Point(42, 63);
            this.Yellow1.Name = "Yellow1";
            this.Yellow1.Size = new System.Drawing.Size(21, 24);
            this.Yellow1.TabIndex = 19;
            this.Yellow1.UseVisualStyleBackColor = false;
            this.Yellow1.Click += new System.EventHandler(this.Yellow1_Click);
            // 
            // Yellow2
            // 
            this.Yellow2.BackColor = System.Drawing.Color.Yellow;
            this.Yellow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yellow2.FlatAppearance.BorderSize = 0;
            this.Yellow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow2.Location = new System.Drawing.Point(42, 39);
            this.Yellow2.Name = "Yellow2";
            this.Yellow2.Size = new System.Drawing.Size(21, 24);
            this.Yellow2.TabIndex = 18;
            this.Yellow2.UseVisualStyleBackColor = false;
            this.Yellow2.Click += new System.EventHandler(this.Yellow2_Click);
            // 
            // Green2
            // 
            this.Green2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Green2.FlatAppearance.BorderSize = 0;
            this.Green2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green2.Location = new System.Drawing.Point(69, 39);
            this.Green2.Name = "Green2";
            this.Green2.Size = new System.Drawing.Size(21, 24);
            this.Green2.TabIndex = 21;
            this.Green2.UseVisualStyleBackColor = false;
            this.Green2.Click += new System.EventHandler(this.Green2_Click);
            // 
            // Green3
            // 
            this.Green3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Green3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Green3.FlatAppearance.BorderSize = 0;
            this.Green3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green3.Location = new System.Drawing.Point(69, 17);
            this.Green3.Name = "Green3";
            this.Green3.Size = new System.Drawing.Size(21, 24);
            this.Green3.TabIndex = 22;
            this.Green3.UseVisualStyleBackColor = false;
            this.Green3.Click += new System.EventHandler(this.Green3_Click);
            // 
            // pick_color
            // 
            this.pick_color.BackColor = System.Drawing.Color.White;
            this.pick_color.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.pick_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pick_color.Location = new System.Drawing.Point(200, 67);
            this.pick_color.Name = "pick_color";
            this.pick_color.Size = new System.Drawing.Size(39, 25);
            this.pick_color.TabIndex = 4;
            this.pick_color.UseVisualStyleBackColor = false;
            this.pick_color.Click += new System.EventHandler(this.pick_color_Click);
            // 
            // Pink3
            // 
            this.Pink3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pink3.FlatAppearance.BorderSize = 0;
            this.Pink3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pink3.Location = new System.Drawing.Point(150, 17);
            this.Pink3.Name = "Pink3";
            this.Pink3.Size = new System.Drawing.Size(21, 24);
            this.Pink3.TabIndex = 24;
            this.Pink3.UseVisualStyleBackColor = false;
            this.Pink3.Click += new System.EventHandler(this.Pink3_Click);
            // 
            // Pink2
            // 
            this.Pink2.BackColor = System.Drawing.Color.Fuchsia;
            this.Pink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pink2.FlatAppearance.BorderSize = 0;
            this.Pink2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pink2.Location = new System.Drawing.Point(150, 41);
            this.Pink2.Name = "Pink2";
            this.Pink2.Size = new System.Drawing.Size(21, 24);
            this.Pink2.TabIndex = 25;
            this.Pink2.UseVisualStyleBackColor = false;
            this.Pink2.Click += new System.EventHandler(this.Pink2_Click);
            // 
            // Aqua2
            // 
            this.Aqua2.BackColor = System.Drawing.Color.Cyan;
            this.Aqua2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aqua2.FlatAppearance.BorderSize = 0;
            this.Aqua2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aqua2.Location = new System.Drawing.Point(96, 39);
            this.Aqua2.Name = "Aqua2";
            this.Aqua2.Size = new System.Drawing.Size(21, 24);
            this.Aqua2.TabIndex = 22;
            this.Aqua2.UseVisualStyleBackColor = false;
            this.Aqua2.Click += new System.EventHandler(this.Aqua2_Click);
            // 
            // Aqua3
            // 
            this.Aqua3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Aqua3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aqua3.FlatAppearance.BorderSize = 0;
            this.Aqua3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aqua3.Location = new System.Drawing.Point(96, 17);
            this.Aqua3.Name = "Aqua3";
            this.Aqua3.Size = new System.Drawing.Size(21, 24);
            this.Aqua3.TabIndex = 21;
            this.Aqua3.UseVisualStyleBackColor = false;
            this.Aqua3.Click += new System.EventHandler(this.Aqua3_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Purple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Purple.FlatAppearance.BorderSize = 0;
            this.Purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purple.Location = new System.Drawing.Point(123, 17);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(21, 24);
            this.Purple.TabIndex = 21;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Navy2
            // 
            this.Navy2.BackColor = System.Drawing.Color.Blue;
            this.Navy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Navy2.FlatAppearance.BorderSize = 0;
            this.Navy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Navy2.Location = new System.Drawing.Point(123, 39);
            this.Navy2.Name = "Navy2";
            this.Navy2.Size = new System.Drawing.Size(21, 24);
            this.Navy2.TabIndex = 22;
            this.Navy2.UseVisualStyleBackColor = false;
            this.Navy2.Click += new System.EventHandler(this.Navy2_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::Paint.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(850, 12);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(73, 72);
            this.btn_ellipse.TabIndex = 11;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.ForeColor = System.Drawing.Color.White;
            this.btn_rectangle.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_rectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rectangle.Location = new System.Drawing.Point(749, 12);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(95, 72);
            this.btn_rectangle.TabIndex = 10;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::Paint.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pencil.Location = new System.Drawing.Point(591, 12);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(73, 72);
            this.btn_pencil.TabIndex = 9;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::Paint.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(512, 12);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(73, 72);
            this.btn_fill.TabIndex = 8;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(433, 12);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(73, 72);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(417, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 94);
            this.panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1171, 760);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // PaintWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 760);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paint";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ToolStripMenuItem clearCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Red1;
        private System.Windows.Forms.Button Pink1;
        private System.Windows.Forms.Button Navy1;
        private System.Windows.Forms.Button Aqua1;
        private System.Windows.Forms.Button Green1;
        private System.Windows.Forms.Button Yellow1;
        private System.Windows.Forms.Button Orange1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Orange2;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Orange3;
        private System.Windows.Forms.Button Red3;
        private System.Windows.Forms.Button Yellow3;
        private System.Windows.Forms.Button Red2;
        private System.Windows.Forms.Button Yellow2;
        private System.Windows.Forms.Button Green2;
        private System.Windows.Forms.Button Green3;
        private System.Windows.Forms.Button Pink3;
        private System.Windows.Forms.Button Pink2;
        private System.Windows.Forms.Button Aqua2;
        private System.Windows.Forms.Button Aqua3;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Navy2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PenThick3;
        private System.Windows.Forms.Button PenThick1;
        private System.Windows.Forms.Button PenThick2;
        public System.Windows.Forms.Button pick_color;
        public System.Windows.Forms.Button btnSEE;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnDRAW;
    }
}