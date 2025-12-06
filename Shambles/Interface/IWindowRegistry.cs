using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shambles.Interface
{
    public interface IWindowRegistry : IDisposable
    {
        object GetValue(string valueName, object defaultValue);
        void SetValue(string valueName, object value);
    }
}
