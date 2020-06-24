namespace Batch_Utility
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Batch = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearList = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadFiles = new DevExpress.XtraEditors.SimpleButton();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBox1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.btnDeletefromTextbox = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.striplabelConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkValidate = new DevExpress.XtraEditors.CheckEdit();
            this.tabControl1.SuspendLayout();
            this.Batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkValidate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(273, 151);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 358);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(816, 94);
            this.textBox2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Batch);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 506);
            this.tabControl1.TabIndex = 5;
            // 
            // Batch
            // 
            this.Batch.Controls.Add(this.chkValidate);
            this.Batch.Controls.Add(this.dataGridView1);
            this.Batch.Controls.Add(this.btnDelete);
            this.Batch.Controls.Add(this.btnClearList);
            this.Batch.Controls.Add(this.btnSelectNone);
            this.Batch.Controls.Add(this.btnSelectAll);
            this.Batch.Controls.Add(this.btnLoadFiles);
            this.Batch.Controls.Add(this.lblCount);
            this.Batch.Controls.Add(this.checkedListBox1);
            this.Batch.Controls.Add(this.btnConnect);
            this.Batch.Controls.Add(this.txtUserName);
            this.Batch.Controls.Add(this.txtPassword);
            this.Batch.Controls.Add(this.txtServer);
            this.Batch.Controls.Add(this.btnDeletefromTextbox);
            this.Batch.Controls.Add(this.label5);
            this.Batch.Controls.Add(this.label4);
            this.Batch.Controls.Add(this.statusStrip1);
            this.Batch.Controls.Add(this.label3);
            this.Batch.Controls.Add(this.label2);
            this.Batch.Controls.Add(this.label1);
            this.Batch.Controls.Add(this.textBox2);
            this.Batch.Controls.Add(this.textBox1);
            this.Batch.Location = new System.Drawing.Point(4, 22);
            this.Batch.Name = "Batch";
            this.Batch.Padding = new System.Windows.Forms.Padding(3);
            this.Batch.Size = new System.Drawing.Size(825, 480);
            this.Batch.TabIndex = 0;
            this.Batch.Text = "Batches";
            this.Batch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colBatch,
            this.colStatus});
            this.dataGridView1.Location = new System.Drawing.Point(4, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(408, 286);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 24);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Batches";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(417, 186);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(83, 23);
            this.btnClearList.TabIndex = 24;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(417, 160);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(83, 23);
            this.btnSelectNone.TabIndex = 23;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(417, 134);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(83, 23);
            this.btnSelectAll.TabIndex = 22;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(417, 54);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(83, 23);
            this.btnLoadFiles.TabIndex = 21;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(38, 35);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(47, 13);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "0 Batches";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Location = new System.Drawing.Point(688, 313);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(129, 39);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(634, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "aegisadmin";
            this.txtUserName.Location = new System.Drawing.Point(245, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(154, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(461, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtServer
            // 
            this.txtServer.EditValue = "svclutron";
            this.txtServer.Location = new System.Drawing.Point(55, 7);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(154, 20);
            this.txtServer.TabIndex = 1;
            // 
            // btnDeletefromTextbox
            // 
            this.btnDeletefromTextbox.Location = new System.Drawing.Point(624, 215);
            this.btnDeletefromTextbox.Name = "btnDeletefromTextbox";
            this.btnDeletefromTextbox.Size = new System.Drawing.Size(98, 23);
            this.btnDeletefromTextbox.TabIndex = 16;
            this.btnDeletefromTextbox.Text = "Delete Batch(s)";
            this.btnDeletefromTextbox.UseVisualStyleBackColor = true;
            this.btnDeletefromTextbox.Click += new System.EventHandler(this.btnDeletefromTextbox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter batch(s) to delete (separate multiples with comma (,)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.striplabelConnected});
            this.statusStrip1.Location = new System.Drawing.Point(3, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // striplabelConnected
            // 
            this.striplabelConnected.Name = "striplabelConnected";
            this.striplabelConnected.Size = new System.Drawing.Size(88, 17);
            this.striplabelConnected.Text = "Not Connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tab2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(547, 407);
            this.treeView1.TabIndex = 0;
            // 
            // colSelected
            // 
            this.colSelected.HeaderText = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Width = 75;
            // 
            // colBatch
            // 
            this.colBatch.HeaderText = "Batch Name";
            this.colBatch.Name = "colBatch";
            this.colBatch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBatch.Width = 230;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkValidate
            // 
            this.chkValidate.Location = new System.Drawing.Point(417, 83);
            this.chkValidate.Name = "chkValidate";
            this.chkValidate.Properties.Caption = "Check if batch exists";
            this.chkValidate.Size = new System.Drawing.Size(121, 19);
            this.chkValidate.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Batch.ResumeLayout(false);
            this.Batch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkValidate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Batch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel striplabelConnected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletefromTextbox;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBox1;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.SimpleButton btnLoadFiles;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnClearList;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private DevExpress.XtraEditors.CheckEdit chkValidate;
    }
}

