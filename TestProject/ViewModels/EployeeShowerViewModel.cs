using TestProject.Extensions;
using TestProject.Helpers;

namespace TestProject.ViewModel
{
    /// <summary>
    /// ViewModel для работы с формой EmoployeeShower
    /// </summary>
    internal class EployeeShowerViewModel
    {
        /// <summary>
        /// Произвести валидацию параметров для вычислений
        /// </summary>
        private void PerformAllСalculationsValidation(string pathToXslt, string inputPath, string pathResult)
        {
            if (string.IsNullOrEmpty(pathToXslt))
            {
                throw new ArgumentNullException("Не задан путь к файлу Xslt.");
            }

            if (string.IsNullOrEmpty(inputPath))
            {
                throw new ArgumentNullException("Не задан путь к файлу Xml.");
            }

            if (string.IsNullOrEmpty(pathResult))
            {
                throw new ArgumentNullException("Не задано имя файла результата.");
            }

            if (!pathToXslt.EndsWith(".xslt"))
            {
                throw new ArgumentException("У файлу Xslt неверное расширение.");
            }

            if (!inputPath.EndsWith(".xml"))
            {
                throw new ArgumentException("У файлу Xml неверное расширение.");
            }
        }

        /// <summary>
        /// Произвести все вычисления
        /// </summary>
        public void PerformAllСalculations(string pathToXslt, string inputPath, string pathResult)
        {
            PerformAllСalculationsValidation(pathToXslt, inputPath, pathResult);

            XmlHelper.CreateXmlByXslt(pathToXslt, inputPath, pathResult);
            XmlHelper.SetTotalAmountEmployee(pathResult);

            if (inputPath.CheckEndIsData1())
            {
                XmlHelper.SetTotalAmountData1(inputPath);
            }
        }

        /// <summary>
        /// Произвести валидацию параметров для загрузки информацию о сотрудниках
        /// </summary>
        private void LoadEmployeeInfoValidation(ListBox listBox, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("Не задан путь к файлу xml.");
            }

            if (listBox == null)
            {
                throw new ArgumentNullException("Бокс для отборажения элементов не должен быть null");
            }
        }

        /// <summary>
        /// Загрузить информацию о сотрудниках
        /// </summary>
        /// <param name="listBox">Бокс для отображения информации</param>
        /// <param name="path">Путь к файлу</param>
        public void LoadEmployeeInfo(ListBox listBox, string path)
        {
            LoadEmployeeInfoValidation(listBox, path);

            listBox.Items.Clear();

            var employeesInfo = XmlHelper.GetEmployeesInfo(path);

            foreach (var employeeInfo in employeesInfo)
            {
                listBox.Items.Add(employeeInfo.Key);

                employeeInfo.Value.ForEach(x => listBox.Items.Add(x));
            }
        }
    }
}
