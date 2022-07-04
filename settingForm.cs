#region noncode
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace CourseworkForAri
{
    public partial class settingForm : Form
    {
        private MainForm main_parent;
        public settingForm(MainForm parentForm)
        {
            InitializeComponent();
            main_parent = parentForm;
        }
        #endregion
#region variebles
        private string mode = string.Empty;
        private string theme = string.Empty;
        #endregion
#region events
        private void settingForm_Load(object sender, EventArgs e)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(MainForm.settingsFile);
                while (reader.Read())
                {
                    reader.MoveToAttribute("mode");
                    switch (reader.GetAttribute("mode"))
                    {
                        case "psyho":
                            mode = "psyho";
                            break;
                        case "user":
                            mode = "user";
                            break;
                    }
                }
                if (mode == "psyho")
                {
                    psyhoModeButton.Checked = true;
                }
                else if (mode == "user")
                {
                    userModeButton.Checked = true;
                }
                reader.MoveToAttribute("mode");
                switch (reader.GetAttribute("theme"))
                {
                    case "dark":
                        mode = "psyho";
                        break;
                    case "user":
                        mode = "user";
                        break;
                }
                if (theme == "dark")
                {
                    darkThemeButton.Checked = true;
                }
                else if (theme == "light")
                {
                    lightThemeButton.Checked = true;
                }
                reader.Close();
            }
            catch (IOException)
            {
                Thread.Sleep(500);
                MessageBox.Show("Settings file error! Do something, or ask developer what's wrong");
            }
        }
        private void psyhoModeButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load($"{MainForm.settingsFile}");
            //Change value of FormID
            doc.DocumentElement.SetAttribute("mode", "psyho"); // Set to new value.
            psyhoModeButton.Checked = true;
            doc.Save($"{MainForm.settingsFile}");
            main_parent.changeMode("psyho");

        }
        private void userModeButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load($"{MainForm.settingsFile}");
            //Change value of FormID
            doc.DocumentElement.SetAttribute("mode", "user"); // Set to new value.
            userModeButton.Checked = true;
            doc.Save($"{MainForm.settingsFile}");
            main_parent.changeMode("user");
        }
        private void darkThemeButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load($"{MainForm.settingsFile}");
            //Change value of FormID
            doc.DocumentElement.SetAttribute("theme", "dark"); // Set to new value.
            darkThemeButton.Checked = true;
            doc.Save($"{MainForm.settingsFile}");
            main_parent.changeTheme("dark");
        }
        private void lightThemeButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load($"{MainForm.settingsFile}");
            doc.DocumentElement.SetAttribute("theme", "light"); // Set to new value.
            lightThemeButton.Checked = true;
            doc.Save($"{MainForm.settingsFile}");
            main_parent.changeTheme("light");
        }
    }
}
#endregion
#region comments
/*
            textReader.ReadToFollowing("theme");
                if ((textReader.GetAttribute("mode")) == "psyho")
                {
                    MessageBox.Show("Success, psyho!");
                }
                else if (textReader.GetAttribute("mode") == "user")
                {
                    MessageBox.Show("Success, user!");
                }
                else MessageBox.Show("Something wrong!");
           
*/
/*            XmlTextReader reader = new XmlTextReader(MainForm.settingsFile);
            while (reader.Read())
            {
                reader.MoveToAttribute("mode");
                MessageBox.Show($"{reader.Value}");
                if (reader.Value == "psyho")
                {
                    break;
                }
                else if (reader.Value != "psyho")
                { 

                }
*/
#endregion