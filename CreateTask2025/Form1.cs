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

namespace CreateTask2025
{
    public partial class Form1 : Form
    {
        private String termOrDef = "term";
        private ArrayList definitions = new ArrayList();
        private int selected;
        public Form1()
        {
            InitializeComponent();
            flashcardsListBox.Visible = false;
            newTermButton.Visible = false;
            label1.Text = "";
            enterInfoBox.Visible = false;
            submitNewButton.Visible = false;
            deleteTermButton.Visible = false;
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {

            answerBox.Clear();
        }

        private void editFlashcardsButton_Click(object sender, EventArgs e)
        {
            flashcardsListBox.Visible = !flashcardsListBox.Visible;
            newTermButton.Visible = !newTermButton.Visible;
            deleteTermButton.Visible = false;
            enterInfoBox.Visible = false;
            submitNewButton.Visible = false;
            label1.Text = "";
            flashcardsListBox.Text = "";
        }

        // https://stackoverflow.com/questions/4454423/c-sharp-listbox-item-double-click-event
        private void flashcardsListBox_DoubleClick(object sender, EventArgs e)
        {   
            if (flashcardsListBox.SelectedItem != null)
            {
                termOrDef = "edit";
                selected = flashcardsListBox.Items.IndexOf(flashcardsListBox.SelectedItem);
                deleteTermButton.Visible = true;
            }
            
        }

        private void newTermButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter term:";
            termOrDef = "term";
            enterInfoBox.Visible = true;
            submitNewButton.Visible = true;
        }

        private void submitNewButton_Click(object sender, EventArgs e)
        {   
            if (termOrDef.Equals("term")) {
                flashcardsListBox.Items.Add(enterInfoBox.Text);
                enterInfoBox.Text = "";
                label1.Text = "Enter definition:";
                termOrDef = "definition";
            } else if (termOrDef.Equals("definition"))
            {
                definitions.Add(enterInfoBox.Text);
                label1.Text = "";
                submitNewButton.Visible = false;
                enterInfoBox.Visible = false;
                enterInfoBox.Text = "";
            } else if (termOrDef.Equals("edit"))
            {

            }
            

        }

        private void deleteTermButton_Click(object sender, EventArgs e)
        {
            flashcardsListBox.Items.RemoveAt(selected);
            definitions.RemoveAt(selected);
        }
    }
}
