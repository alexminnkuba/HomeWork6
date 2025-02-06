using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7_1
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource token;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            string text = textBox1.Text;
            if(string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст!");
                return;
            }
            token = new CancellationTokenSource();
            try
            {
                bool sentences = checkBox_sentences.Checked;
                bool characters = checkBoxchar.Checked;
                bool word = checkBox_word.Checked;
                bool questions = checkBox_question.Checked;
                bool exclamations = checkBox_exclamation.Checked;

                var report = await Task.Run(() => AnalizeText(text,token.Token, sentences,
                    characters, word, questions, exclamations),token.Token);
                label1.Text = report;
            }
           catch(OperationCanceledException)
            {
                label1.Text = "Анализ текста отменен!";
            }
            finally
            {
                token.Dispose();
            }
        }
        private string AnalizeText(string text, CancellationToken token, bool sentences, bool characters,
            bool word, bool questions, bool exclamations)
        {
                token.ThrowIfCancellationRequested();

            StringBuilder report = new StringBuilder("Отчет:\n");
            if(sentences)
            {
                int sentenceCount = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
                report.AppendLine($"Количество предложений: {sentenceCount}");
            }
           if(characters)
            {
                int charCount = text.Length;
                report.AppendLine($"Количество символов: {charCount}");
            }
           if(word)
            {
                int wordCount = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                report.AppendLine($"Количество слов: {wordCount}");
            }
         if(questions)
            {
                int questionCount = text.Split('?').Length - 1;
                report.AppendLine($"Количество вопросительных предложений: {questionCount}");
            }
           if(exclamations)
            {
                int exclamationCount = text.Split('!').Length - 1;
                report.AppendLine($"Количество восклицательных предложений: {exclamationCount}");
            }
           return report.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
           await SaveReportAsync(label1.Text);
        }
        private async Task SaveReportAsync(string text)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = new StreamWriter(fileDialog.FileName))
                {
                    await writer.WriteLineAsync(text);
                }
                MessageBox.Show("Файл отчета сохранен!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            token.Cancel();
        }
    }
}
