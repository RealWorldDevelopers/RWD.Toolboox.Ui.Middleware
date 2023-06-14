using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      // https://developer.mozilla.org/en-US/docs/Web/HTTP/Cross-Origin_Resource_Policy_(CORP)

      /// <summary>
      /// Only requests from the same origin (i.e. scheme + host + port) can read the resource.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginResourcePolicySameOrigin()
      {
         _policy.SetHeaders[CrossOriginResourcePolicyConstants.Header] = CrossOriginResourcePolicyConstants.SameOrigin;
         return this;
      }

      /// <summary>
      /// Requests from any origin (both same-site and cross-site) can read the resource. This is useful when COEP is used.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginResourcePolicyCrossOrigin()
      {
         _policy.SetHeaders[CrossOriginResourcePolicyConstants.Header] = CrossOriginResourcePolicyConstants.CrossOrigin;
         return this;
      }

      /// <summary>
      /// Only requests from the same Site can read the resource.
      /// </summary>
      public SecurityHeadersBuilder AddCrossOriginResourcePolicySameSite()
      {
         _policy.SetHeaders[CrossOriginResourcePolicyConstants.Header] = CrossOriginResourcePolicyConstants.SameSite;
         return this;
      }


   }
}
