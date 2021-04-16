using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioControlProteinas;

namespace ControlProteinasClient
{
    public partial class ControlProteinasForm : Form
    {

        private ProteinTrackingServiceSoapClient service = 
            new ProteinTrackingServiceSoapClient(ProteinTrackingServiceSoapClient.EndpointConfiguration.ProteinTrackingServiceSoap);

        private User[] users;

        public ControlProteinasForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            users = service.ListUsers();
            cbSelectUser.DataSource = users;
            cbSelectUser.DisplayMember = "Name";
            cbSelectUser.ValueMember = "UserId";
            tbNewUserName.Text = "";
            tbNewUserMeta.Text = "";
        }

        private void btnNewUserAdd_Click(object sender, EventArgs e)
        {
            service.AddUser(tbNewUserName.Text, int.Parse(tbNewUserMeta.Text));
            RefreshUsers();
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cbSelectUser.SelectedIndex;
            lbTotalQuantity.Text = users[index].Total.ToString();
            lbMetaQuantity.Text = users[index].Goal.ToString();
        }

        private void btnAddProteina_Click(object sender, EventArgs e)
        {
            var userId = users[cbSelectUser.SelectedIndex].UserId;
            var newTotal = service.AddProtein(int.Parse(tbAgregarProteina.Text), userId);
            users[cbSelectUser.SelectedIndex].Total = newTotal;
            lbTotalQuantity.Text = users[cbSelectUser.SelectedIndex].Total.ToString();
        }
    }
}
