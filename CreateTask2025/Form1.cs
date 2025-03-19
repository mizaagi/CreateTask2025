using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;

namespace CreateTask2025
{
    public partial class Form1 : Form
    {
        private List<string> definitions = new List<string>();
        private int selected;
        bool submit = false;
        bool quizContinue = true;
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

            editTermButton.Visible = false;
            deleteTermButton.Visible = false;
        }

        private void editTermButton_Click(object sender, EventArgs e)
        {
            string term = Interaction.InputBox("Enter new term: ", "Edit Flashcard");
            flashcardsListBox.Items[selected] = term;
            
            string definition = Interaction.InputBox("Enter new definition: ", "Edit Flashcard");
            definitions[selected] = definition;

            editTermButton.Visible = false;
            deleteTermButton.Visible = false;
        }

        private async void quiz(string tOrD)
        {
            while (quizContinue)
            {
                if (tOrD == "term")
                {
                    for (int i = 0; i < definitions.Count; i++)
                    {
                        // https://stackoverflow.com/questions/57745760/how-to-set-a-text-to-a-label-from-another-thread
                        this.Invoke((MethodInvoker)delegate { label1.Text = definitions[i]; });
                        while (!submit) { }
                        if (answerBox.Text.Equals(((string)flashcardsListBox.Items[i]).Trim()))

                        {
                            this.Invoke((MethodInvoker)delegate { correctImg.Visible = true; });
                            this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = false; });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { correctImg.Visible = false; });
                            this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = true; });

                        }
                        this.Invoke((MethodInvoker)delegate { answerBox.Clear(); });
                        this.Invoke((MethodInvoker)delegate { submit = false; });
                        await Task.Delay(500);
                        this.Invoke((MethodInvoker)delegate { correctImg.Visible = false; });
                        this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = false; });
                    }
                }
                else if (tOrD == "definition")
                {
                    for (int i = 0; i < definitions.Count; i++)
                    {
                        // https://stackoverflow.com/questions/57745760/how-to-set-a-text-to-a-label-from-another-thread
                        this.Invoke((MethodInvoker)delegate { label1.Text = (string)flashcardsListBox.Items[i]; });
                        while (!submit) { }
                        if (answerBox.Text.Equals(definitions[i].Trim()))

                        {
                            this.Invoke((MethodInvoker)delegate { correctImg.Visible = true; });
                            this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = false; });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { correctImg.Visible = false; });
                            this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = true; });
                        }
                        this.Invoke((MethodInvoker)delegate { answerBox.Clear(); });
                        this.Invoke((MethodInvoker)delegate { submit = false; });
                        await Task.Delay(500);
                        this.Invoke((MethodInvoker)delegate { correctImg.Visible = false; });
                        this.Invoke((MethodInvoker)delegate { incorrectImg.Visible = false; });
                    }
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            quizContinue = true;
            flashcardsListBox.Visible = false;
            newTermButton.Visible = false;
            deleteTermButton.Visible = false;
            editTermButton.Visible = false;
            string tOrD = Interaction.InputBox("Enter term or definition?", "Quiz Type");
            Thread newQuiz = new Thread(() => quiz(tOrD));
            newQuiz.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            quizContinue = false;
            label1.Text = "";
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/19660775/how-to-use-open-file-dialog

        }
    }
}
