using System.Xml.Linq;
using System.Xml.Xsl;
using TestProject.Extensions;
using TestProject.Helpers;
using TestProject.ViewModel;

namespace TestProject
{
    /// <summary>
    /// Форма отображения информации о сотрудниках
    /// </summary>
    public partial class EmployeesShowerForm : Form
    {
        private string _pathToResult;
        private readonly EployeeShowerViewModel viewModel;

        public EmployeesShowerForm()
        {
            InitializeComponent();
            viewModel = new EployeeShowerViewModel();
            ChangeVisibility();
        }

        /// <summary>
        /// Обработать клик по Рассчитать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcXmlButton_Click(object sender, EventArgs e)
        {
            _pathToResult = $"{fileResultNameText.Text}.xml";

            viewModel.PerformAllСalculations(pathToXsltText.Text, pathToXmlText.Text, _pathToResult);
            viewModel.LoadEmployeeInfo(resultList, _pathToResult);
        }

        /// <summary>
        /// ОБработать клик по Добавить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addItemButton_Click(object sender, EventArgs e)
        {
            var addItemForm = new AddItemForm(pathToXmlText.Text);

            addItemForm.ShowDialog();
        }

        /// <summary>
        /// Обработать клик по Выбрать для Xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toXmlButton_Click(object sender, EventArgs e)
        {
            SelectNewFile(pathToXmlText, "XML files (*.xml)|*.xml");
        }

        /// <summary>
        /// Обработать клик по Выбрать для Xslt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toXsltButton_Click(object sender, EventArgs e)
        {
            SelectNewFile(pathToXsltText, "XSLT files (*.xslt)|*.xslt");
        }

        /// <summary>
        /// Обработать изменение путей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pathText_TextChanged(object sender, EventArgs e)
        {
            ChangeVisibility();
        }

        /// <summary>
        /// Выбрать новый файл
        /// </summary>
        /// <param name="path">Путь до файла</param>
        /// <param name="format">Формат файла</param>
        private void SelectNewFile(TextBox path, string format)
        {
            openFileDialog.Filter = format;

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            path.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Изменить видимость
        /// </summary>
        private void ChangeVisibility()
        {
            var isInserted = CheckInsertPathes();

            calcXmlButton.Visible = isInserted;
            resultList.Visible = isInserted;
            addItemButton.Visible = isInserted && pathToXmlText.Text.CheckEndIsData1();
        }

        /// <summary>
        /// Проверить заполненность путей
        /// </summary>
        /// <returns></returns>
        private bool CheckInsertPathes()
        {
            return !string.IsNullOrEmpty(pathToXsltText.Text) && !string.IsNullOrEmpty(pathToXmlText.Text);
        }
    }
}
