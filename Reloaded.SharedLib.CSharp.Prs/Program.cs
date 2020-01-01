using System;
using csharp_prs;
using csharp_prs_interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;

namespace Reloaded.SharedLib.CSharp.Prs
{
    public class Program : IMod, IExports
    {
        private IModLoader _modLoader;
        private IPrsInstance _prsInstance;

        public static void Main() { }
        public void Start(IModLoaderV1 loader)
        {
            _modLoader = (IModLoader)loader;

            /* Your mod code starts here. */
            _prsInstance = new PrsInstance();
            _modLoader.AddOrReplaceController(this, _prsInstance);
        }

        /* Mod loader actions. */
        public void Suspend() { }
        public void Resume()  { }
        public void Unload()  { }

        public bool CanUnload()  => false;
        public bool CanSuspend() => false;

        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing { get; }
        public Type[] GetTypes() => new[] { typeof(csharp_prs_interfaces.IPrsInstance) };
    }
}
