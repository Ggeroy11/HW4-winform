using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homewWork4
{
    public partial class SaveUndoForm : Form
    {
        
        public SaveUndoForm(LoadEditForm loadEditForm)
        {
            InitializeComponent();
            

        }
        public string Path { get ; set; }
        public void InitializeText(string text)
        {
            SaveUndoTextBox.Text = text;
        }

        private void SaveUndoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            System.IO.File.WriteAllText(@"C:\text.txt", SaveUndoTextBox.Text);
        }
    }
}
