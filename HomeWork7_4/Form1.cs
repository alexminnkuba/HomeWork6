using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_selectsources_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_sources.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button_selectdestination_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog= new FolderBrowserDialog())
            {
                if(folderBrowserDialog.ShowDialog()==DialogResult.OK)
                {
                    textBox_destinationt.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        private async void button_start_Click(object sender, EventArgs e)
        {
            string sourcesDir = textBox_sources.Text;
            string destinationDir = textBox_destinationt.Text;
            if(string.IsNullOrEmpty(sourcesDir) || string.IsNullOrEmpty(destinationDir))
            {
                MessageBox.Show("Необходимо выбрать обе директории!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Directory.Exists(sourcesDir) ||  !Directory.Exists(destinationDir))
            {
                MessageBox.Show("Одна из директорий не существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label1.Text = "Обработка начата...";
            try
            {
                await Task.Run(() => MoveUniqueFiles(sourcesDir, destinationDir));
                label1.Text = "Обработка завершена";
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void MoveUniqueFiles(string sources, string destination )
        {
            string reportPath = Path.Combine(destination, "report.txt");
            try
            {
                var files = Directory.GetFiles(sources);
                var fileNames = new HashSet<string>();

                using(StreamWriter writer = new StreamWriter(reportPath))
                {
                    foreach (var file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        if (fileNames.Add(fileName))
                        {
                            string destinationFile = Path.Combine(destination, fileName);
                            File.Move(file, destinationFile);
                            writer.WriteLine($"Файл {fileName} успешно перемещен в {destination}");
                        }
                        else
                        {
                            writer.WriteLine($"Файл {fileName} уже существует в директории {destination} не был перемещен!");
                        }
                    }
                }            
            }
            catch(Exception ex)
            {                
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}
