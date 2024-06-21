namespace ödev
{
    partial class Form5
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
            panel1 = new Panel();
            onaylabutton = new Button();
            tckimliknolabel = new Label();
            txtNumara = new TextBox();
            tckimliktextBox = new TextBox();
            soyadtextBox = new TextBox();
            adreslabel = new Label();
            label1 = new Label();
            soyisimlabel = new Label();
            adrestextBox = new TextBox();
            numaralabel = new Label();
            adtextBox = new TextBox();
            label2 = new Label();
            adlabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            Load += Form5_Load;
            // 
            // panel1
            // 
            panel1.Controls.Add(onaylabutton);
            panel1.Controls.Add(tckimliknolabel);
            panel1.Controls.Add(txtNumara);
            panel1.Controls.Add(tckimliktextBox);
            panel1.Controls.Add(soyadtextBox);
            panel1.Controls.Add(adreslabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(soyisimlabel);
            panel1.Controls.Add(adrestextBox);
            panel1.Controls.Add(numaralabel);
            panel1.Controls.Add(adtextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(adlabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // onaylabutton
            // 
            onaylabutton.BackColor = SystemColors.ActiveCaption;
            onaylabutton.ForeColor = SystemColors.ButtonHighlight;
            onaylabutton.Location = new Point(312, 350);
            onaylabutton.Name = "onaylabutton";
            onaylabutton.Size = new Size(139, 50);
            onaylabutton.TabIndex = 7;
            onaylabutton.Text = "Kaydet";
            onaylabutton.UseVisualStyleBackColor = false;
            onaylabutton.Click += onaylabutton_Click;
            // 
            // tckimliknolabel
            // 
            tckimliknolabel.AutoSize = true;
            tckimliknolabel.Location = new Point(419, 116);
            tckimliknolabel.Name = "tckimliknolabel";
            tckimliknolabel.Size = new Size(0, 20);
            tckimliknolabel.TabIndex = 6;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(147, 139);
            txtNumara.Name = "numaramaskedTextBox";
            txtNumara.Size = new Size(204, 27);
            txtNumara.TabIndex = 5;
            // 
            // tckimliktextBox
            // 
            tckimliktextBox.Location = new Point(419, 139);
            tckimliktextBox.Name = "tckimliktextBox";
            tckimliktextBox.Size = new Size(204, 27);
            tckimliktextBox.TabIndex = 4;
            // 
            // soyadtextBox
            // 
            soyadtextBox.Location = new Point(419, 71);
            soyadtextBox.Name = "soyadtextBox";
            soyadtextBox.Size = new Size(204, 27);
            soyadtextBox.TabIndex = 4;
            // 
            // adreslabel
            // 
            adreslabel.AutoSize = true;
            adreslabel.Location = new Point(147, 184);
            adreslabel.Name = "adreslabel";
            adreslabel.Size = new Size(47, 20);
            adreslabel.TabIndex = 3;
            adreslabel.Text = "Adres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Eposta";
            // 
            // soyisimlabel
            // 
            soyisimlabel.AutoSize = true;
            soyisimlabel.Location = new Point(421, 116);
            soyisimlabel.Name = "soyisimlabel";
            soyisimlabel.Size = new Size(39, 20);
            soyisimlabel.TabIndex = 3;
            soyisimlabel.Text = "Şifre";
            // 
            // adrestextBox
            // 
            adrestextBox.Location = new Point(147, 207);
            adrestextBox.Multiline = true;
            adrestextBox.Name = "adrestextBox";
            adrestextBox.Size = new Size(476, 137);
            adrestextBox.TabIndex = 4;
            // 
            // numaralabel
            // 
            numaralabel.AutoSize = true;
            numaralabel.Location = new Point(147, 116);
            numaralabel.Name = "numaralabel";
            numaralabel.Size = new Size(62, 20);
            numaralabel.TabIndex = 3;
            numaralabel.Text = "Numara";
            // 
            // adtextBox
            // 
            adtextBox.Location = new Point(147, 71);
            adtextBox.Name = "adtextBox";
            adtextBox.Size = new Size(204, 27);
            adtextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(312, 10);
            label2.Name = "label2";
            label2.Size = new Size(149, 22);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Bilgileri";
            // 
            // adlabel
            // 
            adlabel.AutoSize = true;
            adlabel.Location = new Point(147, 48);
            adlabel.Name = "adlabel";
            adlabel.Size = new Size(73, 20);
            adlabel.TabIndex = 0;
            adlabel.Text = "Ad Soyad";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label adlabel;
        private Label label2;
        private TextBox txtNumara;
        private TextBox tckimliktextBox;
        private TextBox soyadtextBox;
        private Label adreslabel;
        private Label soyisimlabel;
        private TextBox adrestextBox;
        private Label numaralabel;
        private TextBox adtextBox;
        private Label tckimliknolabel;
        private Button onaylabutton;
        private Label label1;
    }
}