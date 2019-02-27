namespace ASort
{
    partial class ASort
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
            this.SelectB = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.ConvertTypes = new System.Windows.Forms.RichTextBox();
            this.SortB = new System.Windows.Forms.Button();
            this.FolderDial = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // SelectB
            // 
            this.SelectB.Location = new System.Drawing.Point(274, 12);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(98, 29);
            this.SelectB.TabIndex = 0;
            this.SelectB.Text = "Select";
            this.SelectB.UseVisualStyleBackColor = true;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(12, 17);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(251, 20);
            this.PathBox.TabIndex = 1;
            // 
            // ConvertTypes
            // 
            this.ConvertTypes.Location = new System.Drawing.Point(12, 52);
            this.ConvertTypes.Name = "ConvertTypes";
            this.ConvertTypes.Size = new System.Drawing.Size(251, 201);
            this.ConvertTypes.TabIndex = 2;
            this.ConvertTypes.Text = "";
            // 
            // SortB
            // 
            this.SortB.Location = new System.Drawing.Point(274, 52);
            this.SortB.Name = "SortB";
            this.SortB.Size = new System.Drawing.Size(98, 29);
            this.SortB.TabIndex = 3;
            this.SortB.Text = "Sort";
            this.SortB.UseVisualStyleBackColor = true;
            // 
            // ASort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.SortB);
            this.Controls.Add(this.ConvertTypes);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.SelectB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ASort";
            this.Text = "ASort";
            this.Shown += new System.EventHandler(this.ASort_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.RichTextBox ConvertTypes;
        private System.Windows.Forms.Button SortB;
        private System.Windows.Forms.FolderBrowserDialog FolderDial;
    }
}

