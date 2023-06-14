using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      // https://arminreiter.com/2020/10/website-hardening-with-http-security-headers/

      /// <summary>
      /// No policy is allowed.
      /// </summary>
      public SecurityHeadersBuilder AddXPermittedCrossDomainPoliciesNone()
      {
         _policy.SetHeaders[XPermittedCrossDomainPoliciesConstants.Header] = XPermittedCrossDomainPoliciesConstants.None;
         return this;
      }

      /// <summary>
      /// Everything is allowed.
      /// </summary>
      public SecurityHeadersBuilder AddXPermittedCrossDomainPoliciesAll()
      {
         _policy.SetHeaders[XPermittedCrossDomainPoliciesConstants.Header] = XPermittedCrossDomainPoliciesConstants.All;
         return this;
      }

      /// <summary>
      /// Allow only the master policy.
      /// </summary>
      public SecurityHeadersBuilder AddXPermittedCrossDomainPoliciesMasterOnly()
      {
         _policy.SetHeaders[XPermittedCrossDomainPoliciesConstants.Header] = XPermittedCrossDomainPoliciesConstants.MasterOnly;
         return this;
      }

      /// <summary>
      /// Allow only a certain type of content. Example – XML
      /// </summary>
      public SecurityHeadersBuilder AddXPermittedCrossDomainPoliciesContentOnly()
      {
         _policy.SetHeaders[XPermittedCrossDomainPoliciesConstants.Header] = XPermittedCrossDomainPoliciesConstants.ByContentOnly;
         return this;
      }

      /// <summary>
      ///  Applicable only for an FTP server
      /// </summary>
      public SecurityHeadersBuilder AddXPermittedCrossDomainPoliciesFtpOnly()
      {
         _policy.SetHeaders[XPermittedCrossDomainPoliciesConstants.Header] = XPermittedCrossDomainPoliciesConstants.ByFtpOnly;
         return this;
      }





   }
}
