using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml;
using HtmlAgilityPack;


namespace IDZ_OPI
{
    interface ILoader { 
        string Load(string path); 
    }
    interface IFactory
    {
        ILoader CreateLoader();
    }

    class TxtLoader : ILoader
    {
        public string Load(string path) => File.ReadAllText(path, Encoding.UTF8);
    }
    class HtmlLoader : ILoader
    {
        public string Load(string path)
        {
            var document = new HtmlAgilityPack.HtmlDocument();
            document.Load(path, Encoding.UTF8);
            var sb = new StringBuilder();

            foreach (var p in document.DocumentNode.SelectNodes("//p|//br") ?? Enumerable.Empty<HtmlNode>())
            {
                string text = HtmlEntity.DeEntitize(p.InnerText).Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    sb.AppendLine(text);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
    class BinLoader : ILoader
    {
        public string Load(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            return Encoding.UTF8.GetString(bytes);
        }
    }

    class TxtFactory : IFactory
    {
        public ILoader CreateLoader() => new TxtLoader();
    }
    class HtmlFactory : IFactory
    {
        public ILoader CreateLoader() => new HtmlLoader();
    }
    class BinFactory : IFactory
    {
        public ILoader CreateLoader() => new BinLoader();
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fullPathname = openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathname);
            filename.Text = src.Name;

            IFactory factory;
            string extension = Path.GetExtension(fullPathname).ToLower();

            switch (extension)
            {
                case ".html":
                    factory = new HtmlFactory();
                    break;
                case ".bin":
                    factory = new BinFactory();
                    break;
                default:
                    factory = new TxtFactory();
                    break;
            }

            ILoader loader = factory.CreateLoader();
            source.Text = loader.Load(fullPathname);
        }

        private void getStatistics_Click(object sender, EventArgs e)
        {
            string text = source.Text;

            string vowels = "аеєиіїоуюяыэАЕЄИІЇОУЮЯЫЭaeiouAEIOU";
            string consonants = "бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩbcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            int symbolsCount = 0;
            int vowelCount = 0;
            int consonantCount = 0;
            int digitCount = 0;
            int punctuationCount = 0;
            int specialSymbolCount = 0;
            int cyrillicCount = 0;
            int latinCount = 0;
            int pageCount = 1;


            foreach (char c in text)
            {
                symbolsCount++;

                if (vowels.Contains(c))
                    vowelCount++;
                else if (consonants.Contains(c))
                    consonantCount++;
                else if (char.IsDigit(c))
                    digitCount++;
                else if (char.IsPunctuation(c))
                    punctuationCount++;
                else if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                    specialSymbolCount++;

                if (c >= '\u0400' && c <= '\u04FF')
                    cyrillicCount++;

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    latinCount++;
            }

            if (symbolsCount > 1800)
                pageCount++;

            string[] words = text.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            int paragraphCount = text.Split(new[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries).Length;

            string fullPathname = openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathname);
            double fileSize = src.Length / 1024.0;

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Кількість символів: {symbolsCount}");
            result.AppendLine($"Кількість голосних: {vowelCount}");
            result.AppendLine($"Кількість приголосних: {consonantCount}");
            result.AppendLine($"Кількість цифр: {digitCount}");
            result.AppendLine($"Кількість знаків пунктуації: {punctuationCount}");
            result.AppendLine($"Кількість спеціальних символів: {specialSymbolCount}");
            result.AppendLine($"Кількість кириличних літер: {cyrillicCount}");
            result.AppendLine($"Кількість латинських літер: {latinCount}");
            result.AppendLine($"Кількість авторських сторінок: {pageCount}");
            result.AppendLine($"Кількість слів: {wordCount}");
            result.AppendLine($"Кількість абзаців: {paragraphCount}");
            result.AppendLine($"Розмір файлу: {fileSize} кілобайт");

            statistics.Text = result.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(source.Text))
            {
                MessageBox.Show("Немає тексту для збереження");
                return;
            }

            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти новини";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fullPathname = saveFileDialog.FileName;
            try
            {
                File.WriteAllText(fullPathname, source.Text, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message);
            }
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            source.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            source.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            source.Paste();
        }

        private void aboutAuthor_Click(object sender, EventArgs e)
        {

            DateTime thisDay = DateTime.Now;
            MessageBox.Show($"  Файл був відкритий {thisDay.ToString("g")}");
        }

        private void getCorrectMailAdresses_Click(object sender, EventArgs e)
        {
            string text = source.Text;
            Regex regex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,7}\b");
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Існуючі електронні адреси:");
                foreach (Match match in matches)
                {
                    sb.AppendLine(match.Value);
                }
                statistics.Text = sb.ToString();
            }
            else
            {
                statistics.Text = "Електронних адрес не знайдено";
            }

        }

        private void copyFile_Click(object sender, EventArgs e)
        {
            string[] lines = source.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            List<string> uniqueLines = new List<string>();

            string previousLine = null;
            foreach (string line in lines)
            {
                if (previousLine == null || line.Trim() != previousLine.Trim())
                {
                    uniqueLines.Add(line);
                }
                previousLine = line;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, uniqueLines);
                statistics.Text = "Файл успішно збережено без повторюваних рядків!";
            }

        }

        private void getNews_Click(object sender, EventArgs e)
        {
            string url = "https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr";
            filename.Text = url;

            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = http.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string html = sr.ReadToEnd();

            string pattern = @"<div class=""znu-2016-new-img-list-info"">.*?<h4>\s*<a.*?>(.*?)</a>\s*</h4>.*?<div class=""text"">\s*<p>(.*?)</p>";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Singleline);

            if (matches.Count == 0)
            {
                MessageBox.Show("Новини не знайдено");
                return;
            }

            if (string.IsNullOrWhiteSpace(maxVal.Text))
            {
                MessageBox.Show("Обмежте кількість новин для перегляду");
                return;
            }

            if (!int.TryParse(maxVal.Text, out int max) || max <= 0)
            {
                MessageBox.Show("Введіть коректне ціле число для кількості новин");
                return;
            }

            var builder = new StringBuilder();

            foreach (Match match in matches.Cast<Match>().Take(max))
            {
                string title = Regex.Replace(match.Groups[1].Value, "<.*?>", "").Trim();
                string anons = Regex.Replace(match.Groups[2].Value, "<.*?>", "").Trim();

                builder.AppendLine("Заголовок: " + title);
                builder.AppendLine("Анотація: " + anons);
                builder.AppendLine();
            }

            source.Text = builder.ToString();

        }
    }
}
