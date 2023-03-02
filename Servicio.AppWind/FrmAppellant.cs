using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using wcfrestservice.erpmak.entity;

namespace Servicio.AppWind
{
    public partial class FrmAppellant : Form
    {
        public FrmAppellant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgvAppellants.DataSource = null;
            //this.dgvAppellants.DataBind();
            try
            {
                string serviceUrl = "http://localhost:17476/ProductRESTService.svc/Appellants";
                HttpWebRequest request = WebRequest.Create(serviceUrl) as HttpWebRequest;
                //WebResponse response = request.GetResponse();
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    // Get the response stream 
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    var jsonData = reader.ReadToEnd().ToString();
                    List<Appellant> listCandidates = new
                   JavaScriptSerializer().Deserialize<List<Appellant>>(jsonData);
                    int count = listCandidates.Count;
                    dgvAppellants.DataSource = listCandidates;
                    //dgvAppellants.DataBind();
                }
            }
            catch (Exception ex)
            {
                string problem = ex.Message.ToString();
            }
        }


        /*
         Here if the class Appellant has another namespace it will not work...
        that's why I reuse the wcfrestservice.erpmak.entity.
        Another idea would be just to add the assembly as a reference ( only the dll file) 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            this.dgvAppellants.DataSource = null;
            //this.dgvAppellants.DataBind();
            try
            {
                string serviceUrl = "http://localhost:17476/ProductRESTService.svc/AppellantsXML";
                WebRequest request = WebRequest.Create(serviceUrl);
                WebResponse response = request.GetResponse();
                DataContractSerializer collectionData = new DataContractSerializer(typeof(Appellant[]));
                var arrayAppeal = collectionData.ReadObject(response.GetResponseStream());
                dgvAppellants.DataSource = arrayAppeal as Appellant[];
                //dgvAppellants.DataBind();
            }
            catch (Exception ex)
            {
                string problem = ex.Message.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.dgvAppellants.DataSource = null;
        }
    }
}
