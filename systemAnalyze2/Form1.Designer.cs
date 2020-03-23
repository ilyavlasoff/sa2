namespace systemAnalyze2
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
            this.relationsMatrixView = new System.Windows.Forms.DataGridView();
            this.levelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.levelList = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.allLevelCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.topsCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // relationsMatrixView
            // 
            this.relationsMatrixView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relationsMatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationsMatrixView.Location = new System.Drawing.Point(12, 12);
            this.relationsMatrixView.Name = "relationsMatrixView";
            this.relationsMatrixView.Size = new System.Drawing.Size(693, 420);
            this.relationsMatrixView.TabIndex = 1;
            // 
            // levelUpDown
            // 
            this.levelUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.levelUpDown.Location = new System.Drawing.Point(89, 482);
            this.levelUpDown.Name = "levelUpDown";
            this.levelUpDown.Size = new System.Drawing.Size(43, 20);
            this.levelUpDown.TabIndex = 2;
            this.levelUpDown.ValueChanged += new System.EventHandler(this.levelUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Уровень";
            // 
            // levelList
            // 
            this.levelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.levelList.Location = new System.Drawing.Point(167, 482);
            this.levelList.Name = "levelList";
            this.levelList.Size = new System.Drawing.Size(538, 20);
            this.levelList.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(630, 453);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Всего уровней:";
            // 
            // allLevelCount
            // 
            this.allLevelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allLevelCount.AutoSize = true;
            this.allLevelCount.Location = new System.Drawing.Point(562, 458);
            this.allLevelCount.Name = "allLevelCount";
            this.allLevelCount.Size = new System.Drawing.Size(13, 13);
            this.allLevelCount.TabIndex = 9;
            this.allLevelCount.Text = "?";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество вершин";
            // 
            // topsCount
            // 
            this.topsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topsCount.Location = new System.Drawing.Point(411, 456);
            this.topsCount.Name = "topsCount";
            this.topsCount.ReadOnly = true;
            this.topsCount.Size = new System.Drawing.Size(43, 20);
            this.topsCount.TabIndex = 10;
            this.topsCount.ValueChanged += new System.EventHandler(this.topsCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Правила преобразования";
            // 
            // rules
            // 
            this.rules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rules.Location = new System.Drawing.Point(167, 520);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(538, 42);
            this.rules.TabIndex = 13;
            this.rules.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 574);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topsCount);
            this.Controls.Add(this.allLevelCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.levelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelUpDown);
            this.Controls.Add(this.relationsMatrixView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView relationsMatrixView;
        private System.Windows.Forms.NumericUpDown levelUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox levelList;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allLevelCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown topsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rules;
    }
}

