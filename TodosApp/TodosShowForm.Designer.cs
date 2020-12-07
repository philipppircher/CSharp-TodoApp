﻿namespace TodosApp
{
    partial class TodosShowForm
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
            this.rbShowAllTodos = new System.Windows.Forms.RadioButton();
            this.rbTodosDone = new System.Windows.Forms.RadioButton();
            this.rbTodosNotDone = new System.Windows.Forms.RadioButton();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.rbTodoNextToHours = new System.Windows.Forms.RadioButton();
            this.rtbTodos = new System.Windows.Forms.RichTextBox();
            this.cbIsDone = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbShowAllTodos
            // 
            this.rbShowAllTodos.AutoSize = true;
            this.rbShowAllTodos.Location = new System.Drawing.Point(19, 24);
            this.rbShowAllTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbShowAllTodos.Name = "rbShowAllTodos";
            this.rbShowAllTodos.Size = new System.Drawing.Size(92, 24);
            this.rbShowAllTodos.TabIndex = 0;
            this.rbShowAllTodos.TabStop = true;
            this.rbShowAllTodos.Text = "All Todos";
            this.rbShowAllTodos.UseVisualStyleBackColor = true;
            this.rbShowAllTodos.CheckedChanged += new System.EventHandler(this.rbShowAllTodos_CheckedChanged);
            // 
            // rbTodosDone
            // 
            this.rbTodosDone.AutoSize = true;
            this.rbTodosDone.Location = new System.Drawing.Point(19, 74);
            this.rbTodosDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTodosDone.Name = "rbTodosDone";
            this.rbTodosDone.Size = new System.Drawing.Size(114, 24);
            this.rbTodosDone.TabIndex = 1;
            this.rbTodosDone.TabStop = true;
            this.rbTodosDone.Text = "Todos Done";
            this.rbTodosDone.UseVisualStyleBackColor = true;
            // 
            // rbTodosNotDone
            // 
            this.rbTodosNotDone.AutoSize = true;
            this.rbTodosNotDone.Location = new System.Drawing.Point(19, 125);
            this.rbTodosNotDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTodosNotDone.Name = "rbTodosNotDone";
            this.rbTodosNotDone.Size = new System.Drawing.Size(143, 24);
            this.rbTodosNotDone.TabIndex = 2;
            this.rbTodosNotDone.TabStop = true;
            this.rbTodosNotDone.Text = "Todos Not Done";
            this.rbTodosNotDone.UseVisualStyleBackColor = true;
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(19, 256);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(46, 26);
            this.nudHours.TabIndex = 3;
            // 
            // rbTodoNextToHours
            // 
            this.rbTodoNextToHours.AutoSize = true;
            this.rbTodoNextToHours.Location = new System.Drawing.Point(19, 207);
            this.rbTodoNextToHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTodoNextToHours.Name = "rbTodoNextToHours";
            this.rbTodoNextToHours.Size = new System.Drawing.Size(177, 24);
            this.rbTodoNextToHours.TabIndex = 4;
            this.rbTodoNextToHours.TabStop = true;
            this.rbTodoNextToHours.Text = "Todos Next to hours..";
            this.rbTodoNextToHours.UseVisualStyleBackColor = true;
            // 
            // rtbTodos
            // 
            this.rtbTodos.Location = new System.Drawing.Point(269, 74);
            this.rtbTodos.Name = "rtbTodos";
            this.rtbTodos.Size = new System.Drawing.Size(358, 157);
            this.rtbTodos.TabIndex = 5;
            this.rtbTodos.Text = "";
            // 
            // cbIsDone
            // 
            this.cbIsDone.AutoSize = true;
            this.cbIsDone.Location = new System.Drawing.Point(269, 257);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(67, 24);
            this.cbIsDone.TabIndex = 6;
            this.cbIsDone.Text = "Done";
            this.cbIsDone.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(364, 257);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(263, 34);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // TodosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 303);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbIsDone);
            this.Controls.Add(this.rtbTodos);
            this.Controls.Add(this.rbTodoNextToHours);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.rbTodosNotDone);
            this.Controls.Add(this.rbTodosDone);
            this.Controls.Add(this.rbShowAllTodos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TodosShowForm";
            this.Text = "Show Todos Selection Window";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbShowAllTodos;
        private System.Windows.Forms.RadioButton rbTodosDone;
        private System.Windows.Forms.RadioButton rbTodosNotDone;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.RadioButton rbTodoNextToHours;
        private System.Windows.Forms.RichTextBox rtbTodos;
        private System.Windows.Forms.CheckBox cbIsDone;
        private System.Windows.Forms.Button btSave;
    }
}