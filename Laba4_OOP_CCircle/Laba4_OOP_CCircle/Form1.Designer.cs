
namespace Laba4_OOP_CCircle
{
    partial class MainForm
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
            this.Circle_Panel = new System.Windows.Forms.Panel();
            this.Coord_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            this.СlearStorage_button = new System.Windows.Forms.Button();
            this.ShowCircle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Circle_Panel
            // 
            this.Circle_Panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Circle_Panel.Location = new System.Drawing.Point(12, 12);
            this.Circle_Panel.Name = "Circle_Panel";
            this.Circle_Panel.Size = new System.Drawing.Size(1327, 553);
            this.Circle_Panel.TabIndex = 0;
            this.Circle_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Circle_Panel_MouseDown);
            this.Circle_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Circle_Panel_MouseMove);
            // 
            // Coord_label
            // 
            this.Coord_label.AutoSize = true;
            this.Coord_label.Location = new System.Drawing.Point(1385, 9);
            this.Coord_label.Name = "Coord_label";
            this.Coord_label.Size = new System.Drawing.Size(59, 25);
            this.Coord_label.TabIndex = 1;
            this.Coord_label.Text = "label1";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(23, 585);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(270, 57);
            this.Clear_button.TabIndex = 2;
            this.Clear_button.Text = "Очистить панель";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Del_button
            // 
            this.Del_button.Location = new System.Drawing.Point(370, 585);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(264, 57);
            this.Del_button.TabIndex = 3;
            this.Del_button.Text = "Удалить объекты";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // СlearStorage_button
            // 
            this.СlearStorage_button.Location = new System.Drawing.Point(716, 585);
            this.СlearStorage_button.Name = "СlearStorage_button";
            this.СlearStorage_button.Size = new System.Drawing.Size(267, 57);
            this.СlearStorage_button.TabIndex = 4;
            this.СlearStorage_button.Text = "Очистить хранилище";
            this.СlearStorage_button.UseVisualStyleBackColor = true;
            this.СlearStorage_button.Click += new System.EventHandler(this.СlearStorage_button_Click);
            // 
            // ShowCircle_button
            // 
            this.ShowCircle_button.Location = new System.Drawing.Point(1065, 585);
            this.ShowCircle_button.Name = "ShowCircle_button";
            this.ShowCircle_button.Size = new System.Drawing.Size(266, 57);
            this.ShowCircle_button.TabIndex = 5;
            this.ShowCircle_button.Text = "Показать объекты хранилища";
            this.ShowCircle_button.UseVisualStyleBackColor = true;
            this.ShowCircle_button.Click += new System.EventHandler(this.ShowCircle_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 654);
            this.Controls.Add(this.ShowCircle_button);
            this.Controls.Add(this.СlearStorage_button);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Coord_label);
            this.Controls.Add(this.Circle_Panel);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №4";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Circle_Panel;
        private System.Windows.Forms.Label Coord_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button СlearStorage_button;
        private System.Windows.Forms.Button ShowCircle_button;
    }
}

