namespace practice2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            textBoxStack = new TextBox();
            buttonStackPrint = new Button();
            buttonStackPop = new Button();
            buttonStackPush = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBoxSortOutput = new TextBox();
            textBoxSortSource = new TextBox();
            buttonSortStep = new Button();
            buttonSortGenerate = new Button();
            label2 = new Label();
            panel3 = new Panel();
            textBoxGraphOutput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxGraphMatrix = new TextBox();
            buttonGraphSearch = new Button();
            textBoxGraphSearch = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxStack);
            panel1.Controls.Add(buttonStackPrint);
            panel1.Controls.Add(buttonStackPop);
            panel1.Controls.Add(buttonStackPush);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 555);
            panel1.TabIndex = 0;
            // 
            // textBoxStack
            // 
            textBoxStack.Location = new Point(12, 174);
            textBoxStack.Name = "textBoxStack";
            textBoxStack.Size = new Size(297, 23);
            textBoxStack.TabIndex = 4;
            // 
            // buttonStackPrint
            // 
            buttonStackPrint.Location = new Point(213, 145);
            buttonStackPrint.Name = "buttonStackPrint";
            buttonStackPrint.Size = new Size(96, 23);
            buttonStackPrint.TabIndex = 3;
            buttonStackPrint.Text = "Вывести";
            buttonStackPrint.UseVisualStyleBackColor = true;
            buttonStackPrint.Click += ButtonStackPrint_Click;
            // 
            // buttonStackPop
            // 
            buttonStackPop.Location = new Point(111, 145);
            buttonStackPop.Name = "buttonStackPop";
            buttonStackPop.Size = new Size(96, 23);
            buttonStackPop.TabIndex = 2;
            buttonStackPop.Text = "Извлечь";
            buttonStackPop.UseVisualStyleBackColor = true;
            buttonStackPop.Click += ButtonStackPop_Click;
            // 
            // buttonStackPush
            // 
            buttonStackPush.Location = new Point(9, 145);
            buttonStackPush.Name = "buttonStackPush";
            buttonStackPush.Size = new Size(96, 23);
            buttonStackPush.TabIndex = 1;
            buttonStackPush.Text = "Добавить";
            buttonStackPush.UseVisualStyleBackColor = true;
            buttonStackPush.Click += ButtonStackPush_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Margin = new Padding(8, 8, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 105);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSortOutput);
            panel2.Controls.Add(textBoxSortSource);
            panel2.Controls.Add(buttonSortStep);
            panel2.Controls.Add(buttonSortGenerate);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(318, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 555);
            panel2.TabIndex = 1;
            // 
            // textBoxSortOutput
            // 
            textBoxSortOutput.Location = new Point(119, 253);
            textBoxSortOutput.Name = "textBoxSortOutput";
            textBoxSortOutput.Size = new Size(204, 23);
            textBoxSortOutput.TabIndex = 8;
            // 
            // textBoxSortSource
            // 
            textBoxSortSource.Location = new Point(119, 223);
            textBoxSortSource.Name = "textBoxSortSource";
            textBoxSortSource.Size = new Size(204, 23);
            textBoxSortSource.TabIndex = 7;
            // 
            // buttonSortStep
            // 
            buttonSortStep.Location = new Point(8, 252);
            buttonSortStep.Name = "buttonSortStep";
            buttonSortStep.Size = new Size(105, 23);
            buttonSortStep.TabIndex = 6;
            buttonSortStep.Text = "Шаг";
            buttonSortStep.UseVisualStyleBackColor = true;
            buttonSortStep.Click += ButtonSortStep_Click;
            // 
            // buttonSortGenerate
            // 
            buttonSortGenerate.Location = new Point(8, 223);
            buttonSortGenerate.Name = "buttonSortGenerate";
            buttonSortGenerate.Size = new Size(105, 23);
            buttonSortGenerate.TabIndex = 5;
            buttonSortGenerate.Text = "Сгенерировать";
            buttonSortGenerate.UseVisualStyleBackColor = true;
            buttonSortGenerate.Click += ButtonSortGenerate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 17);
            label2.Margin = new Padding(8, 8, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(288, 195);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxGraphOutput);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxGraphMatrix);
            panel3.Controls.Add(buttonGraphSearch);
            panel3.Controls.Add(textBoxGraphSearch);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(647, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 555);
            panel3.TabIndex = 2;
            // 
            // textBoxGraphOutput
            // 
            textBoxGraphOutput.Location = new Point(149, 96);
            textBoxGraphOutput.Multiline = true;
            textBoxGraphOutput.Name = "textBoxGraphOutput";
            textBoxGraphOutput.Size = new Size(80, 169);
            textBoxGraphOutput.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 99);
            label5.Name = "label5";
            label5.Size = new Size(13, 150);
            label5.TabIndex = 14;
            label5.Text = "0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 73);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 13;
            label4.Text = "0 1 2 3 4 5 6 7 8 9";
            // 
            // textBoxGraphMatrix
            // 
            textBoxGraphMatrix.Location = new Point(30, 96);
            textBoxGraphMatrix.Multiline = true;
            textBoxGraphMatrix.Name = "textBoxGraphMatrix";
            textBoxGraphMatrix.Size = new Size(113, 169);
            textBoxGraphMatrix.TabIndex = 12;
            // 
            // buttonGraphSearch
            // 
            buttonGraphSearch.Location = new Point(93, 48);
            buttonGraphSearch.Name = "buttonGraphSearch";
            buttonGraphSearch.Size = new Size(75, 23);
            buttonGraphSearch.TabIndex = 11;
            buttonGraphSearch.Text = "Поиск";
            buttonGraphSearch.UseVisualStyleBackColor = true;
            buttonGraphSearch.Click += ButtonGraphSearch_Click;
            // 
            // textBoxGraphSearch
            // 
            textBoxGraphSearch.Location = new Point(8, 47);
            textBoxGraphSearch.Name = "textBoxGraphSearch";
            textBoxGraphSearch.Size = new Size(79, 23);
            textBoxGraphSearch.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Margin = new Padding(8, 8, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(281, 30);
            label3.TabIndex = 9;
            label3.Text = "Реализовать алгоритм поиска в графе, используя\r\nобход в глубину (матрица смежности). ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 555);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button buttonStackPrint;
        private Button buttonStackPop;
        private Button buttonStackPush;
        private Button buttonSortGenerate;
        private Label label2;
        private TextBox textBoxSortSource;
        private Button buttonSortStep;
        private TextBox textBoxSortOutput;
        private Label label3;
        private TextBox textBoxStack;
        private TextBox textBoxGraphMatrix;
        private Button buttonGraphSearch;
        private TextBox textBoxGraphSearch;
        private Label label5;
        private Label label4;
        private TextBox textBoxGraphOutput;
    }
}