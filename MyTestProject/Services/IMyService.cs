using System;

namespace MyTestProject.Services
{
    /// <summary>
    /// Service contract
    /// </summary>
    public interface IMyService
    {
        string Get(Guid id);
    }
}
