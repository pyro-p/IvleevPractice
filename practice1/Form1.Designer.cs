namespace practice1
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
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            labelTask = new Label();
            buttonTwoDim = new Button();
            buttonOneDim = new Button();
            textBoxOutput = new TextBox();
            buttonRun = new Button();
            label1 = new Label();
            textBoxRows = new TextBox();
            labelSize = new Label();
            textBoxMax = new TextBox();
            textBoxColumns = new TextBox();
            textBoxArray = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 419);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(48, 186);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "Задание 6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(48, 157);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Задание 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(48, 128);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Задание 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Задание 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Задание 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Задание 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTask);
            panel2.Controls.Add(buttonTwoDim);
            panel2.Controls.Add(buttonOneDim);
            panel2.Controls.Add(textBoxOutput);
            panel2.Controls.Add(buttonRun);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxRows);
            panel2.Controls.Add(labelSize);
            panel2.Controls.Add(textBoxMax);
            panel2.Controls.Add(textBoxColumns);
            panel2.Controls.Add(textBoxArray);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(424, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 419);
            panel2.TabIndex = 1;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelTask.Location = new Point(15, 186);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(42, 12);
            labelTask.TabIndex = 6;
            labelTask.Text = "Задание";
            // 
            // buttonTwoDim
            // 
            buttonTwoDim.Location = new Point(189, 157);
            buttonTwoDim.Name = "buttonTwoDim";
            buttonTwoDim.Size = new Size(100, 23);
            buttonTwoDim.TabIndex = 10;
            buttonTwoDim.Text = "Двумерный";
            buttonTwoDim.UseVisualStyleBackColor = true;
            buttonTwoDim.Click += ButtonTwoDim_Click;
            // 
            // buttonOneDim
            // 
            buttonOneDim.Location = new Point(189, 128);
            buttonOneDim.Name = "buttonOneDim";
            buttonOneDim.Size = new Size(100, 23);
            buttonOneDim.TabIndex = 9;
            buttonOneDim.Text = "Одномерный";
            buttonOneDim.UseVisualStyleBackColor = true;
            buttonOneDim.Click += ButtonOneDim_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(15, 319);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(274, 88);
            textBoxOutput.TabIndex = 8;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(15, 290);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 7;
            buttonRun.Text = "Запустить";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += ButtonRun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 161);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Макс. значение";
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(114, 128);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(40, 23);
            textBoxRows.TabIndex = 4;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(15, 132);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(47, 15);
            labelSize.TabIndex = 3;
            labelSize.Text = "Размер";
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(114, 157);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(67, 23);
            textBoxMax.TabIndex = 2;
            // 
            // textBoxColumns
            // 
            textBoxColumns.Location = new Point(68, 128);
            textBoxColumns.Name = "textBoxColumns";
            textBoxColumns.Size = new Size(40, 23);
            textBoxColumns.TabIndex = 1;
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(15, 23);
            textBoxArray.Multiline = true;
            textBoxArray.Name = "textBoxArray";
            textBoxArray.Size = new Size(274, 88);
            textBoxArray.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 419);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox textBoxArray;
        private Label label1;
        private TextBox textBoxRows;
        private Label labelSize;
        private TextBox textBoxMax;
        private TextBox textBoxColumns;
        private TextBox textBoxOutput;
        private Button buttonRun;
        private Label labelTask;
        private Button buttonTwoDim;
        private Button buttonOneDim;
    }
}
