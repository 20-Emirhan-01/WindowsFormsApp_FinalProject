using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FinalProject.STForms
{
    public partial class STPersonelListeForm : Form
    {
        public STPersonelListeForm()
        {
            InitializeComponent();
        }

        private void STPersonelListeForm_Load(object sender, EventArgs e)
        {
            var ctx = new YeniEntities();
            var stprsLst = ctx.STPersonels.ToList();
            var bindingList = new BindingList<STPersonel>(stprsLst);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
