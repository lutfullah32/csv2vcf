using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace excel2vcf
{
    public partial class Form1 : Form
    {
        string file;
        public Form1()
        {
            InitializeComponent();
            //textBox1.Text = @"C:\testcsv.csv";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Dosyası |*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] row = { "ad", "test" };
            //var listViewItem = new ListViewItem(row);
            //listView1.Items.Add(listViewItem);
            listView1.Columns.Add("Adı Soyadı", 300);
            listView1.Columns.Add("Telefon", 300);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Text.EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);
            if (textBox1.Text != "")
            {
                try
                {


                    StreamReader sr = new StreamReader(textBox1.Text, Encoding.GetEncoding("iso-8859-9"));
                    StreamReader vcfFormat = new StreamReader("vcfFormat.txt", Encoding.Default);
                    string svcfFormat = vcfFormat.ReadToEnd();
                    file = "";
                    listView1.Items.Clear();
                    bool isFirstLine = true;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (isFirstLine && checkBox1.Checked)
                        {
                            isFirstLine = !isFirstLine;
                            continue;
                        }
                        var arrayLine = line.Split(";");
                        if (radioButtonIOS.Checked)
                            arrayLine[0] = TurkishCharacterToEnglish(textBox2.Text + arrayLine[0]);
                        else
                            arrayLine[0] = textBox2.Text + arrayLine[0];
                        listView1.Items.Add(new ListViewItem(arrayLine));
                        string tempFormat = svcfFormat.Replace("$name$", arrayLine[0]);
                        tempFormat = tempFormat.Replace("$tel$", arrayLine[1]);
                        file = file + tempFormat;

                    }
                    sr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen dosya seçiniz!.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string devicetext = radioButtonIOS.Checked ? " - ios" : " - android";
            Encoding encoding = radioButtonIOS.Checked ? Encoding.Default : Encoding.UTF8;
            StreamWriter sw = new StreamWriter("rehber" + devicetext + ".vcf",false, encoding);
            sw.WriteLine(file);
            sw.Close();
            MessageBox.Show("Dosya indirildi.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string TurkishCharacterToEnglish(string text)
        {
            char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
            char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };

            // Match chars
            for (int i = 0; i < turkishChars.Length; i++)
                text = text.Replace(turkishChars[i], englishChars[i]);

            return text;
        }
    }
}
