using Microsoft.IdentityModel.Tokens;

namespace Its.PleaseScan.Api.Authentications
{
    public interface IJwtSigner
    {
        public SecurityKey GetSignedKey(string? url);
    }
}
