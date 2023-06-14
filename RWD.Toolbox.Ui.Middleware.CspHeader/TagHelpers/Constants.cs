
namespace RWD.Toolbox.Ui.Middleware.CspHeader.TagHelpers
{
   /// <summary>
   /// The algorithms available for CSP hashing
   /// </summary>
   public enum CSPHashType
   {
      /// <summary>
      /// Use the SHA256 algorithm for CSP hashing
      /// </summary>
      SHA256 = 0,

      /// <summary>
      /// Use the SHA384 for CSP hashing
      /// </summary>
      SHA384 = 1,

      /// <summary>
      /// Use the SHA512 for CSP hashing
      /// </summary>
      SHA512 = 2,
   }

   /// <summary>
   /// Various constant values used internally
   /// </summary>
   internal static class Constants
   {
      /// <summary>
      /// A key for the per-request nonce
      /// </summary>
      internal const string DefaultNonceKey = "NYCB_NONCE";

      /// <summary>
      /// The default number of bytes to use for generating a nonce
      /// </summary>
      internal const int DefaultBytesInNonce = 32;

      /// <summary>
      /// A key for per-request hashes for script-src
      /// </summary>
      internal const string DefaultScriptHashKey = "NYCB_HASHES_SCRIPT";

      /// <summary>
      /// A key for per-request hashes for styles-src
      /// </summary>
      internal const string DefaultStylesHashKey = "NYCB_HASHES_STYLES";

   }

}
