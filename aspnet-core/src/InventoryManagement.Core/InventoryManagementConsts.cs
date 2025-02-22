using InventoryManagement.Debugging;

namespace InventoryManagement
{
    public class InventoryManagementConsts
    {
        public const string LocalizationSourceName = "InventoryManagement";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6859d9cf55c249268d5e01f3bc9212e8";
    }
}
