using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReplaceData
{
    internal class Action
    {
        private readonly Form1 _form1 = new();

        public static List<Id> IdList = new();

        public struct Id
        {
            public Id(string name, string code)
            {
                Name = name;
                Code = code;
            }

            public string Name, Code;
        }

        public static string RemovingGaps(ref string str)
        {
            str = str.Replace(" ", "");
            return str;
        }

        public static void Parser(string[] id)
        {
            foreach (var t in id)
            {
                var name = t[..t.IndexOf('=')];
                var code = t.Substring(t.IndexOf('=') + 1,
                    t.Length - t.IndexOf('=') - 1);
                var token = new Id(name, code);
                IdList.Add(token);
            }
        }

        public string OpenFileEditor()
        {
            if (_form1.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return "";

            // получаем выбранный файл
            var filename = _form1.openFileDialog1.FileName;
            // читаем файл в строку
            var fileText = File.ReadAllText(filename);

            MessageBox.Show(@"Код программы записан");

            return fileText;
        }

        public string[] OpenFileId()
        {
            if (_form1.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return new[] {""};

            // получаем выбранный файл
            var filename = _form1.openFileDialog1.FileName;
            // читаем файл в строку
            var fileText = File.ReadAllLines(filename);

            MessageBox.Show(@"Код программы записан");

            return fileText;
        }

        public void SaveFile(string str)
        {
            if (_form1.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // Сохранем в выбранный файл
            var filename = _form1.saveFileDialog1.FileName;
            // Сохраняем текст
            File.WriteAllText(filename, str);

            MessageBox.Show(@"Файл сохранён");
        }

        public string Execute(string[] id, string editortext)
        {
            Parser(id);
            RemovingGaps(ref editortext);

            foreach (var x in IdList.Where(x => editortext.Contains(x.Name)))
            {
                editortext = editortext.Replace(x.Name, x.Code);
            }

            return editortext;
        }
    }
}