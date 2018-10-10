using System;

namespace RunDomain
{
    public interface IAssemblyProxy : IDisposable
    {
        object ExecStaticMethod(string typeFullName, string methodName, object[] methodParams = null);
    }
}