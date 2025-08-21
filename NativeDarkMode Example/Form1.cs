using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NativeDarkMode_Lib;
using NativeDarkMode_Lib.Utils; // For DarkMessageBox.Show usage. 

namespace NativeDarkMode_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateControls();

            Converter.DarkModeEnable(this);

            trackBar1_Scroll(this, null);
        }

        

        #region Data Population and Event Handlers
        private void PopulateControls()
        {
            // This method's content is unchanged
            // Tab 1: Basic Controls
            this.textBox1.Text = "This is a sample text.";
            this.maskedTextBox1.Text = "12345";
            this.checkBox1.Checked = true;
            this.radioButton2.Checked = true;

            // Tab 2: List Controls
            string[] listItems = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            this.listBox1.Items.AddRange(listItems);
            this.checkedListBox1.Items.AddRange(listItems);
            this.comboBox1.Items.AddRange(listItems);
            this.listBox1.SelectedIndex = 0;
            this.checkedListBox1.SetItemChecked(1, true);
            this.comboBox1.SelectedIndex = 2;

            // ListView Population
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("Product", 120);
            this.listView1.Columns.Add("Price", 70);
            this.listView1.Columns.Add("In Stock", 70);
            string[] row1 = { "Laptop", "1200", "50" };
            string[] row2 = { "Mouse", "25", "200" };
            string[] row3 = { "Keyboard", "75", "150" };
            this.listView1.Items.Add(new ListViewItem(row1));
            this.listView1.Items.Add(new ListViewItem(row2));
            this.listView1.Items.Add(new ListViewItem(row3));

            

            // Tab 3: Data Controls
            // DataGridView Population
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("IsMember", typeof(bool));
            dt.Rows.Add(1, "John", "Doe", true);
            dt.Rows.Add(2, "Jane", "Smith", false);
            dt.Rows.Add(3, "Peter", "Jones", true);
            this.dataGridView1.DataSource = dt;

            // TreeView Population
            TreeNode rootNode = new TreeNode("Categories");
            TreeNode electronicsNode = new TreeNode("Electronics");
            electronicsNode.Nodes.Add("Laptops");
            electronicsNode.Nodes.Add("Smartphones");
            TreeNode booksNode = new TreeNode("Books");
            booksNode.Nodes.Add("Fiction");
            booksNode.Nodes.Add("Non-Fiction");
            rootNode.Nodes.Add(electronicsNode);
            rootNode.Nodes.Add(booksNode);
            this.treeView1.Nodes.Add(rootNode);
            this.treeView1.ExpandAll();

            // Tab 5: Other Controls
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(50, 50, 50));
                g.DrawString("Hi!", new Font("Arial", 24), Brushes.Silver, new PointF(20, 30));
            }
            this.pictureBox1.Image = bmp;
            this.trackBar1.Value = 50;
            this.progressBar1.Value = 50;
            this.dateTimePicker1.Value = DateTime.Now;
            this.monthCalendar1.SelectionStart = DateTime.Now.AddDays(3);
            this.webBrowser1.DocumentText = "<html><body style='background-color:#212121; color:silver;'><h1>Hello, World!</h1><p>This is a WebBrowser control.</p></body></html>";
            this.richTextBox1.Text = "This is a RichTextBox. You can apply formatting like ";
            int startIndex = this.richTextBox1.Text.Length;
            this.richTextBox1.AppendText("bold");
            this.richTextBox1.Select(startIndex, 4);
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font, FontStyle.Bold);
            this.richTextBox1.SelectionColor = Color.LightSkyBlue;
            this.richTextBox1.AppendText(" and ");
            startIndex = this.richTextBox1.Text.Length;
            this.richTextBox1.AppendText("italic");
            this.richTextBox1.Select(startIndex, 6);
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font, FontStyle.Italic);
            this.richTextBox1.SelectionColor = Color.LightGreen;
            this.richTextBox1.AppendText(".");
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            DarkMessageBox.Show(this, "This is a simple message box.", "Message Box Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open File Dialog";
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"File selected: {ofd.FileName}");
                }
            }
        }
        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save File Dialog";
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"File will be saved to: {sfd.FileName}");
                }
            }
        }
        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                fd.ShowColor = true;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.lblFontDialogResult.Font = fd.Font;
                    this.lblFontDialogResult.ForeColor = fd.Color;
                }
            }
        }
        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.pnlColorDialogResult.BackColor = cd.Color;
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e) { this.progressBar1.Value = this.trackBar1.Value; this.toolStripProgressBar1.Value = this.trackBar1.Value; }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) { DarkMessageBox.Show(this, "All WinForms Controls Demo Application", "About"); }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
        #endregion

        private void darkTabControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
