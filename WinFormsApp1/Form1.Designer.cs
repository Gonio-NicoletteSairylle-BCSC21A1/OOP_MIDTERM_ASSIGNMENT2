namespace To_do_list
{
    partial class Form1TodoList
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
            label1Title = new Label();
            label2Desc = new Label();
            Descriptionn = new TextBox();
            Titlee = new TextBox();
            dataGridView1TodoList = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Checkbox = new DataGridViewCheckBoxColumn();
            button1Edit = new Button();
            button2Delete = new Button();
            button3New = new Button();
            button4Save = new Button();
            button1Exit = new Button();
            label1Date = new Label();
            Datee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1TodoList).BeginInit();
            SuspendLayout();
            // 
            // label1Title
            // 
            label1Title.AutoSize = true;
            label1Title.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Title.Location = new Point(26, 22);
            label1Title.Margin = new Padding(4, 0, 4, 0);
            label1Title.Name = "label1Title";
            label1Title.Size = new Size(59, 19);
            label1Title.TabIndex = 0;
            label1Title.Text = "Name:";
            // 
            // label2Desc
            // 
            label2Desc.AutoSize = true;
            label2Desc.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2Desc.Location = new Point(472, 22);
            label2Desc.Margin = new Padding(4, 0, 4, 0);
            label2Desc.Name = "label2Desc";
            label2Desc.Size = new Size(99, 19);
            label2Desc.TabIndex = 1;
            label2Desc.Text = "Description:";
            label2Desc.Click += label2_Click;
            // 
            // Descriptionn
            // 
            Descriptionn.BackColor = Color.Salmon;
            Descriptionn.BorderStyle = BorderStyle.FixedSingle;
            Descriptionn.Location = new Point(477, 47);
            Descriptionn.Margin = new Padding(4, 3, 4, 3);
            Descriptionn.Multiline = true;
            Descriptionn.Name = "Descriptionn";
            Descriptionn.Size = new Size(421, 125);
            Descriptionn.TabIndex = 2;
            Descriptionn.TextChanged += textBox1_TextChanged;
            // 
            // Titlee
            // 
            Titlee.BackColor = Color.Salmon;
            Titlee.BorderStyle = BorderStyle.FixedSingle;
            Titlee.Location = new Point(30, 47);
            Titlee.Margin = new Padding(4, 3, 4, 3);
            Titlee.Multiline = true;
            Titlee.Name = "Titlee";
            Titlee.Size = new Size(421, 125);
            Titlee.TabIndex = 3;
            Titlee.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1TodoList
            // 
            dataGridView1TodoList.BackgroundColor = Color.Maroon;
            dataGridView1TodoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1TodoList.Columns.AddRange(new DataGridViewColumn[] { Title, Description, Date, Checkbox });
            dataGridView1TodoList.Location = new Point(30, 202);
            dataGridView1TodoList.Margin = new Padding(4, 3, 4, 3);
            dataGridView1TodoList.Name = "dataGridView1TodoList";
            dataGridView1TodoList.Size = new Size(909, 519);
            dataGridView1TodoList.TabIndex = 4;
            dataGridView1TodoList.CellContentClick += dataGridView1TodoList_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "Name";
            Title.Name = "Title";
            Title.Width = 170;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.Width = 225;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 170;
            // 
            // Checkbox
            // 
            Checkbox.HeaderText = "Check box";
            Checkbox.Name = "Checkbox";
            Checkbox.Width = 170;
            // 
            // button1Edit
            // 
            button1Edit.BackColor = Color.RosyBrown;
            button1Edit.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1Edit.Location = new Point(965, 308);
            button1Edit.Margin = new Padding(4, 3, 4, 3);
            button1Edit.Name = "button1Edit";
            button1Edit.Size = new Size(203, 67);
            button1Edit.TabIndex = 5;
            button1Edit.Text = "Edit";
            button1Edit.UseVisualStyleBackColor = false;
            button1Edit.Click += button1_Click;
            // 
            // button2Delete
            // 
            button2Delete.BackColor = Color.RosyBrown;
            button2Delete.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2Delete.Location = new Point(965, 417);
            button2Delete.Margin = new Padding(4, 3, 4, 3);
            button2Delete.Name = "button2Delete";
            button2Delete.Size = new Size(203, 67);
            button2Delete.TabIndex = 6;
            button2Delete.Text = "Delete";
            button2Delete.UseVisualStyleBackColor = false;
            button2Delete.Click += button2Delete_Click;
            // 
            // button3New
            // 
            button3New.BackColor = Color.RosyBrown;
            button3New.BackgroundImageLayout = ImageLayout.None;
            button3New.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3New.Location = new Point(965, 202);
            button3New.Margin = new Padding(4, 3, 4, 3);
            button3New.Name = "button3New";
            button3New.Size = new Size(203, 67);
            button3New.TabIndex = 7;
            button3New.Text = "Add";
            button3New.UseVisualStyleBackColor = false;
            button3New.Click += button3New_Click;
            // 
            // button4Save
            // 
            button4Save.BackColor = Color.RosyBrown;
            button4Save.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4Save.Location = new Point(965, 523);
            button4Save.Margin = new Padding(4, 3, 4, 3);
            button4Save.Name = "button4Save";
            button4Save.Size = new Size(203, 69);
            button4Save.TabIndex = 8;
            button4Save.Text = "Save";
            button4Save.UseVisualStyleBackColor = false;
            button4Save.Click += button4Save_Click;
            // 
            // button1Exit
            // 
            button1Exit.BackColor = Color.RosyBrown;
            button1Exit.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1Exit.ForeColor = Color.Black;
            button1Exit.Location = new Point(965, 633);
            button1Exit.Margin = new Padding(4, 3, 4, 3);
            button1Exit.Name = "button1Exit";
            button1Exit.Size = new Size(203, 68);
            button1Exit.TabIndex = 9;
            button1Exit.Text = "Exit";
            button1Exit.UseVisualStyleBackColor = false;
            // 
            // label1Date
            // 
            label1Date.AutoSize = true;
            label1Date.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Date.Location = new Point(916, 22);
            label1Date.Margin = new Padding(4, 0, 4, 0);
            label1Date.Name = "label1Date";
            label1Date.Size = new Size(49, 19);
            label1Date.TabIndex = 10;
            label1Date.Text = "Date:";
            // 
            // Datee
            // 
            Datee.BackColor = Color.Salmon;
            Datee.BorderStyle = BorderStyle.FixedSingle;
            Datee.Location = new Point(920, 46);
            Datee.Margin = new Padding(4, 3, 4, 3);
            Datee.Multiline = true;
            Datee.Name = "Datee";
            Datee.Size = new Size(357, 125);
            Datee.TabIndex = 11;
            Datee.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1TodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 735);
            Controls.Add(Datee);
            Controls.Add(label1Date);
            Controls.Add(button1Exit);
            Controls.Add(button4Save);
            Controls.Add(button3New);
            Controls.Add(button2Delete);
            Controls.Add(button1Edit);
            Controls.Add(dataGridView1TodoList);
            Controls.Add(Titlee);
            Controls.Add(Descriptionn);
            Controls.Add(label2Desc);
            Controls.Add(label1Title);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1TodoList";
            Text = "To do list menu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1TodoList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1Title;
        private System.Windows.Forms.Label label2Desc;
        private System.Windows.Forms.TextBox Descriptionn;
        private System.Windows.Forms.TextBox Titlee;
        private System.Windows.Forms.DataGridView dataGridView1TodoList;
        private System.Windows.Forms.Button button1Edit;
        private System.Windows.Forms.Button button2Delete;
        private System.Windows.Forms.Button button3New;
        private System.Windows.Forms.Button button4Save;
        private System.Windows.Forms.Button button1Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.Label label1Date;
        private System.Windows.Forms.TextBox Datee;
    }
}
