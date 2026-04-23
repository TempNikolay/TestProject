using TestProject.Helpers;

namespace TestProject
{
    /// <summary>
    /// Форма добавления нового элемента
    /// </summary>
    public partial class AddItemForm : Form
    {
        private readonly string _path;

        public AddItemForm(string path)
        {
            InitializeComponent();
            _path = path;
        }

        /// <summary>
        /// Обработать клик Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            XmlHelper.AddNewItemToData1(_path, nameText.Text, surnameText.Text, amountText.Text, monthText.Text);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
