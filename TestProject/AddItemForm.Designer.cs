namespace TestProject
{
    partial class AddItemForm
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
            AddItemButton = new Button();
            nameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            surnameText = new TextBox();
            label3 = new Label();
            amountText = new TextBox();
            label4 = new Label();
            monthText = new TextBox();
            SuspendLayout();
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(12, 173);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(126, 34);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Добавить";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(97, 9);
            nameText.Name = "nameText";
            nameText.Size = new Size(256, 31);
            nameText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 4;
            label2.Text = "Фамилия";
            // 
            // surnameText
            // 
            surnameText.Location = new Point(97, 46);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(256, 31);
            surnameText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 6;
            label3.Text = "Сумма";
            // 
            // amountText
            // 
            amountText.Location = new Point(97, 83);
            amountText.Name = "amountText";
            amountText.Size = new Size(256, 31);
            amountText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 8;
            label4.Text = "Месяц";
            // 
            // monthText
            // 
            monthText.Location = new Point(97, 120);
            monthText.Name = "monthText";
            monthText.Size = new Size(256, 31);
            monthText.TabIndex = 7;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 255);
            Controls.Add(label4);
            Controls.Add(monthText);
            Controls.Add(label3);
            Controls.Add(amountText);
            Controls.Add(label2);
            Controls.Add(surnameText);
            Controls.Add(label1);
            Controls.Add(nameText);
            Controls.Add(AddItemButton);
            Name = "AddItemForm";
            Text = "AddItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddItemButton;
        private TextBox nameText;
        private Label label1;
        private Label label2;
        private TextBox surnameText;
        private Label label3;
        private TextBox amountText;
        private Label label4;
        private TextBox monthText;
    }
}