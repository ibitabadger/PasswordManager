using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Edit : Form
    {
        public Edit(string index)
        {
            InitializeComponent();
            centerForm(this);
            setWindowSize(this, 315, 377);
        }

        private void centerForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void setWindowSize(Form form, int width, int height)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Size = new Size(width, height);
            form.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
