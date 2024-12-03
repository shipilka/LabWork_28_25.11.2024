namespace LabWork_28_25._11._2024
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
            Task1Button = new Button();
            Task2Button = new Button();
            Task3Button = new Button();
            SuspendLayout();
            // 
            // Task1Button
            // 
            Task1Button.Location = new Point(129, 51);
            Task1Button.Name = "Task1Button";
            Task1Button.Size = new Size(94, 29);
            Task1Button.TabIndex = 0;
            Task1Button.Text = "Задание 1";
            Task1Button.UseVisualStyleBackColor = true;
            Task1Button.Click += Task1Button_Click;
            // 
            // Task2Button
            // 
            Task2Button.Location = new Point(129, 136);
            Task2Button.Name = "Task2Button";
            Task2Button.Size = new Size(94, 29);
            Task2Button.TabIndex = 1;
            Task2Button.Text = "Задание 2";
            Task2Button.UseVisualStyleBackColor = true;
            Task2Button.Click += Task2Button_Click;
            // 
            // Task3Button
            // 
            Task3Button.Location = new Point(129, 235);
            Task3Button.Name = "Task3Button";
            Task3Button.Size = new Size(94, 29);
            Task3Button.TabIndex = 2;
            Task3Button.Text = "Задание 3";
            Task3Button.UseVisualStyleBackColor = true;
            Task3Button.Click += Task3Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 346);
            Controls.Add(Task3Button);
            Controls.Add(Task2Button);
            Controls.Add(Task1Button);
            Name = "MainForm";
            Text = "Лабораторная работа №28";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Task1Button;
        private Button Task2Button;
        private Button Task3Button;
    }
}
