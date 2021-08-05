using System;

namespace MyTestProject.Services
{
    /// <summary>
    /// Service implementation
    /// </summary>
    public class MyService : IMyService
    {
        public string Get(Guid id) => id.ToString();
    }
}
