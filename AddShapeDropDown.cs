using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDraft
{
    public partial class AddShapeDropDown : Form
    {
        public AddShapeDropDown(string s="")
        {
            InitializeComponent();
            sizeChangeBtn.Text = s;
        }

        public event EventHandler<string> ShapeDrawn;
        
        private void SizeChangeBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, sizeChangeBtn.Text);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ShapeDrawn?.Invoke(sender, "close");
        }
    }
}
