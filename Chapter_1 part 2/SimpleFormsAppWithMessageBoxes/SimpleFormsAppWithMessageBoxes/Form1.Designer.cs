namespace SimpleFormsAppWithMessageBoxes
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            firstname = new TextBox();
            middlename = new TextBox();
            lastname = new TextBox();
            suffix = new TextBox();
            Submit = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 1;
            label2.Text = "Simple Form Application";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(5, 127);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 3;
            label4.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(6, 216);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 4;
            label5.Text = "Last Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(12, 296);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 5;
            label6.Text = "Suffix";
            label6.Click += label6_Click;
            // 
            // firstname
            // 
            firstname.Location = new Point(5, 87);
            firstname.Name = "firstname";
            firstname.Size = new Size(150, 23);
            firstname.TabIndex = 6;
            // 
            // middlename
            // 
            middlename.Location = new Point(5, 173);
            middlename.Name = "middlename";
            middlename.Size = new Size(150, 23);
            middlename.TabIndex = 7;
            // 
            // lastname
            // 
            lastname.Location = new Point(5, 252);
            lastname.Name = "lastname";
            lastname.Size = new Size(150, 23);
            lastname.TabIndex = 8;
            // 
            // suffix
            // 
            suffix.Location = new Point(4, 328);
            suffix.Name = "suffix";
            suffix.Size = new Size(151, 23);
            suffix.TabIndex = 9;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.WindowFrame;
            Submit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Submit.Location = new Point(6, 382);
            Submit.Name = "Submit";
            Submit.Size = new Size(143, 29);
            Submit.TabIndex = 11;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(253, 450);
            Controls.Add(Submit);
            Controls.Add(suffix);
            Controls.Add(lastname);
            Controls.Add(middlename);
            Controls.Add(firstname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstname;
        private TextBox middlename;
        private TextBox lastname;
        private TextBox suffix;
        private Button Submit;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}
