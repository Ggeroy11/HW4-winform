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
    public partial class LoadEditForm : Form
    {

        SaveUndoForm saveundo;
        private string path = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
        private string copytext = "";

        public LoadEditForm()
        {
            InitializeComponent();
            saveundo = new SaveUndoForm(this);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = path;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            LoadEditTextBox.Text = fileText;
            saveundo.InitializeText(fileText);
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
           
            saveundo.Show();
            
            
        }

        private void LoadTextBox_TextChanged(object sender, EventArgs e)
        {
            EditButton.Enabled=true;

        }
    }
}
