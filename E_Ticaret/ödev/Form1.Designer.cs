namespace ödev
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
            panel1 = new Panel();
            kayıtbutton1 = new Button();
            parolatextBox = new TextBox();
            girişbutton = new Button();
            kullanıcıadıtextBox = new TextBox();
            parolalabel = new Label();
            kullanıcıadılabel = new Label();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(kayıtbutton1);
            panel1.Controls.Add(parolatextBox);
            panel1.Controls.Add(girişbutton);
            panel1.Controls.Add(kullanıcıadıtextBox);
            panel1.Controls.Add(parolalabel);
            panel1.Controls.Add(kullanıcıadılabel);
            panel1.Location = new Point(237, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 243);
            panel1.TabIndex = 0;
            // 
            // kayıtbutton1
            // 
            kayıtbutton1.BackColor = SystemColors.ActiveCaption;
            kayıtbutton1.ForeColor = SystemColors.ButtonHighlight;
            kayıtbutton1.Location = new Point(233, 166);
            kayıtbutton1.Name = "kayıtbutton1";
            kayıtbutton1.Size = new Size(139, 50);
            kayıtbutton1.TabIndex = 7;
            kayıtbutton1.Text = "Kayıt Ol";
            kayıtbutton1.UseVisualStyleBackColor = false;
            kayıtbutton1.Click += kayıtbutton1_Click;
            // 
            // parolatextBox
            // 
            parolatextBox.Location = new Point(78, 104);
            parolatextBox.Name = "parolatextBox";
            parolatextBox.Size = new Size(227, 27);
            parolatextBox.TabIndex = 6;
            // 
            // girişbutton
            // 
            girişbutton.BackColor = SystemColors.ActiveCaption;
            girişbutton.ForeColor = SystemColors.ButtonHighlight;
            girişbutton.Location = new Point(12, 166);
            girişbutton.Name = "girişbutton";
            girişbutton.Size = new Size(139, 50);
            girişbutton.TabIndex = 5;
            girişbutton.Text = "Giriş";
            girişbutton.UseVisualStyleBackColor = false;
            girişbutton.Click += girişbutton_Click;
            // 
            // kullanıcıadıtextBox
            // 
            kullanıcıadıtextBox.Location = new Point(78, 37);
            kullanıcıadıtextBox.Name = "kullanıcıadıtextBox";
            kullanıcıadıtextBox.Size = new Size(227, 27);
            kullanıcıadıtextBox.TabIndex = 3;
            // 
            // parolalabel
            // 
            parolalabel.AutoSize = true;
            parolalabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            parolalabel.Location = new Point(78, 76);
            parolalabel.Name = "parolalabel";
            parolalabel.Size = new Size(63, 25);
            parolalabel.TabIndex = 2;
            parolalabel.Text = "Parola";
            // 
            // kullanıcıadılabel
            // 
            kullanıcıadılabel.AutoSize = true;
            kullanıcıadılabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kullanıcıadılabel.Location = new Point(77, 9);
            kullanıcıadılabel.Name = "kullanıcıadılabel";
            kullanıcıadılabel.Size = new Size(64, 25);
            kullanıcıadılabel.TabIndex = 1;
            kullanıcıadılabel.Text = "Eposta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(366, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 11;
            label1.Text = "SMED";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(764, 188);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 477);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox parolatextBox;
        private Button girişbutton;
        private TextBox kullanıcıadıtextBox;
        private Label parolalabel;
        private Label kullanıcıadılabel;
        private Button kayıtbutton1;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}
