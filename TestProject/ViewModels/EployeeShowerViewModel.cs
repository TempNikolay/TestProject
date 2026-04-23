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
        /// Произвести все вычисления
        /// </summary>
        public void PerformAllСalculations(string pathToXslt, string inputPath, string pathResult)
        {
            XmlHelper.CreateXmlByXslt(pathToXslt, inputPath, pathResult);
            XmlHelper.SetTotalAmountEmployee(pathResult);

            if (inputPath.CheckEndIsData1())
            {
                XmlHelper.SetTotalAmountData1(inputPath);
            }
        }

        public void LoadEmployeeInfo(ListBox listBox, string path)
        {
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
