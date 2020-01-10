using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace src
{
    public class Function
    {
        private ILambdaConfiguration Configuration {get;}
        public Function()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Configuration = serviceProvider.GetService<ILambdaConfiguration>();
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILambdaConfiguration, LambdaConfiguration>();
        }
        
        public Message ToUpper(Message input, ILambdaContext context)
        {
            input.Upper();
            return input;
        }

        public Message ToLower(Message input,ILambdaContext context)
        {
            input.Lower();
            return input;
        }        
    }
}
