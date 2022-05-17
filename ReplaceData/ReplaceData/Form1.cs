using System;
using System.Windows.Forms;

namespace ReplaceData
{
    public partial class Form1 : Form
    {
        private string[] _id;
        private string _editortext;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void загрузитьIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var action = new Action();
            _id = action.OpenFileId();
        }

        private void загрузитьИзменяемыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var action = new Action();
            
            _editortext = action.OpenFileEditor();
        }

        private void сохранитьИзминенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var action = new Action();
            try
            {
                if (_editortext != null)
                    action.SaveFile(_editortext);
                else
                    MessageBox.Show(@"Ошибка строка пуста");
            }
            catch
            {
                MessageBox.Show(@"Ошибка блока сохранения");
            }
        }

        private void buttonExecuteTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                var action = new Action();
                if (_editortext != null)
                {
                    _editortext = action.Execute(_id, _editortext);
                    MessageBox.Show(@"Файл изменён");
                }
                else
                    MessageBox.Show(@"Ошибка изминения файла");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}