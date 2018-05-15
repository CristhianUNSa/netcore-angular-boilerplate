using System.Collections.Generic;

namespace InnovationSoft.Olh.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
