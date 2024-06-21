namespace ödev
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            devametbutton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripSplitButton();
            hesapAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            listSepet = new ListView();
            headUrunAd = new ColumnHeader();
            headFiyat = new ColumnHeader();
            headAdet = new ColumnHeader();
            lblToplam = new Label();
            lblToplamFiyat = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            Load += Form4_Load;
            // 
            // devametbutton
            // 
            devametbutton.BackColor = SystemColors.ActiveCaption;
            devametbutton.ForeColor = SystemColors.ButtonHighlight;
            devametbutton.Location = new Point(626, 388);
            devametbutton.Name = "devametbutton";
            devametbutton.Size = new Size(139, 50);
            devametbutton.TabIndex = 6;
            devametbutton.Text = "Devam Et";
            devametbutton.UseVisualStyleBackColor = false;
            devametbutton.Click += devametbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 31);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(47, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 5;
            label2.Text = "Sepet";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackgroundImageLayout = ImageLayout.None;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { hesapAyarlarıToolStripMenuItem, çıkışYapToolStripMenuItem });
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(39, 24);
            toolStripButton1.Text = "Ayarlar";
            // 
            // hesapAyarlarıToolStripMenuItem
            // 
            hesapAyarlarıToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            hesapAyarlarıToolStripMenuItem.Image = (Image)resources.GetObject("hesapAyarlarıToolStripMenuItem.Image");
            hesapAyarlarıToolStripMenuItem.Name = "hesapAyarlarıToolStripMenuItem";
            hesapAyarlarıToolStripMenuItem.Size = new Size(224, 26);
            hesapAyarlarıToolStripMenuItem.Text = "Hesap Ayarları";
            hesapAyarlarıToolStripMenuItem.Click += hesapAyarlarıToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Image = (Image)resources.GetObject("çıkışYapToolStripMenuItem.Image");
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(224, 26);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            //
            // listSepet
            //
            headUrunAd.Text = "Ürün Adı";
            headUrunAd.Width = 100;
            headFiyat.Text = "Birim Fiyat";
            headFiyat.Width = 100;
            headAdet.Text = "Adet";
            headAdet.Width = 100;
            listSepet.Columns.AddRange(new ColumnHeader[]
            {
                headUrunAd,
                headFiyat,
                headAdet
            });
            listSepet.FullRowSelect = true;
            listSepet.GridLines = true;
            listSepet.Location = new Point(10, 35);
            listSepet.Name = "sepet";
            listSepet.Size = new Size(500, 350);
            listSepet.TabIndex = 1;
            listSepet.UseCompatibleStateImageBehavior = false;
            listSepet.View = View.Details;
            Controls.Add(listSepet);
            lblToplam.Text = "Toplam:";
            lblToplam.Size = new Size(70, 20);
            lblToplam.Location = new Point(550, 350);
            Controls.Add(lblToplam);
            lblToplamFiyat.Location = new Point(620, 350);
            lblToplamFiyat.Size = new Size(70, 20);
            Controls.Add(lblToplamFiyat);
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(devametbutton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button devametbutton;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripButton1;
        private ToolStripMenuItem hesapAyarlarıToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private PictureBox pictureBox1;
        private ListView listSepet;
        private ColumnHeader headUrunAd;
        private ColumnHeader headFiyat;
        private ColumnHeader headAdet;
        private Label lblToplam;
        private Label lblToplamFiyat;
    }
}