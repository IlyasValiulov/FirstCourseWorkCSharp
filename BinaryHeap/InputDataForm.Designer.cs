namespace Курсовая
{
    partial class InputDataForm
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
            buttonAdd = new Button();
            numericUpDown = new NumericUpDown();
            labelInputData = new Label();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(29, 210);
            buttonAdd.Margin = new Padding(7, 8, 7, 8);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(265, 82);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Location = new Point(29, 101);
            numericUpDown.Margin = new Padding(7, 8, 7, 8);
            numericUpDown.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(537, 51);
            numericUpDown.TabIndex = 1;
            // 
            // labelInputData
            // 
            labelInputData.AutoSize = true;
            labelInputData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputData.Location = new Point(29, 25);
            labelInputData.Margin = new Padding(7, 0, 7, 0);
            labelInputData.Name = "labelInputData";
            labelInputData.Size = new Size(298, 54);
            labelInputData.TabIndex = 2;
            labelInputData.Text = "Введите число:";
            labelInputData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(301, 210);
            buttonCancel.Margin = new Padding(7, 8, 7, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(265, 82);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonClose_Click;
            // 
            // InputDataForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 309);
            Controls.Add(buttonCancel);
            Controls.Add(labelInputData);
            Controls.Add(numericUpDown);
            Controls.Add(buttonAdd);
            Margin = new Padding(7, 8, 7, 8);
            Name = "InputDataForm";
            Text = "InputData";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private NumericUpDown numericUpDown;
        private Label labelInputData;
        private Button buttonCancel;
    }
}