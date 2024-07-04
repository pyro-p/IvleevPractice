namespace practice4
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
            dataGridView1 = new DataGridView();
            buttonAction = new Button();
            maskedTextBoxN1 = new MaskedTextBox();
            maskedTextBoxN2 = new MaskedTextBox();
            maskedTextBoxP2 = new MaskedTextBox();
            maskedTextBoxP1 = new MaskedTextBox();
            ColumnStep = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnN1 = new DataGridViewTextBoxColumn();
            ColumnN2 = new DataGridViewTextBoxColumn();
            ColumnCondition = new DataGridViewTextBoxColumn();
            ColumnCheck1 = new DataGridViewTextBoxColumn();
            ColumnCheck2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnStep, ColumnYear, ColumnN1, ColumnN2, ColumnCondition, ColumnCheck1, ColumnCheck2 });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(471, 12);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(75, 23);
            buttonAction.TabIndex = 1;
            buttonAction.Text = "Запустить";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += ButtonAction_Click;
            // 
            // maskedTextBoxN1
            // 
            maskedTextBoxN1.Location = new Point(12, 12);
            maskedTextBoxN1.Name = "maskedTextBoxN1";
            maskedTextBoxN1.Size = new Size(100, 23);
            maskedTextBoxN1.TabIndex = 2;
            // 
            // maskedTextBoxN2
            // 
            maskedTextBoxN2.Location = new Point(118, 12);
            maskedTextBoxN2.Name = "maskedTextBoxN2";
            maskedTextBoxN2.Size = new Size(100, 23);
            maskedTextBoxN2.TabIndex = 3;
            // 
            // maskedTextBoxP2
            // 
            maskedTextBoxP2.Location = new Point(365, 12);
            maskedTextBoxP2.Name = "maskedTextBoxP2";
            maskedTextBoxP2.Size = new Size(100, 23);
            maskedTextBoxP2.TabIndex = 5;
            // 
            // maskedTextBoxP1
            // 
            maskedTextBoxP1.Location = new Point(259, 12);
            maskedTextBoxP1.Name = "maskedTextBoxP1";
            maskedTextBoxP1.Size = new Size(100, 23);
            maskedTextBoxP1.TabIndex = 4;
            // 
            // ColumnStep
            // 
            ColumnStep.HeaderText = "№";
            ColumnStep.Name = "ColumnStep";
            ColumnStep.Width = 40;
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "Year";
            ColumnYear.Name = "ColumnYear";
            ColumnYear.Width = 60;
            // 
            // ColumnN1
            // 
            ColumnN1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnN1.HeaderText = "N1";
            ColumnN1.Name = "ColumnN1";
            // 
            // ColumnN2
            // 
            ColumnN2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnN2.HeaderText = "N2";
            ColumnN2.Name = "ColumnN2";
            // 
            // ColumnCondition
            // 
            ColumnCondition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCondition.HeaderText = "N1 < N2";
            ColumnCondition.Name = "ColumnCondition";
            // 
            // ColumnCheck1
            // 
            ColumnCheck1.HeaderText = "N1 > N2";
            ColumnCheck1.Name = "ColumnCheck1";
            // 
            // ColumnCheck2
            // 
            ColumnCheck2.HeaderText = "P1 < P2";
            ColumnCheck2.Name = "ColumnCheck2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxP2);
            Controls.Add(maskedTextBoxP1);
            Controls.Add(maskedTextBoxN2);
            Controls.Add(maskedTextBoxN1);
            Controls.Add(buttonAction);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAction;
        private MaskedTextBox maskedTextBoxN1;
        private MaskedTextBox maskedTextBoxN2;
        private MaskedTextBox maskedTextBoxP2;
        private MaskedTextBox maskedTextBoxP1;
        private DataGridViewTextBoxColumn ColumnStep;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnN1;
        private DataGridViewTextBoxColumn ColumnN2;
        private DataGridViewTextBoxColumn ColumnCondition;
        private DataGridViewTextBoxColumn ColumnCheck1;
        private DataGridViewTextBoxColumn ColumnCheck2;
    }
}