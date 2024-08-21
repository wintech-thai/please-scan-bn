using Microsoft.IdentityModel.Tokens;

namespace Its.PleaseScan.Api.Authentications
{
    public class JwtSigner : IJwtSigner
    {
        public JwtSigner()
        {
        }

        public static void ResetSigedKeyJson()
        {
            //For unit testing
            JwtSignerKey.ResetSigedKeyJson();
        }
 
        public SecurityKey GetSignedKey(string? url)
        {
            return JwtSignerKey.GetSignedKey(url);
        }
    }
}
