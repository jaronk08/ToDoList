namespace ToDoList
{
    partial class ToDoListForm
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
            this.todolistLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.todolistView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.todolistView)).BeginInit();
            this.SuspendLayout();
            // 
            // todolistLabel
            // 
            this.todolistLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todolistLabel.Location = new System.Drawing.Point(12, 9);
            this.todolistLabel.Name = "todolistLabel";
            this.todolistLabel.Size = new System.Drawing.Size(560, 54);
            this.todolistLabel.TabIndex = 0;
            this.todolistLabel.Text = "To Do List";
            this.todolistLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(552, 20);
            this.textBox2.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(15, 123);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(560, 22);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(15, 71);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(560, 22);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(20, 175);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(133, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(159, 175);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(133, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(303, 175);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(133, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(442, 175);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // todolistView
            // 
            this.todolistView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todolistView.BackgroundColor = System.Drawing.Color.White;
            this.todolistView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todolistView.Location = new System.Drawing.Point(20, 204);
            this.todolistView.Name = "todolistView";
            this.todolistView.Size = new System.Drawing.Size(552, 345);
            this.todolistView.TabIndex = 9;
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.todolistView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.todolistLabel);
            this.Name = "ToDoListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.todolistView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todolistLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView todolistView;
    }
}

