using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {
      // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Cross-Origin-Opener-Policy

      /// <summary>
      /// Allows the document to be added to its opener's browsing context group unless the opener itself has a COOP of same-origin or same-origin-allow-popups.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginOpenerPolicyUnsafeNone()
      {
         _policy.SetHeaders[CrossOriginOpenerPolicyConstants.Header] = CrossOriginOpenerPolicyConstants.UnsafeNone;
         return this;
      }

      /// <summary>
      /// Retains references to newly opened windows or tabs that either don't set COOP or that opt out of isolation by setting a COOP of unsafe-none.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginOpenerPolicySameOrigin()
      {
         _policy.SetHeaders[CrossOriginOpenerPolicyConstants.Header] = CrossOriginOpenerPolicyConstants.SameOrigin;
         return this;
      }

      /// <summary>
      /// Isolates the browsing context exclusively to same-origin documents. 
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginOpenerPolicySameOriginAllowPopups()
      {
         _policy.SetHeaders[CrossOriginOpenerPolicyConstants.Header] = CrossOriginOpenerPolicyConstants.SameOriginAllowPopups;
         return this;
      }



   }
}
