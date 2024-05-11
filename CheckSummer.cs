using LLM.MD5_CheckSummer.Data;
using LLM.MD5_CheckSummer.Handlers;

namespace LLM.MD5_CheckSummer
{
    public partial class CheckSummer : Form
    {
        private string filename = "sum";
        private string separator = ":";

        private Hasher hasher;
        private Presenter presenter;

        public CheckSummer()
        {
            InitializeComponent();

            var comparerData = new ComparerUIData(compareBox1, compareBox2, separatorCompare1,
                separatorCompare2, startCompareButton, browseFirstFile, browseSecondFile);
            var encoderData = new EncoderUIData(pathBox, filenameBox, separatorBox, startEncodeButton, browseButton);

            new ThemeController(this, themeBox); //registering theme controller and leaving it as it is (it will subscribe on theme change)
            new HashComparer(comparerData); //the same, since we are providing everything inside ComparerUIData, no need to store it here

            hasher = new Hasher(folderBrowser, encoderData);
            presenter = new Presenter(
                new UIItem[]
                {
                    comparerData,
                    encoderData,
                    new MenuUIData(labelOr, encodeModeButton, compareModeButton)
                });

            presenter.ShowUI(Presenter.UIPage.Menu); //showing menu on startup
        }

        private void button1_Click(object sender, EventArgs e) => hasher.BrowseDirectory();

        private void UpdatePath(object sender, FileSystemEventArgs e) => pathBox.Text = e.FullPath;

        //some check just in case we have any custom filenames or separators
        private void startButton_Click(object sender, EventArgs e)
        {
            if (filenameBox.Text.Length > 0) filename = filenameBox.Text;
            if (separatorBox.Text.Length > 0) separator = separatorBox.Text;

            loadingAnimation.Visible = true;
            hasher.Checksum(filename, separator);
            loadingAnimation.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e) => Application.Exit();

        private void compareModeButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Comparer);

        private void encodeModeButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Encoder);

        private void menuButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Menu);
    }
}