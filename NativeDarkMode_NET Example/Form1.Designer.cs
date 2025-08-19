using NativeDarkMode_Lib_NET;

namespace NativeDarkMode_NET
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            darkTabControl1 = new DarkTabControl();
            tabPageOther = new DarkTabPage();
            label14 = new Label();
            richTextBox1 = new RichTextBox();
            label13 = new Label();
            webBrowser1 = new WebBrowser();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            monthCalendar1 = new MonthCalendar();
            label11 = new Label();
            dateTimePicker1 = new DarkDateTimePicker();
            label10 = new Label();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            tabPageBasic = new DarkTabPage();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tabPageData = new DarkTabPage();
            label8 = new Label();
            treeView1 = new TreeView();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            tabPageDialogs = new DarkTabPage();
            pnlColorDialogResult = new Panel();
            lblFontDialogResult = new Label();
            btnColorDialog = new Button();
            btnFontDialog = new Button();
            btnSaveFileDialog = new Button();
            btnOpenFileDialog = new Button();
            btnShowMessageBox = new Button();
            tabPageLists = new DarkTabPage();
            label6 = new Label();
            listView1 = new ListView();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkTabControl1).BeginInit();
            darkTabControl1.SuspendLayout();
            tabPageOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageBasic.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageDialogs.SuspendLayout();
            tabPageLists.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(915, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 623);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(915, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 19);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(117, 18);
            toolStripProgressBar1.Value = 75;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, helpToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(915, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(35, 22);
            newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(40, 22);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(35, 22);
            saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(36, 22);
            helpToolStripButton.Text = "He&lp";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(102, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(102, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // darkTabControl1
            // 
            darkTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            darkTabControl1.BackColor = Color.FromArgb(33, 33, 33);
            darkTabControl1.Controls.Add(tabPageBasic);
            darkTabControl1.Controls.Add(tabPageOther);
            darkTabControl1.Controls.Add(tabPageData);
            darkTabControl1.Controls.Add(tabPageDialogs);
            darkTabControl1.Controls.Add(tabPageLists);
            darkTabControl1.Location = new Point(14, 60);
            darkTabControl1.Margin = new Padding(5, 3, 5, 3);
            darkTabControl1.Name = "darkTabControl1";
            darkTabControl1.Size = new Size(887, 558);
            darkTabControl1.TabIndex = 4;
            darkTabControl1.TabPages.Add(tabPageOther);
            darkTabControl1.TabPages.Add(tabPageBasic);
            darkTabControl1.TabPages.Add(tabPageData);
            darkTabControl1.TabPages.Add(tabPageDialogs);
            darkTabControl1.TabPages.Add(tabPageLists);
            // 
            // tabPageOther
            // 
            tabPageOther.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageOther.Controls.Add(label14);
            tabPageOther.Controls.Add(richTextBox1);
            tabPageOther.Controls.Add(label13);
            tabPageOther.Controls.Add(webBrowser1);
            tabPageOther.Controls.Add(label12);
            tabPageOther.Controls.Add(numericUpDown1);
            tabPageOther.Controls.Add(monthCalendar1);
            tabPageOther.Controls.Add(label11);
            tabPageOther.Controls.Add(dateTimePicker1);
            tabPageOther.Controls.Add(label10);
            tabPageOther.Controls.Add(trackBar1);
            tabPageOther.Controls.Add(progressBar1);
            tabPageOther.Controls.Add(label9);
            tabPageOther.Controls.Add(pictureBox1);
            tabPageOther.Location = new Point(0, 35);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Size = new Size(887, 523);
            tabPageOther.TabIndex = 4;
            tabPageOther.Text = "Other Controls";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(493, 23);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 41;
            label14.Text = "RichTextBox:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(497, 45);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 185);
            richTextBox1.TabIndex = 40;
            richTextBox1.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 392);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 39;
            label13.Text = "WebBrowser:";
            // 
            // webBrowser1
            // 
            webBrowser1.Location = new Point(24, 411);
            webBrowser1.Margin = new Padding(4, 3, 4, 3);
            webBrowser1.MinimumSize = new Size(23, 23);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(853, 99);
            webBrowser1.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(22, 252);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 15);
            label12.TabIndex = 37;
            label12.Text = "NumericUpDown:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(26, 273);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(140, 23);
            numericUpDown1.TabIndex = 36;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(210, 44);
            monthCalendar1.Margin = new Padding(10);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(637, 350);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 34;
            label11.Text = "DateTimePicker:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(644, 368);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(640, 234);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(122, 15);
            label10.TabIndex = 32;
            label10.Text = "ProgressBar/TrackBar:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(640, 286);
            trackBar1.Margin = new Padding(4, 3, 4, 3);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(237, 45);
            trackBar1.TabIndex = 31;
            trackBar1.TickFrequency = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(640, 253);
            progressBar1.Margin = new Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(237, 27);
            progressBar1.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 23);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 29;
            label9.Text = "PictureBox:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(24, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // tabPageBasic
            // 
            tabPageBasic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageBasic.Controls.Add(panel1);
            tabPageBasic.Controls.Add(groupBox1);
            tabPageBasic.Controls.Add(maskedTextBox1);
            tabPageBasic.Controls.Add(label2);
            tabPageBasic.Controls.Add(textBox1);
            tabPageBasic.Controls.Add(label1);
            tabPageBasic.Controls.Add(button1);
            tabPageBasic.Location = new Point(0, 35);
            tabPageBasic.Name = "tabPageBasic";
            tabPageBasic.Size = new Size(887, 523);
            tabPageBasic.TabIndex = 0;
            tabPageBasic.Text = "Basic Controls";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(26, 273);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 115);
            panel1.TabIndex = 20;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 70);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(103, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Radio Button 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(16, 44);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Radio Button 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 17);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Radio Button 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(26, 133);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(233, 115);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "GroupBox with CheckBoxes";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 78);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(87, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "CheckBox 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 51);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "CheckBox 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 23);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "CheckBox 1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(130, 88);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(129, 23);
            maskedTextBox1.TabIndex = 18;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 17;
            label2.Text = "Masked Text Box:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 54);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 15;
            label1.Text = "Text Box:";
            // 
            // button1
            // 
            button1.Location = new Point(22, 17);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(147, 27);
            button1.TabIndex = 14;
            button1.Text = "Standard Button";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPageData
            // 
            tabPageData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageData.Controls.Add(label8);
            tabPageData.Controls.Add(treeView1);
            tabPageData.Controls.Add(label7);
            tabPageData.Controls.Add(dataGridView1);
            tabPageData.Location = new Point(0, 35);
            tabPageData.Name = "tabPageData";
            tabPageData.Size = new Size(887, 523);
            tabPageData.TabIndex = 2;
            tabPageData.Text = "Data Controls";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(538, 18);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 11;
            label8.Text = "TreeView:";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(541, 40);
            treeView1.Margin = new Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(342, 469);
            treeView1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 9;
            label7.Text = "DataGridView:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 40);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(499, 470);
            dataGridView1.TabIndex = 8;
            // 
            // tabPageDialogs
            // 
            tabPageDialogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageDialogs.Controls.Add(pnlColorDialogResult);
            tabPageDialogs.Controls.Add(lblFontDialogResult);
            tabPageDialogs.Controls.Add(btnColorDialog);
            tabPageDialogs.Controls.Add(btnFontDialog);
            tabPageDialogs.Controls.Add(btnSaveFileDialog);
            tabPageDialogs.Controls.Add(btnOpenFileDialog);
            tabPageDialogs.Controls.Add(btnShowMessageBox);
            tabPageDialogs.Location = new Point(0, 35);
            tabPageDialogs.Name = "tabPageDialogs";
            tabPageDialogs.Size = new Size(887, 523);
            tabPageDialogs.TabIndex = 3;
            tabPageDialogs.Text = "Dialogs & Menus";
            // 
            // pnlColorDialogResult
            // 
            pnlColorDialogResult.BorderStyle = BorderStyle.FixedSingle;
            pnlColorDialogResult.Location = new Point(205, 198);
            pnlColorDialogResult.Margin = new Padding(4, 3, 4, 3);
            pnlColorDialogResult.Name = "pnlColorDialogResult";
            pnlColorDialogResult.Size = new Size(188, 26);
            pnlColorDialogResult.TabIndex = 20;
            // 
            // lblFontDialogResult
            // 
            lblFontDialogResult.AutoSize = true;
            lblFontDialogResult.Location = new Point(202, 155);
            lblFontDialogResult.Margin = new Padding(4, 0, 4, 0);
            lblFontDialogResult.Name = "lblFontDialogResult";
            lblFontDialogResult.Size = new Size(170, 15);
            lblFontDialogResult.TabIndex = 19;
            lblFontDialogResult.Text = "Sample text for the Font Dialog";
            // 
            // btnColorDialog
            // 
            btnColorDialog.Location = new Point(24, 198);
            btnColorDialog.Margin = new Padding(4, 3, 4, 3);
            btnColorDialog.Name = "btnColorDialog";
            btnColorDialog.Size = new Size(152, 27);
            btnColorDialog.TabIndex = 18;
            btnColorDialog.Text = "Show Color Dialog";
            btnColorDialog.UseVisualStyleBackColor = true;
            btnColorDialog.Click += btnColorDialog_Click;
            // 
            // btnFontDialog
            // 
            btnFontDialog.Location = new Point(24, 155);
            btnFontDialog.Margin = new Padding(4, 3, 4, 3);
            btnFontDialog.Name = "btnFontDialog";
            btnFontDialog.Size = new Size(152, 27);
            btnFontDialog.TabIndex = 17;
            btnFontDialog.Text = "Show Font Dialog";
            btnFontDialog.UseVisualStyleBackColor = true;
            btnFontDialog.Click += btnFontDialog_Click;
            // 
            // btnSaveFileDialog
            // 
            btnSaveFileDialog.Location = new Point(24, 111);
            btnSaveFileDialog.Margin = new Padding(4, 3, 4, 3);
            btnSaveFileDialog.Name = "btnSaveFileDialog";
            btnSaveFileDialog.Size = new Size(152, 27);
            btnSaveFileDialog.TabIndex = 16;
            btnSaveFileDialog.Text = "Show Save File Dialog";
            btnSaveFileDialog.UseVisualStyleBackColor = true;
            btnSaveFileDialog.Click += btnSaveFileDialog_Click;
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(24, 67);
            btnOpenFileDialog.Margin = new Padding(4, 3, 4, 3);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(152, 27);
            btnOpenFileDialog.TabIndex = 15;
            btnOpenFileDialog.Text = "Show Open File Dialog";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // btnShowMessageBox
            // 
            btnShowMessageBox.Location = new Point(24, 23);
            btnShowMessageBox.Margin = new Padding(4, 3, 4, 3);
            btnShowMessageBox.Name = "btnShowMessageBox";
            btnShowMessageBox.Size = new Size(152, 27);
            btnShowMessageBox.TabIndex = 14;
            btnShowMessageBox.Text = "Show Message Box";
            btnShowMessageBox.UseVisualStyleBackColor = true;
            btnShowMessageBox.Click += btnShowMessageBox_Click;
            // 
            // tabPageLists
            // 
            tabPageLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageLists.Controls.Add(label6);
            tabPageLists.Controls.Add(listView1);
            tabPageLists.Controls.Add(label5);
            tabPageLists.Controls.Add(comboBox1);
            tabPageLists.Controls.Add(label4);
            tabPageLists.Controls.Add(checkedListBox1);
            tabPageLists.Controls.Add(label3);
            tabPageLists.Controls.Add(listBox1);
            tabPageLists.Location = new Point(0, 35);
            tabPageLists.Name = "tabPageLists";
            tabPageLists.Size = new Size(887, 523);
            tabPageLists.TabIndex = 1;
            tabPageLists.Text = "List Controls";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 23;
            label6.Text = "ListView:";
            // 
            // listView1
            // 
            listView1.Location = new Point(405, 44);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(356, 230);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 299);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 21;
            label5.Text = "ComboBox:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 321);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 19;
            label4.Text = "CheckedListBox:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(214, 44);
            checkedListBox1.Margin = new Padding(4, 3, 4, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(171, 220);
            checkedListBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 17;
            label3.Text = "ListBox:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 44);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 229);
            listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(915, 647);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(darkTabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Silver;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "All WinForms Controls Showcase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)darkTabControl1).EndInit();
            darkTabControl1.ResumeLayout(false);
            tabPageOther.ResumeLayout(false);
            tabPageOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageBasic.ResumeLayout(false);
            tabPageBasic.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageData.ResumeLayout(false);
            tabPageData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageDialogs.ResumeLayout(false);
            tabPageDialogs.PerformLayout();
            tabPageLists.ResumeLayout(false);
            tabPageLists.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private DarkTabControl darkTabControl1;
        private DarkTabPage tabPageBasic;
        private DarkTabPage tabPageLists;
        private DarkTabPage tabPageData;
        private DarkTabPage tabPageDialogs;
        private DarkTabPage tabPageOther;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlColorDialogResult;
        private System.Windows.Forms.Label lblFontDialogResult;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnShowMessageBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label11;
        private DarkDateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

