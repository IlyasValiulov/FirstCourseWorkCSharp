namespace Курсовая
{
    partial class BinaryHeapForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddElement = new Button();
            buttonForwardStep = new Button();
            buttonBackStep = new Button();
            menuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            pictureBoxHeap = new PictureBox();
            buttonSkipBack = new Button();
            buttonSkipForward = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeap).BeginInit();
            SuspendLayout();
            // 
            // buttonAddElement
            // 
            buttonAddElement.Location = new Point(12, 542);
            buttonAddElement.Name = "buttonAddElement";
            buttonAddElement.Size = new Size(211, 39);
            buttonAddElement.TabIndex = 0;
            buttonAddElement.Text = "Add Element";
            buttonAddElement.UseVisualStyleBackColor = true;
            buttonAddElement.Click += buttonAddElement_Click;
            // 
            // buttonForwardStep
            // 
            buttonForwardStep.Location = new Point(756, 542);
            buttonForwardStep.Name = "buttonForwardStep";
            buttonForwardStep.Size = new Size(117, 39);
            buttonForwardStep.TabIndex = 1;
            buttonForwardStep.Text = "Forward Step";
            buttonForwardStep.UseVisualStyleBackColor = true;
            buttonForwardStep.Click += buttonForwardStep_Click;
            // 
            // buttonBackStep
            // 
            buttonBackStep.Location = new Point(633, 542);
            buttonBackStep.Name = "buttonBackStep";
            buttonBackStep.Size = new Size(117, 39);
            buttonBackStep.TabIndex = 2;
            buttonBackStep.Text = "Back  Step";
            buttonBackStep.UseVisualStyleBackColor = true;
            buttonBackStep.Click += buttonBackStep_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, informationToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1008, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStripFile";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileDialogToolStripMenuItem, loadToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // saveFileDialogToolStripMenuItem
            // 
            saveFileDialogToolStripMenuItem.Name = "saveFileDialogToolStripMenuItem";
            saveFileDialogToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveFileDialogToolStripMenuItem.Size = new Size(181, 22);
            saveFileDialogToolStripMenuItem.Text = "Сохранение";
            saveFileDialogToolStripMenuItem.Click += saveFileDialogToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(181, 22);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(172, 20);
            informationToolStripMenuItem.Text = "Информация об алгоритме";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // pictureBoxHeap
            // 
            pictureBoxHeap.Location = new Point(0, 27);
            pictureBoxHeap.Name = "pictureBoxHeap";
            pictureBoxHeap.Size = new Size(965, 509);
            pictureBoxHeap.TabIndex = 4;
            pictureBoxHeap.TabStop = false;
            // 
            // buttonSkipBack
            // 
            buttonSkipBack.Location = new Point(510, 542);
            buttonSkipBack.Name = "buttonSkipBack";
            buttonSkipBack.Size = new Size(117, 39);
            buttonSkipBack.TabIndex = 5;
            buttonSkipBack.Text = "Skip Back";
            buttonSkipBack.UseVisualStyleBackColor = true;
            buttonSkipBack.Click += buttonSkipBack_Click;
            // 
            // buttonSkipForward
            // 
            buttonSkipForward.Location = new Point(879, 542);
            buttonSkipForward.Name = "buttonSkipForward";
            buttonSkipForward.Size = new Size(117, 39);
            buttonSkipForward.TabIndex = 6;
            buttonSkipForward.Text = "Skip Forward";
            buttonSkipForward.UseVisualStyleBackColor = true;
            buttonSkipForward.Click += buttonSkipForward_Click;
            // 
            // BinaryHeapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 593);
            Controls.Add(buttonSkipForward);
            Controls.Add(buttonSkipBack);
            Controls.Add(pictureBoxHeap);
            Controls.Add(buttonBackStep);
            Controls.Add(buttonForwardStep);
            Controls.Add(buttonAddElement);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "BinaryHeapForm";
            Text = "Heap";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddElement;
        private Button buttonForwardStep;
        private Button buttonBackStep;
        private MenuStrip menuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem saveFileDialogToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem loadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        public PictureBox pictureBoxHeap;
        private Button buttonSkipBack;
        private Button buttonSkipForward;
        private ToolStripMenuItem informationToolStripMenuItem;
    }
}