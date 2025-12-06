using Microsoft.Win32;
using Shambles.Interface;
using System;

namespace Shambles
{
    internal class WindowRegistry : IWindowRegistry
    {
        private RegistryKey _softwareKey;
        private RegistryKey _appKey;
        private bool _disposed = false;

        public WindowRegistry() 
        {
            _softwareKey= Registry.CurrentUser.OpenSubKey("Software", true);
            _appKey= _softwareKey.CreateSubKey("Shambles", true);
        }

        public void SetValue( string valueName, object value)
        {
            _appKey.SetValue(valueName, value);
        }

        public object GetValue(string valueName, object defaultValue)
        {
            return _appKey.GetValue(valueName, defaultValue);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }
                _appKey.Close();
                _softwareKey.Close();
                _disposed = true;
            }
        }
    }
}
