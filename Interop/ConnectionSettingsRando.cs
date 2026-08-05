using AccessRandomizer.Manager;
using ConnectionSettingsRando;

namespace AccessRandomizer.Interop
{
    internal static class CSR_Interop
    {
        public static void Hook()
        {
            CSR.Register(
            AccessRandomizer.Instance.GetName(),
            () => AccessManager.Settings,
            s => SettingsRandomizer.CopyTo(s, AccessManager.Settings));
        }
    }
}