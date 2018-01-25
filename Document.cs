using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Document : Form
    {
        public Document() //Инициализация компонента
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
/*работа по изменению текста и вывод его в окно. стандартный текст функции без ввода изменений
и дополнительных переменных*/
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainForm F1 = (MainForm)Owner;
            if (Names.Text == "" || Year.Text == "" ||
                Pages.Text == "" || Publisher.Text == "")
            {
                DialogResult Miss;
                Miss = MessageBox.Show("Заполните все обязательные поля");
            }
            else
            {
                if (Author.Text != "")
                {
                    string[] author = Author.Text.Split(';');
                    F1.AddingToList(new DocumentL(Names.Text, Convert.ToInt32(Year.Text),
                    Publisher.Text, Pages.Text, author, GOST.Text));
                    F1.SortButton_Click(sender, e);
                    Close();
                }
                else
                {
                    F1.AddingToList(new DocumentL(Names.Text, Convert.ToInt32(Year.Text),
                    Publisher.Text, Pages.Text, null, GOST.Text));
                    F1.SortButton_Click(sender, e);
                    Close();
                }
            }
        }
    }
}
