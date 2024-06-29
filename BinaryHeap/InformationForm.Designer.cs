namespace Курсовая
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            buttonClose = new Button();
            richTextBox = new RichTextBox();
            pictureBoxMassive = new PictureBox();
            pictureBoxTree = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMassive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTree).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            resources.ApplyResources(buttonClose, "buttonClose");
            buttonClose.Name = "buttonClose";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.Menu;
            richTextBox.BorderStyle = BorderStyle.None;
            resources.ApplyResources(richTextBox, "richTextBox");
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            // 
            // pictureBoxMassive
            // 
            pictureBoxMassive.Image = Properties.Resources.massive;
            resources.ApplyResources(pictureBoxMassive, "pictureBoxMassive");
            pictureBoxMassive.Name = "pictureBoxMassive";
            pictureBoxMassive.TabStop = false;
            // 
            // pictureBoxTree
            // 
            pictureBoxTree.Image = Properties.Resources.tree;
            resources.ApplyResources(pictureBoxTree, "pictureBoxTree");
            pictureBoxTree.Name = "pictureBoxTree";
            pictureBoxTree.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            // 
            // InformationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(pictureBoxTree);
            Controls.Add(pictureBoxMassive);
            Controls.Add(richTextBox);
            Controls.Add(buttonClose);
            Name = "InformationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMassive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTree).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private RichTextBox richTextBox;
        private PictureBox pictureBoxMassive;
        private PictureBox pictureBoxTree;
        private RichTextBox richTextBox1;
    }
}