using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Victorium1p8.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Victorium1p8.Properties.Resources.resourceMan == null)
                    Victorium1p8.Properties.Resources.resourceMan = new ResourceManager("Victorium1p8.Properties.Resources", typeof(Victorium1p8.Properties.Resources).Assembly);
                return Victorium1p8.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => Victorium1p8.Properties.Resources.resourceCulture;
            set => Victorium1p8.Properties.Resources.resourceCulture = value;
        }
    }
}
