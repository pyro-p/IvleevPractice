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
            textBoxCircularList = new TextBox();
            buttonCircularListPrint = new Button();
            buttonCircularListRemove = new Button();
            buttonCircularListAdd = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBoxSortOutput = new TextBox();
            textBoxSortSource = new TextBox();
            buttonSortStep = new Button();
            buttonSortGenerate = new Button();
            label2 = new Label();
            panel3 = new Panel();
            textBoxGraphOutput = new TextBox();
            textBoxGraphList = new TextBox();
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
            panel1.Controls.Add(textBoxCircularList);
            panel1.Controls.Add(buttonCircularListPrint);
            panel1.Controls.Add(buttonCircularListRemove);
            panel1.Controls.Add(buttonCircularListAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 555);
            panel1.TabIndex = 0;
            // 
            // textBoxCircularList
            // 
            textBoxCircularList.Location = new Point(12, 174);
            textBoxCircularList.Name = "textBoxCircularList";
            textBoxCircularList.Size = new Size(297, 23);
            textBoxCircularList.TabIndex = 4;
            // 
            // buttonCircularListPrint
            // 
            buttonCircularListPrint.Location = new Point(213, 145);
            buttonCircularListPrint.Name = "buttonCircularListPrint";
            buttonCircularListPrint.Size = new Size(96, 23);
            buttonCircularListPrint.TabIndex = 3;
            buttonCircularListPrint.Text = "Вывести";
            buttonCircularListPrint.UseVisualStyleBackColor = true;
            buttonCircularListPrint.Click += ButtonCircularListPrint_Click;
            // 
            // buttonCircularListRemove
            // 
            buttonCircularListRemove.Location = new Point(111, 145);
            buttonCircularListRemove.Name = "buttonCircularListRemove";
            buttonCircularListRemove.Size = new Size(96, 23);
            buttonCircularListRemove.TabIndex = 2;
            buttonCircularListRemove.Text = "Удалить";
            buttonCircularListRemove.UseVisualStyleBackColor = true;
            buttonCircularListRemove.Click += ButtonCircularListRemove_Click;
            // 
            // buttonCircularListAdd
            // 
            buttonCircularListAdd.Location = new Point(9, 145);
            buttonCircularListAdd.Name = "buttonCircularListAdd";
            buttonCircularListAdd.Size = new Size(96, 23);
            buttonCircularListAdd.TabIndex = 1;
            buttonCircularListAdd.Text = "Добавить";
            buttonCircularListAdd.UseVisualStyleBackColor = true;
            buttonCircularListAdd.Click += ButtonCircularListAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Margin = new Padding(8, 8, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 90);
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
            label2.Size = new Size(309, 195);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxGraphOutput);
            panel3.Controls.Add(textBoxGraphList);
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
            textBoxGraphOutput.Location = new Point(153, 223);
            textBoxGraphOutput.Multiline = true;
            textBoxGraphOutput.Name = "textBoxGraphOutput";
            textBoxGraphOutput.Size = new Size(80, 169);
            textBoxGraphOutput.TabIndex = 15;
            // 
            // textBoxGraphList
            // 
            textBoxGraphList.Location = new Point(34, 223);
            textBoxGraphList.Multiline = true;
            textBoxGraphList.Name = "textBoxGraphList";
            textBoxGraphList.Size = new Size(113, 169);
            textBoxGraphList.TabIndex = 12;
            // 
            // buttonGraphSearch
            // 
            buttonGraphSearch.Location = new Point(97, 175);
            buttonGraphSearch.Name = "buttonGraphSearch";
            buttonGraphSearch.Size = new Size(75, 23);
            buttonGraphSearch.TabIndex = 11;
            buttonGraphSearch.Text = "Поиск";
            buttonGraphSearch.UseVisualStyleBackColor = true;
            buttonGraphSearch.Click += ButtonGraphSearch_Click;
            // 
            // textBoxGraphSearch
            // 
            textBoxGraphSearch.Location = new Point(12, 174);
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
            label3.Size = new Size(309, 150);
            label3.TabIndex = 9;
            label3.Text = resources.GetString("label3.Text");
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
        private Button buttonCircularListPrint;
        private Button buttonCircularListRemove;
        private Button buttonCircularListAdd;
        private Button buttonSortGenerate;
        private Label label2;
        private TextBox textBoxSortSource;
        private Button buttonSortStep;
        private TextBox textBoxSortOutput;
        private Label label3;
        private TextBox textBoxCircularList;
        private TextBox textBoxGraphList;
        private Button buttonGraphSearch;
        private TextBox textBoxGraphSearch;
        private TextBox textBoxGraphOutput;
    }
}