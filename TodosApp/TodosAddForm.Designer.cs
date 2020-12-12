namespace TodosApp
{
    partial class TodosAddForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.rtbTodos = new System.Windows.Forms.RichTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(29, 23);
            this.dtpDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(245, 30);
            this.dtpDateTime.TabIndex = 0;
            // 
            // rtbTodos
            // 
            this.rtbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTodos.Location = new System.Drawing.Point(29, 69);
            this.rtbTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTodos.Name = "rtbTodos";
            this.rtbTodos.Size = new System.Drawing.Size(245, 214);
            this.rtbTodos.TabIndex = 1;
            this.rtbTodos.Text = "";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(29, 318);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(245, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(29, 358);
            this.btTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(245, 23);
            this.btTodos.TabIndex = 3;
            this.btTodos.Text = "Offene Todos anzeigen";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // TodosAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 409);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.rtbTodos);
            this.Controls.Add(this.dtpDateTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TodosAddForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.RichTextBox rtbTodos;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btTodos;
    }
}

