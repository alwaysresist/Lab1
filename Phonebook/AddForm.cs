using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddForm : Form
    {
        public Note MyRecord;
        public bool Full = false;

        public AddForm(Note _MyRecord, AddOrEdit MyType)
        {
            InitializeComponent();
            MyRecord = _MyRecord;
            if (MyType == AddOrEdit.Add)
            {
                Text = "Добавление абонента";
                AddButton.Text = "Добавить";
            }
            else
            {
                Text = "Изменение абонента";
                AddButton.Text = "Изменить";
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var emptyTextboxes = from tb in Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text) || tb.Text.All((x) => x == ' ')
                                 select tb;
            if (PhoneMaskedTextBox.MaskFull && !emptyTextboxes.Any())
            {
                MyRecord.LastName = LastNameTextBox.Text;
                MyRecord.Name = NameTextBox.Text;
                MyRecord.Patronymic = PatronymicTextBox.Text;
                MyRecord.Phone = PhoneMaskedTextBox.Text;
                MyRecord.Street = StreetTextBox.Text;
                MyRecord.House = (ushort)HouseNumericUpDown.Value;
                MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
                Full = true;
                Close();
            }
            else
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void PatronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
