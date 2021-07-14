using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySortedList_Deneme_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySortedList1.View = View.Details;
            mySortedList1.FullRowSelect = true;
            mySortedList1.Columns.Add("Şehir", 15);
            mySortedList1.Columns.Add("Posta Kodu", 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Şehir = textBox1.Text;
            string Posta_Kodu = textBox2.Text;
            string[] bilgiler = { Şehir, Posta_Kodu };
            mySortedList1.Items.Add(new ListViewItem(bilgiler));
            MessageBox.Show("Kayıt eklendi.");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seçim = mySortedList1.SelectedItems.Count;
            foreach (ListViewItem bilgi in mySortedList1.SelectedItems)
            { bilgi.Remove(); }
            MessageBox.Show(seçim + " adet kayıt silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int adet_bilgisi = mySortedList1.Items.Count;
            MessageBox.Show(adet_bilgisi + "  adet kayıt yapıldı.");
        }
    }
}
