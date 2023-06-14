
namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants
{
   /// <summary>
   /// Cross-Origin-Embedder-Policy related constants.
   /// </summary>
   public static class CrossOriginEmbedderPolicyConstants
   {

      /// <summary>
      /// The header value for Cross-Origin-Embedder-Policy (COEP)
      /// </summary>
      public const string Header = "Cross-Origin-Embedder-Policy";

      /// <summary>
      /// Allows the document to fetch cross-origin resources without giving explicit permission through the CORS protocol or the Cross-Origin-Resource-Policy header.
      /// </summary>
      public const string UnsafeNone = "unsafe-none";

      /// <summary>
      /// A document can only load resources from the same origin, or resources explicitly marked as loadable from another origin.
      /// </summary>
      /// <remarks>
      /// If a cross origin resource supports CORS, the cross origin attribute or the Cross-Origin-Resource-Policy header must be used to load it without being blocked by COEP.
      /// </remarks>
      public const string RequireCorp = "require-corp";


   }
}
