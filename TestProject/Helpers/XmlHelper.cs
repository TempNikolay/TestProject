using System.Xml.Linq;
using System.Xml.Xsl;
using TestProject.Extensions;

namespace TestProject.Helpers
{
    /// <summary>
    /// Хелпер для работы с Xml
    /// </summary>
    internal static class XmlHelper
    {
        /// <summary>
        /// Создать Xml-файл по Xstl
        /// </summary>
        /// <param name="pathToXslt">Путь до Xstl-преобразования</param>
        /// <param name="inputPath">Путь для Xml-файла ввода</param>
        /// <param name="resultPath">Путь для Xml-файла результата</param>
        public static void CreateXmlByXslt(string pathToXslt, string inputPath, string resultPath)
        {
            var xslt = new XslCompiledTransform();

            xslt.Load(pathToXslt);
            xslt.Transform(inputPath, resultPath);
        }

        /// <summary>
        /// Записать полную сумма сотрудников
        /// </summary>
        /// <param name="pathToXml">Путь до файла Xml</param>
        public static void SetTotalAmountEmployee(string pathToXml)
        {
            var doc = XDocument.Load(pathToXml);

            foreach (var emp in doc.Descendants("Employee"))
            {
                var totalAmount = emp.Descendants("salary")
                    .Sum(i => ((string)i.Attribute("amount")).ConvertToDouble());

                emp.SetAttributeValue("totalSalary", totalAmount.ToString());
            }

            doc.Save(pathToXml);
        }

        /// <summary>
        /// Записать полную сумма сотрудников
        /// </summary>
        /// <param name="pathToXml">Путь до файла Xml</param>
        public static void SetTotalAmountData1(string pathToXml)
        {
            var doc = XDocument.Load(pathToXml);

            var total = doc.Descendants("item")
                .Sum(i => ((string)i.Attribute("amount")).ConvertToDouble());

            doc.Root?.SetAttributeValue("totalAmount", total.ToString());

            doc.Save(pathToXml);
        }

        /// <summary>
        /// Получить информацию о сотрудниках
        /// </summary>
        /// <param name="pathToXml">Путь до xml файла</param>
        public static Dictionary<string, List<string>> GetEmployeesInfo(string pathToXml)
        {
            var doc = XDocument.Load(pathToXml);
            var result = new Dictionary<string, List<string>>();

            foreach (var emp in doc.Descendants("Employee"))
            {
                var name = (string)emp.Attribute("name");
                var surname = (string)emp.Attribute("surname");
                var totalSum = (string)emp.Attribute("totalSalary") ?? "0";
                var key = $"{name} {surname} — Итого: {totalSum}";

                result.Add(key, new List<string>());

                var salaryInfo = emp.Descendants("salary")
                    .GroupBy(s => (string)s.Attribute("mount"))
                    .ToDictionary(
                        g => g.Key,
                        g => g.Sum(s => ((string)s.Attribute("amount")).ConvertToDouble())
                    );

                foreach (var s in salaryInfo)
                {
                    result[key].Add($"   {s.Key}: {s.Value}");
                }
            }

            return result;
        }

        /// <summary>
        /// Добавить новый элемент в Data1
        /// </summary>
        /// <param name="pathToXml">Путь до файла</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="amount">Сумма</param>
        /// <param name="month">Месяц</param>
        public static void AddNewItemToData1(string pathToXml, string name, string surname, string amount, string month)
        {
            var doc = XDocument.Load(pathToXml);

            var newItem = new XElement("item",
                new XAttribute("name", name),
                new XAttribute("surname", surname),
                new XAttribute("amount", amount),
                new XAttribute("mount", month)
            );

            doc.Root?.Add(newItem);

            doc.Save(pathToXml);
        }
    }
}
