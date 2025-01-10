namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            passBox = new Label();
            genBtn = new Button();
            cpyBtn = new Button();
            groupBox1 = new GroupBox();
            symbolCheck = new CheckBox();
            digitCheck = new CheckBox();
            upperCheck = new CheckBox();
            lowerCheck = new CheckBox();
            passLenghtText = new Label();
            passLenght = new TrackBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passLenght).BeginInit();
            SuspendLayout();
            // 
            // passBox
            // 
            passBox.AutoSize = true;
            passBox.BorderStyle = BorderStyle.Fixed3D;
            passBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passBox.Location = new Point(49, 56);
            passBox.Margin = new Padding(5, 0, 5, 0);
            passBox.MaximumSize = new Size(500, 50);
            passBox.MinimumSize = new Size(500, 25);
            passBox.Name = "passBox";
            passBox.Padding = new Padding(5);
            passBox.Size = new Size(500, 37);
            passBox.TabIndex = 0;
            passBox.TextAlign = ContentAlignment.MiddleCenter;
            passBox.UseCompatibleTextRendering = true;
            // 
            // genBtn
            // 
            genBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genBtn.Location = new Point(557, 52);
            genBtn.Name = "genBtn";
            genBtn.Padding = new Padding(2);
            genBtn.Size = new Size(100, 40);
            genBtn.TabIndex = 1;
            genBtn.Text = "Generate";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // cpyBtn
            // 
            cpyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpyBtn.Location = new Point(663, 52);
            cpyBtn.Name = "cpyBtn";
            cpyBtn.Size = new Size(100, 40);
            cpyBtn.TabIndex = 2;
            cpyBtn.Text = "Copy";
            cpyBtn.UseVisualStyleBackColor = true;
            cpyBtn.Click += copyBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(symbolCheck);
            groupBox1.Controls.Add(digitCheck);
            groupBox1.Controls.Add(upperCheck);
            groupBox1.Controls.Add(lowerCheck);
            groupBox1.Controls.Add(passLenghtText);
            groupBox1.Controls.Add(passLenght);
            groupBox1.Location = new Point(49, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // symbolCheck
            // 
            symbolCheck.AutoSize = true;
            symbolCheck.Font = new Font("Segoe UI", 11.25F);
            symbolCheck.Location = new Point(411, 66);
            symbolCheck.Name = "symbolCheck";
            symbolCheck.Padding = new Padding(3);
            symbolCheck.Size = new Size(90, 30);
            symbolCheck.TabIndex = 5;
            symbolCheck.Text = "Symbols";
            symbolCheck.UseVisualStyleBackColor = true;
            // 
            // digitCheck
            // 
            digitCheck.AutoSize = true;
            digitCheck.Font = new Font("Segoe UI", 11.25F);
            digitCheck.Location = new Point(292, 66);
            digitCheck.Name = "digitCheck";
            digitCheck.Padding = new Padding(3);
            digitCheck.Size = new Size(73, 30);
            digitCheck.TabIndex = 4;
            digitCheck.Text = "Digits";
            digitCheck.UseVisualStyleBackColor = true;
            // 
            // upperCheck
            // 
            upperCheck.AutoSize = true;
            upperCheck.Font = new Font("Segoe UI", 11.25F);
            upperCheck.Location = new Point(153, 66);
            upperCheck.Name = "upperCheck";
            upperCheck.Padding = new Padding(3);
            upperCheck.Size = new Size(104, 30);
            upperCheck.TabIndex = 3;
            upperCheck.Text = "Uppercase";
            upperCheck.UseVisualStyleBackColor = true;
            // 
            // lowerCheck
            // 
            lowerCheck.AutoSize = true;
            lowerCheck.Checked = true;
            lowerCheck.CheckState = CheckState.Checked;
            lowerCheck.Font = new Font("Segoe UI", 11.25F);
            lowerCheck.Location = new Point(16, 66);
            lowerCheck.Name = "lowerCheck";
            lowerCheck.Padding = new Padding(3);
            lowerCheck.Size = new Size(103, 30);
            lowerCheck.TabIndex = 2;
            lowerCheck.Text = "Lowercase";
            lowerCheck.UseVisualStyleBackColor = true;
            // 
            // passLenghtText
            // 
            passLenghtText.AutoSize = true;
            passLenghtText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLenghtText.Location = new Point(664, 21);
            passLenghtText.Name = "passLenghtText";
            passLenghtText.Padding = new Padding(5);
            passLenghtText.Size = new Size(29, 31);
            passLenghtText.TabIndex = 1;
            passLenghtText.Text = "8";
            passLenghtText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passLenght
            // 
            passLenght.LargeChange = 1;
            passLenght.Location = new Point(6, 22);
            passLenght.Maximum = 32;
            passLenght.Name = "passLenght";
            passLenght.Size = new Size(641, 45);
            passLenght.TabIndex = 0;
            passLenght.Value = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 209);
            Controls.Add(groupBox1);
            Controls.Add(cpyBtn);
            Controls.Add(genBtn);
            Controls.Add(passBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random Password Generator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passLenght).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passBox;
        private Button genBtn;
        private Button cpyBtn;
        private GroupBox groupBox1;
        private Label passLenghtText;
        private TrackBar passLenght;
        private CheckBox symbolCheck;
        private CheckBox digitCheck;
        private CheckBox upperCheck;
        private CheckBox lowerCheck;
    }
}
