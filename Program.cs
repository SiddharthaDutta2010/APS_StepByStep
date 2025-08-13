using Autodesk.Authentication;
using Autodesk.Authentication.Model;

namespace APS_StepByStep
{
    class AuthController
    {
        public static async Task<string> GetToken(string _clientId, string _clientSecret, List<Scopes> scopes)
        {
            var authenticationClient = new AuthenticationClient();
            var auth = await authenticationClient.GetTwoLeggedTokenAsync(_clientId, _clientSecret, scopes);
            return auth.AccessToken;
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var accessToken = AuthController.GetToken("dmqcHi4CsHnSoH5NZB3L6ZjTzBCaKWA2HGn26Zh9IPasxBLk", "YakHyIAogXSWsWpnGGLXPhgSkIAAYgGHEzxk4cXJZDa5x3gc69TFAbmbaNXwuq1Q", [Scopes.ViewablesRead]).Result;
            Console.WriteLine(accessToken);
        }
    }
}
