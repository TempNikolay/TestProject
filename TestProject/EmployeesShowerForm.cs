using System.Xml.Linq;
using System.Xml.Xsl;

namespace TestProject
{
    public partial class EmployeesShowerForm : Form
    {
        private string _pathToResult;

        public EmployeesShowerForm()
        {
            InitializeComponent();
        }

        private void pathText_TextChanged(object sender, EventArgs e)
        {
            var isInserted = CheckInsertPathes();
            calcXmlButton.Visible = isInserted;
            resultList.Visible = isInserted;

            if (isInserted)
            {
                var fileInfo = new FileInfo(pathToXmlText.Text);

                addItemButton.Visible = fileInfo.Name == "Data1.xml";
            }
        }

        private void toXmlButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pathToXmlText.Text = openFileDialog.FileName;
        }

        private void toXsltButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XSLT files (*.xslt)|*.xslt";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pathToXsltText.Text = openFileDialog.FileName;
        }

        private void calcXmlButton_Click(object sender, EventArgs e)
        {
            _pathToResult = $"{fileResultNameText.Text}.xml";

            CreateXmlByXslt();
            ReloadInfo();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var addItemForm = new AddItemForm(pathToXmlText.Text);

            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                ReloadInfo();
            }
        }

        private void ReloadInfo()
        {
            CalcTotalAmountEmployee();
            CalcTotalAmountData1();
            ShowEmployeesInfo();
        }

        private void CreateXmlByXslt()
        {
            var xslt = new XslCompiledTransform();

            xslt.Load(pathToXsltText.Text);
            xslt.Transform(pathToXmlText.Text, _pathToResult);
        }

        private void CalcTotalAmountEmployee()
        {
            var doc = XDocument.Load(_pathToResult);

            foreach (var emp in doc.Descendants("Employee"))
            {
                var totalAmount = emp.Descendants("salary")
                    .Sum(i => ParseAmount((string)i.Attribute("amount")));

                emp.SetAttributeValue("totalSalary", totalAmount.ToString());
            }

            doc.Save(_pathToResult);
        }

        private void CalcTotalAmountData1()
        {
            var doc = XDocument.Load(pathToXmlText.Text);

            var total = doc.Descendants("item")
                .Sum(i => ParseAmount((string)i.Attribute("amount")));

            doc.Root?.SetAttributeValue("totalAmount", total.ToString());

            doc.Save(pathToXmlText.Text);
        }

        private void ShowEmployeesInfo()
        {
            resultList.Items.Clear();

            var doc = XDocument.Load(_pathToResult);

            foreach (var emp in doc.Descendants("Employee"))
            {
                string name = (string)emp.Attribute("name");
                string surname = (string)emp.Attribute("surname");
                string totalSum = (string)emp.Attribute("totalSalary") ?? "0";

                resultList.Items.Add($"{name} {surname} — Итого: {totalSum}");

                var months = emp.Descendants("salary")
                    .GroupBy(s => (string)s.Attribute("mount"))
                    .ToDictionary(
                        g => g.Key,
                        g => g.Sum(s => ParseAmount((string)s.Attribute("amount")))
                    );

                foreach (var m in months)
                {
                    resultList.Items.Add($"   {m.Key}: {m.Value}");
                }

                resultList.Items.Add("---");
            }
        }

        private double ParseAmount(string amountStr)
        {
            if (string.IsNullOrEmpty(amountStr))
            {
                return 0;
            }

            return double.TryParse(amountStr.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                out double val) ? val : 0;
        }

        private bool CheckInsertPathes()
        {
            return !string.IsNullOrEmpty(pathToXsltText.Text) && !string.IsNullOrEmpty(pathToXmlText.Text);
        }
    }
}
