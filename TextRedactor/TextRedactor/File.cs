using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextRedactor
{
    class File
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        RichTextBox richTextBox = new RichTextBox();
        public File(OpenFileDialog openFileDialog, SaveFileDialog saveFileDialog, RichTextBox richTextBox)
        {
            this.saveFileDialog = saveFileDialog;
            this.openFileDialog = openFileDialog;
            this.richTextBox = richTextBox;
        }

        public void SaveFile()
        {
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, richTextBox.Text);
        }

        public void SaveAsFile ()
        {
            saveFileDialog.Filter = "Text File(*.txt)|*.txt|Ant TextRedactor File (*.tnf)|*.tnf";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, richTextBox.Text);
        }

        public void OpenFile()
        {
            openFileDialog.Filter = "Text File(*.txt)|*.txt|Ant TextRedactor File (*.tnf)|*.tnf";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBox.Text = fileText;
        }

    }
}
