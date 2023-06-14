using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Cross-Origin-Embedder-Policy

      /// <summary>
      /// Indicates that the server wishes to clear all types of data for the origin of the response.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginEmbedderPolicyUnsafeNone()
      {
         _policy.SetHeaders[CrossOriginEmbedderPolicyConstants.Header] = CrossOriginEmbedderPolicyConstants.UnsafeNone;
         return this;
      }

      /// <summary>
      /// Indicates that the server wishes to clear all types of data for the origin of the response.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginEmbedderPolicyRequireCorp()
      {
         _policy.SetHeaders[CrossOriginEmbedderPolicyConstants.Header] = CrossOriginEmbedderPolicyConstants.RequireCorp;
         return this;
      }


   }
}
