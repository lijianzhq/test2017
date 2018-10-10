using System;
using System.Reflection;

namespace RunDomain
{
    public class AssemblyLoader : IDisposable
    {
        private AppDomain _innerDomain = null;
        private Boolean _hasDisposed = false;
        private String _execDomainName = String.Empty;
        public delegate void DomainUnhandledEventHandler(Object sender, Exception e);
        public event DomainUnhandledEventHandler DomainUnhandledException;

        /// <summary>
        /// 执行当前调用的程序域的名称
        /// </summary>
        public String ExecDomainName
        {
            get
            {
                return _execDomainName;
            }
        }

        public AssemblyLoader(String loaderName)
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ShadowCopyFiles = "true";
            _execDomainName = loaderName;
            _innerDomain = AppDomain.CreateDomain(loaderName, null, setup);
            _innerDomain.UnhandledException += new UnhandledExceptionEventHandler(_innerDomain_UnhandledException);
        }

        void _innerDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (DomainUnhandledException != null)
                DomainUnhandledException.Invoke(this, e.ExceptionObject as Exception);
        }

        public virtual IAssemblyProxy Load(String assemblyString)
        {
            ThrowsIfDisposed();
            var inputParams = new String[] { assemblyString, "" };
            return (IAssemblyProxy)_innerDomain.CreateInstanceFromAndUnwrap(typeof(AssemblyProxy).Assembly.Location,
                                                                            typeof(AssemblyProxy).FullName,
                                                                            false,
                                                                            BindingFlags.Instance | BindingFlags.NonPublic,
                                                                            null,
                                                                            inputParams,
                                                                            null,
                                                                            null);
        }
        public virtual IAssemblyProxy LoadFrom(String assemblyFile)
        {
            ThrowsIfDisposed();
            var inputParams = new String[] { "", assemblyFile };
            return (IAssemblyProxy)_innerDomain.CreateInstanceFromAndUnwrap(typeof(AssemblyProxy).Assembly.Location,
                                                                            typeof(AssemblyProxy).FullName,
                                                                            false,
                                                                            BindingFlags.Instance | BindingFlags.NonPublic,
                                                                            null,
                                                                            inputParams,
                                                                            null,
                                                                            null);
        }

        public void Unload()
        {
            Dispose(true);
        }

        ~AssemblyLoader()
        {
            Dispose(false);
        }

        #region IDisposable 成员

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

        protected virtual void ThrowsIfDisposed()
        {
            if (_hasDisposed) throw new Exception("loader has been disposed!");
        }

        protected virtual void Dispose(bool disposing)
        {
            _hasDisposed = true;
            if (disposing) AppDomain.Unload(_innerDomain);
        }
    }
}
