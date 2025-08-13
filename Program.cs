namespace APS_StepByStep
{    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var accessToken = AuthController.GetToken().Result;
            Console.WriteLine(accessToken);
        }
    }
}
