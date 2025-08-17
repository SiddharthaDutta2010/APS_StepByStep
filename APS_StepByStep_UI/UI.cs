using Autodesk.Authentication;
using Autodesk.Authentication.Model;

namespace APS_StepByStep_UI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            FetchToken();
        }

        private async void FetchToken()
        {
            txtToken.Text = await GetToken();
        }

        private async Task<string> GetToken()
        {
            var authenticationClient = new AuthenticationClient();
            var auth = await authenticationClient.GetTwoLeggedTokenAsync(txtClientID.Text, txtClientSecret.Text, [Scopes.ViewablesRead]);
            return auth.AccessToken;   
        }
    }
}
