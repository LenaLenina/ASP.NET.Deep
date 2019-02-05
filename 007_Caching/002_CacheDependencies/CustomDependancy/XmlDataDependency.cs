using System;
using System.IO;
using System.Threading;
using System.Web.Caching;
using System.Xml;
namespace CustomDependancy
{
    public class XmlDataCacheDependency : CacheDependency
    {
        // Объект для вызова метода с определенным интервалом.
        static Timer _timer;

        // Интервал между вызовами метода проверки изменений в файле.
        int _interval = 0;

        string _fileName;
        string _xpathExpression;
        string _currentValue;

        // Конструктор.
        public XmlDataCacheDependency(string fileName, string xpath, int interval)
        {
            _fileName = fileName;
            _xpathExpression = xpath;
            _interval = interval;

            // Чтение текущего значения из файла.
            _currentValue = ReadDataFromFile();

            // Установка таймера.
            if (_timer == null)
            {
                int ms = _interval * 1000;

                // Метод, который будет запускаться с определенным интервалом.
                TimerCallback cb = new TimerCallback(XmlDataCallback);

                // Создание и запуск таймера.
                // 1 параметр - метод, который будет вызываться с указанным интервалом.
                // 2 параметр - объект, который будет передан, как аргумент в метод.
                // 3 параметр - через какое время таймер стартует.
                // 4 параметр - интервал между вызовами метода.
                _timer = new Timer(cb, this, ms, ms);
            }
        }

        public string CurrentValue
        {
            get { return _currentValue; }
        }

        public static void XmlDataCallback(object sender)
        {
            XmlDataCacheDependency dep = (XmlDataCacheDependency)sender;

            string value = dep.ReadDataFromFile();

            // Если данные прочтенные из файла и хранящиеся в кэше разные - оповещаем об изменениях.
            if (dep._currentValue != value)
                dep.NotifyDependencyChanged(dep, EventArgs.Empty);
        }

        string ReadDataFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_fileName);

            // Получение данных из файла по выражению, которое задал пользователь.
            XmlNode node = doc.SelectSingleNode(_xpathExpression);

            return node.InnerText;
        }

        protected override void DependencyDispose()
        {
            _timer.Dispose();
            _timer = null;
            base.DependencyDispose();
        }
    }
}
