using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestProject
{
    public partial class AddItemForm : Form
    {
        private string _path;

        public AddItemForm(string path)
        {
            InitializeComponent();
            _path = path;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddNewItem();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void AddNewItem()
        {
            var doc = XDocument.Load(_path);

            var newItem = new XElement("item",
                new XAttribute("name", nameText.Text),
                new XAttribute("surname", surnameText.Text),
                new XAttribute("amount", amountText.Text),
                new XAttribute("mount", monthText.Text)
            );

            doc.Root?.Add(newItem);

            doc.Save(_path);
        }
    }
}
