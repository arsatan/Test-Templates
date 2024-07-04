using Aspose.Words;
using Aspose.Words.Bibliography;
using Aspose.Words.Reporting;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Headers;
using Templates.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace Templates
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }


        private void Mainform_Load(object sender, EventArgs e)
        {
            groupBox1_1.DataContext = new Test1_1();
            userLastName.DataBindings.Add(new Binding("Text", groupBox1_1.DataContext, "UserLastName"));
            userFirstName.DataBindings.Add(new Binding("Text", groupBox1_1.DataContext, "UserFirstName"));
            userMiddleName.DataBindings.Add(new Binding("Text", groupBox1_1.DataContext, "UserMiddleName"));
            groupBox1_2.DataContext = new Test1_2();
            guestFullName.DataBindings.Add(new Binding("Text", groupBox1_2.DataContext, "GuestFullName"));
            guestBirthDate.DataBindings.Add(new Binding("Value", groupBox1_2.DataContext, "GuestBirthDate"));
            totalStaySum.DataBindings.Add(new Binding("Value", groupBox1_2.DataContext, "TotalStaySum"));
        }
        private void button1_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userLastName.Text) || string.IsNullOrEmpty(userFirstName.Text))
            {
                MessageBox.Show("Не заполнены данные Фамилия/Имя");
                return;
            }
            if (groupBox1_1.DataContext != null)
                PrintDoc.Print(@"templates\template1_1.docx", @"results\result1_1.docx", groupBox1_1.DataContext);
        }
        private void button1_2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guestFullName.Text))
            {
                MessageBox.Show("Не заполнены данные ФИО");
                return;
            }
            if (groupBox1_2.DataContext != null)
                PrintDoc.Print(@"templates\template1_2.docx", @"results\result1_2.docx", groupBox1_2.DataContext);
        }

        private void totalStaySum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
            Task2_1 task2_1 = new Task2_1();
            char[] symbols = task2_1.GetData(DateTime.Parse("21.05.2006 0:00:00"));
            foreach (char symbol in symbols)
            {
                richTextBoxOutput.Text = richTextBoxOutput.Text + "[" + symbol + "]";
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
            Task2_2 task2_2 = new Task2_2();
            richTextBoxOutput.Text = "с ИНН: ";
            char[] symbols = task2_2.GetData("6022", "767579", true);
            foreach (char symbol in symbols)
            {
                richTextBoxOutput.Text = richTextBoxOutput.Text + "[" + symbol + "]";
            }
            richTextBoxOutput.Text = richTextBoxOutput.Text + "\r\nБез ИНН: ";
            symbols = task2_2.GetData("6022", "767579", false);
            foreach (char symbol in symbols)
            {
                richTextBoxOutput.Text = richTextBoxOutput.Text + "[" + symbol + "]";
            }
        }

        private void button2_3_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
            Task2_3 task2_3 = new Task2_3();
            richTextBoxOutput.Text = "для (14): ";
            char[] symbols = task2_3.GetData("ВРУДОРФ", "Временное удостоверение РФ");
            foreach (char symbol in symbols)
            {
                richTextBoxOutput.Text = richTextBoxOutput.Text + "[" + symbol + "]";
            }
        }
    }
    internal static class PrintDoc
    {
        internal static void Print(string templateName, string outputName, object sender)
        {
            Document doc = new Document(templateName);
            ReportingEngine engine = new ReportingEngine();
            engine.BuildReport(doc, sender, "sender");
            doc.Save(outputName);
            MessageBox.Show("Результат в " + outputName);
            //MessageBox.Show(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase("text text"));
        }
    }
    public class Test1
    {
    }
    public class Test1_1 : Test1
    {
        public string UserLastName { get; set; } = "";
        public string UserFirstName { get; set; } = "";
        public string? UserMiddleName { get; set; }
    }
    public class Test1_2 : Test1
    {
        public string GuestFullName { get; set; } = "РЕШЕТНИКОВ АНТОН НИКОЛАЕВИЧ";
        public DateTime GuestBirthDate { get; set; } = DateTime.Parse("21/05/2006");
        //public string[] GuestBirthDateGenitiveMonthNames { get; set; } = DateTimeWorks.GetGenitiveNames("ru-RU");
        public decimal TotalStaySum { get; set; } = (decimal)24000.00;
        public RuConverter RuConverter { get; set; } = new RuConverter();//.CurrencyToTxt(568.98, false);
    }
    internal class DateTimeWorks
    {
        internal static string[] GetGenitiveNames(string cultureInfoId)
        {
            var cultureInfo = CultureInfo.GetCultureInfo(cultureInfoId);
            return cultureInfo.DateTimeFormat.MonthGenitiveNames;
        }
    }
}
