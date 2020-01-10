using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace src
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
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
    public class Message
    {
        public string key1 { get; set; }
        public void Upper()
        {
            key1 = key1.ToUpper();
        }
        public void Lower()
        {
            key1 = key1.ToLower();
        }
    }
}
