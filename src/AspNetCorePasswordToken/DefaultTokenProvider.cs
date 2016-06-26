using Microsoft.AspNet.DataProtection;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.OptionsModel;

namespace AspNetCorePasswordToken
{

    public class DefaultDataProtectorTokenProvider<TUser> : DataProtectorTokenProvider<TUser> where TUser : class
    {
        public DefaultDataProtectorTokenProvider(IDataProtectionProvider dataProtectionProvider, IOptions<DefaultDataProtectorTokenProviderOptions> options) : base(dataProtectionProvider, options)
        {
        }
    }

    public class DefaultDataProtectorTokenProviderOptions : DataProtectionTokenProviderOptions { }

}
