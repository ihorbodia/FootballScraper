namespace Betfair_Football_Markets
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reloadBtn = new System.Windows.Forms.Button();
            this.serverData = new System.Windows.Forms.DataGridView();
            this.midBox = new System.Windows.Forms.TextBox();
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apiCall = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localGrid = new System.Windows.Forms.DataGridView();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputGrid = new System.Windows.Forms.DataGridView();
            this.recBtn = new System.Windows.Forms.Button();
            this.excCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.serverData)).BeginInit();
            this.serverGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadBtn
            // 
            this.reloadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reloadBtn.Location = new System.Drawing.Point(3, 82);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(361, 23);
            this.reloadBtn.TabIndex = 0;
            this.reloadBtn.Text = "Update";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // serverData
            // 
            this.serverData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.serverData.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.serverData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverData.Location = new System.Drawing.Point(3, 105);
            this.serverData.Name = "serverData";
            this.serverData.Size = new System.Drawing.Size(361, 399);
            this.serverData.TabIndex = 1;
            // 
            // midBox
            // 
            this.midBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.midBox.Location = new System.Drawing.Point(3, 62);
            this.midBox.Name = "midBox";
            this.midBox.Size = new System.Drawing.Size(361, 20);
            this.midBox.TabIndex = 2;
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.serverData);
            this.serverGroup.Controls.Add(this.reloadBtn);
            this.serverGroup.Controls.Add(this.midBox);
            this.serverGroup.Controls.Add(this.label2);
            this.serverGroup.Controls.Add(this.apiCall);
            this.serverGroup.Controls.Add(this.label);
            this.serverGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverGroup.Location = new System.Drawing.Point(0, 0);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(367, 507);
            this.serverGroup.TabIndex = 3;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "Server Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Market IDs:";
            // 
            // apiCall
            // 
            this.apiCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.apiCall.Location = new System.Drawing.Point(3, 29);
            this.apiCall.Name = "apiCall";
            this.apiCall.Size = new System.Drawing.Size(361, 20);
            this.apiCall.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(3, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 13);
            this.label.TabIndex = 3;
            this.label.Text = "API Call:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localGrid);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.pathBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 507);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Data";
            // 
            // localGrid
            // 
            this.localGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.localGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.localGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localGrid.Location = new System.Drawing.Point(3, 72);
            this.localGrid.Name = "localGrid";
            this.localGrid.Size = new System.Drawing.Size(344, 432);
            this.localGrid.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseBtn.Location = new System.Drawing.Point(3, 49);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(344, 23);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathBox.Location = new System.Drawing.Point(3, 29);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(344, 20);
            this.pathBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // outputGrid
            // 
            this.outputGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.outputGrid.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.outputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGrid.Location = new System.Drawing.Point(0, 30);
            this.outputGrid.Name = "outputGrid";
            this.outputGrid.Size = new System.Drawing.Size(684, 477);
            this.outputGrid.TabIndex = 5;
            this.outputGrid.SelectionChanged += new System.EventHandler(this.outputGrid_SelectionChanged);
            // 
            // recBtn
            // 
            this.recBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recBtn.Location = new System.Drawing.Point(125, 0);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(559, 30);
            this.recBtn.TabIndex = 6;
            this.recBtn.Text = "Recalculate Stats";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // excCheck
            // 
            this.excCheck.AutoSize = true;
            this.excCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.excCheck.Location = new System.Drawing.Point(0, 0);
            this.excCheck.Name = "excCheck";
            this.excCheck.Size = new System.Drawing.Size(125, 30);
            this.excCheck.TabIndex = 7;
            this.excCheck.Text = "Exclude Below 100%";
            this.excCheck.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recBtn);
            this.panel1.Controls.Add(this.excCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 30);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1409, 507);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.outputGrid);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.serverGroup);
            this.splitContainer2.Size = new System.Drawing.Size(1055, 507);
            this.splitContainer2.SplitterDistance = 684;
            this.splitContainer2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 507);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Football Scrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverData)).EndInit();
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.DataGridView serverData;
        private System.Windows.Forms.TextBox midBox;
        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView localGrid;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outputGrid;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiCall;
        private System.Windows.Forms.CheckBox excCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

