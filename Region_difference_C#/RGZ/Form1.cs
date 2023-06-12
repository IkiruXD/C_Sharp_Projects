using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ
{
    public partial class Form1 : Form
    {
        Dictionary<String, double> cityMap;
        public Form1()
        {
            InitializeComponent();
            cityMap = new Dictionary<string, double>();

            cityMap.Add("Агра", +3.5);
            cityMap.Add("Астана", +4);
            cityMap.Add("Афины", +0);
            cityMap.Add("Баку", +2);
            cityMap.Add("Барселона", -1);
            cityMap.Add("Берлин", -1);
            cityMap.Add("Варшава", -1);

            cityMap.Add("Вашингтон", -6);
            cityMap.Add("Гаага", -1);
            cityMap.Add("Гавана", -6);
            cityMap.Add("Дубай", +2);
            cityMap.Add("Дублин", -2);
            cityMap.Add("Евпатория", +1);
            cityMap.Add("Женева", -1);
            cityMap.Add("Задар", -1);
            cityMap.Add("Ибица", -1);
            cityMap.Add("Йоханнесбург", +0);

            cityMap.Add("Киев", +0);
            cityMap.Add("Лондон", -2);
            cityMap.Add("Мадрид", -1);
            cityMap.Add("Милан", -1);
            cityMap.Add("Москва", +1);
            cityMap.Add("Неаполь", -1);
            cityMap.Add("Осло", -1);
            cityMap.Add("Порту", -2);
            cityMap.Add("Рим", -1);

            cityMap.Add("Ростов", +1);
            cityMap.Add("Сочи", +1);
            cityMap.Add("Токио", +7);
            cityMap.Add("Тула", +1);
            cityMap.Add("Уфа", +3);
            cityMap.Add("Хабаровск", +8);
            cityMap.Add("Цюрих", -1);

            cityMap.Add("Чикаго", -7);
            cityMap.Add("Шанхай", +6);
            cityMap.Add("Эйлат", +0);
            cityMap.Add("Юрмала", +0);
            cityMap.Add("Ялта", +1);
            cityMap.Add("Ярославль", +1);

            foreach (var item in Enum.GetNames(typeof(City)))
            {
                comboBox1.Items.Add(item.ToString());
            }

            foreach (var item in Enum.GetNames(typeof(City)))
            {
                comboBox2.Items.Add(item.ToString());
            }

            foreach (var item in Enum.GetNames(typeof(City)))
            {
                comboBox3.Items.Add(item.ToString());
            }
        }



    private void button2_Click(object sender, EventArgs e)  //вычесть время
        {
            int indexOne = comboBox2.SelectedIndex;
            int indexTwo = comboBox3.SelectedIndex;

            ComparisonTime comparison = new ComparisonTime();
            comparison.CityOne = comboBox2.Items[indexOne].ToString();
            comparison.CityTwo = comboBox3.Items[indexTwo].ToString();

            foreach (KeyValuePair<string, double> item in cityMap)
            {
                if (item.Key.Equals(comparison.CityOne))
                {
                    comparison.HourOne = item.Value;
                    break;
                }
            }

            foreach (KeyValuePair<string, double> item in cityMap)
            {
                if (item.Key.Equals(comparison.CityTwo))
                {
                    comparison.HourTwo = item.Value;
                    break;
                }
            }

            label2.Text = comparison.calculateTimeTwoCity();
        }



    private void button1_Click(object sender, EventArgs e)  // показать время
    {
            int index = comboBox1.SelectedIndex;
            string nameCity = comboBox1.Items[index].ToString();

            foreach (KeyValuePair<string, double> item in cityMap) {
                if (item.Key.Equals(nameCity)) {
                    label1.Text = getHourCityTime(nameCity, item.Value);
                    break;
                }
            }

    }
    

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string message =
          "\t\t РГЗ ver 1.1 ." + "\n" + "Программа дает возможность:" +
          "\n\t" + "- выбрать город и узнать время в нём,"
          + "\n\t" + "- а также сравнить время между городами."
          + "\n" + "Приложение можно добавить в автозагрузку и извлечь."
          + "\n\t" + "Если Вы не нашли нужный город," + "\n\t" + "    Вы можете перейти на сайт." +
           "\n\t" + "             Создатель: Iki. (^_^)";
        string caption = "Справка";
        var result = MessageBox.Show(message, caption);
    }

    private void Большегородов_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("http://dateandtime.info/ru/");
    }

    private void добавитьВАвтозагрузкуToolStripMenuItem_Click(object sender, EventArgs e)
    {
        const string name = "RGZ_IKI";
        string ExePath = System.Windows.Forms.Application.ExecutablePath;
        RegistryKey reg;
        reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
        reg.SetValue(name, ExePath);
    }

    private void извлечьИзАвтозагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
        const string name = "RGZ_IKI";
        string ExePath = System.Windows.Forms.Application.ExecutablePath;
        RegistryKey reg;
        reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
        reg.DeleteValue(name);
        reg.Close();
    }

    private string getHourCityTime(string nameCity, double hourTime) {
            DateTime PresentDate = new DateTime();
            PresentDate = DateTime.UtcNow.ToLocalTime();

            string result = "Вы выбрали город: " + nameCity + "\n" + "Точное дата и время: " + PresentDate.AddHours(hourTime).ToLocalTime(); ;
            return result;
        }

    }
}



