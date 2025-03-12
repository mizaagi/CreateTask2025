namespace CreateTask2025
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label promptLabel;
            this.answerBox = new System.Windows.Forms.TextBox();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.editFlashcardsButton = new System.Windows.Forms.Button();
            this.rightWrong = new System.Windows.Forms.PictureBox();
            this.flashcardsListBox = new System.Windows.Forms.ListBox();
            this.newTermButton = new System.Windows.Forms.Button();
            this.enterInfoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitNewButton = new System.Windows.Forms.Button();
            promptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            promptLabel.Location = new System.Drawing.Point(332, 195);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new System.Drawing.Size(101, 31);
            promptLabel.TabIndex = 1;
            promptLabel.Text = "Prompt";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(12, 397);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(776, 20);
            this.answerBox.TabIndex = 0;
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Location = new System.Drawing.Point(338, 423);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(118, 23);
            this.submitAnswerButton.TabIndex = 2;
            this.submitAnswerButton.Text = "Submit Answer";
            this.submitAnswerButton.UseVisualStyleBackColor = true;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // editFlashcardsButton
            // 
            this.editFlashcardsButton.Location = new System.Drawing.Point(13, 13);
            this.editFlashcardsButton.Name = "editFlashcardsButton";
            this.editFlashcardsButton.Size = new System.Drawing.Size(94, 23);
            this.editFlashcardsButton.TabIndex = 3;
            this.editFlashcardsButton.Text = "Edit Flashcards";
            this.editFlashcardsButton.UseVisualStyleBackColor = true;
            this.editFlashcardsButton.Click += new System.EventHandler(this.editFlashcardsButton_Click);
            // 
            // rightWrong
            // 
            this.rightWrong.Location = new System.Drawing.Point(688, 13);
            this.rightWrong.Name = "rightWrong";
            this.rightWrong.Size = new System.Drawing.Size(100, 50);
            this.rightWrong.TabIndex = 6;
            this.rightWrong.TabStop = false;
            // 
            // flashcardsListBox
            // 
            this.flashcardsListBox.FormattingEnabled = true;
            this.flashcardsListBox.Location = new System.Drawing.Point(13, 42);
            this.flashcardsListBox.Name = "flashcardsListBox";
            this.flashcardsListBox.Size = new System.Drawing.Size(120, 95);
            this.flashcardsListBox.TabIndex = 8;
            this.flashcardsListBox.DoubleClick += new System.EventHandler(this.flashcardsListBox_DoubleClick);
            // 
            // newTermButton
            // 
            this.newTermButton.Location = new System.Drawing.Point(13, 144);
            this.newTermButton.Name = "newTermButton";
            this.newTermButton.Size = new System.Drawing.Size(75, 23);
            this.newTermButton.TabIndex = 9;
            this.newTermButton.Text = "New Term";
            this.newTermButton.UseVisualStyleBackColor = true;
            this.newTermButton.Click += new System.EventHandler(this.newTermButton_Click);
            // 
            // enterInfoBox
            // 
            this.enterInfoBox.Location = new System.Drawing.Point(12, 190);
            this.enterInfoBox.Name = "enterInfoBox";
            this.enterInfoBox.Size = new System.Drawing.Size(100, 20);
            this.enterInfoBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // submitNewButton
            // 
            this.submitNewButton.Location = new System.Drawing.Point(119, 190);
            this.submitNewButton.Name = "submitNewButton";
            this.submitNewButton.Size = new System.Drawing.Size(75, 23);
            this.submitNewButton.TabIndex = 12;
            this.submitNewButton.Text = "Submit";
            this.submitNewButton.UseVisualStyleBackColor = true;
            this.submitNewButton.Click += new System.EventHandler(this.submitNewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitNewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterInfoBox);
            this.Controls.Add(this.newTermButton);
            this.Controls.Add(this.flashcardsListBox);
            this.Controls.Add(this.rightWrong);
            this.Controls.Add(this.editFlashcardsButton);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(promptLabel);
            this.Controls.Add(this.answerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Button editFlashcardsButton;
        private System.Windows.Forms.PictureBox rightWrong;
        private System.Windows.Forms.ListBox flashcardsListBox;
        private System.Windows.Forms.Button newTermButton;
        private System.Windows.Forms.TextBox enterInfoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitNewButton;
    }
}

