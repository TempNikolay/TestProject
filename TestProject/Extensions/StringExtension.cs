namespace TestProject.Extensions
{
    /// <summary>
    /// Расширение для String
    /// </summary>
    internal static class StringExtension
    {
        /// <summary>
        /// Конвертировать строку в double
        /// </summary>
        /// <param name="value">Значение строки</param>
        /// <returns>Результат типа double</returns>
        public static double ConvertToDouble(this string value)
            => double.TryParse(value?.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                out double val) ? val : 0;

        /// <summary>
        /// Проверить окончание на Data1
        /// </summary>
        /// <param name="value">Значение строки</param>
        /// <returns>Содержит</returns>
        public static bool CheckEndIsData1(this string value)
            => value.EndsWith("Data1.xml");
    }
}
