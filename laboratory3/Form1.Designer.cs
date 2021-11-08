
namespace laboratory3
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonChangePrice = new System.Windows.Forms.Button();
            this.buttonOutputInfo = new System.Windows.Forms.Button();
            this.buttonPriceAllBooks = new System.Windows.Forms.Button();
            this.buttonCreateBook = new System.Windows.Forms.Button();
            this.buttonOutputInfoBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonBinaryInput = new System.Windows.Forms.Button();
            this.buttonBinaryOutput = new System.Windows.Forms.Button();
            this.buttonBinaryDelete = new System.Windows.Forms.Button();
            this.buttonDeleteXML = new System.Windows.Forms.Button();
            this.buttonOutputXML = new System.Windows.Forms.Button();
            this.buttonInputXML = new System.Windows.Forms.Button();
            this.buttonDeleteJSON = new System.Windows.Forms.Button();
            this.buttonOutputJSON = new System.Windows.Forms.Button();
            this.buttonInputJSON = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(493, 110);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(133, 22);
            this.textBoxPrice.TabIndex = 25;
            this.textBoxPrice.Enter += new System.EventHandler(this.textBoxPrice_Enter);
            this.textBoxPrice.Leave += new System.EventHandler(this.textBoxPrice_Leave);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(493, 142);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(133, 22);
            this.textBoxQuantity.TabIndex = 23;
            this.textBoxQuantity.Enter += new System.EventHandler(this.textBoxQuantity_Enter);
            this.textBoxQuantity.Leave += new System.EventHandler(this.textBoxQuantity_Leave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(493, 46);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(133, 22);
            this.textBoxTitle.TabIndex = 22;
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(493, 14);
            this.textBoxSerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(133, 22);
            this.textBoxSerialNumber.TabIndex = 21;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxSerialNumber_TextChanged);
            this.textBoxSerialNumber.Enter += new System.EventHandler(this.textBoxSerialNumber_Enter);
            this.textBoxSerialNumber.Leave += new System.EventHandler(this.textBoxSerialNumber_Leave);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(13, 110);
            this.textBoxIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(63, 22);
            this.textBoxIndex.TabIndex = 17;
            this.textBoxIndex.Enter += new System.EventHandler(this.textBoxIndex_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 78);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // buttonChangePrice
            // 
            this.buttonChangePrice.AutoSize = true;
            this.buttonChangePrice.Location = new System.Drawing.Point(13, 213);
            this.buttonChangePrice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePrice.Name = "buttonChangePrice";
            this.buttonChangePrice.Size = new System.Drawing.Size(193, 28);
            this.buttonChangePrice.TabIndex = 20;
            this.buttonChangePrice.Text = "Изменить стоимость (%):";
            this.buttonChangePrice.UseVisualStyleBackColor = true;
            this.buttonChangePrice.Click += new System.EventHandler(this.buttonChangePrice_Click);
            // 
            // buttonOutputInfo
            // 
            this.buttonOutputInfo.AutoSize = true;
            this.buttonOutputInfo.Location = new System.Drawing.Point(13, 142);
            this.buttonOutputInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOutputInfo.Name = "buttonOutputInfo";
            this.buttonOutputInfo.Size = new System.Drawing.Size(228, 28);
            this.buttonOutputInfo.TabIndex = 19;
            this.buttonOutputInfo.Text = "Вывести информацию о книге";
            this.buttonOutputInfo.UseVisualStyleBackColor = true;
            this.buttonOutputInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            // 
            // buttonPriceAllBooks
            // 
            this.buttonPriceAllBooks.AutoSize = true;
            this.buttonPriceAllBooks.Location = new System.Drawing.Point(13, 177);
            this.buttonPriceAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPriceAllBooks.Name = "buttonPriceAllBooks";
            this.buttonPriceAllBooks.Size = new System.Drawing.Size(260, 28);
            this.buttonPriceAllBooks.TabIndex = 18;
            this.buttonPriceAllBooks.Text = "Вывести общую стоимость тиража";
            this.buttonPriceAllBooks.UseVisualStyleBackColor = true;
            this.buttonPriceAllBooks.Click += new System.EventHandler(this.buttonPriceAllBooks_Click);
            // 
            // buttonCreateBook
            // 
            this.buttonCreateBook.AutoSize = true;
            this.buttonCreateBook.Location = new System.Drawing.Point(301, 47);
            this.buttonCreateBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateBook.Name = "buttonCreateBook";
            this.buttonCreateBook.Size = new System.Drawing.Size(174, 28);
            this.buttonCreateBook.TabIndex = 16;
            this.buttonCreateBook.Text = "Добавить книгу";
            this.buttonCreateBook.UseVisualStyleBackColor = true;
            this.buttonCreateBook.Click += new System.EventHandler(this.buttonCreateBook_Click);
            // 
            // buttonOutputInfoBooks
            // 
            this.buttonOutputInfoBooks.AutoSize = true;
            this.buttonOutputInfoBooks.Location = new System.Drawing.Point(20, 47);
            this.buttonOutputInfoBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOutputInfoBooks.Name = "buttonOutputInfoBooks";
            this.buttonOutputInfoBooks.Size = new System.Drawing.Size(173, 28);
            this.buttonOutputInfoBooks.TabIndex = 15;
            this.buttonOutputInfoBooks.Text = "Вывести информацию";
            this.buttonOutputInfoBooks.UseVisualStyleBackColor = true;
            this.buttonOutputInfoBooks.Click += new System.EventHandler(this.buttonOutputInfoBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Работа с книгами";
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(205, 215);
            this.textBoxPercent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(33, 22);
            this.textBoxPercent.TabIndex = 26;
            this.textBoxPercent.Enter += new System.EventHandler(this.textBoxPercent_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "index";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(337, 263);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 100);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonBinaryDelete);
            this.tabPage1.Controls.Add(this.buttonBinaryOutput);
            this.tabPage1.Controls.Add(this.buttonBinaryInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Бинарная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Моя";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Сериализация";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteXML);
            this.tabPage3.Controls.Add(this.buttonOutputXML);
            this.tabPage3.Controls.Add(this.buttonInputXML);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(257, 71);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "XML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonDeleteJSON);
            this.tabPage4.Controls.Add(this.buttonOutputJSON);
            this.tabPage4.Controls.Add(this.buttonInputJSON);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(257, 71);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "JSON";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonBinaryInput
            // 
            this.buttonBinaryInput.Location = new System.Drawing.Point(3, 6);
            this.buttonBinaryInput.Name = "buttonBinaryInput";
            this.buttonBinaryInput.Size = new System.Drawing.Size(119, 28);
            this.buttonBinaryInput.TabIndex = 0;
            this.buttonBinaryInput.Text = "Загрузить";
            this.buttonBinaryInput.UseVisualStyleBackColor = true;
            this.buttonBinaryInput.Click += new System.EventHandler(this.buttonBinaryInput_Click);
            // 
            // buttonBinaryOutput
            // 
            this.buttonBinaryOutput.Location = new System.Drawing.Point(132, 6);
            this.buttonBinaryOutput.Name = "buttonBinaryOutput";
            this.buttonBinaryOutput.Size = new System.Drawing.Size(119, 28);
            this.buttonBinaryOutput.TabIndex = 1;
            this.buttonBinaryOutput.Text = "Выгрузить";
            this.buttonBinaryOutput.UseVisualStyleBackColor = true;
            this.buttonBinaryOutput.Click += new System.EventHandler(this.buttonBinaryOutput_Click);
            // 
            // buttonBinaryDelete
            // 
            this.buttonBinaryDelete.Location = new System.Drawing.Point(132, 40);
            this.buttonBinaryDelete.Name = "buttonBinaryDelete";
            this.buttonBinaryDelete.Size = new System.Drawing.Size(119, 28);
            this.buttonBinaryDelete.TabIndex = 2;
            this.buttonBinaryDelete.Text = "Удалить";
            this.buttonBinaryDelete.UseVisualStyleBackColor = true;
            this.buttonBinaryDelete.Click += new System.EventHandler(this.buttonBinaryDelete_Click);
            // 
            // buttonDeleteXML
            // 
            this.buttonDeleteXML.Location = new System.Drawing.Point(133, 38);
            this.buttonDeleteXML.Name = "buttonDeleteXML";
            this.buttonDeleteXML.Size = new System.Drawing.Size(119, 28);
            this.buttonDeleteXML.TabIndex = 5;
            this.buttonDeleteXML.Text = "Удалить";
            this.buttonDeleteXML.UseVisualStyleBackColor = true;
            this.buttonDeleteXML.Click += new System.EventHandler(this.buttonDeleteXML_Click);
            // 
            // buttonOutputXML
            // 
            this.buttonOutputXML.Location = new System.Drawing.Point(133, 4);
            this.buttonOutputXML.Name = "buttonOutputXML";
            this.buttonOutputXML.Size = new System.Drawing.Size(119, 28);
            this.buttonOutputXML.TabIndex = 4;
            this.buttonOutputXML.Text = "Выгрузить";
            this.buttonOutputXML.UseVisualStyleBackColor = true;
            this.buttonOutputXML.Click += new System.EventHandler(this.buttonOutputXML_Click);
            // 
            // buttonInputXML
            // 
            this.buttonInputXML.Location = new System.Drawing.Point(4, 4);
            this.buttonInputXML.Name = "buttonInputXML";
            this.buttonInputXML.Size = new System.Drawing.Size(119, 28);
            this.buttonInputXML.TabIndex = 3;
            this.buttonInputXML.Text = "Загрузить";
            this.buttonInputXML.UseVisualStyleBackColor = true;
            this.buttonInputXML.Click += new System.EventHandler(this.buttonInputXML_Click);
            // 
            // buttonDeleteJSON
            // 
            this.buttonDeleteJSON.Location = new System.Drawing.Point(133, 38);
            this.buttonDeleteJSON.Name = "buttonDeleteJSON";
            this.buttonDeleteJSON.Size = new System.Drawing.Size(119, 28);
            this.buttonDeleteJSON.TabIndex = 8;
            this.buttonDeleteJSON.Text = "Удалить";
            this.buttonDeleteJSON.UseVisualStyleBackColor = true;
            this.buttonDeleteJSON.Click += new System.EventHandler(this.buttonDeleteJSON_Click);
            // 
            // buttonOutputJSON
            // 
            this.buttonOutputJSON.Location = new System.Drawing.Point(133, 4);
            this.buttonOutputJSON.Name = "buttonOutputJSON";
            this.buttonOutputJSON.Size = new System.Drawing.Size(119, 28);
            this.buttonOutputJSON.TabIndex = 7;
            this.buttonOutputJSON.Text = "Выгрузить";
            this.buttonOutputJSON.UseVisualStyleBackColor = true;
            this.buttonOutputJSON.Click += new System.EventHandler(this.buttonOutputJSON_Click);
            // 
            // buttonInputJSON
            // 
            this.buttonInputJSON.Location = new System.Drawing.Point(4, 4);
            this.buttonInputJSON.Name = "buttonInputJSON";
            this.buttonInputJSON.Size = new System.Drawing.Size(119, 28);
            this.buttonInputJSON.TabIndex = 6;
            this.buttonInputJSON.Text = "Загрузить";
            this.buttonInputJSON.UseVisualStyleBackColor = true;
            this.buttonInputJSON.Click += new System.EventHandler(this.buttonInputJSON_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonChangePrice);
            this.Controls.Add(this.buttonOutputInfo);
            this.Controls.Add(this.buttonPriceAllBooks);
            this.Controls.Add(this.buttonCreateBook);
            this.Controls.Add(this.buttonOutputInfoBooks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Сериализация";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonChangePrice;
        private System.Windows.Forms.Button buttonOutputInfo;
        private System.Windows.Forms.Button buttonPriceAllBooks;
        private System.Windows.Forms.Button buttonCreateBook;
        private System.Windows.Forms.Button buttonOutputInfoBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBinaryDelete;
        private System.Windows.Forms.Button buttonBinaryOutput;
        private System.Windows.Forms.Button buttonBinaryInput;
        private System.Windows.Forms.Button buttonDeleteXML;
        private System.Windows.Forms.Button buttonOutputXML;
        private System.Windows.Forms.Button buttonInputXML;
        private System.Windows.Forms.Button buttonDeleteJSON;
        private System.Windows.Forms.Button buttonOutputJSON;
        private System.Windows.Forms.Button buttonInputJSON;
    }
}

