namespace BudgetTracking
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.btnPeople = new System.Windows.Forms.Button();
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(38, 21);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(88, 15);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "People Entry";
            // 
            // btnPeople
            // 
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Location = new System.Drawing.Point(28, 39);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(103, 29);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(38, 91);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(90, 15);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Income Entry";
            this.lblIncome.Click += new System.EventHandler(this.lblIncome_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.Location = new System.Drawing.Point(28, 109);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(103, 23);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(26, 144);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(105, 15);
            this.lblExpenses.TabIndex = 4;
            this.lblExpenses.Text = "Expenses Entry";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Expenses";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.lblPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Button button1;
    }
}

