using System.Text;
using System.Windows.Forms;

namespace InputFilesDOCX
{
    internal partial class SettingsForm_InputFilesDOCX : Form
    {


        #region Get and Set Options

        public string TextFileDirectory { get; set; }
        public bool ScanSubfolders { get; set; }
        public bool PreserveParags { get; set; }

       #endregion



        public SettingsForm_InputFilesDOCX(string TextFileDirectory, bool ScanSubfolders, bool PreserveParagraphs)
        {
            InitializeComponent();

            IncludeSubfoldersCheckbox.Checked = ScanSubfolders;
            SelectedFolderTextbox.Text = TextFileDirectory;
            PreserveParagraphsCheckbox.Checked = PreserveParagraphs;

        }






        private void SetFolderButton_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;
                dialog.Description = "Please choose the location of your .docx files to analyze";
                if (!string.IsNullOrWhiteSpace(SelectedFolderTextbox.Text)) dialog.SelectedPath = SelectedFolderTextbox.Text;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFolderTextbox.Text = dialog.SelectedPath.ToString();
                }
            }
        }


        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.ScanSubfolders = IncludeSubfoldersCheckbox.Checked;
            this.TextFileDirectory = SelectedFolderTextbox.Text;
            this.PreserveParags = PreserveParagraphsCheckbox.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
