
namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants
{
   /// <summary>
   /// Clear-Site-Data related constants.
   /// </summary>
   public static class ClearSiteDataConstants
   {
      /// <summary>
      /// The header value for Clear-Site-Data
      /// </summary>
      public const string Header = "Clear-Site-Data";

      /// <summary>
      /// Indicates that the server wishes to remove locally cached browser data for the origin of the response URL.
      /// </summary>
      /// <remarks>
      /// Depending on the browser, this might also clear out things like pre-rendered pages, script caches, WebGL shader caches, or address bar suggestions.
      /// </remarks>
      public const string Cache = "cache";

      /// <summary>
      /// Indicates that the server wishes to remove all DOM storage for the origin of the response URL.
      /// </summary>
      /// <remarks>
      /// Including localStorage, sessionStorage, Service worker registrations, IndexedDB, WebSQL, Plugin data, File System data.
      /// </remarks>
      public const string Storage = "storage";

      /// <summary>
      /// Indicates that the server wishes to remove all cookies for the origin of the response URL.
      /// </summary>
      /// <remarks>
      /// HTTP authentication credentials are also cleared out.
      /// This affects the entire registered domain, including subdomains.
      /// So https://example.com as well as https://stage.example.com, will have cookies cleared.
      /// </remarks>
      public const string Cookies = "cookies";

      /// <summary>
      /// Indicates that the server wishes to reload all browsing contexts for the origin of the response.
      /// </summary>
      public const string ExecutionContexts = "executionContexts";

      /// <summary>
      /// Indicates that the server wishes to clear all types of data for the origin of the response.
      /// </summary>
      /// <remarks>
      /// If more data types are added in future versions of this header, they will also be covered by it.
      /// </remarks>
      public const string All = "*";

   }
}
