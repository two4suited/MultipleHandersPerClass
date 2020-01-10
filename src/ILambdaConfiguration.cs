
using Microsoft.Extensions.Configuration;

namespace src
{
    public interface ILambdaConfiguration
    {
         IConfiguration Configuration { get; }
    }
}