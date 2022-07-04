#region noncode
using System;using System.Collections.Generic;using System.Data;using System.Drawing;using System.Drawing.Printing;using System.IO;using System.Linq;using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;using System.Xml;using MySql.Data.MySqlClient;
namespace CourseworkForAri
{
    public partial class MainForm : Form
    {
        // form initialization
        public MainForm()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current; //context from UI

        }
        #endregion
        #region global_variebles
        private string currentMode = String.Empty;
        private readonly string programMaterialsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AriVena materials\";
        private readonly string programNotesDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AriVena materials\Notes\";
        private readonly string programBooksDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AriVena materials\Books\";
        public static readonly string settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AriVena materials\settings.config";
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;
        public string currentRowIdValue = String.Empty;
        private string programMode = "psyho";
        private string programTheme = "dark";
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;user=root;database=arivenadb");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        public DataTable dataTable = new DataTable();
        #endregion
        #region functions and metods 
        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;
            //Here we only refresh our UI each 50 ms  
            if ((DateTime.Now - previousTime).Milliseconds <= 50) return;
            //Send the update to our UI thread  
            synchronizationContext.Post(new SendOrPostCallback(o => { statusLabelSelectedFile.Text = @"Count : " + (int)o; }), value);
            previousTime = timeNow;
        }
        IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }
        private string getSelectedListItemText()
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                return this.listView1.SelectedItems[0].Text;
            }
            else
            {
                return this.listView1.TopItem.Text;
            }
        }
        public void changeTheme(string themeName)
        {
            if (themeName == "light")
            {
                foreach (Control element in GetAllControls(this))
                {
                    element.BackColor = System.Drawing.Color.White;
                    element.ForeColor = System.Drawing.SystemColors.HotTrack;
                }
            }
            else if (themeName == "dark")
            {
                foreach (Control element in GetAllControls(this))
                {
                    element.BackColor = System.Drawing.SystemColors.WindowFrame;
                    element.ForeColor = System.Drawing.Color.Red;
                }
            }
            else MessageBox.Show("Theme change error! Repair Settigs File");
        }
        public void changeMode(string modeName)
        {
            if (modeName == "user")
            {
                tabControl.TabPages[0].Enabled = false;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.Size = this.Size;
                pictureBox1.BringToFront();
                tabControl.TabPages[1].Enabled = false;
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                pictureBox2.Dock = DockStyle.Fill;
                pictureBox2.Size = this.Size;
                pictureBox2.BringToFront();
                tabControl.TabPages[3].Enabled = false;
                pictureBox3.Enabled = true;
                pictureBox3.Visible = true;
                pictureBox3.Dock = DockStyle.Fill;
                pictureBox3.Size = this.Size;
                pictureBox3.BringToFront();
                tabControl.TabPages[0].Visible = false;
                tabControl.TabPages[1].Visible = false;
                tabControl.TabPages[3].Visible = false;
                currentMode = "user";

            }
            else if (modeName == "psyho")
            {
                tabControl.TabPages[0].Enabled = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                tabControl.TabPages[1].Enabled = true;
                pictureBox2.Enabled = false;
                pictureBox2.Visible = false;
                tabControl.TabPages[3].Enabled = true;
                pictureBox3.Enabled = false;
                pictureBox3.Visible = false;
                tabControl.TabPages[0].Visible = true;
                tabControl.TabPages[1].Visible = true;
                tabControl.TabPages[3].Visible = true;
                currentMode = "psyho";
            }
            else MessageBox.Show("Mode change error. Repair settings file");
        }
        #endregion
        #region form events
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.listView1.MultiSelect = false;
                this.timer1 = new System.Windows.Forms.Timer() { Interval = 1000 };
                this.listView1.Height = Height - 50;
                this.dataGridView1.Height = Height;
                this.dataGridView1.Width = Width;
                this.statusLabelTime.Text = "Current time: ";
                this.timer1.Tick += timer1_Tick;
                this.timer1.Start();
                #region program file checking
                if (Directory.Exists($"{this.programMaterialsDir}"))
                {
                    IEnumerable<string> files = Directory.EnumerateFiles($"{this.programMaterialsDir}", "*", SearchOption.AllDirectories).Select(Path.GetFileName);
                    List<object> filesList = files.Cast<object>().ToList();
                    foreach (string file in filesList)
                    {
                        if (file.EndsWith(".config"))
                        {
                            continue;
                        }
                        else
                        {
                            this.listView1.Items.Add(Path.GetFileName($"{file}"));
                        }
                    }
                }
                else if (!Directory.Exists(($"{this.programMaterialsDir}")))
                {
                    Directory.CreateDirectory($"{this.programMaterialsDir}");
                    Directory.CreateDirectory($"{this.programMaterialsDir + @"Books\"}");
                    Directory.CreateDirectory($"{this.programMaterialsDir + @"Notes\"}");
                    using (StreamWriter writer = File.CreateText(this.programBooksDir + "Home.html"))
                    {
                        writer.WriteLine("<p>&nbsp;</p><p> &nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Empty.<br/> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Try to chose something...</ p ><br/> ");
                    }
                    MessageBox.Show("Add books in html/txt format in " + $@"{this.programMaterialsDir}" + @"books\");
                }
                if (!Directory.Exists($"{this.programMaterialsDir + @"Notes\"}"))
                {
                    Directory.CreateDirectory($"{this.programMaterialsDir + @"Notes\"}");
                }
                if (!Directory.Exists($"{this.programMaterialsDir + @"Books\"}"))
                {
                    Directory.CreateDirectory($"{this.programMaterialsDir + @"Books\"}");
                }
                this.webBrowser1.Url = new Uri(string.Format("file:///{0}", this.programMaterialsDir + "Home.html"));
                if (!File.Exists($"{settingsFile}"))
                {
                    XmlWriter writer = null;
                    try
                    {
                        XmlWriterSettings settings = new XmlWriterSettings
                        {
                            Indent = true,
                            OmitXmlDeclaration = true,
                            NewLineOnAttributes = true
                        };
                        writer = XmlWriter.Create(settingsFile, settings);
                        writer.WriteComment("Settings XML file for AriVena program. DONT DELETE THIS PLS. AND DONT TOUCH ANYTHING");
                        writer.WriteStartElement("Settings");
                        writer.WriteAttributeString("mode", "psyho");
                        writer.WriteAttributeString("theme", "dark");
                        writer.WriteEndElement();
                        writer.Flush();
                        writer.Close();
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                }
                try
                {
                    XmlTextReader reader = new XmlTextReader(settingsFile);
                    while (reader.Read())
                    {
                        reader.MoveToAttribute("mode");
                        switch (reader.GetAttribute("mode"))
                        {
                            case "psyho":
                                programMode = "psyho";
                                break;
                            case "user":
                                programMode = "user";
                                break;
                        }
                    }
                    if (programMode == "psyho")
                    {
                        changeMode("psyho");
                    }
                    else if (programMode == "user")
                    {
                        changeMode("user");
                    }
                    reader.MoveToAttribute("theme");
                    switch (reader.GetAttribute("theme"))
                    {
                        case "dark":
                            programTheme = "dark";
                            break;
                        case "user":
                            programTheme = "light";
                            break;
                    }
                    if (programTheme == "dark")
                    {
                        changeTheme("dark");
                    }
                    else if (programTheme == "light")
                    {
                        changeTheme("light");
                    }
                    reader.Close();
                }
                catch (IOException)
                {
                    Thread.Sleep(500);
                    MessageBox.Show("Settings file error! Do something, or ask developer what's wrong");
                }
                var count = 0;
                await Task.Run(() =>
                {
                    for (var i = 0; i <= 1000000; i++)
                    {
                        UpdateUI(i);
                        count = i;
                    }
                });
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("FormLoad goes bad, please restart app" + System.Environment.NewLine + ex.ToString());
            }
            #endregion
            try
            {
                conn = new MySqlConnection("server=localhost;uid=root");
                conn.Open();
                this.cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS arivenadb", conn);
                this.cmd.ExecuteNonQuery();
                conn.Close();
                conn = new MySqlConnection("server=localhost;uid=root;database=arivenadb");
                conn.Open();
                this.cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS clients(id INT NOT NULL AUTO_INCREMENT, Прізвище TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `Імя` TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `По батькові` TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `Номер телефону` TEXT CHARACTER SET ascii COLLATE ascii_bin NULL DEFAULT NULL , `Адрес місця проживання` TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `Діагноз` TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `Скарги` TEXT CHARACTER SET utf16 COLLATE utf16_bin NULL DEFAULT NULL , `Час останоього відвідування` TEXT CHARACTER SET ascii COLLATE ascii_bin NULL DEFAULT NULL, PRIMARY KEY(id) ) ENGINE = InnoDB;", conn);
                this.cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Помилка! Звяжіться з розробником, або адміністратором" + System.Environment.NewLine + ex.ToString(), "AriVena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.listView1.Height = Height;
            this.webBrowser1.Height = Height;
            this.webBrowser1.Width = Width;
            this.dataGridView1.Width = Width;
            this.dataGridView1.Height = Height;
            this.groupBox1.Width = this.Width - 3;
            this.groupBox1.Height = (this.Height + 100) - this.Height;
            this.diaryTextBox.Size = new Size(Width, Height - 160);
            this.groupBox1.Location = new Point(3, Height - 208);
            this.label6.Location = new Point(Width - 496, 16);
            this.diagnosisDataTextBox.Location = new Point(Width - 496, 48);
            this.label7.Location = new Point(Width - 496, 96);
            this.emotionsDataTextBox.Location = new Point(Width - 496, 136);
            this.saveDataButton.Location = new Point(Width - 496, 440);
            this.editDataButton.Location = new Point(8, 32);
            this.deleteDataButton.Location = new Point(Width - 208, 32);
            this.diaryTextOpenButton.Location = new Point(16, 8);
            this.diaryTextSaveButton.Location = new Point(210, 8);
        }
        private void tabPage1_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                #region first tab selected
                case 0:
                    if (currentMode != "user")
                    {
                        this.listView1.Clear();//
                        if (Directory.Exists($"{this.programMaterialsDir}"))
                        {
                            IEnumerable<string> files = Directory.EnumerateFiles($"{this.programMaterialsDir}", "*", SearchOption.AllDirectories).Select(Path.GetFileName);
                            List<object> filesList = files.Cast<object>().ToList();
                            foreach (string file in filesList)
                            {
                                if (file.EndsWith(".config"))
                                {
                                    continue;
                                }
                                else
                                {
                                    this.listView1.Items.Add(Path.GetFileName($"{file}"));
                                }
                            }
                        }
                        else if (!Directory.Exists(($"{this.programMaterialsDir}")))
                        {
                            Directory.CreateDirectory($"{this.programMaterialsDir + @"Books\"}");
                        }
                    }
                    break;
                #endregion
                #region second tab selected
                case 1:
                    if (currentMode != "user")
                    {
                        conn = new MySqlConnection("server=localhost;uid=root;database=arivenadb");
                        conn.Open();
                        this.dataAdapter = new MySqlDataAdapter("SELECT * FROM clients", conn);
                        this.dataTable = new DataTable();
                        this.dataAdapter.Fill(this.dataTable);
                        this.dataGridView1.DataSource = this.dataTable;
                        conn.Close();
                    }
                    break;
                #endregion
                #region data page selected
                case 2:
                    //searchDataList.Items 
                    break;
                #endregion
                #region text page selected;
                case 3:
                    //PAPA здесь пиши код для событий
                    break;
                    #endregion
            }
        }
        #endregion
        #region statusbar
        private void timer1_Tick(object sender, EventArgs e) => this.statusLabelTime.Text = (DateTime.Now.ToLongTimeString());
        private void statusLabelGearSetings_Click(object sender, EventArgs e)
        {
            settingForm settingsForm = new settingForm(this);
            settingsForm.ShowDialog();
        }
        #endregion
        #region bookshalf
        private void urlTextBox_Click(object sender, EventArgs e)
        {
            if (materialsURLTextBox.Text == "URL:")
            { this.materialsURLTextBox.Text = string.Empty; }
        }
        private void materialsNavigateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                if (materialsURLTextBox.TextLength != 0) { this.webBrowser1.Navigate(materialsURLTextBox.Text); }
            }
            else if(listView1.SelectedItems.Count >= 1)
            {
                this.webBrowser1.Navigate(new Uri(string.Format("file:///{0}", this.programBooksDir + getSelectedListItemText())));
            }
            this.statusLabelFileName.Text = getSelectedListItemText();
        }
        #endregion
        #region data tab
        private void addressFirstPartDataTextBox_Click(object sender, EventArgs e) => this.addressFirstPartDataTextBox.Text = string.Empty;
        private void addressSecondPartDataTextBox_Click(object sender, EventArgs e) => this.addressSecondPartDataTextBox.Text = string.Empty;
        private void addressFirstPartDataTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.addressFirstPartDataTextBox.Text == "" || this.addressFirstPartDataTextBox.Text == string.Empty)
            {
                this.addressFirstPartDataTextBox.Text = "Країна: LLLLLLLLLLLLLLL Місто: LLLLLLLLLLLLLLL";
            }
        }
        private void addressSecondPartDataTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.addressSecondPartDataTextBox.Text == "" || this.addressSecondPartDataTextBox.Text == string.Empty)
            {
                this.addressSecondPartDataTextBox.Text = "Вулиця: LLLLLLLLLLLLLLLLLLLLLLLLLLLL Дім: CCCC";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) => this.currentRowIdValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection("server=localhost;user=root;database=arivenadb");
                conn.Open();
                this.cmd = new MySqlCommand("INSERT INTO clients(Прізвище, Імя, `По батькові`, `Номер телефону`, `Адрес місця проживання`, Діагноз, Скарги, `Час останоього відвідування`)" +
                  " VALUES('" + $"{this.secondNameDataTextBox.Text.Trim(' ')}" + "','"
                  + $"{this.firstNameDataTextBox.Text.Trim(' ')}" + "','" + $"{this.patronimNameDataTextBox.Text.Trim(' ')}" + "','"
                  + $"{this.telephoneDataTextBox.Text.Trim(' ')}" + "','"
                  + ($"{this.addressFirstPartDataTextBox.Text.Trim(' ')}" + $"{this.addressSecondPartDataTextBox.Text.Trim(' ')}") + "','"
                  + $"{this.diagnosisDataTextBox.Text}" + "','" + $"{this.emotionsDataTextBox.Text}" + "','" + $"{this.statusLabelTime.Text}" + "')", conn);
                this.cmd.ExecuteNonQuery();
                MessageBox.Show("Дані відправлені!");
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Помилка! Звяжіться з розробником, або адміністратором" + System.Environment.NewLine + ex.ToString(), "AriVena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Delete row?", "Nope", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn = new MySqlConnection("server=localhost;user=root;database=arivenadb");
                    conn.Open();
                    this.cmd = new MySqlCommand("DELETE FROM `clients` WHERE `clients`.`" + this.dataGridView1.Columns[0].HeaderText + "` = "
                     + (Convert.ToInt32(this.currentRowIdValue)), conn);
                    this.cmd.ExecuteNonQuery();
                    MessageBox.Show("Дані видалені!");
                    conn.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Помилка! Звяжіться з розробником, або адміністратором" + System.Environment.NewLine + ex.ToString(), "AriVena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void editDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Дані відредактовані!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Помилка! Звяжіться з розробником, або адміністратором" + System.Environment.NewLine + ex.ToString(), "AriVena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region notes
        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e) => e.Graphics.DrawString(this.diaryTextBox.Text, this.diaryTextBox.Font, Brushes.Black, 10, 25);
        private void diaryTextSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = $"{this.programNotesDir}",
                Filter = "Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2
            };
            if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.diaryTextBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                this.statusLabelFileName.Text = "Last saved file: " + SaveFileDialog1.FileName;
            }
        }
        private void diaryTextOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = $"{this.programMaterialsDir + @"Notes/"}",
                Filter = "Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2
            };
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.diaryTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText);
                this.statusLabelFileName.Text = "Current opened file " + OpenFileDialog1.FileName;
            }
        }
        private void printNotesButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }
        #endregion
    }
}
#region comments
/*            MySqlConnection conn = new MySqlConnection("Server=localhost;user=root");
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM 'clients'", conn);
            DataTable dataTable = new DataTable();
*/
/*            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }*/
#endregion