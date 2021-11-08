using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace laboratory3
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InitializeGrayText();
            MessageBox.Show("Создан массив на 5 книг. \nРабота происходит с этим массивом");
        }
        public void InitializeGrayText()
        {
            textBoxSerialNumber.ForeColor = Color.Gray;
            textBoxSerialNumber.Text = "Серийный номер";

            textBoxTitle.ForeColor = Color.Gray;
            textBoxTitle.Text = "Название книги";

            textBoxPrice.ForeColor = Color.Gray;
            textBoxPrice.Text = "Цена";

            textBoxQuantity.ForeColor = Color.Gray;
            textBoxQuantity.Text = "Количество";

            textBoxPercent.ForeColor = Color.Gray;
            textBoxPercent.Text = "100";

            textBoxIndex.ForeColor = Color.Gray;
            textBoxIndex.Text = "0";
        }

        private void buttonOutputInfoBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WorkWithBook.GetInformation());
        }

        private void buttonCreateBook_Click(object sender, EventArgs e)
        {
            if (textBoxSerialNumber.Text == "Серийный номер")
                textBoxSerialNumber.Text = "";
            if (textBoxTitle.Text == "Название книги")
                textBoxTitle.Text = "";
            if (textBoxPrice.Text == "Цена")
                textBoxPrice.Text = "0";
            if (textBoxQuantity.Text == "Количество")
                textBoxQuantity.Text = "0";
            try
            {
                WorkWithBook.CreateBookArray(textBoxSerialNumber.Text, textBoxTitle.Text, 
                    dateTimePicker1.Value, decimal.Parse(textBoxPrice.Text), uint.Parse(textBoxQuantity.Text));
                MessageBox.Show("Книга успешно добавлена в массив");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка! \n"+exp.Message);
            }
            finally
            {
                InitializeGrayText();
            }
        }

        private void textBoxSerialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerialNumber_Enter(object sender, EventArgs e)
        {
            textBoxSerialNumber.ForeColor = Color.Black;
            textBoxSerialNumber.Text = "";
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {

            textBoxTitle.ForeColor = Color.Black;
            textBoxTitle.Text = "";
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            textBoxPrice.ForeColor = Color.Black;
            textBoxPrice.Text = "";
        }

        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            textBoxQuantity.ForeColor = Color.Black;
            textBoxQuantity.Text = "";
        }

        private void textBoxSerialNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxSerialNumber.Text == "")
            {
                textBoxSerialNumber.ForeColor = Color.Gray;
                textBoxSerialNumber.Text = "Серийный номер";
            }
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.ForeColor = Color.Gray;
                textBoxTitle.Text = "Название книги";
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.ForeColor = Color.Gray;
                textBoxPrice.Text = "Цена";
            }
        }

        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "")
            {
                textBoxQuantity.ForeColor = Color.Gray;
                textBoxQuantity.Text = "Количество";
            }
        }

        private void textBoxPercent_Enter(object sender, EventArgs e)
        {
            textBoxPercent.ForeColor = Color.Black;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIndex_Enter(object sender, EventArgs e)
        {
            textBoxIndex.ForeColor = Color.Black;
        }

        private void buttonOutputInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBoxIndex.Text);
                string information = WorkWithBook.GetInformationOfIndex(index);
                MessageBox.Show(information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка!\n"+exp.Message);
            }
        }

        private void buttonPriceAllBooks_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBoxIndex.Text);
                string information = WorkWithBook.GetPriceAllBook(index).ToString();
                MessageBox.Show("Общая стоимость тиража книги: "+information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка!\n" + exp.Message);
            }
        }

        private void buttonChangePrice_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBoxIndex.Text);
                int percent = int.Parse(textBoxPercent.Text);
                WorkWithBook.ChanchePrice(index, percent);
                MessageBox.Show("Цена успешно изменена");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка! \n"+exp.Message);
            }
        }

        private void buttonBinaryInput_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < WorkWithBook.GetArrayBook().Length; i++)
            {
                books.Add(WorkWithBook.GetArrayBook()[i]);
            }

            File.Delete("E:\\books.txt");
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("E:\\books.txt", FileMode.Create))
            {
                binFormatter.Serialize(file, books);
            }
        }

        private void buttonBinaryOutput_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();


            var binFormatter = new BinaryFormatter();
            try
            {
                using (var file = new FileStream("E:\\books.txt", FileMode.Open))
                {
                    books = binFormatter.Deserialize(file) as List<Book>;
                }
            }
            catch(SerializationException)
            {
                MessageBox.Show("Ошибка десериализации!");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка! \n"+exp.Message);
            }

            Book[] arrayBooks = new Book[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                arrayBooks[i] = books[i];
            }
            WorkWithBook.AssignValue(arrayBooks);
        }

        private void buttonBinaryDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("E:\\books.txt"))
            {
                File.Delete("E:\\books.txt");
                MessageBox.Show("Удалено!");
            }
            else
            {
                MessageBox.Show("Файл не обнаружен");
            }
        }

        private void buttonInputXML_Click(object sender, EventArgs e)
        {
            File.Delete("E:\\books.xml");
            var xmlFormatter = new XmlSerializer(typeof(Book[]));
            try
            {
                using (var file = new FileStream("E:\\books.xml", FileMode.Create))
                {
                    xmlFormatter.Serialize(file, WorkWithBook.GetArrayBook());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! \n"+ex.Message);
            }
        }

        private void buttonOutputXML_Click(object sender, EventArgs e)
        {
            var xmlFormatter = new XmlSerializer(typeof(Book[]));
            try
            {
                using (var file = new FileStream("E:\\books.xml", FileMode.Open))
                {
                    WorkWithBook.AssignValue(xmlFormatter.Deserialize(file) as Book[]);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Ошибка десериализации!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! \n"+ex.Message);
            }
        }

        private void buttonDeleteXML_Click(object sender, EventArgs e)
        {
            if (File.Exists("E:\\books.xml"))
            {
                File.Delete("E:\\books.xml");
                MessageBox.Show("Успешно удалено!");
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }

        private void buttonDeleteJSON_Click(object sender, EventArgs e)
        {
            if (File.Exists("E:\\books.json"))
            {
                File.Delete("E:\\books.json");
                MessageBox.Show("Успешно удалено!");
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }

        private void buttonInputJSON_Click(object sender, EventArgs e)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Book[]));
            File.Exists("E:\\books.json");
            try
            {
                using (var file = new FileStream("E:\\books.json", FileMode.Create))
                {
                    jsonFormatter.WriteObject(file, WorkWithBook.GetArrayBook());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! \n"+ex.Message);
            }
        }

        private void buttonOutputJSON_Click(object sender, EventArgs e)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Book[]));
            try
            {
                using (var file = new FileStream("E:\\books.json", FileMode.Open))
                {
                    WorkWithBook.AssignValue((Book[])jsonFormatter.ReadObject(file));
                }
            }
            catch(SerializationException)
            {
                MessageBox.Show("Ошибка десериализации!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! \n" + ex.Message);
            }
        }
    }
}
