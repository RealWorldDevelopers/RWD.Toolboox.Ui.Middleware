
namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants
{
   /// <summary>
   /// X-Permitted-Cross-Domain-Policies related constants.
   /// </summary>
   public static class XPermittedCrossDomainPoliciesConstants
   {
      /// <summary>
      /// The header value for X-Permitted-Cross-Domain-Policies
      /// </summary>
      public const string Header = "X-Permitted-Cross-Domain-Policies";

      /// <summary>
      /// No policy is allowed.
      /// </summary>
      public const string None = "none";

      /// <summary>
      /// Allow only the master policy.
      /// </summary>
      public const string MasterOnly = "master-only";

      /// <summary>
      /// Everything is allowed.
      /// </summary>
      public const string All = "all";

      /// <summary>
      /// Allow only a certain type of content. Example – XML
      /// </summary>
      public const string ByContentOnly = "by-content-only";

      /// <summary>
      /// Applicable only for an FTP server
      /// </summary>
      public const string ByFtpOnly = "by-ftp-only";

   }
}
