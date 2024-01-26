using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__Assessment1
{
    public partial class Form1 : Form
    {
        private List<string> wordsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a word or phrase.");
                return;
            }

            if (!wordsList.Contains(newWord))
            {
                wordsList.Add(newWord);
                UpdateListBox();
                MessageBox.Show("Word added! ");
            }

            else
            {
                MessageBox.Show("Word or phrase already exists. ");
            }

            ClearTextBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(wordsList.ToArray());
        }
        private string GetSelectedWord()
        {
            if (listBox1.SelectedIndex != -1)
            {
                return listBox1.SelectedItem.ToString();
            }
            return null;
        }

        private void ClearTextBox()
        {
            textBox1.Clear();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();

            if (string.IsNullOrEmpty(selectedWord))
            {
                MessageBox.Show("Please select a word to change.");
                return;
            }

            string newWord = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a new word to change!" );
                return;
            }
            int index = wordsList.IndexOf(selectedWord);
            wordsList[index] = newWord;

            MessageBox.Show("Word is changed! ");
            UpdateListBox();
            ClearTextBox();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wordsList.Clear();
            UpdateListBox();
            MessageBox.Show("All words cleared!.");
            ClearTextBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();
            if (string.IsNullOrEmpty(selectedWord))
            {
                MessageBox.Show("Select a word to remove.");
                return;
            }

            wordsList.Remove(selectedWord);
            UpdateListBox();
            MessageBox.Show("Selected word removed");
            ClearTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
