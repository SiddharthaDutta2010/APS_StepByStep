namespace APS_StepByStep
{    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            APS aps = new APS("dmqcHi4CsHnSoH5NZB3L6ZjTzBCaKWA2HGn26Zh9IPasxBLk", "YakHyIAogXSWsWpnGGLXPhgSkIAAYgGHEzxk4cXJZDa5x3gc69TFAbmbaNXwuq1Q", "Merlin");
            
            AuthController authController = new AuthController(aps);

            var accessToken = authController.GetToken().Result;
            Console.WriteLine(accessToken);
        }
    }
}
