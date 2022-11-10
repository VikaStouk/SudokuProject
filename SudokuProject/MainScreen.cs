using System.Configuration;
using System.IO;
using static System.Net.WebRequestMethods;

namespace SudokuProject
{
    public partial class MainScreen : Form
    {
        
        private string path = ConfigurationManager.AppSettings["filePath"];
        private string file = ConfigurationManager.AppSettings["fileName"];

        public MainScreen()
        {
            InitializeComponent();

           
        }

        private void GenPuz_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Step = 2;
            progressBar.Value = 0;

            Thread t = new Thread(ShowOnProgressBar);
            t.IsBackground= true;
            t.Name = "ShowOnProgressBar_THREAD";
            t.Start();
        }

        delegate void SetTextCallback(string text);

        private void setTotalGuessedText(string text)
        {
            string labelToFind = "cpuWordLabel";
            Control[] controls = Controls.Find(labelToFind, true);
            if (controls.Length == 1)
            {
                Label lab = controls[0] as Label;
                if (lab.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(setTotalGuessedText);
                    Invoke(d, new object[] { text });
                }
                else
                {
                    lab.Text = text;
                }
            }
        }

        delegate void PerformProgress();

        public void ShowOnProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                PerformProgress d = new PerformProgress(ShowOnProgressBar);
                Invoke(d, new object[] { });
            }
            else
            {
                progressBar.PerformStep();
            }
        }

        public void completeProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                PerformProgress d = new PerformProgress(completeProgressBar);
                Invoke(d, new object[] { });
            }
            else
            {
                progressBar.Value = 100;
            }
        }
        
        delegate void PerformProgressStatus(string text);

        public void ChangeProgressLabel(string text)
        {
            if (StatusL.InvokeRequired)
            {
                PerformProgressStatus d = new PerformProgressStatus(ChangeProgressLabel);
                Invoke(d, new object[] { text });
            }
            else
            {
                StatusL.Text = "Status: " + text;
            }
        }

        private void doWork(object state)
        {
            SudokuGrid sg = new SudokuGrid(path, file);
            ChangeProgressLabel("Working...");
            sg.setUpPlacementOrders();
            ShowOnProgressBar();
            for (int i = 0; i < 9; i++)
                sg.doInitialPlacementFill(i);

            ShowOnProgressBar();
            sg.populate(this);
        }

    }
}