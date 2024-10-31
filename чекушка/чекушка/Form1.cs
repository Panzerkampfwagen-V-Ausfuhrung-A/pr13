using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace чекушка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пР_13_BD_Tur_FirmDataSet.Информация_о_туристах". При необходимости она может быть перемещена или удалена.
            this.информация_о_туристахTableAdapter.Fill(this.пР_13_BD_Tur_FirmDataSet.Информация_о_туристах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пР_13_BD_Tur_FirmDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.пР_13_BD_Tur_FirmDataSet.Туристы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            туристыTableAdapter.Update(пР_13_BD_Tur_FirmDataSet);
            информация_о_туристахTableAdapter.Update(пР_13_BD_Tur_FirmDataSet);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
