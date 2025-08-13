using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Authentication;
using Autodesk.Authentication.Model;

namespace APS_StepByStep
{
    public  class APS
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _bucket;

        private Token _publicTokenCache;

        public APS(string clientId, string clientSecret, string bucket = null)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _bucket = string.IsNullOrEmpty(bucket) ? string.Format("{0}-basic-app", _clientId.ToLower()) : bucket;
        }       

        public async Task<Token> GetPublicToken()
        {
            if (_publicTokenCache == null || _publicTokenCache.ExpiresAt < DateTime.UtcNow)
                _publicTokenCache = await GetToken([Scopes.ViewablesRead]);
            return _publicTokenCache;
        }

        private async Task<Token> GetToken(List<Scopes> scopes)
        {
            var authenticationClient = new AuthenticationClient();
            var auth = await authenticationClient.GetTwoLeggedTokenAsync(_clientId, _clientSecret, scopes);
            return new Token(auth.AccessToken, DateTime.UtcNow.AddSeconds((double)auth.ExpiresIn));
        }

    }
}
