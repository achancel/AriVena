
namespace CourseworkForAri
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelGearSetings = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBorder1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBorder2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBorder3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSelectedFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notesPage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.printNotesButton = new System.Windows.Forms.Button();
            this.diaryTextOpenButton = new System.Windows.Forms.Button();
            this.bufferBox = new System.Windows.Forms.RichTextBox();
            this.diaryTextSaveButton = new System.Windows.Forms.Button();
            this.diaryTextBox = new System.Windows.Forms.RichTextBox();
            this.cartoteryPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialsPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialsNavigateButton = new System.Windows.Forms.Button();
            this.materialsURLTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.emotionsDataTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressSecondPartDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressFirstPartDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.patronimNameDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.firstNameDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.secondNameDataTextBox = new System.Windows.Forms.MaskedTextBox();
            this.diagnosisDataTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.notesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cartoteryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelGearSetings,
            this.statusBorder1,
            this.statusLabelTime,
            this.statusBorder2,
            this.statusLabelFileName,
            this.statusBorder3,
            this.statusLabelSelectedFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1264, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelGearSetings
            // 
            this.statusLabelGearSetings.Image = global::CourseworkForAri.Properties.Resources.gaer;
            this.statusLabelGearSetings.Name = "statusLabelGearSetings";
            this.statusLabelGearSetings.Size = new System.Drawing.Size(20, 20);
            this.statusLabelGearSetings.Click += new System.EventHandler(this.statusLabelGearSetings_Click);
            // 
            // statusBorder1
            // 
            this.statusBorder1.Name = "statusBorder1";
            this.statusBorder1.Size = new System.Drawing.Size(13, 20);
            this.statusBorder1.Text = "|";
            // 
            // statusLabelTime
            // 
            this.statusLabelTime.Name = "statusLabelTime";
            this.statusLabelTime.Size = new System.Drawing.Size(37, 20);
            this.statusLabelTime.Text = "Час:";
            // 
            // statusBorder2
            // 
            this.statusBorder2.Name = "statusBorder2";
            this.statusBorder2.Size = new System.Drawing.Size(13, 20);
            this.statusBorder2.Text = "|";
            // 
            // statusLabelFileName
            // 
            this.statusLabelFileName.Name = "statusLabelFileName";
            this.statusLabelFileName.Size = new System.Drawing.Size(0, 20);
            // 
            // statusBorder3
            // 
            this.statusBorder3.Name = "statusBorder3";
            this.statusBorder3.Size = new System.Drawing.Size(13, 20);
            this.statusBorder3.Text = "|";
            this.statusBorder3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // statusLabelSelectedFile
            // 
            this.statusLabelSelectedFile.Name = "statusLabelSelectedFile";
            this.statusLabelSelectedFile.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notesPage
            // 
            this.notesPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.notesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notesPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesPage.Controls.Add(this.pictureBox3);
            this.notesPage.Controls.Add(this.printNotesButton);
            this.notesPage.Controls.Add(this.diaryTextOpenButton);
            this.notesPage.Controls.Add(this.bufferBox);
            this.notesPage.Controls.Add(this.diaryTextSaveButton);
            this.notesPage.Controls.Add(this.diaryTextBox);
            this.notesPage.Font = new System.Drawing.Font("Verdana", 15F);
            this.notesPage.Location = new System.Drawing.Point(4, 47);
            this.notesPage.Name = "notesPage";
            this.notesPage.Padding = new System.Windows.Forms.Padding(3);
            this.notesPage.Size = new System.Drawing.Size(1256, 604);
            this.notesPage.TabIndex = 3;
            this.notesPage.Text = "Нотатник";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::CourseworkForAri.Properties.Resources.SingleRoseNullBackground_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(775, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // printNotesButton
            // 
            this.printNotesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printNotesButton.AutoSize = true;
            this.printNotesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printNotesButton.Location = new System.Drawing.Point(1041, 8);
            this.printNotesButton.Name = "printNotesButton";
            this.printNotesButton.Size = new System.Drawing.Size(204, 43);
            this.printNotesButton.TabIndex = 4;
            this.printNotesButton.Text = "Роздрукувати";
            this.printNotesButton.UseVisualStyleBackColor = true;
            this.printNotesButton.Click += new System.EventHandler(this.printNotesButton_Click);
            // 
            // diaryTextOpenButton
            // 
            this.diaryTextOpenButton.AutoSize = true;
            this.diaryTextOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diaryTextOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diaryTextOpenButton.Location = new System.Drawing.Point(8, 8);
            this.diaryTextOpenButton.Name = "diaryTextOpenButton";
            this.diaryTextOpenButton.Size = new System.Drawing.Size(217, 43);
            this.diaryTextOpenButton.TabIndex = 2;
            this.diaryTextOpenButton.Text = "Відкрити файл";
            this.diaryTextOpenButton.UseVisualStyleBackColor = true;
            this.diaryTextOpenButton.Click += new System.EventHandler(this.diaryTextOpenButton_Click);
            // 
            // bufferBox
            // 
            this.bufferBox.DetectUrls = false;
            this.bufferBox.Location = new System.Drawing.Point(1032, 8);
            this.bufferBox.Name = "bufferBox";
            this.bufferBox.ShortcutsEnabled = false;
            this.bufferBox.Size = new System.Drawing.Size(35, 32);
            this.bufferBox.TabIndex = 3;
            this.bufferBox.TabStop = false;
            this.bufferBox.Text = "";
            this.bufferBox.Visible = false;
            this.bufferBox.WordWrap = false;
            // 
            // diaryTextSaveButton
            // 
            this.diaryTextSaveButton.AutoSize = true;
            this.diaryTextSaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diaryTextSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diaryTextSaveButton.Location = new System.Drawing.Point(200, 8);
            this.diaryTextSaveButton.Name = "diaryTextSaveButton";
            this.diaryTextSaveButton.Size = new System.Drawing.Size(243, 43);
            this.diaryTextSaveButton.TabIndex = 0;
            this.diaryTextSaveButton.Text = "Зберегти у файл";
            this.diaryTextSaveButton.UseVisualStyleBackColor = true;
            this.diaryTextSaveButton.Click += new System.EventHandler(this.diaryTextSaveButton_Click);
            // 
            // diaryTextBox
            // 
            this.diaryTextBox.AcceptsTab = true;
            this.diaryTextBox.AutoWordSelection = true;
            this.diaryTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.diaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diaryTextBox.BulletIndent = 4;
            this.diaryTextBox.DetectUrls = false;
            this.diaryTextBox.HideSelection = false;
            this.diaryTextBox.Location = new System.Drawing.Point(3, 56);
            this.diaryTextBox.Name = "diaryTextBox";
            this.diaryTextBox.Size = new System.Drawing.Size(1248, 557);
            this.diaryTextBox.TabIndex = 1;
            this.diaryTextBox.Text = "";
            // 
            // cartoteryPage
            // 
            this.cartoteryPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cartoteryPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cartoteryPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartoteryPage.Controls.Add(this.pictureBox2);
            this.cartoteryPage.Controls.Add(this.groupBox1);
            this.cartoteryPage.Controls.Add(this.dataGridView1);
            this.cartoteryPage.Font = new System.Drawing.Font("Verdana", 15F);
            this.cartoteryPage.Location = new System.Drawing.Point(4, 47);
            this.cartoteryPage.Name = "cartoteryPage";
            this.cartoteryPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartoteryPage.Size = new System.Drawing.Size(1256, 604);
            this.cartoteryPage.TabIndex = 1;
            this.cartoteryPage.Text = "Картотека";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CourseworkForAri.Properties.Resources.SingleRoseNullBackground_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(977, 424);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteDataButton);
            this.groupBox1.Controls.Add(this.editDataButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контроль";
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDataButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDataButton.ForeColor = System.Drawing.Color.Red;
            this.deleteDataButton.Location = new System.Drawing.Point(1080, 32);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(160, 64);
            this.deleteDataButton.TabIndex = 16;
            this.deleteDataButton.Text = "Видалити обране";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDataButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDataButton.ForeColor = System.Drawing.Color.Red;
            this.editDataButton.Location = new System.Drawing.Point(8, 32);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(160, 64);
            this.editDataButton.TabIndex = 15;
            this.editDataButton.Text = "Редагувати";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = "Пусто";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "####";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.NullValue = "Пусто";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 48;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // materialsPage
            // 
            this.materialsPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.materialsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialsPage.Controls.Add(this.pictureBox1);
            this.materialsPage.Controls.Add(this.materialsNavigateButton);
            this.materialsPage.Controls.Add(this.materialsURLTextBox);
            this.materialsPage.Controls.Add(this.listView1);
            this.materialsPage.Controls.Add(this.webBrowser1);
            this.materialsPage.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsPage.Location = new System.Drawing.Point(4, 47);
            this.materialsPage.Name = "materialsPage";
            this.materialsPage.Padding = new System.Windows.Forms.Padding(3);
            this.materialsPage.Size = new System.Drawing.Size(1256, 604);
            this.materialsPage.TabIndex = 0;
            this.materialsPage.Text = "Довідник";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CourseworkForAri.Properties.Resources.SingleRoseNullBackground_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(228, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // materialsNavigateButton
            // 
            this.materialsNavigateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialsNavigateButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.materialsNavigateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialsNavigateButton.ForeColor = System.Drawing.Color.Red;
            this.materialsNavigateButton.Location = new System.Drawing.Point(8, 8);
            this.materialsNavigateButton.Name = "materialsNavigateButton";
            this.materialsNavigateButton.Size = new System.Drawing.Size(72, 32);
            this.materialsNavigateButton.TabIndex = 0;
            this.materialsNavigateButton.Text = "GO";
            this.materialsNavigateButton.UseVisualStyleBackColor = false;
            this.materialsNavigateButton.Click += new System.EventHandler(this.materialsNavigateButton_Click);
            // 
            // materialsURLTextBox
            // 
            this.materialsURLTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.materialsURLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialsURLTextBox.ForeColor = System.Drawing.Color.Red;
            this.materialsURLTextBox.Location = new System.Drawing.Point(88, 8);
            this.materialsURLTextBox.Name = "materialsURLTextBox";
            this.materialsURLTextBox.Size = new System.Drawing.Size(808, 38);
            this.materialsURLTextBox.TabIndex = 11;
            this.materialsURLTextBox.Text = "URL:";
            this.materialsURLTextBox.WordWrap = false;
            this.materialsURLTextBox.Click += new System.EventHandler(this.urlTextBox_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 48);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 579);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(280, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(983, 579);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.materialsPage);
            this.tabControl.Controls.Add(this.cartoteryPage);
            this.tabControl.Controls.Add(this.dataPage);
            this.tabControl.Controls.Add(this.notesPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 655);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPage1_Selected);
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataPage.BackgroundImage = global::CourseworkForAri.Properties.Resources.SingleRoseNullBackground_removebg_preview;
            this.dataPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPage.Controls.Add(this.emotionsDataTextBox);
            this.dataPage.Controls.Add(this.label7);
            this.dataPage.Controls.Add(this.addressSecondPartDataTextBox);
            this.dataPage.Controls.Add(this.addressFirstPartDataTextBox);
            this.dataPage.Controls.Add(this.telephoneDataTextBox);
            this.dataPage.Controls.Add(this.patronimNameDataTextBox);
            this.dataPage.Controls.Add(this.firstNameDataTextBox);
            this.dataPage.Controls.Add(this.secondNameDataTextBox);
            this.dataPage.Controls.Add(this.diagnosisDataTextBox);
            this.dataPage.Controls.Add(this.label6);
            this.dataPage.Controls.Add(this.saveDataButton);
            this.dataPage.Controls.Add(this.label5);
            this.dataPage.Controls.Add(this.label4);
            this.dataPage.Controls.Add(this.label3);
            this.dataPage.Controls.Add(this.label2);
            this.dataPage.Controls.Add(this.label1);
            this.dataPage.Font = new System.Drawing.Font("Verdana", 15F);
            this.dataPage.Location = new System.Drawing.Point(4, 47);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(1256, 604);
            this.dataPage.TabIndex = 4;
            this.dataPage.Text = "Дані";
            // 
            // emotionsDataTextBox
            // 
            this.emotionsDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emotionsDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.emotionsDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emotionsDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.emotionsDataTextBox.Location = new System.Drawing.Point(784, 136);
            this.emotionsDataTextBox.Name = "emotionsDataTextBox";
            this.emotionsDataTextBox.Size = new System.Drawing.Size(456, 288);
            this.emotionsDataTextBox.TabIndex = 12;
            this.emotionsDataTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(784, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Скарги";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressSecondPartDataTextBox
            // 
            this.addressSecondPartDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addressSecondPartDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressSecondPartDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.addressSecondPartDataTextBox.Location = new System.Drawing.Point(16, 406);
            this.addressSecondPartDataTextBox.Mask = "Вулиця: LLLLLLLLLLLLLLLLLLLLLLLLLLLL ,Дім: CCCC";
            this.addressSecondPartDataTextBox.Name = "addressSecondPartDataTextBox";
            this.addressSecondPartDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.addressSecondPartDataTextBox.TabIndex = 10;
            this.addressSecondPartDataTextBox.Click += new System.EventHandler(this.addressSecondPartDataTextBox_Click);
            this.addressSecondPartDataTextBox.TextChanged += new System.EventHandler(this.addressSecondPartDataTextBox_TextChanged);
            // 
            // addressFirstPartDataTextBox
            // 
            this.addressFirstPartDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addressFirstPartDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressFirstPartDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.addressFirstPartDataTextBox.Location = new System.Drawing.Point(16, 366);
            this.addressFirstPartDataTextBox.Mask = "Країна: LLLLLLLLLLLLLL ,Місто: LLLLLLLLLLLLLLL ,";
            this.addressFirstPartDataTextBox.Name = "addressFirstPartDataTextBox";
            this.addressFirstPartDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.addressFirstPartDataTextBox.TabIndex = 9;
            this.addressFirstPartDataTextBox.Click += new System.EventHandler(this.addressFirstPartDataTextBox_Click);
            this.addressFirstPartDataTextBox.TextChanged += new System.EventHandler(this.addressFirstPartDataTextBox_TextChanged);
            // 
            // telephoneDataTextBox
            // 
            this.telephoneDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.telephoneDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.telephoneDataTextBox.Location = new System.Drawing.Point(16, 281);
            this.telephoneDataTextBox.Mask = "+(999)-(00)-000-0000";
            this.telephoneDataTextBox.Name = "telephoneDataTextBox";
            this.telephoneDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.telephoneDataTextBox.TabIndex = 8;
            // 
            // patronimNameDataTextBox
            // 
            this.patronimNameDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.patronimNameDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronimNameDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.patronimNameDataTextBox.Location = new System.Drawing.Point(16, 201);
            this.patronimNameDataTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.patronimNameDataTextBox.Name = "patronimNameDataTextBox";
            this.patronimNameDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.patronimNameDataTextBox.TabIndex = 7;
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.firstNameDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.firstNameDataTextBox.Location = new System.Drawing.Point(16, 129);
            this.firstNameDataTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.firstNameDataTextBox.TabIndex = 6;
            // 
            // secondNameDataTextBox
            // 
            this.secondNameDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.secondNameDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.secondNameDataTextBox.Location = new System.Drawing.Point(16, 53);
            this.secondNameDataTextBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.secondNameDataTextBox.Name = "secondNameDataTextBox";
            this.secondNameDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.secondNameDataTextBox.TabIndex = 5;
            // 
            // diagnosisDataTextBox
            // 
            this.diagnosisDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosisDataTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.diagnosisDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisDataTextBox.ForeColor = System.Drawing.Color.Red;
            this.diagnosisDataTextBox.Location = new System.Drawing.Point(784, 53);
            this.diagnosisDataTextBox.Name = "diagnosisDataTextBox";
            this.diagnosisDataTextBox.Size = new System.Drawing.Size(456, 36);
            this.diagnosisDataTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(784, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Діагноз";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDataButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDataButton.ForeColor = System.Drawing.Color.Red;
            this.saveDataButton.Location = new System.Drawing.Point(1080, 536);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(160, 64);
            this.saveDataButton.TabIndex = 14;
            this.saveDataButton.Text = "Зберегти в базу";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес місця проживання";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефону";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "По-Батькові";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Імя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1256, 720);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AriVena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.notesPage.ResumeLayout(false);
            this.notesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cartoteryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialsPage.ResumeLayout(false);
            this.materialsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel statusBorder1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFileName;
        private System.Windows.Forms.ToolStripStatusLabel statusBorder2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage notesPage;
        private System.Windows.Forms.TabPage cartoteryPage;
        private System.Windows.Forms.TabPage materialsPage;
        private System.Windows.Forms.TextBox materialsURLTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button materialsNavigateButton;
        private System.Windows.Forms.Button diaryTextOpenButton;
        private System.Windows.Forms.Button diaryTextSaveButton;
        private System.Windows.Forms.RichTextBox diaryTextBox;
        private System.Windows.Forms.RichTextBox bufferBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelGearSetings;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSelectedFile;
        private System.Windows.Forms.ToolStripStatusLabel statusBorder3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox addressSecondPartDataTextBox;
        private System.Windows.Forms.MaskedTextBox addressFirstPartDataTextBox;
        private System.Windows.Forms.MaskedTextBox telephoneDataTextBox;
        private System.Windows.Forms.MaskedTextBox patronimNameDataTextBox;
        private System.Windows.Forms.MaskedTextBox firstNameDataTextBox;
        private System.Windows.Forms.MaskedTextBox secondNameDataTextBox;
        private System.Windows.Forms.TextBox diagnosisDataTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox emotionsDataTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button printNotesButton;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

