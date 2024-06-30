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
            maskedTextBoxA = new MaskedTextBox();
            maskedTextBoxB = new MaskedTextBox();
            ColumnStep = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnProduction = new DataGridViewTextBoxColumn();
            ColumnDemand = new DataGridViewTextBoxColumn();
            ColumnCondition = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnStep, ColumnYear, ColumnProduction, ColumnDemand, ColumnCondition });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(224, 12);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(75, 23);
            buttonAction.TabIndex = 1;
            buttonAction.Text = "Запустить";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += ButtonAction_Click;
            // 
            // maskedTextBoxA
            // 
            maskedTextBoxA.Location = new Point(12, 12);
            maskedTextBoxA.Name = "maskedTextBoxA";
            maskedTextBoxA.Size = new Size(100, 23);
            maskedTextBoxA.TabIndex = 2;
            // 
            // maskedTextBoxB
            // 
            maskedTextBoxB.Location = new Point(118, 12);
            maskedTextBoxB.Name = "maskedTextBoxB";
            maskedTextBoxB.Size = new Size(100, 23);
            maskedTextBoxB.TabIndex = 3;
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
            // ColumnProduction
            // 
            ColumnProduction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnProduction.HeaderText = "Production";
            ColumnProduction.Name = "ColumnProduction";
            // 
            // ColumnDemand
            // 
            ColumnDemand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDemand.HeaderText = "Demand";
            ColumnDemand.Name = "ColumnDemand";
            // 
            // ColumnCondition
            // 
            ColumnCondition.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCondition.HeaderText = "producion < demand";
            ColumnCondition.Name = "ColumnCondition";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxB);
            Controls.Add(maskedTextBoxA);
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
        private MaskedTextBox maskedTextBoxA;
        private MaskedTextBox maskedTextBoxB;
        private DataGridViewTextBoxColumn ColumnStep;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnProduction;
        private DataGridViewTextBoxColumn ColumnDemand;
        private DataGridViewTextBoxColumn ColumnCondition;
    }
}