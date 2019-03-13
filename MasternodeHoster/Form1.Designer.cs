namespace MasternodeHoster
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.olvMasternodes = new BrightIdeasSoftware.ObjectListView();
            this.titleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.blockColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hwndColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvMasternodes)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(1504, 373);
            this.listBox8.Name = "listBox8";
            this.listBox8.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox8.Size = new System.Drawing.Size(594, 199);
            this.listBox8.TabIndex = 49;
            this.listBox8.Visible = false;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(1504, 193);
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox5.Size = new System.Drawing.Size(527, 43);
            this.listBox5.TabIndex = 48;
            this.listBox5.Visible = false;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(1504, 242);
            this.listBox6.Name = "listBox6";
            this.listBox6.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox6.Size = new System.Drawing.Size(527, 43);
            this.listBox6.TabIndex = 47;
            this.listBox6.Visible = false;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(1504, 301);
            this.listBox7.Name = "listBox7";
            this.listBox7.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox7.Size = new System.Drawing.Size(527, 43);
            this.listBox7.TabIndex = 46;
            this.listBox7.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(1504, 144);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox4.Size = new System.Drawing.Size(527, 43);
            this.listBox4.TabIndex = 45;
            this.listBox4.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(1504, 95);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(527, 43);
            this.listBox3.TabIndex = 44;
            this.listBox3.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1504, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(527, 43);
            this.listBox2.TabIndex = 43;
            this.listBox2.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 285);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 25);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 57);
            this.button1.TabIndex = 76;
            this.button1.TabStop = false;
            this.button1.Text = "Delete Masternode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 57);
            this.button4.TabIndex = 78;
            this.button4.TabStop = false;
            this.button4.Text = "Add New Masternode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(261, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 57);
            this.button5.TabIndex = 79;
            this.button5.TabStop = false;
            this.button5.Text = "Run At Startup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(55, 95);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(98, 20);
            this.textBox11.TabIndex = 106;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Working Directory";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 105;
            this.button2.TabStop = false;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(160, 94);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(403, 20);
            this.textBox10.TabIndex = 104;
            this.textBox10.TabStop = false;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(611, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 57);
            this.button6.TabIndex = 107;
            this.button6.TabStop = false;
            this.button6.Text = "Refresh Masternode List";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(376, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 57);
            this.button7.TabIndex = 108;
            this.button7.TabStop = false;
            this.button7.Text = "Don\'t Run At Startup";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1504, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 113;
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 285);
            this.tabControl1.TabIndex = 117;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.olvMasternodes);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Masternodes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(107, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 57);
            this.button10.TabIndex = 122;
            this.button10.TabStop = false;
            this.button10.Text = "Hide Masternode Windows";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(207, 196);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 57);
            this.button9.TabIndex = 121;
            this.button9.TabStop = false;
            this.button9.Text = "Show Masternode Windows";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 57);
            this.button3.TabIndex = 120;
            this.button3.TabStop = false;
            this.button3.Text = "Check Selected Masternode Status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 196);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 57);
            this.button8.TabIndex = 119;
            this.button8.TabStop = false;
            this.button8.Text = "Start Selected Masternode";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // olvMasternodes
            // 
            this.olvMasternodes.AllColumns.Add(this.titleColumn);
            this.olvMasternodes.AllColumns.Add(this.statusColumn);
            this.olvMasternodes.AllColumns.Add(this.blockColumn);
            this.olvMasternodes.AllColumns.Add(this.hwndColumn);
            this.olvMasternodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvMasternodes.CellEditUseWholeCell = false;
            this.olvMasternodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.statusColumn,
            this.blockColumn,
            this.hwndColumn});
            this.olvMasternodes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvMasternodes.LargeImageList = this.imageList1;
            this.olvMasternodes.Location = new System.Drawing.Point(6, 6);
            this.olvMasternodes.MultiSelect = false;
            this.olvMasternodes.Name = "olvMasternodes";
            this.olvMasternodes.ShowGroups = false;
            this.olvMasternodes.ShowHeaderInAllViews = false;
            this.olvMasternodes.ShowImagesOnSubItems = true;
            this.olvMasternodes.Size = new System.Drawing.Size(700, 184);
            this.olvMasternodes.SmallImageList = this.imageList1;
            this.olvMasternodes.SpaceBetweenGroups = 1;
            this.olvMasternodes.TabIndex = 118;
            this.olvMasternodes.TileSize = new System.Drawing.Size(620, 80);
            this.olvMasternodes.UseAlternatingBackColors = true;
            this.olvMasternodes.UseCompatibleStateImageBehavior = false;
            this.olvMasternodes.UseExplorerTheme = true;
            this.olvMasternodes.View = System.Windows.Forms.View.Tile;
            this.olvMasternodes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.olvMasternodes_ItemSelectionChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.AspectName = "Title";
            this.titleColumn.AspectToStringFormat = "";
            this.titleColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.titleColumn.IsTileViewColumn = true;
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 94;
            // 
            // statusColumn
            // 
            this.statusColumn.AspectName = "Status";
            this.statusColumn.AspectToStringFormat = "{0:d}";
            this.statusColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusColumn.IsTileViewColumn = true;
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 350;
            // 
            // blockColumn
            // 
            this.blockColumn.AspectName = "Block";
            this.blockColumn.IsTileViewColumn = true;
            this.blockColumn.Text = "Block";
            // 
            // hwndColumn
            // 
            this.hwndColumn.AspectName = "Hwnd";
            this.hwndColumn.Text = "Hwnd";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "green");
            this.imageList1.Images.SetKeyName(1, "red");
            this.imageList1.Images.SetKeyName(2, "yellow");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 310);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Masternode Hoster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvMasternodes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView olvMasternodes;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private BrightIdeasSoftware.OLVColumn statusColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button8;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.Button button3;
        private BrightIdeasSoftware.OLVColumn blockColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private BrightIdeasSoftware.OLVColumn hwndColumn;
    }
}

