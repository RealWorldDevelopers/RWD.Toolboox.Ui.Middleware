
namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants
{
   /// <summary>
   /// Cross-Origin-Opener-Policy related constants.
   /// </summary>
   public static class CrossOriginOpenerPolicyConstants
   {
      /// <summary>
      /// The header value for Cross-Origin-Opener-Policy (COOP)
      /// </summary>
      public const string Header = "Cross-Origin-Opener-Policy";

      /// <summary>
      /// Allows the document to be added to its opener's browsing context group unless the opener itself has a COOP of same-origin or same-origin-allow-popups.
      /// </summary>
      public const string UnsafeNone = "unsafe-none";

      /// <summary>
      /// Isolates the browsing context exclusively to same-origin documents. 
      /// </summary>
      /// <remarks>
      /// Cross-origin documents are not loaded in the same browsing context.
      /// </remarks>
      public const string SameOriginAllowPopups = "same-origin-allow-popups";

      /// <summary>
      /// Retains references to newly opened windows or tabs that either don't set COOP or that opt out of isolation by setting a COOP of unsafe-none.
      /// </summary>
      public const string SameOrigin = "same-origin";


   }
}
