using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncDemo.Models;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
            this.toolTip1.SetToolTip(this.loadReportSynchronous, "Loads the report synchronously. Expect the form to become unresponsive after clicking this button.");
            this.toolTip1.SetToolTip(this.loadReportInvoke, "Loads the report asynchronously using BeginInvoke/ EndInvoke callbacks");
            this.toolTip1.SetToolTip(this.loadReportBackground, "Loads the report asynchronously using BackgroundWorker");
            this.toolTip1.SetToolTip(this.loadReportTPL, "Loads the report asynchronously async/ await keywords and TPL.");
        }


        private void FreezeControls()
        {
            this.loadReportTPL.Enabled = false;
            this.loadReportSynchronous.Enabled = false;
            this.loadReportBackground.Enabled = false;
            this.loadReportInvoke.Enabled = false;
        }
        private void UnFreezeControls()
        {
            this.loadReportTPL.Enabled = true;
            this.loadReportSynchronous.Enabled = true;
            this.loadReportBackground.Enabled = true;
            this.loadReportInvoke.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Application.DoEvents();
            FreezeControls();
            // Calling a long running job
            var result = GetLongRunningProductsReport();
            listView1.Items.AddRange(result);
            UnFreezeControls();
        }
        private ListViewItem[] GetLongRunningProductsReport()
        {
            var collections = new ListViewItem[100];
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                var product = new Product()
                {
                    Sku = $"Product_{i}",
                    Name = $"ProductName_{i}",
                    Description = $"ProductDescription_{i}",
                    Cost = rand.Next(1, 1000),
                    Price = rand.Next(1, 1000)
                };
                var listViewItem = new ListViewItem(product.Sku);
                listViewItem.SubItems.Add(product.Name);
                listViewItem.SubItems.Add(product.Description);
                listViewItem.SubItems.Add($"${product.Cost.ToString()}");
                listViewItem.SubItems.Add($"${product.Price.ToString()}");
                collections[i] = listViewItem; ;
            }
            return collections;
        }

        #region AsynchronyUsingIAsyncResult

        private delegate ListViewItem[] AsyncMethodCaller();
        private void btnLoadReportInvoke_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Application.DoEvents();
            FreezeControls();
            AsyncMethodCaller caller = new AsyncMethodCaller(GetLongRunningProductsReport);
            caller.BeginInvoke(new AsyncCallback(UpdateListViewCallback), null);
        }
        private void UpdateListViewCallback(IAsyncResult result)
        {
            AsyncResult ar = (AsyncResult)result;
            AsyncMethodCaller caller = (AsyncMethodCaller)ar.AsyncDelegate;
            var records = caller.EndInvoke(result);
            listView1.BeginInvoke(new InvokeDelegate(UpdateListView), new object[] { records });
        }
        private delegate void InvokeDelegate(ListViewItem[] records);
        private void UpdateListView(ListViewItem[] records)
        {
            listView1.Items.AddRange(records);
            UnFreezeControls();
        }

        #endregion

        #region BackgroundWorker

        private void btnLoadReportBackground_Click(object sender, EventArgs e)
        {
            FreezeControls();
            listView1.Items.Clear();
            Application.DoEvents();
            worker.RunWorkerAsync();
        }


        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var records = GetLongRunningProductsReport();
            listView1.BeginInvoke(new InvokeDelegate(UpdateListView), new object[] { records });
        }
        #endregion

        #region async/await

        private async Task<ListViewItem[]> GetLongRunningProductsReportAsync()
        {
            var collections = new ListViewItem[100];
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(500);
                var product = new Product()
                {
                    Sku = $"Product_{i}",
                    Name = $"ProductName_{i}",
                    Description = $"ProductDescription_{i}",
                    Cost = rand.Next(1, 1000),
                    Price = rand.Next(1, 1000)
                };
                var listViewItem = new ListViewItem(product.Sku);
                listViewItem.SubItems.Add(product.Name);
                listViewItem.SubItems.Add(product.Description);
                listViewItem.SubItems.Add($"${product.Cost.ToString()}");
                listViewItem.SubItems.Add($"${product.Price.ToString()}");
                collections[i] = listViewItem;
            }
            return collections;
        }


        private async void btnLoadReportTPL(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            FreezeControls();
            Application.DoEvents();
            var result = await GetLongRunningProductsReportAsync();
            listView1.Items.AddRange(result);
            UnFreezeControls();
        }
        #endregion

    }
}
