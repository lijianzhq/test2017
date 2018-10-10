using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace RunDomain
{
    /// <summary>
    /// Assembly代理类
    /// </summary>
    public class AssemblyProxy : MarshalByRefObject, IDisposable, IAssemblyProxy
    {
        private Assembly _assembly;

        protected AssemblyProxy(String assemblyString, String assemblyFile)
        {
            if (!String.IsNullOrEmpty(assemblyString))
                _assembly = Assembly.Load(assemblyString);
            else if (!String.IsNullOrEmpty(assemblyFile))
                _assembly = Assembly.LoadFrom(assemblyFile);
            else
                throw new ArgumentNullException("assemblyString,assemblyFile", "the two parameters of [assemblyString,assemblyFile] must provide one at least!");
        }

        public virtual Object ExecStaticMethod(String typeFullName, String methodName, Object[] methodParams = null)
        {
            var type = _assembly.GetType(typeFullName);
            MethodInfo method = null;
            if (methodParams == null)
            {
                method = type.GetMethod(methodName, new Type[0]);
            }
            else
            {
                method = type.GetMethod(methodName, GetParameterTypes(methodParams));
            }
            return method.Invoke(null, methodParams);
        }

        protected virtual Type[] GetParameterTypes(Object[] methodParams)
        {
            if (methodParams == null || methodParams.Length == 0) return null;
            var typeArray = new Type[methodParams.Length];
            for (var i = 0; i < methodParams.Length; i++)
            {
                typeArray[i] = methodParams[i].GetType();
            }
            return typeArray;
        }

        ~AssemblyProxy()
        {
            Dispose(true);
        }

        #region IDisposable 成员

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect(0);
            }
        }

        #endregion
    }
}
