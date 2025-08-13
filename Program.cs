using Autodesk.Authentication;
using Autodesk.Authentication.Model;

namespace Step0
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var authenticationClient = new AuthenticationClient();
            var auth = await authenticationClient.GetTwoLeggedTokenAsync("dmqcHi4CsHnSoH5NZB3L6ZjTzBCaKWA2HGn26Zh9IPasxBLk", "YakHyIAogXSWsWpnGGLXPhgSkIAAYgGHEzxk4cXJZDa5x3gc69TFAbmbaNXwuq1Q", [Scopes.ViewablesRead]);
            Console.WriteLine(auth.AccessToken);
        }
    }
}
