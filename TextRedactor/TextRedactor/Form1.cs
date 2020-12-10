using System;
using System.IO;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class Form1 : Form
    {
        File file;
        public Form1()
        {
            InitializeComponent();
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = new File(openFileDialog1, saveFileDialog1, richTextBox1);
            file.SaveAsFile();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = new File(openFileDialog1, saveFileDialog1, richTextBox1);
            file.OpenFile();
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = new File(openFileDialog1, saveFileDialog1, richTextBox1);
            file.OpenFile();
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

     

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }
    }
}
