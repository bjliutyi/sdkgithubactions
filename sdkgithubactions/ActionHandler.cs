using Newtonsoft.Json;
using System;

namespace sdkgithubactions
{
    public static class ActionHandler
    {
        public static string Invoke()
        {
            Console.WriteLine("ActionHandler::Invoke is invoked");
            return JsonConvert.SerializeObject(DateTime.Now);
        }
    }
}
