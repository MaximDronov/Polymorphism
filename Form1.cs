using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_Dronov_IS_21_2
{
    public partial class Form1 : Form
    {
        int click = 0;
        List<Weapon> weapons = new List<Weapon>();
        List<Personage> personages = new List<Personage>();
        public Form1()
        {
            // Устанавливаем стиль выпадающего списка ComboBox в DropDownList, чтобы ограничить ввод пользователя
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавление нового персонажа в список personages
            personages.Add(new Personage(textBox1.Text, weapons[comboBox1.SelectedIndex], Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)));
            // Расчет мощности персонажа
            double power = Personage.Power(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox2.Text),
                weapons[comboBox1.SelectedIndex].lvl, weapons[comboBox1.SelectedIndex].Damage);
            // Определение звания персонажа
            string title = Personage.Title(power, weapons[comboBox1.SelectedIndex].Type_Weapon);
            // Отображение информации о персонаже
            label7.Text = "Имя: " + personages[0].Name + '\n' + "Звание: " + title + '\n' + "Мощность: " + power.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Добавление нового оружия в список weapons
            weapons.Add(new Weapon(textBox6.Text, comboBox2.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text)));
            // Отображение оружия в списке listBox1 и комбобоксах
            listBox1.Items.Insert(click, weapons[click].Type_Weapon + ": " + weapons[click].Name + ", LVL: " + weapons[click].lvl + ", DMG: " + weapons[click].Damage);
            comboBox1.Items.Add(weapons[click].Type_Weapon + ": " + weapons[click].Name + ", LVL: " + weapons[click].lvl + ", DMG: " + weapons[click].Damage);
            comboBox3.Items.Add(weapons[click].Type_Weapon + ": " + weapons[click].Name + ", LVL: " + weapons[click].lvl + ", DMG: " + weapons[click].Damage);
            comboBox4.Items.Add(weapons[click].Type_Weapon + ": " + weapons[click].Name + ", LVL: " + weapons[click].lvl + ", DMG: " + weapons[click].Damage);
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            click++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получение выбранного оружия из комбобоксов
            Weapon w1 = weapons[comboBox3.SelectedIndex];
            Weapon w2 = weapons[comboBox4.SelectedIndex];
            // Проверка, можно ли улучшить оружие
            if (w1.Type_Weapon == w2.Type_Weapon && comboBox3.SelectedIndex != comboBox4.SelectedIndex)
            {
                // Улучшение оружия и его добавление в списки
                w1 += w2;
                listBox1.Items.Insert(click, w1.Type_Weapon + ": " + w1.Name + ", LVL: " + w1.lvl + ", DMG: " + w1.Damage);
                comboBox1.Items.Add(w1.Type_Weapon + ": " + w1.Name + ", LVL: " + w1.lvl + ", DMG: " + w1.Damage);
                comboBox3.Items.Add(w1.Type_Weapon + ": " + w1.Name + ", LVL: " + w1.lvl + ", DMG: " + w1.Damage);
                comboBox4.Items.Add(w1.Type_Weapon + ": " + w1.Name + ", LVL: " + w1.lvl + ", DMG: " + w1.Damage);
                weapons.Add(w1);
                click++;
            }
            else
            {
                MessageBox.Show("Нельзя улучшить!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Открытие изображения для pictureBox
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(filename);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
