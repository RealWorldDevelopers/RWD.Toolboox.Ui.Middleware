
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// Build the source list for a directive.
   /// </summary>
   public sealed class PermissionsPolicySourceBuilder
   {
      internal PermissionsPolicySourceBuilder() { }

      internal IList<string> Sources { get; set; } = new List<string>();
      internal string? Token { get; set; }

      /// <summary>
      /// Add 'self' as a token to the directive
      /// </summary>
      /// <remarks>
      /// The feature will be allowed in this document, and in all nested browsing contexts (iframes) in the same origin.
      /// The feature is not allowed in cross-origin documents in nested browsing contexts.
      /// </remarks>
      public PermissionsPolicySourceBuilder AllowSelf() => AllowToken("self");

      /// <summary>
      /// Add 'none' as a token to the directive
      /// </summary>
      /// <remarks>
      /// The feature is disabled in top-level and nested browsing contexts
      /// </remarks>
      public PermissionsPolicySourceBuilder AllowNone() => AllowToken("none");

      /// <summary>
      /// Add * as a token to the directive
      /// </summary>
      /// <remarks>
      /// Syntax: [FEATURE]=*
      /// Policy applied for all origins
      /// Example: geolocation=*
      /// </remarks>
      public PermissionsPolicySourceBuilder AllowAny() => AllowToken("*");

      /// <summary>
      /// Add empty as a token to the directive
      /// </summary>
      /// <remarks>
      /// Syntax: [FEATURE]=()
      /// Feature blocked for all origins
      /// Example: geolocation=()
      /// </remarks>
      public PermissionsPolicySourceBuilder BlockAny() => AllowToken("");

      /// <summary>
      /// Ad-hoc source value to the directive
      /// </summary>
      /// <param name="tokens">Token Value</param>
      public PermissionsPolicySourceBuilder AllowToken(string tokens)
      {
         Token = tokens;
         return this;
      }

      /// <summary>
      /// add origin value to the directive
      /// </summary>
      /// <param name="origin">Origin value</param>
      public PermissionsPolicySourceBuilder AddOrigin(string origin)
      {
         Sources.Add($" \"{origin}\"");
         return this;
      }

      /// <summary>
      /// Ad-hoc sources value to the directive 
      /// </summary>
      /// <param name="origins">Origin Values as <see cref="List{T}"/></param>
      public PermissionsPolicySourceBuilder AddOrigin(IEnumerable<string> origins)
      {
         foreach (var s in origins)
         { Sources.Add($" \"{s}\""); }
         return this;
      }

   }
}
