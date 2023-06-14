using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      /// <summary>
      /// Add X-XSS-Protection 1 to all requests.
      /// Enables the XSS Protections
      /// </summary>
      public SecurityHeadersBuilder AddXssProtectionEnabled()
      {
         _policy.SetHeaders[XssProtectionConstants.Header] = XssProtectionConstants.Enabled;
         return this;
      }

      /// <summary>
      /// Add X-XSS-Protection 0 to all requests.
      /// Disables the XSS Protections offered by the user-agent.
      /// </summary>
      public SecurityHeadersBuilder AddXssProtectionDisabled()
      {
         _policy.SetHeaders[XssProtectionConstants.Header] = XssProtectionConstants.Disabled;
         return this;
      }

      /// <summary>
      /// Add X-XSS-Protection 1; mode=block to all requests.
      /// Enables XSS protections and instructs the user-agent to block the response in the event that script has been inserted from user input, instead of sanitizing.
      /// </summary>
      public SecurityHeadersBuilder AddXssProtectionBlock()
      {
         _policy.SetHeaders[XssProtectionConstants.Header] = XssProtectionConstants.Block;
         return this;
      }

      /// <summary>
      /// Add X-XSS-Protection 1; report=http://site.com/report to all requests.
      /// A partially supported directive that tells the user-agent to report potential XSS attacks to a single URL. Data will be POST'd to the report URL in JSON format.
      /// </summary>
      public SecurityHeadersBuilder AddXssProtectionReport(string reportUrl)
      {
         _policy.SetHeaders[XssProtectionConstants.Header] = string.Format(XssProtectionConstants.Report, reportUrl);
         return this;
      }




   }
}
