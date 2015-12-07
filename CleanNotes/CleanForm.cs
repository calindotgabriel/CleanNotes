using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanNotes
{
    public partial class CleanForm : Form
    {
        public CleanForm()
        {
            InitializeComponent();

            AddItemsToListView();
        }

        private void AddItemsToListView()
        {
            mainListView.Items.Add(new ListViewItem("test"));
        }

    }
}
