using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр18_Старостин
{
	public partial class Form1 : Form
	{
		private int itemCountLevel1 = 5; // Количество предметов для уровня 1
		private int itemCountLevel2 = 7; // Количество предметов для уровня 2
		private int currentLevel = 1; // Текущий уровень

		// Словарь для хранения соответствия PictureBox и предмета
		private Dictionary<PictureBox, string> pictureBoxItems = new Dictionary<PictureBox, string>();

		// Список предметов для уровня 2
		private List<string> itemsLevel2 = new List<string> { "ключ", "часы", "книга", "монета", "билет", "очки", "карандаш" };

		public Form1()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			InitializeLevel();
		}
		private void InitializeLevel()
		{
			foreach (PictureBox pictureBox in panel1.Controls)
			{
				pictureBox.BackColor = Color.Transparent;
				pictureBox.Visible = true; // Отображаем предметы для уровня 1
			}

			if (currentLevel == 1)
				label1.Text = "Вам необходимо найти предметы: " + itemCountLevel1.ToString() + " яблоко!";
			else if (currentLevel == 2)
				SetRandomItem();
		}
		private void SetRandomItem()
		{
			int randomIndex = new Random().Next(itemsLevel2.Count);
			string randomItem = itemsLevel2[randomIndex];
			label1.Text = "Вам необходимо найти предмет: " + randomItem;

			// Привязываем предмет ко всем PictureBox на уровне 2
			foreach (PictureBox pictureBox in panel1.Controls)
			{
				pictureBoxItems[pictureBox] = randomItem;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel1--;
			CheckLevelCompletion(itemCountLevel1);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel1--;
			CheckLevelCompletion(itemCountLevel1);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel1--;
			CheckLevelCompletion(itemCountLevel1);
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel1--;
			CheckLevelCompletion(itemCountLevel1);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel1--;
			CheckLevelCompletion(itemCountLevel1);
		}

		private void CheckLevelCompletion(int remainingItems)
		{
			if (remainingItems <= 0)
			{
				MessageBox.Show("Вы нашли все предметы", "Поздравляем!");

				// Переход на следующий уровень
				currentLevel++;
				if (currentLevel <= 2)
				{
					foreach (PictureBox pictureBox in panel1.Controls)
					{
						pictureBox.Visible = true;
					}
					SetRandomItem();
				}
				else
				{
					MessageBox.Show("Поздравляем! Вы прошли все уровни.", "Игра завершена");
				}
			}
			else
			{
				label1.Text = "Вам осталось найти " + remainingItems.ToString() + " предмета";
			}
		}

		private void pictureBox_Click_Level2(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			string targetItem = pictureBoxItems[clickedPictureBox]; // Получаем предмет, привязанный к PictureBox

			// Проверяем, правильный ли предмет был выбран
			if (targetItem == label1.Text.Replace("Вам необходимо найти предмет: ", ""))
			{
				clickedPictureBox.Visible = false;
				itemCountLevel2--;
				CheckLevelCompletion(itemCountLevel2);
			}
			else
			{
				// Пользователь выбрал неправильный предмет, можно добавить соответствующее сообщение
				MessageBox.Show("Неправильный предмет! Попробуйте снова.", "Предупреждение");
			}
		}
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = (PictureBox)sender;
			clickedPictureBox.Visible = false;
			itemCountLevel2--;
			CheckLevelCompletion(itemCountLevel2);
		}
	}
}
