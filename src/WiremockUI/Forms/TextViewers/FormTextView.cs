﻿using System.Windows.Forms;

namespace WiremockUI
{
    public partial class FormTextView : Form
    {
        private FormMaster master;

        public FormTextView(FormMaster master, string title, string content)
        {
            InitializeComponent();

            this.master = master;
            this.TabStop = false;
            this.txtTitle.TextValue = title;
            this.txtContent.TextValue = Helper.ResolveBreakLineInCompatibility(content);

            if (string.IsNullOrWhiteSpace(title))
                this.txtTitle.Visible = false;
        }

        private void FormTextView_Load(object sender, System.EventArgs e)
        {
            this.ActiveControl = txtContent;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            FormMaster.Current.TabMaster.CloseTab(this);
        }
    }
}
