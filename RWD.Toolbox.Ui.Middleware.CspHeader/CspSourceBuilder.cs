
using System.Collections.Generic;


namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
   /// <summary>
   /// Build the source list for a directive.
   /// </summary>
   public sealed class CspSourceBuilder
   {
      internal CspSourceBuilder() { }

      internal IList<string> Sources { get; set; } = new List<string>();

      /// <summary>
      /// Add 'strict-dynamic' as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowStrictDynamic() => Allow("'strict-dynamic'");

      /// <summary>
      /// Add 'self' as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowSelf() => Allow("'self'");

      /// <summary>
      /// Add 'none' as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowNone() => Allow("'none'");

      /// <summary>
      /// Add * as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowAny() => Allow("*");

      /// <summary>
      /// Add data: as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowData() => Allow("data:");

      /// <summary>
      /// Add 'unsafe-inline' as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowUnsafeInline() => Allow("'unsafe-inline'");

      /// <summary>
      /// Add 'unsafe-eval' as a source to the directive
      /// </summary>
      public CspSourceBuilder AllowUnsafeEval() => Allow("'unsafe-eval'");

      /// <summary>
      /// Add 'nonce-key' as a source to the directive
      /// </summary>
      /// <param name="key">key value for the nonce source</param>
      public CspSourceBuilder AllowNonce(string key) => Allow($"'nonce-{key}'");

      /// <summary>
      /// Add 'nonce' from UI Tag Helpers
      /// </summary>
      public CspSourceBuilder AllowNonceTagHelper() => Allow($"'nonce-nonceValue'");

      /// <summary>
      /// Add 'hash' Manually
      /// </summary>
      /// <param name="algorithm">Which algorithm to use as <see cref="string"/></param>
      /// <param name="hash">Value of hash as <see cref="string"/></param>
      public CspSourceBuilder AllowHash(string algorithm, string hash)
      {
         Sources.Add($"'{algorithm}-{hash}'");
         return this;
      }

      /// <summary>
      /// Add 'hash' from UI Tag Helpers
      /// </summary>
      public CspSourceBuilder AllowHashTagHelper()
      {
         return this;
      }

            /// <summary>
      /// Ad-hoc source value to the directive
      /// </summary>
      /// <param name="source">Source Value</param>
      public CspSourceBuilder Allow(string source)
      {
         Sources.Add(source);
         return this;
      }

      /// <summary>
      /// Ad-hoc sources value to the directive 
      /// </summary>
      /// <param name="sources">Source Values</param>
      public CspSourceBuilder Allow(IEnumerable<string> sources)
      {
         foreach (var s in sources)
         { Sources.Add(s); }
         return this;
      }
   }

}
