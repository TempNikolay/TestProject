namespace TestProject
{
    partial class EmployeesShowerForm
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
            openFileDialog = new OpenFileDialog();
            pathToXmlText = new TextBox();
            toXmlButton = new Button();
            toXmlGroup = new GroupBox();
            toXsltGroup = new GroupBox();
            pathToXsltText = new TextBox();
            toXsltButton = new Button();
            calcXmlButton = new Button();
            groupBox1 = new GroupBox();
            fileResultNameText = new TextBox();
            resultList = new ListBox();
            addItemButton = new Button();
            toXmlGroup.SuspendLayout();
            toXsltGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // pathToXmlText
            // 
            pathToXmlText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathToXmlText.Location = new Point(6, 30);
            pathToXmlText.Name = "pathToXmlText";
            pathToXmlText.Size = new Size(611, 31);
            pathToXmlText.TabIndex = 0;
            pathToXmlText.Text = "Data1.xml";
            pathToXmlText.TextChanged += pathText_TextChanged;
            // 
            // toXmlButton
            // 
            toXmlButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toXmlButton.Location = new Point(623, 27);
            toXmlButton.Name = "toXmlButton";
            toXmlButton.Size = new Size(124, 34);
            toXmlButton.TabIndex = 1;
            toXmlButton.Text = "Выбрать";
            toXmlButton.UseVisualStyleBackColor = true;
            toXmlButton.Click += toXmlButton_Click;
            // 
            // toXmlGroup
            // 
            toXmlGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toXmlGroup.Controls.Add(pathToXmlText);
            toXmlGroup.Controls.Add(toXmlButton);
            toXmlGroup.Location = new Point(12, 12);
            toXmlGroup.Name = "toXmlGroup";
            toXmlGroup.Size = new Size(776, 75);
            toXmlGroup.TabIndex = 2;
            toXmlGroup.TabStop = false;
            toXmlGroup.Text = "Путь к XML";
            // 
            // toXsltGroup
            // 
            toXsltGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toXsltGroup.Controls.Add(pathToXsltText);
            toXsltGroup.Controls.Add(toXsltButton);
            toXsltGroup.Location = new Point(12, 93);
            toXsltGroup.Name = "toXsltGroup";
            toXsltGroup.Size = new Size(776, 75);
            toXsltGroup.TabIndex = 3;
            toXsltGroup.TabStop = false;
            toXsltGroup.Text = "Путь к XSLT";
            // 
            // pathToXsltText
            // 
            pathToXsltText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathToXsltText.Location = new Point(6, 30);
            pathToXsltText.Name = "pathToXsltText";
            pathToXsltText.Size = new Size(611, 31);
            pathToXsltText.TabIndex = 0;
            pathToXsltText.Text = "Transform.xslt";
            pathToXsltText.TextChanged += pathText_TextChanged;
            // 
            // toXsltButton
            // 
            toXsltButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toXsltButton.Location = new Point(623, 27);
            toXsltButton.Name = "toXsltButton";
            toXsltButton.Size = new Size(124, 34);
            toXsltButton.TabIndex = 1;
            toXsltButton.Text = "Выбрать";
            toXsltButton.UseVisualStyleBackColor = true;
            toXsltButton.Click += toXsltButton_Click;
            // 
            // calcXmlButton
            // 
            calcXmlButton.Location = new Point(12, 284);
            calcXmlButton.Name = "calcXmlButton";
            calcXmlButton.Size = new Size(167, 34);
            calcXmlButton.TabIndex = 2;
            calcXmlButton.Text = "Рассчитать";
            calcXmlButton.UseVisualStyleBackColor = true;
            calcXmlButton.Click += calcXmlButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(fileResultNameText);
            groupBox1.Location = new Point(12, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Имя файла результата";
            // 
            // fileResultNameText
            // 
            fileResultNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileResultNameText.Location = new Point(6, 30);
            fileResultNameText.Name = "fileResultNameText";
            fileResultNameText.Size = new Size(341, 31);
            fileResultNameText.TabIndex = 0;
            fileResultNameText.Text = "Employees";
            // 
            // resultList
            // 
            resultList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultList.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            resultList.ItemHeight = 22;
            resultList.Location = new Point(12, 334);
            resultList.Name = "resultList";
            resultList.Size = new Size(776, 180);
            resultList.TabIndex = 5;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(192, 284);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(200, 34);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Добавить элемент";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // EmployeesShowerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(addItemButton);
            Controls.Add(resultList);
            Controls.Add(groupBox1);
            Controls.Add(calcXmlButton);
            Controls.Add(toXsltGroup);
            Controls.Add(toXmlGroup);
            Name = "EmployeesShowerForm";
            Text = "EmployeesShower";
            toXmlGroup.ResumeLayout(false);
            toXmlGroup.PerformLayout();
            toXsltGroup.ResumeLayout(false);
            toXsltGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private TextBox pathToXmlText;
        private Button toXmlButton;
        private GroupBox toXmlGroup;
        private GroupBox toXsltGroup;
        private TextBox pathToXsltText;
        private Button toXsltButton;
        private Button calcXmlButton;
        private GroupBox groupBox1;
        private TextBox fileResultNameText;
        private ListBox resultList;
        private Button addItemButton;
    }
}