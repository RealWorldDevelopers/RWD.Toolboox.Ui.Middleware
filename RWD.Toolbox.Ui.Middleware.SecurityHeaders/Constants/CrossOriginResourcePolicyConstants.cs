
namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants
{
   /// <summary>
   /// Cross-Origin-Resource-Policy related constants.
   /// </summary>
   public static class CrossOriginResourcePolicyConstants
   {
      /// <summary>
      /// The header value for Cross-Origin-Resource-Policy (CORP)
      /// </summary>
      public const string Header = "Cross-Origin-Resource-Policy";

      /// <summary>
      /// Allows the document to be added to its opener's browsing context group unless the opener itself has a COOP of same-origin or same-origin-allow-popups.
      /// </summary>
      public const string SameSite = "same-site";

      /// <summary>
      /// Isolates the browsing context exclusively to same-origin documents. 
      /// </summary>
      /// <remarks>
      /// Cross-origin documents are not loaded in the same browsing context.
      /// </remarks>
      public const string SameOrigin = "same-origin";

      /// <summary>
      /// Retains references to newly opened windows or tabs that either don't set COOP or that opt out of isolation by setting a COOP of unsafe-none.
      /// </summary>
      public const string CrossOrigin = "cross-origin";


   }
}
