namespace WinFormsApp3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Kirb1 = new CheckedListBox();
            Kirb2 = new ListBox();
            addbtn = new Button();
            removebtn = new Button();
            clrbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(256, 22);
            label1.Name = "label1";
            label1.Size = new Size(291, 44);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Movie Picker App\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(452, 92);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Movie Selected";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(123, 92);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 2;
            label3.Text = "Movies/Series List";
            // 
            // Kirb1
            // 
            Kirb1.FormattingEnabled = true;
            Kirb1.Location = new Point(107, 133);
            Kirb1.Name = "Kirb1";
            Kirb1.Size = new Size(173, 148);
            Kirb1.TabIndex = 3;
            Kirb1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Kirb2
            // 
            Kirb2.FormattingEnabled = true;
            Kirb2.ItemHeight = 15;
            Kirb2.Location = new Point(429, 133);
            Kirb2.Name = "Kirb2";
            Kirb2.Size = new Size(168, 154);
            Kirb2.TabIndex = 4;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.ForeColor = SystemColors.ActiveCaptionText;
            addbtn.Location = new Point(651, 148);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 5;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button1_Click;
            // 
            // removebtn
            // 
            removebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.Location = new Point(651, 195);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(75, 24);
            removebtn.TabIndex = 6;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += button2_Click;
            // 
            // clrbtn
            // 
            clrbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrbtn.Location = new Point(651, 244);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(75, 23);
            clrbtn.TabIndex = 7;
            clrbtn.Text = "Clear";
            clrbtn.UseVisualStyleBackColor = true;
            clrbtn.Click += clrbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 355);
            Controls.Add(clrbtn);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(Kirb2);
            Controls.Add(Kirb1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox Kirb1;
        private ListBox Kirb2;
        private Button addbtn;
        private Button removebtn;
        private Button clrbtn;
    }
}
