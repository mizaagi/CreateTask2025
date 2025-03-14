﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CreateTask2025
{
    public partial class Form1 : Form
    {
        private List<string> definitions = new List<string>();
        private int selected;
        bool submit = false;
        public Form1()
        {
            InitializeComponent();
            flashcardsListBox.Visible = false;
            newTermButton.Visible = false;
            deleteTermButton.Visible = false;
            editTermButton.Visible = false;
            correctImg.Visible = false;
            incorrectImg.Visible = false;
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            submit = true;
            submit = false;
        }

        private void editFlashcardsButton_Click(object sender, EventArgs e)
        {
            flashcardsListBox.Visible = !flashcardsListBox.Visible;
            newTermButton.Visible = !newTermButton.Visible;
            deleteTermButton.Visible = false;
            editTermButton.Visible = false;
        }

        // https://stackoverflow.com/questions/4454423/c-sharp-listbox-item-double-click-event
        private void flashcardsListBox_DoubleClick(object sender, EventArgs e)
        {   
            if (flashcardsListBox.SelectedItem != null)
            {
                selected = flashcardsListBox.Items.IndexOf(flashcardsListBox.SelectedItem);
                deleteTermButton.Visible = true;
                editTermButton.Visible = true;
            }
        }

        private void newTermButton_Click(object sender, EventArgs e)
        {
            string term = Interaction.InputBox("Enter term: ", "New Flashcard");
            flashcardsListBox.Items.Add(term);
            string definition = Interaction.InputBox("Enter definition: ", "New Flashcard");
            definitions.Add(definition);

        }

        private void deleteTermButton_Click(object sender, EventArgs e)
        {
            flashcardsListBox.Items.RemoveAt(selected);
            definitions.RemoveAt(selected);
        }

        private void editTermButton_Click(object sender, EventArgs e)
        {
            string term = Interaction.InputBox("Enter new term: ", "Edit Flashcard");
            flashcardsListBox.Items[selected] = term;
            
            string definition = Interaction.InputBox("Enter new definition: ", "Edit Flashcard");
            definitions[selected] = definition;
        }

        private void quiz(string tOrD)
        {
            if (tOrD == "term")
            {
                for (int i = 0; i < definitions.Count; i++)
                {
                    label1.Text = definitions[i];
                    if (answerBox.Text == (string)flashcardsListBox.Items[i])
                    {
                        correctImg.Visible = true;
                        incorrectImg.Visible = false;
                    }
                    else
                    {
                        correctImg.Visible = false;
                        incorrectImg.Visible = true;
                    }
                }
            }
            else if (tOrD == "definition")
            {

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string tOrD = Interaction.InputBox("Enter term or definition?", "Quiz Type");
            quiz(tOrD);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
