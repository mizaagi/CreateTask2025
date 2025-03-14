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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answerBox = new System.Windows.Forms.TextBox();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.editFlashcardsButton = new System.Windows.Forms.Button();
            this.correctImg = new System.Windows.Forms.PictureBox();
            this.flashcardsListBox = new System.Windows.Forms.ListBox();
            this.newTermButton = new System.Windows.Forms.Button();
            this.deleteTermButton = new System.Windows.Forms.Button();
            this.editTermButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.incorrectImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.correctImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrectImg)).BeginInit();
            this.SuspendLayout();
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
            // correctImg
            // 
            this.correctImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("correctImg.BackgroundImage")));
            this.correctImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.correctImg.Location = new System.Drawing.Point(704, 13);
            this.correctImg.Name = "correctImg";
            this.correctImg.Size = new System.Drawing.Size(84, 84);
            this.correctImg.TabIndex = 6;
            this.correctImg.TabStop = false;
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
            // deleteTermButton
            // 
            this.deleteTermButton.Location = new System.Drawing.Point(139, 42);
            this.deleteTermButton.Name = "deleteTermButton";
            this.deleteTermButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTermButton.TabIndex = 13;
            this.deleteTermButton.Text = "Delete Term";
            this.deleteTermButton.UseVisualStyleBackColor = true;
            this.deleteTermButton.Click += new System.EventHandler(this.deleteTermButton_Click);
            // 
            // editTermButton
            // 
            this.editTermButton.Location = new System.Drawing.Point(139, 71);
            this.editTermButton.Name = "editTermButton";
            this.editTermButton.Size = new System.Drawing.Size(75, 23);
            this.editTermButton.TabIndex = 14;
            this.editTermButton.Text = "Edit Term";
            this.editTermButton.UseVisualStyleBackColor = true;
            this.editTermButton.Click += new System.EventHandler(this.editTermButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(347, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(347, 42);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 17;
            // 
            // incorrectImg
            // 
            this.incorrectImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("incorrectImg.BackgroundImage")));
            this.incorrectImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.incorrectImg.Location = new System.Drawing.Point(704, 13);
            this.incorrectImg.Name = "incorrectImg";
            this.incorrectImg.Size = new System.Drawing.Size(84, 84);
            this.incorrectImg.TabIndex = 18;
            this.incorrectImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incorrectImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.editTermButton);
            this.Controls.Add(this.deleteTermButton);
            this.Controls.Add(this.newTermButton);
            this.Controls.Add(this.flashcardsListBox);
            this.Controls.Add(this.correctImg);
            this.Controls.Add(this.editFlashcardsButton);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.answerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.correctImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrectImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Button editFlashcardsButton;
        private System.Windows.Forms.PictureBox correctImg;
        private System.Windows.Forms.ListBox flashcardsListBox;
        private System.Windows.Forms.Button newTermButton;
        private System.Windows.Forms.Button deleteTermButton;
        private System.Windows.Forms.Button editTermButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox incorrectImg;
        private System.Windows.Forms.Timer timer1;
    }
}

