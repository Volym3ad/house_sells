using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace house_sells
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            groupBox1.Text = "Про компанію";
            label1.Text = "Рієлторська компанія була заснована в 2010 році. Основний орієнтир компанії - надання рієлторських" + "\n" + "послуг принципово нової якості в нових умовах ринку нерухомості."
                + "\n" + "Якісне обслуговування для нас визначається в першу чергу, виходячи з орієнтації на довгу співпрацю" + "\n" + "з Вами, а також із розрахунку отримання Вашої рекомендації наших послуг своїм друзям і знайомим."
                + "\n\n" + "Наша адреса: місто Київ, вулиця Панаса Мирного 19";
            webBrowser1.Navigate("https://maps.yandex.ua/143/kyiv/?ncrnd=2287&ll=30.535821%2C50.433776&z=15&text=%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B0%2C%20%D0%9A%D0%B8%D1%97%D0%B2%2C%20%D0%B2%D1%83%D0%BB%D0%B8%D1%86%D1%8F%20%D0%9F%D0%B0%D0%BD%D0%B0%D1%81%D0%B0%20%D0%9C%D0%B8%D1%80%D0%BD%D0%BE%D0%B3%D0%BE%2C%2019&sll=30.535800%2C50.433872&sspn=0.013304%2C0.007113&ol=geo&oll=30.535821%2C50.433776");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
