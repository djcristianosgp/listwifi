using NativeWifi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiView
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            pbProgress.Dock = DockStyle.Fill;
            pnProgresso.Visible = false;
            btnExportarLista.Enabled = false;
            btnGerarQrcode.Enabled = false;
        }

        private void ExibirRede()
        {
            try
            {
                pbProgress.Value = 0;
                pbProgress.Maximum = 100;
                pnProgresso.Visible = true;
                if(!WlanClient.WlanInterface.ReferenceEquals(this, null))
                {
                    return;
                }
                var wlan = new WlanClient();
                Collection<string> connectedSsids = new Collection<string>();

                foreach (WlanClient.WlanInterface wlanInterface in wlan.Interfaces)
                {
                    if(pbProgress.Value<pbProgress.Maximum)
                        pbProgress.Value = +2;
                    Wlan.Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
                    connectedSsids.Add(new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength)));
                }

                lsRedes.Items.Clear();
                lsRedes.Items.Add(connectedSsids);
                btnExportarLista.Enabled = true;
                btnGerarQrcode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnExportarLista.Enabled = false;
                btnGerarQrcode.Enabled = false;
            }
            finally
            {
                pnProgresso.Visible = false;
            }
        }

        private void GerarQRCode()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportarLista()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ExibirRede();
        }

        private void btnGerarQrcode_Click(object sender, EventArgs e)
        {
            GerarQRCode();
        }

        private void btnExportarLista_Click(object sender, EventArgs e)
        {
            ExportarLista();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
