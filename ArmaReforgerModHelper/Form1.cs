using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace ArmaReforgerModHelper
{
    public partial class Form1 : Form
    {

        string location;
        int folderCount = 0;
        private string[] subdirs;
        private List<string> useablemods = new List<string>();

        int currentSelection;

        private dynamic jsonFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void changePathbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            location = folderBrowserDialog1.SelectedPath;
            int directoryCount = System.IO.Directory.GetDirectories(location).Length;
            

            subdirs = Directory.GetDirectories(location).Select(Path.GetFileName).ToArray();


            for (int i = 0; i < subdirs.Length; i++)
            {
                //useablemods.Add(subdirs[i]);

                if (File.Exists(location + "/" + subdirs[i] + "/ServerData.json"))
                {
                    //listBox1.Items.Add(useablemods[i]);
                    useablemods.Add(subdirs[i]);
                }

                
            }

            textBox1.Text = "Path: " + location + " | Contains " + useablemods.Count + " Usable Mods";

            folderCount = 0;
            ReadJsonFile();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (folderCount + 1 < useablemods.Count && useablemods.Count > 0)
            {
                folderCount++;

                int newCount = folderCount + 1;

                //folderCounter.Text = newCount + "/" + useablemods.Count;
                ReadJsonFile();
            }
            
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if(folderCount > 0 && useablemods.Count > 0)
            {
                folderCount--;

                int newCount = folderCount - 1;

                //folderCounter.Text = newCount + "/" + useablemods.Count;
                ReadJsonFile();
            }
            
        }

        private void ReadJsonFile()
        {
            jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(location + "/" + useablemods[folderCount] + "/ServerData.json"));

            //pictureBox1.ImageLocation = location + "/" + useablemods[folderCount] + "/thumbnail.png";

            if(File.Exists(location + "/" + useablemods[folderCount] + "/thumbnail.png"))
            {
                pictureBox1.ImageLocation = location + "/" + useablemods[folderCount] + "/thumbnail.png";
            }
            else
            {

                pictureBox1.Image = Properties.Resources.noimage;
            }


            assetidtxtbox.Text = $"{jsonFile["id"]}";
            assetnametextbox.Text = $"{jsonFile["name"]}";
            assetvertextbox.Text = $"{jsonFile["revision"]["version"]}";
        }

    }
}