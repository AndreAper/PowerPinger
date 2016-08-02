using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPinger
{
    public partial class frmTargetManager : Form
    {
        public StringCollection TargetList { get; set; }

        private StringCollection _scTargetList;

        private void UpdateForm()
        {
            if (_scTargetList != null)
            {
                if (_scTargetList.Count > 0)
                {
                    this.tbxTargets.Lines = _scTargetList.Cast<string>().ToArray();  
                }
            }

        }

        public frmTargetManager()
        {
            InitializeComponent();
            UpdateForm();
        }

        public frmTargetManager(StringCollection tl)
        {
            InitializeComponent();
            _scTargetList = tl;
            UpdateForm();
        }

        private void btnSaveTargets_Click(object sender, EventArgs e)
        {
            _scTargetList = new StringCollection();
            if (this.tbxTargets.Lines.Count() > 0)
            {
                foreach (string line in this.tbxTargets.Lines)
                {
                    _scTargetList.Add(line);
                }

                Properties.Settings.Default.TargetList = _scTargetList;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.TargetList = new StringCollection();
                Properties.Settings.Default.Save();
            }

            this.TargetList = _scTargetList;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.TargetList = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
