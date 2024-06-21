using ödev.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Id = "0";

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;


        }

        private void button26_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("1da68626-2c33-4927-95a8-d1733b937a14", Id);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("9de63242-c683-48b3-926e-6e64d5ac9d05", Id);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("fafeb0bb-d710-4e2f-8274-3ba858e5699e", Id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("6d5670a5-bc46-45d6-9571-32efe1ff5ba4", Id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("9d0002c7-fada-478c-83d7-f4c50202c8cc", Id);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("3ddfe885-921a-4a75-8815-ae8b5f809832", Id);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("458d945f-680c-447b-b159-9188e19abda1", Id);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("70737983-37d3-4993-8e59-d480de92b7b7", Id);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("5ee41757-0af8-4fe3-9136-655c40804a8e", Id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("3f2fa8b6-a90b-42aa-ba28-3d8251e6d1d3", Id);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("83eada45-198f-4df8-b29b-5f0ba74678ca", Id);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("256346e5-5ad3-431a-8e1b-e535dfe80d26", Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("12fbe037-85ee-4735-8723-e1d40a2ec7af", Id);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("a9492c52-c227-415d-a0c2-95550589d8f3", Id);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Business.SepetteArttır("177a01de-2f9a-4c60-b941-9da6dce62584", Id);
        }

        //

        private void button27_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("1da68626-2c33-4927-95a8-d1733b937a14", Id);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("9de63242-c683-48b3-926e-6e64d5ac9d05", Id);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("fafeb0bb-d710-4e2f-8274-3ba858e5699e", Id);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("6d5670a5-bc46-45d6-9571-32efe1ff5ba4", Id);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("9d0002c7-fada-478c-83d7-f4c50202c8cc", Id);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("3ddfe885-921a-4a75-8815-ae8b5f809832", Id);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("458d945f-680c-447b-b159-9188e19abda1", Id);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("70737983-37d3-4993-8e59-d480de92b7b7", Id);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("5ee41757-0af8-4fe3-9136-655c40804a8e", Id);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("3f2fa8b6-a90b-42aa-ba28-3d8251e6d1d3", Id);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("83eada45-198f-4df8-b29b-5f0ba74678ca", Id);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("256346e5-5ad3-431a-8e1b-e535dfe80d26", Id);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("12fbe037-85ee-4735-8723-e1d40a2ec7af", Id);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("a9492c52-c227-415d-a0c2-95550589d8f3", Id);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Business.SepetteAzalt("177a01de-2f9a-4c60-b941-9da6dce62584", Id);

        }

        private void hesapAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Id = Id;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Id = Id;
            form.ShowDialog();
        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Id = "0";
            this.Close();
        }
    }
}
