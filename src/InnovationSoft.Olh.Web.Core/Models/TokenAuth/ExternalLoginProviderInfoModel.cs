using Abp.AutoMapper;
using InnovationSoft.Olh.Authentication.External;

namespace InnovationSoft.Olh.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
