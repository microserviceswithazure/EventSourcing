using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    using System.Configuration;

    using RestSharp;

    public partial class Lifecycle : Form
    {
        RestClient client = new RestClient(ConfigurationManager.AppSettings["commerceService"]);
        public Lifecycle()
        {
            InitializeComponent();
        }

        private void btn_AddToInventory_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"/Inventory?productId={1}&productName={"something"}&supplierName={"supplier"}&warehouseCode={"delhi"}", Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        private void btn_ShipToCustomer_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"Shipping?productName={"stuff"}&warehouseName={"delhi"}&customerName={"rahul"}", Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        private void btn_DeliveredToCustomer_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"Customer?productId={1}&customerName={"rahul"}", Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        private void btn_ReshipToCustomer_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"Customer?productId={1}&customerName={"rahul"}", Method.PUT);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        private void btn_AuditLifecycle_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"Audit?correlationCode={1}", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Lifecycle_Load(object sender, EventArgs e)
        {

        }
    }
}
