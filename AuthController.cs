using Autodesk.Authentication;
using Autodesk.Authentication.Model;
using Microsoft.AspNetCore.Mvc;

namespace APS_StepByStep
{
    public record Token(string AccessToken, DateTime ExpiresAt);
    class AuthController : ControllerBase
    {
        private readonly APS _aps;

        public AuthController(APS aps)
        {
            _aps = aps;
        }

        public async Task<IActionResult> GetAccessToken()
        {
            var token = await _aps.GetPublicToken();
            return Ok(new
            {
                access_token = token.AccessToken,
                expires_in = (long)Math.Round((token.ExpiresAt - DateTime.UtcNow).TotalSeconds)
            });
        }
    }
}
