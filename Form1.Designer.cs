namespace module_test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberWizard = new System.Windows.Forms.NumericUpDown();
            this.numberLightCavalery = new System.Windows.Forms.NumericUpDown();
            this.numberCatapult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridArmy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numberWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLightCavalery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCatapult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сформувати армію";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Армія";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість чарівники";
            // 
            // numberWizard
            // 
            this.numberWizard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.numberWizard.Location = new System.Drawing.Point(16, 62);
            this.numberWizard.Name = "numberWizard";
            this.numberWizard.Size = new System.Drawing.Size(170, 26);
            this.numberWizard.TabIndex = 3;
            // 
            // numberLightCavalery
            // 
            this.numberLightCavalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.numberLightCavalery.Location = new System.Drawing.Point(16, 122);
            this.numberLightCavalery.Name = "numberLightCavalery";
            this.numberLightCavalery.Size = new System.Drawing.Size(170, 26);
            this.numberLightCavalery.TabIndex = 4;
            // 
            // numberCatapult
            // 
            this.numberCatapult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.numberCatapult.Location = new System.Drawing.Point(16, 187);
            this.numberCatapult.Name = "numberCatapult";
            this.numberCatapult.Size = new System.Drawing.Size(170, 26);
            this.numberCatapult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість легкої кавалерії";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість катапульт";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridArmy,
            this.GridCost,
            this.GridSpeed});
            this.dataGridView1.Location = new System.Drawing.Point(246, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 429);
            this.dataGridView1.TabIndex = 8;
            // 
            // GridArmy
            // 
            this.GridArmy.HeaderText = "Військо";
            this.GridArmy.MinimumWidth = 6;
            this.GridArmy.Name = "GridArmy";
            this.GridArmy.Width = 160;
            // 
            // GridCost
            // 
            this.GridCost.HeaderText = "Вартість";
            this.GridCost.MinimumWidth = 6;
            this.GridCost.Name = "GridCost";
            this.GridCost.Width = 200;
            // 
            // GridSpeed
            // 
            this.GridSpeed.HeaderText = "Швидкість";
            this.GridSpeed.MinimumWidth = 6;
            this.GridSpeed.Name = "GridSpeed";
            this.GridSpeed.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberCatapult);
            this.Controls.Add(this.numberLightCavalery);
            this.Controls.Add(this.numberWizard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberLightCavalery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCatapult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberWizard;
        private System.Windows.Forms.NumericUpDown numberLightCavalery;
        private System.Windows.Forms.NumericUpDown numberCatapult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridArmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSpeed;
    }
}

