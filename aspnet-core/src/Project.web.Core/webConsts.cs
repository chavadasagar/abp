using Project.web.Debugging;

namespace Project.web
{
    public class webConsts
    {
        public const string LocalizationSourceName = "web";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "22e282a085c04e36b99a59434d375520";
    }
}
