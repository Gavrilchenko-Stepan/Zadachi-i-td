﻿namespace MyMVP
{
    partial class DataTable
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
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.UserCard = new UserCard.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTable
            // 
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.Location = new System.Drawing.Point(61, 32);
            this.UserTable.Name = "UserTable";
            this.UserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserTable.Size = new System.Drawing.Size(658, 150);
            this.UserTable.TabIndex = 0;
            this.UserTable.SelectionChanged += new System.EventHandler(this.UserTable_SelectionChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(147, 231);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.Location = new System.Drawing.Point(61, 205);
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(251, 20);
            this.TextBoxFilter.TabIndex = 2;
            // 
            // UserCard
            // 
            this.UserCard.Location = new System.Drawing.Point(334, 188);
            this.UserCard.Name = "UserCard";
            this.UserCard.Size = new System.Drawing.Size(439, 256);
            this.UserCard.TabIndex = 3;
            this.UserCard.Load += new System.EventHandler(this.UserCard_Load);
            // 
            // DataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserCard);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.UserTable);
            this.Name = "DataTable";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserTable;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private UserCard.UserControl1 UserCard;
    }
}

