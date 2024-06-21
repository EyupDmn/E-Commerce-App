namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void girişbutton_Click(object sender, EventArgs e)
        {
            var id = Business.GirisYap(kullanıcıadıtextBox.Text, parolatextBox.Text);
            if (id != "0")
            {
                Form2 form = new Form2();
                form.Id = id;
                form.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!\n");
            }
        }

        private void kayıtbutton1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }
    }
}
