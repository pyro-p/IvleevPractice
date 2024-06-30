namespace practice3
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxObjectColor = new TextBox();
            comboBoxObjectMaterial = new ComboBox();
            buttonObjectOutput = new Button();
            listBoxObjects = new ListBox();
            buttonObjectCreate = new Button();
            tabPage2 = new TabPage();
            buttonFigureSquare = new Button();
            buttonFigureOval = new Button();
            buttonFigureDraw = new Button();
            pictureBox1 = new PictureBox();
            maskedTextBoxFigureWidth = new MaskedTextBox();
            comboBoxFigureFill = new ComboBox();
            tabPage3 = new TabPage();
            buttonCalculate = new Button();
            textBoxCalculate = new TextBox();
            maskedTextBoxNum2 = new MaskedTextBox();
            maskedTextBoxNum1 = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxObjectColor);
            tabPage1.Controls.Add(comboBoxObjectMaterial);
            tabPage1.Controls.Add(buttonObjectOutput);
            tabPage1.Controls.Add(listBoxObjects);
            tabPage1.Controls.Add(buttonObjectCreate);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Инкапсуляция";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxObjectColor
            // 
            textBoxObjectColor.Location = new Point(193, 35);
            textBoxObjectColor.Name = "textBoxObjectColor";
            textBoxObjectColor.Size = new Size(100, 23);
            textBoxObjectColor.TabIndex = 6;
            // 
            // comboBoxObjectMaterial
            // 
            comboBoxObjectMaterial.FormattingEnabled = true;
            comboBoxObjectMaterial.Items.AddRange(new object[] { "Деревянный", "Пластиковый" });
            comboBoxObjectMaterial.Location = new Point(193, 6);
            comboBoxObjectMaterial.Name = "comboBoxObjectMaterial";
            comboBoxObjectMaterial.Size = new Size(100, 23);
            comboBoxObjectMaterial.TabIndex = 5;
            // 
            // buttonObjectOutput
            // 
            buttonObjectOutput.Location = new Point(193, 93);
            buttonObjectOutput.Name = "buttonObjectOutput";
            buttonObjectOutput.Size = new Size(100, 23);
            buttonObjectOutput.TabIndex = 4;
            buttonObjectOutput.Text = "Вывести";
            buttonObjectOutput.UseVisualStyleBackColor = true;
            buttonObjectOutput.Click += ButtonObjectOutput_Click;
            // 
            // listBoxObjects
            // 
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 15;
            listBoxObjects.Location = new Point(6, 6);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(181, 289);
            listBoxObjects.TabIndex = 3;
            // 
            // buttonObjectCreate
            // 
            buttonObjectCreate.Location = new Point(193, 64);
            buttonObjectCreate.Name = "buttonObjectCreate";
            buttonObjectCreate.Size = new Size(100, 23);
            buttonObjectCreate.TabIndex = 2;
            buttonObjectCreate.Text = "Создать";
            buttonObjectCreate.UseVisualStyleBackColor = true;
            buttonObjectCreate.Click += ButtonObjectCreate_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonFigureSquare);
            tabPage2.Controls.Add(buttonFigureOval);
            tabPage2.Controls.Add(buttonFigureDraw);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(maskedTextBoxFigureWidth);
            tabPage2.Controls.Add(comboBoxFigureFill);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Наследование";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFigureSquare
            // 
            buttonFigureSquare.Location = new Point(6, 64);
            buttonFigureSquare.Name = "buttonFigureSquare";
            buttonFigureSquare.Size = new Size(121, 23);
            buttonFigureSquare.TabIndex = 5;
            buttonFigureSquare.Text = "Квадрат";
            buttonFigureSquare.UseVisualStyleBackColor = true;
            buttonFigureSquare.Click += ButtonFigureSquare_Click;
            // 
            // buttonFigureOval
            // 
            buttonFigureOval.Location = new Point(6, 93);
            buttonFigureOval.Name = "buttonFigureOval";
            buttonFigureOval.Size = new Size(121, 23);
            buttonFigureOval.TabIndex = 4;
            buttonFigureOval.Text = "Овал";
            buttonFigureOval.UseVisualStyleBackColor = true;
            buttonFigureOval.Click += ButtonFigureOval_Click;
            // 
            // buttonFigureDraw
            // 
            buttonFigureDraw.Location = new Point(6, 122);
            buttonFigureDraw.Name = "buttonFigureDraw";
            buttonFigureDraw.Size = new Size(121, 23);
            buttonFigureDraw.TabIndex = 3;
            buttonFigureDraw.Text = "Вывести";
            buttonFigureDraw.UseVisualStyleBackColor = true;
            buttonFigureDraw.Click += ButtonFigureDraw_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(133, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 386);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBoxFigureWidth
            // 
            maskedTextBoxFigureWidth.Location = new Point(6, 35);
            maskedTextBoxFigureWidth.Mask = "00";
            maskedTextBoxFigureWidth.Name = "maskedTextBoxFigureWidth";
            maskedTextBoxFigureWidth.Size = new Size(121, 23);
            maskedTextBoxFigureWidth.TabIndex = 1;
            maskedTextBoxFigureWidth.ValidatingType = typeof(int);
            // 
            // comboBoxFigureFill
            // 
            comboBoxFigureFill.FormattingEnabled = true;
            comboBoxFigureFill.Items.AddRange(new object[] { "Закрашенный", "Не закрашенный" });
            comboBoxFigureFill.Location = new Point(6, 6);
            comboBoxFigureFill.Name = "comboBoxFigureFill";
            comboBoxFigureFill.Size = new Size(121, 23);
            comboBoxFigureFill.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonCalculate);
            tabPage3.Controls.Add(textBoxCalculate);
            tabPage3.Controls.Add(maskedTextBoxNum2);
            tabPage3.Controls.Add(maskedTextBoxNum1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Полиморфизм";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(6, 64);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Посчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // textBoxCalculate
            // 
            textBoxCalculate.Location = new Point(6, 93);
            textBoxCalculate.Name = "textBoxCalculate";
            textBoxCalculate.Size = new Size(100, 23);
            textBoxCalculate.TabIndex = 2;
            // 
            // maskedTextBoxNum2
            // 
            maskedTextBoxNum2.Location = new Point(6, 35);
            maskedTextBoxNum2.Mask = "00";
            maskedTextBoxNum2.Name = "maskedTextBoxNum2";
            maskedTextBoxNum2.Size = new Size(100, 23);
            maskedTextBoxNum2.TabIndex = 1;
            // 
            // maskedTextBoxNum1
            // 
            maskedTextBoxNum1.Location = new Point(6, 6);
            maskedTextBoxNum1.Mask = "00";
            maskedTextBoxNum1.Name = "maskedTextBoxNum1";
            maskedTextBoxNum1.Size = new Size(100, 23);
            maskedTextBoxNum1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox listBoxObjects;
        private Button buttonObjectCreate;
        private MaskedTextBox maskedTextBoxFigureWidth;
        private ComboBox comboBoxFigureFill;
        private Button buttonFigureDraw;
        private PictureBox pictureBox1;
        private Button buttonCalculate;
        private TextBox textBoxCalculate;
        private MaskedTextBox maskedTextBoxNum2;
        private MaskedTextBox maskedTextBoxNum1;
        private Button buttonFigureOval;
        private ComboBox comboBoxObjectMaterial;
        private Button buttonObjectOutput;
        private TextBox textBoxObjectColor;
        private Button buttonFigureSquare;
    }
}