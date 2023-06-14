using RWD.Toolbox.Ui.Middleware.SecurityHeaders.Constants;

namespace RWD.Toolbox.Ui.Middleware.SecurityHeaders
{
   /// <summary>
   /// Exposes methods to build a policy.
   /// </summary>
   public partial class SecurityHeadersBuilder
   {

      /// <summary>
      /// Add X-Frame-Options DENY to all requests.
      /// The page cannot be displayed in a frame, regardless of the site attempting to do so
      /// </summary>
      public SecurityHeadersBuilder AddFrameOptionsDeny()
      {
         _policy.SetHeaders[FrameOptionsConstants.Header] = FrameOptionsConstants.Deny;
         return this;
      }

      /// <summary>
      /// Add X-Frame-Options SAMEORIGIN to all requests.
      /// The page can only be displayed in a frame on the same origin as the page itself.
      /// </summary>
      public SecurityHeadersBuilder AddFrameOptionsSameOrigin()
      {
         _policy.SetHeaders[FrameOptionsConstants.Header] = FrameOptionsConstants.SameOrigin;
         return this;
      }

      /// <summary>
      /// Add X-Frame-Options ALLOW-FROM {URI} to all requests, where the URI is provided
      /// The page can only be displayed in a frame on the specified origin.
      /// </summary>
      /// <param name="uri">The URI of the origin in which the page may be displayed in a frame</param>
      public SecurityHeadersBuilder AddFrameOptionsSameOrigin(string uri)
      {
         _policy.SetHeaders[FrameOptionsConstants.Header] = string.Format(FrameOptionsConstants.AllowFromUri, uri);
         return this;
      }


   }
}
