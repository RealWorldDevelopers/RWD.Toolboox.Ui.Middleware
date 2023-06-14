using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {


      /// <summary>
      /// Add Referrer-Policy No_Referrer to all requests.
      /// The Referrer header will be omitted entirely. No referrer information is sent along with requests.
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyNoReferrer()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.NoReferrer;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy No_Referrer_When_Downgrade to all requests.
      /// This is the user agent's default behavior if no policy is specified. 
      /// The URL is sent as a referrer when the protocol security level stays the same (HTTP→HTTP, HTTPS→HTTPS), 
      /// but isn't sent to a less secure destination (HTTPS→HTTP).
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyNoReferrerWhenDowngrade()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.NoReferrerWhenDowngrade;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Origin to all requests.
      /// Only send the origin of the document as the referrer in all cases. 
      /// The document https://example.com/page.html will send the referrer https://example.com/.
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyOrigin()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.Origin;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Origin_When_Cross_Origin to all requests.
      /// Send a full URL when performing a same-origin request, but only send the origin of the document for other cases.
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyOriginWhenCrossOrigin()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.OriginWhenCrossOrigin;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Same_Origin to all requests.
      /// A referrer will be sent for same-site origins, but cross-origin requests will contain no referrer information.
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicySameOrigin()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.SameOrigin;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Strict_Origin to all requests.
      /// Only send the origin of the document as the referrer when the protocol security level stays the same (HTTPS→HTTPS), 
      /// but don't send it to a less secure destination (HTTPS→HTTP).
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyStrictOrigin()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.StrictOrigin;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Strict_Origin_When_Cross_Origin to all requests.
      /// Send a full URL when performing a same-origin request, only send the origin when the protocol security level stays the same (HTTPS→HTTPS), 
      /// and send no header to a less secure destination (HTTPS→HTTP).
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyStrictOriginWhenCrossOrigin()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.StrictOriginWhenCrossOrigin;
         return this;
      }

      /// <summary>
      /// Add Referrer-Policy Unsafe_Url to all requests.
      /// Send a full URL when performing a same-origin or cross-origin request. 
      /// This policy will leak origins and paths from TLS-protected resources to insecure origins. 
      /// Carefully consider the impact of this setting.
      /// </summary>
      public SecurityHeadersBuilder AddReferrerPolicyUnsafeUrl()
      {
         _policy.SetHeaders[ReferrerPolicyConstants.Header] = ReferrerPolicyConstants.UnsafeUrl;
         return this;
      }



   }
}
