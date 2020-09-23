namespace AsyncDemo
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadReportBackground = new System.Windows.Forms.Button();
            this.loadReportInvoke = new System.Windows.Forms.Button();
            this.loadReportSynchronous = new System.Windows.Forms.Button();
            this.loadReportTPL = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sku,
            this.ProductName,
            this.Description,
            this.Price,
            this.Cost});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 387);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sku
            // 
            this.sku.Text = "Sku";
            this.sku.Width = 75;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 250;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadReportBackground);
            this.panel1.Controls.Add(this.loadReportInvoke);
            this.panel1.Controls.Add(this.loadReportSynchronous);
            this.panel1.Controls.Add(this.loadReportTPL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 51);
            this.panel1.TabIndex = 2;
            // 
            // loadReportBackground
            // 
            this.loadReportBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadReportBackground.Location = new System.Drawing.Point(421, 0);
            this.loadReportBackground.Name = "loadReportBackground";
            this.loadReportBackground.Size = new System.Drawing.Size(199, 51);
            this.loadReportBackground.TabIndex = 2;
            this.loadReportBackground.Text = "LoadReport (BackgroundWorker)";
            this.loadReportBackground.UseVisualStyleBackColor = true;
            this.loadReportBackground.Click += new System.EventHandler(this.btnLoadReportBackground_Click);
            // 
            // loadReportInvoke
            // 
            this.loadReportInvoke.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadReportInvoke.Location = new System.Drawing.Point(194, 0);
            this.loadReportInvoke.Name = "loadReportInvoke";
            this.loadReportInvoke.Size = new System.Drawing.Size(227, 51);
            this.loadReportInvoke.TabIndex = 1;
            this.loadReportInvoke.Text = "Load Report (BeginInvoke / End Invoke)";
            this.loadReportInvoke.UseVisualStyleBackColor = true;
            this.loadReportInvoke.Click += new System.EventHandler(this.btnLoadReportInvoke_Click);
            // 
            // loadReportSynchronous
            // 
            this.loadReportSynchronous.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadReportSynchronous.Location = new System.Drawing.Point(0, 0);
            this.loadReportSynchronous.Name = "loadReportSynchronous";
            this.loadReportSynchronous.Size = new System.Drawing.Size(194, 51);
            this.loadReportSynchronous.TabIndex = 0;
            this.loadReportSynchronous.Text = "Load Report (Synchronous)";
            this.loadReportSynchronous.UseVisualStyleBackColor = true;
            this.loadReportSynchronous.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loadReportTPL
            // 
            this.loadReportTPL.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadReportTPL.Location = new System.Drawing.Point(620, 0);
            this.loadReportTPL.Name = "loadReportTPL";
            this.loadReportTPL.Size = new System.Drawing.Size(174, 51);
            this.loadReportTPL.TabIndex = 3;
            this.loadReportTPL.Text = "Load Report (async/ await)";
            this.loadReportTPL.UseVisualStyleBackColor = true;
            this.loadReportTPL.Click += new System.EventHandler(this.btnLoadReportTPL);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Asyncrony Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader sku;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadReportTPL;
        private System.Windows.Forms.Button loadReportBackground;
        private System.Windows.Forms.Button loadReportInvoke;
        private System.Windows.Forms.Button loadReportSynchronous;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

