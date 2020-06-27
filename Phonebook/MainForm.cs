using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace PhoneBook
{ 
    public partial class MainForm : Form
    {
        private List<Note> PhoneNote;
        private int current;
        public bool UpdateInForm = false;
        private bool Changes = false;
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
        }
        private void PrintElement()
        {
            if ((current >= 0) && (current < PhoneNote.Count))
            { 
                Note MyRecord = PhoneNote[current];       
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
                UpdateInForm = true;
            }
            else 
            { 
                LastNameTextBox.Text = "";
                NameTextBox.Text = "";
                PatronymicTextBox.Text = "";
                PhoneMaskedTextBox.Text = "";
                StreetTextBox.Text = "";
                HouseNumericUpDown.Value = 1;
                FlatNumericUpDown.Value = 1;
            }
            NumberToolStripStatusLabel.Text = (current + 1).ToString();
            QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if ((PhoneNote.Count > 0) && (current != 0)) current--;
            else MessageBox.Show("Предыдущей записи не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PrintElement();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (current != PhoneNote.Count - 1) current++;
            else MessageBox.Show("Следующей записи не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PrintElement();
        }

        private void ДобавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Note MyRecord = new Note();
            AddForm _AddForm = new AddForm(MyRecord,PhoneNote, AddOrEdit.Add);
            _AddForm.ShowDialog();
            if (_AddForm.Full)
            {
                if (PhoneNote.Contains(_AddForm.MyRecord))
                    MessageBox.Show("Данный контакт уже есть в списке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    current = PhoneNote.Count;
                    PhoneNote.Add(_AddForm.MyRecord);
                    PrintElement();
                    Changes = true;
                }
            }
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInForm = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            foreach (Note MyRecord in PhoneNote)
                            {
                                sw.WriteLine(MyRecord.LastName);
                                sw.WriteLine(MyRecord.Name);
                                sw.WriteLine(MyRecord.Patronymic);
                                sw.WriteLine(MyRecord.Street);
                                sw.WriteLine(MyRecord.House);
                                sw.WriteLine(MyRecord.Flat);
                                sw.WriteLine(MyRecord.Phone);
                            }
                        }
                    }
                    else
                    {
                        XmlTextWriter textWriter = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8);
                        textWriter.WriteStartDocument();
                        textWriter.WriteStartElement("Notes");
                        textWriter.WriteEndDocument();
                        textWriter.Close();

                        XmlDocument document = new XmlDocument();
                        document.Load(saveFileDialog1.FileName);

                        int index = 0;
                        foreach (Note MyRecord in PhoneNote)
                        {
                            XmlElement element = document.CreateElement("Note");
                            document.DocumentElement.AppendChild(element);

                            XmlAttribute attribute = document.CreateAttribute("id");
                            attribute.Value = index.ToString();
                            element.Attributes.Append(attribute);

                            XmlNode lastNameElem = document.CreateElement("Lastname");
                            lastNameElem.InnerText = MyRecord.LastName;
                            element.AppendChild(lastNameElem);

                            XmlNode nameElem = document.CreateElement("Name");
                            nameElem.InnerText = MyRecord.Name;
                            element.AppendChild(nameElem);

                            XmlNode patronymicElem = document.CreateElement("Patronymic");
                            patronymicElem.InnerText = MyRecord.Patronymic;
                            element.AppendChild(patronymicElem);

                            XmlNode streetElem = document.CreateElement("Street");
                            streetElem.InnerText = MyRecord.Street;
                            element.AppendChild(streetElem);

                            XmlNode houseElem = document.CreateElement("House");
                            houseElem.InnerText = MyRecord.House.ToString();
                            element.AppendChild(houseElem);

                            XmlNode flatElem = document.CreateElement("Flat");
                            flatElem.InnerText = MyRecord.Flat.ToString();
                            element.AppendChild(flatElem);

                            XmlNode phoneElem = document.CreateElement("Phone");
                            phoneElem.InnerText = MyRecord.Phone;
                            element.AppendChild(phoneElem);

                            index++;
                        }
                        document.Save(saveFileDialog1.FileName);
                    }
                    Changes = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить данные!" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void ИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                Note MyRecord = new Note();
                AddForm _AddForm = new AddForm(MyRecord,PhoneNote, AddOrEdit.Edit);
                MyRecord.LastName = LastNameTextBox.Text;
                MyRecord.Name = NameTextBox.Text;
                MyRecord.Patronymic = PatronymicTextBox.Text;
                MyRecord.Phone = PhoneMaskedTextBox.Text;
                MyRecord.Street = StreetTextBox.Text;
                MyRecord.House = (ushort)HouseNumericUpDown.Value;
                MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
                
                _AddForm.ShowDialog();
                if (_AddForm.Full)
                {
                    PhoneNote[current] = _AddForm.MyRecord;
                    if (PhoneNote.Contains(_AddForm.MyRecord))
                        MessageBox.Show("Данный контакт уже есть в списке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else { PhoneNote[current] = _AddForm.MyRecord; }
                }
            }
            PrintElement();
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Note MyRecord;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.FilterIndex == 1)
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            while (!sr.EndOfStream)
                            {
                                Note MyRecord = new Note();
                                MyRecord.LastName = sr.ReadLine();
                                MyRecord.Name = sr.ReadLine();
                                MyRecord.Patronymic = sr.ReadLine();
                                MyRecord.Street = sr.ReadLine();
                                MyRecord.House = ushort.Parse(sr.ReadLine());
                                MyRecord.Flat = ushort.Parse(sr.ReadLine());
                                MyRecord.Phone = sr.ReadLine();
                                PhoneNote.Add(MyRecord);
                            }
                        }
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        PrintElement();
                    }
                    else
                    {

                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(openFileDialog1.FileName);
                        XmlElement xRoot = xDoc.DocumentElement;
                        foreach (XmlElement xNode in xRoot)
                        {
                            Note MyRecord = new Note();
                            XmlNode child = xNode.FirstChild;
                            MyRecord.LastName = child.InnerText;
                            child = child.NextSibling;
                            MyRecord.Name = child.InnerText;
                            child = child.NextSibling;
                            MyRecord.Patronymic = child.InnerText;
                            child = child.NextSibling;
                            MyRecord.Street = child.InnerText;
                            child = child.NextSibling;
                            MyRecord.House = ushort.Parse(child.InnerText);
                            child = child.NextSibling;
                            MyRecord.Flat = ushort.Parse(child.InnerText);
                            child = child.NextSibling;
                            MyRecord.Phone = child.InnerText;
                            PhoneNote.Add(MyRecord);
                        }
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        PrintElement();
                    }
                    Changes = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При открытии файла произошла ошибка!" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdateInForm)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter sw =
                            new StreamWriter(saveFileDialog1.FileName))
                            {
                                foreach (Note MyRecord in PhoneNote)
                                {
                                    sw.WriteLine(MyRecord.LastName);
                                    sw.WriteLine(MyRecord.Name);
                                    sw.WriteLine(MyRecord.Patronymic);
                                    sw.WriteLine(MyRecord.Street);
                                    sw.WriteLine(MyRecord.House);
                                    sw.WriteLine(MyRecord.Flat);
                                    sw.WriteLine(MyRecord.Phone);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не удалось сохранить данные! Ошибка: " +
                            ex.Message);
                        }
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    
                }
                else e.Cancel = true;
            }
        }

        private void ПоискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchNameForm _Search = new SearchNameForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void ПоискПоАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdressSearchForm _Search = new AdressSearchForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void ПоискПоНомеруТелефонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneNumberForm _Search = new PhoneNumberForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByLastName());
                current = 0;
                PrintElement();
            }
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByLastName());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }

        private void поВозрастаниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByName());
                current = 0;
                PrintElement();
            }
        }

        private void поУбываниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByName());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPatronymic());
                current = 0;
                PrintElement();
            }
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPatronymic());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }

        private void поВозрастаниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByStreet());
                current = 0;
                PrintElement();
            }
        }

        private void поУбываниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByStreet());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }

        private void поВозрастаниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByHouse());
                current = 0;
                PrintElement();
            }
        }

        private void поУбываниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByHouse());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }

        private void поВозрастаниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PhoneNote.Sort(new CompareByFlat());
            current = 0;
            PrintElement();
        }

        private void поУбываниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PhoneNote.Sort(new CompareByFlat());
            PhoneNote.Reverse();
            current = 0;
            PrintElement();
        }

        private void поВозрастаниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PhoneNote.Sort(new CompareByPhone());
            current = 0;
            PrintElement();
        }

        private void поУбываниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PhoneNote.Sort(new CompareByPhone());
            PhoneNote.Reverse();
            current = 0;
            PrintElement();
        }
    }
  
    public enum AddOrEdit
    {
        Add,
        Edit
    }
}
