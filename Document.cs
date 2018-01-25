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
        public Document()
        {
            InitializeComponent(); //
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainForm F1 = (MainForm)Owner; // создается экземпляр формы
			/*выполняется проверка на пустые поля*/
            if (Names.Text == "" || Year.Text == "" ||
                Pages.Text == "" || Publisher.Text == "")
            {
                DialogResult Miss; // выводится сообщение о незаполненных полях
                Miss = MessageBox.Show("Заполните все обязательные поля");
            }
            else
            {
                if (Author.Text != "") // проверка поля Автор на заполненность
                {
					/*не пустой*/
                    string[] author = Author.Text.Split(';');
					 // добавление исчотника с список
                    F1.AddingToList(new DocumentL(Names.Text, Convert.ToInt32(Year.Text),
						Publisher.Text, Pages.Text, author, GOST.Text));
                    F1.SortButton_Click(sender, e);
                    Close();
                }
                else
                {
					/*пустой*/
                    F1.AddingToList(new DocumentL(Names.Text, Convert.ToInt32(Year.Text),
                    Publisher.Text, Pages.Text, null, GOST.Text));
                    F1.SortButton_Click(sender, e);
                    Close();
                }
            }
        }
    }
}
