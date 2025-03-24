namespace WinFormsApp4
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
            cmbCharacters = new ComboBox();
            btnSelect = new Button();
            btnClear = new Button();
            pbCharacter = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCharacter).BeginInit();
            SuspendLayout();
            // 
            // cmbCharacters
            // 
            cmbCharacters.BackColor = SystemColors.Window;
            cmbCharacters.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCharacters.ForeColor = SystemColors.WindowText;
            cmbCharacters.FormattingEnabled = true;
            cmbCharacters.Location = new Point(21, 117);
            cmbCharacters.Name = "cmbCharacters";
            cmbCharacters.Size = new Size(145, 22);
            cmbCharacters.TabIndex = 0;
            cmbCharacters.SelectedIndexChanged += CmbCharacters_SelectedIndexChanged;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = SystemColors.ActiveBorder;
            btnSelect.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(37, 156);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(110, 24);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "View";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += BtnSelect_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(37, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 24);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // pbCharacter
            // 
            pbCharacter.BackColor = Color.Transparent;
            pbCharacter.BackgroundImageLayout = ImageLayout.None;
            pbCharacter.ErrorImage = null;
            pbCharacter.InitialImage = null;
            pbCharacter.Location = new Point(374, 102);
            pbCharacter.Name = "pbCharacter";
            pbCharacter.Size = new Size(234, 170);
            pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCharacter.TabIndex = 3;
            pbCharacter.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 54);
            label1.TabIndex = 4;
            label1.Text = "SIMPLE FAVORITE CHRACTER  PICKER\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 92);
            label2.Name = "label2";
            label2.Size = new Size(105, 14);
            label2.TabIndex = 5;
            label2.Text = "Select an Image";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._123;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(701, 414);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbCharacter);
            Controls.Add(btnClear);
            Controls.Add(btnSelect);
            Controls.Add(cmbCharacters);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCharacter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCharacters;
        private Button btnSelect;
        private Button btnClear;
        private PictureBox pbCharacter;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
