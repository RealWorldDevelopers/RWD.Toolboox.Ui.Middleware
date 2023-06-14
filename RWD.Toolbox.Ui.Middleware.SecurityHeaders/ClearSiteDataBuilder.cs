using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      // https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Clear-Site-Data

      /// <summary>
      /// Indicates that the server wishes to remove locally cached browser data for the origin of the response URL.
      /// </summary>
      public SecurityHeadersBuilder AddClearSiteDataConstantsCache()
      {
         _policy.SetHeaders[ClearSiteDataConstants.Header] = ClearSiteDataConstants.Cache;
         return this;
      }

      /// <summary>
      /// Indicates that the server wishes to remove all cookies for the origin of the response URL.
      /// </summary>
      public SecurityHeadersBuilder AddClearSiteDataConstantsCookies()
      {
         _policy.SetHeaders[ClearSiteDataConstants.Header] = ClearSiteDataConstants.Cookies;
         return this;
      }

      /// <summary>
      /// Indicates that the server wishes to reload all browsing contexts for the origin of the response.
      /// </summary>
      public SecurityHeadersBuilder AddClearSiteDataConstantsExecutionContexts()
      {
         _policy.SetHeaders[ClearSiteDataConstants.Header] = ClearSiteDataConstants.ExecutionContexts;
         return this;
      }

      /// <summary>
      /// Indicates that the server wishes to remove all DOM storage for the origin of the response URL.
      /// </summary>
      public SecurityHeadersBuilder AddClearSiteDataConstantsStorage()
      {
         _policy.SetHeaders[ClearSiteDataConstants.Header] = ClearSiteDataConstants.Storage;
         return this;
      }

      /// <summary>
      /// Indicates that the server wishes to clear all types of data for the origin of the response.
      /// </summary>
      public SecurityHeadersBuilder AddClearSiteDataConstantsAll()
      {
         _policy.SetHeaders[ClearSiteDataConstants.Header] = ClearSiteDataConstants.All;
         return this;
      }


   }
}
