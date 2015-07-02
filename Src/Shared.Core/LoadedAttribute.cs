using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.Core
{
    
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    public sealed class LoadedAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string _argsLoaded;

        // This is a positional argument
        public LoadedAttribute(string argsLoaded)
        {
            _argsLoaded = argsLoaded;
            MessageBox.Show("Assembly Loaded : " + _argsLoaded);
        }


    }
}
