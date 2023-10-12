namespace To_do_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.tasktextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.discription_task = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_loed = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "To to list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tasktextBox
            // 
            this.tasktextBox.Location = new System.Drawing.Point(10, 164);
            this.tasktextBox.Name = "tasktextBox";
            this.tasktextBox.Size = new System.Drawing.Size(945, 22);
            this.tasktextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(945, 22);
            this.textBox2.TabIndex = 2;
            // 
            // discription_task
            // 
            this.discription_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discription_task.Location = new System.Drawing.Point(12, 199);
            this.discription_task.Name = "discription_task";
            this.discription_task.Size = new System.Drawing.Size(943, 29);
            this.discription_task.TabIndex = 3;
            this.discription_task.Text = "Опис завдання";
            this.discription_task.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(943, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Завдання";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_loed
            // 
            this.button_loed.Location = new System.Drawing.Point(10, 277);
            this.button_loed.Name = "button_loed";
            this.button_loed.Size = new System.Drawing.Size(162, 45);
            this.button_loed.TabIndex = 5;
            this.button_loed.Text = "Загрузити завдання";
            this.button_loed.UseVisualStyleBackColor = true;
            this.button_loed.Click += new System.EventHandler(this.button_loed_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(200, 277);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(140, 45);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Видалити завдання";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(360, 274);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(138, 45);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "Додати завдання ";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(515, 274);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(137, 50);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Зберігти завдання";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // List
            // 
            this.List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List.BackgroundColor = System.Drawing.Color.White;
            this.List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List.Location = new System.Drawing.Point(2, 343);
            this.List.Name = "List";
            this.List.RowHeadersWidth = 51;
            this.List.RowTemplate.Height = 24;
            this.List.Size = new System.Drawing.Size(987, 303);
            this.List.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(995, 658);
            this.Controls.Add(this.List);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_loed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discription_task);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tasktextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "To Do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tasktextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label discription_task;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_loed;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView List;
    }
}

