using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using FactoryLogix.xTend.Core;
using FactoryLogix.xTend.DataObjects;
using FactoryLogix.xTend.Production;
using FactoryLogix.xTend.Services;
using FactoryLogix.xTend.Configuration;
using System.Collections;
using System.Threading;


namespace Batch_Utility
{
    public partial class Form1 : Form
    {
        private IBatchServices _batchServices = new BatchServices();
        private ISystemSettingServices _systemsettingServives = new FactoryLogix.xTend.Configuration.SystemSettingServices();
        private string dbConnName;
        private static Guid _sessionId;
        private ConnectionServices conn = new ConnectionServices();
        private bool connected = false;
        private ArrayList list = new ArrayList();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {          
            this.txtServer.Enter += new EventHandler(txtServer_Enter);
            this.txtServer.Leave += new EventHandler(txtServer_Leave);
            textBox2_SetText();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isBlank = (txtServer.Text == "" || txtUserName.Text == "");

            if (!isBlank)
            {
                try
                {
                    textBox2.AppendText("Attempting to connect..... " + Environment.NewLine);
                    dbConnName = conn.GetDefaultDatabaseConnection(txtServer.Text);
                    _sessionId = conn.Connect(txtServer.Text, txtUserName.Text, txtPassword.Text, dbConnName);

                    striplabelConnected.Text = "Connected. SessionID: " + _sessionId;
                    striplabelConnected.ForeColor = Color.Green;

                    textBox2.AppendText("Connected to: " + txtServer.Text + Environment.NewLine);
                    connected = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Error: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.AppendText("Connection Attempt Failed. " + Environment.NewLine);
                }
            }
            else

            {
                MessageBox.Show("Fill In all credential information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnDeletefromTextbox_Click(object sender, EventArgs e)
        {
            List<int> batchList = textBox1.Text.Split(',').Select(int.Parse).ToList();
            var batch1 = _batchServices as Batch;

            foreach (int batch in batchList)
            {
                batch1 = _batchServices.FindBatchByName(_sessionId, batch.ToString());
                if (batch1 == null)
                {
                    Console.WriteLine("Batch {0} does not exist", batch.ToString());
                    textBox2.AppendText("Batch does not exist: " + batch.ToString() + Environment.NewLine);
                }
                else
                {
                    try
                    {
                        _batchServices.DeleteBatch(_sessionId, batch1.Id);
                        Console.WriteLine(batch1.Name + " Deleted");
                        textBox2.AppendText("Batch Deleted: " + batch.ToString() + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting batch -  " + ex.ToString());
                        Console.WriteLine(ex);
                    }
                }
            }

        }
        private void btnDeleteBatch_Click(object sender, EventArgs e)
        {
            var batch1 = _batchServices as Batch;
            Console.WriteLine("Items to process {0}", checkedListBox1.Items.Count);

            foreach (var item in checkedListBox1.CheckedItems)
            {
                batch1 = _batchServices.FindBatchByName(_sessionId, item.ToString());
                if (batch1 == null)
                {
                    Console.WriteLine("Batch {0} does not exist", item.ToString());
                    textBox2.AppendText("Batch does not exist: " + item.ToString() + Environment.NewLine);
                }
                else
                {
                    _batchServices.DeleteBatch(_sessionId, batch1.Id);
                    Console.WriteLine(batch1.Name + " Deleted Successfully");
                    textBox2.AppendText("Batch Deleted Successfully: " + item.ToString() + Environment.NewLine);

                }
            }
        }


        private void btnLoadFiles_Click(object sender, EventArgs e)
        {           
            OpenFileDialog thedialog = new OpenFileDialog();
            thedialog.Title = "Select Batch Import Files";
            thedialog.Multiselect = true;
            thedialog.RestoreDirectory = true;
            thedialog.InitialDirectory = @"C:\";
            if (thedialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in thedialog.FileNames)
                {
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
                        XmlNode xmlnode;
                        xmlDoc.Load(file); // Load the XML document from the specified file

                        //get the batchdata node
                        XmlNodeList _batchdata = xmlDoc.SelectNodes("/Batches/BatchData");
                        list.Add(_batchdata);
                        foreach (XmlNode batchdata in _batchdata)
                        {
                            string assembly = batchdata.SelectSingleNode("AssemblyName").InnerText;

                            XmlNode productsNode = batchdata.SelectSingleNode("Products");

                            if (productsNode != null)
                            {

                                string Initialization = productsNode.SelectSingleNode("InitializationOperation").InnerText;
                            }

                        }



                        xmlnode = xmlDoc.ChildNodes[1];
                        treeView1.Nodes.Clear();
                        treeView1.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));
                        TreeNode tNode;
                        tNode = treeView1.Nodes[0];
                        AddNode(xmlnode, tNode);
                        {
                        }

                        // Get elements
                        //XmlNodeList girlAddress = xmlDoc.GetElementsByTagName("BatchData");
                        XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/Batches/BatchData/Name");

                        //xmlDoc.DocumentElement.SelectNodes("BatchData/Name");


                        foreach (XmlElement element in xmlNodeList)
                        {
                            //textBox1.AppendText(element.InnerText + Environment.NewLine);
                            checkedListBox1.Items.Add(element.InnerText);
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                            row.Cells[0].Value = true;
                            row.Cells[1].Value = element.InnerText;
                            //see if batch exists
                            if (chkValidate.Checked && connected)
                            {
                                var batchinfo = _batchServices.FindBatchByName(_sessionId, element.InnerText);
                                if (batchinfo != null)
                                    row.Cells[2].Value = "Batch Exists";
                                else
                                    row.Cells[2].Value = "Batch Doesn't Exists";
                            }
                            else
                            {
                                textBox2.AppendText("Not Connected - Skipped checking if file exists: " + Environment.NewLine);
                            }

                            dataGridView1.Rows.Add(row);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Error: " + ex.ToString());
                        Console.WriteLine(ex);
                        textBox2.AppendText("Error Opening File: " + file + " - " + ex.Message + Environment.NewLine);
                    }
                }
                //Check all items in listbox
                //checkedListBox1.CheckAll();
                //lblCount.Text = checkedListBox1.CheckedItems.Count.ToString() + " Batches Selected";
            }
        }

       


        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            int sCount = checkedListBox1.CheckedItems.Count;
            lblCount.Text = sCount.ToString() + " Batches Selected";
            //if (e.State == CheckState.Checked) { ++sCount; }
            //if (e.State == CheckState.Unchecked) { --sCount; }            
        }
  
        protected void textBox2_SetText()
        {
            this.txtServer.Text = "Enter API Server Name or IP...";
            txtServer.ForeColor = Color.Gray;
        }
        private void txtServer_Enter(object sender, EventArgs e)
        {
            if (txtServer.ForeColor == Color.Black)
                return;
            txtServer.Text = "";
            txtServer.ForeColor = Color.Black;
        }
        private void txtServer_Leave(object sender, EventArgs e)
        {
            if (txtServer.Text.Trim() == "")
                textBox2_SetText();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            //checkedListBox1.CheckAll();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);               
                checkBox.Value = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            //checkedListBox1.UnCheckAll();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);                
                checkBox.Value = false;
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            //checkedListBox1.Items.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var batch1 = _batchServices as Batch;
            Console.WriteLine("Items to process {0}", checkedListBox1.Items.Count);

            //foreach (var item in checkedListBox1.CheckedItems)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    batch1 = _batchServices.FindBatchByName(_sessionId, row.Cells[1].Value.ToString());
                    if (batch1 == null)
                    {
                        Console.WriteLine("Batch {0} does not exist", batch1.Name.ToString());
                        textBox2.AppendText("Batch does not exist: " + batch1.Name.ToString() + Environment.NewLine);
                    }
                    else
                    {
                        _batchServices.DeleteBatch(_sessionId, batch1.Id);
                        Console.WriteLine(batch1.Name + " Deleted Successfully");
                        textBox2.AppendText("Batch Deleted Successfully: " + batch1.Name.ToString() + Environment.NewLine);

                    }
                }
            }
        }
    }

}
