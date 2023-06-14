using Microsoft.AspNetCore.Http;
using RWD.Toolbox.Ui.Middleware.CspHeader.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
   /// <summary>
   /// An ASP.NET middleware for adding CSP header.
   /// </summary>
   public sealed class CspMiddleware
   {
      private const string POLICY_HEADER = "Content-Security-Policy";
      private readonly RequestDelegate _next;
      private readonly ICspDirectives _directives;
      private readonly bool _mustGenerateNonce;

      /// <summary>
      /// Instantiates a new <see cref="CspMiddleware"/>.
      /// </summary>
      /// <param name="next">The next middleware in the pipeline.</param>
      /// <param name="directives">An instance of <see cref="ICspDirectives"/>.</param>        
      public CspMiddleware(RequestDelegate next, ICspDirectives directives)
      {
         _next = next ?? throw new ArgumentNullException(nameof(next));
         _directives = directives ?? throw new ArgumentNullException(nameof(directives));
         _mustGenerateNonce = MustGenerateNonce(directives);
      }

      /// <summary>
      /// Invoke the middleware
      /// </summary>
      /// <param name="context">The current context</param>
      /// <returns></returns>
      public async Task Invoke(HttpContext context)
      {
         if (context == null)
            throw new ArgumentNullException(nameof(context));

         if (_mustGenerateNonce)
         {
            var nonceGenerator = new NonceGenerator();
            context.SetNonce(nonceGenerator.GetNonce(Constants.DefaultBytesInNonce));
         }


         context.Response.OnStarting(OnResponseStarting, context);
         await _next(context);
      }

      private Task OnResponseStarting(object state)
      {
         var context = (HttpContext)state;
         context.Response.Headers.Add(POLICY_HEADER, GetHeaderValue(context));
         return Task.CompletedTask;
      }

      /// <summary>
      /// Supportive Function to build Header Value
      /// </summary>
      private string GetHeaderValue(HttpContext context)
      {
         var nonceValue = context.GetNonce();
         var styleHashes = context.GetStyleCspHashes().ToList();
         var scriptHashes = context.GetScriptCspHashes().ToList();


         var value = string.Empty;
         value += GetDirective(_directives.DefaultSrc.Header, _directives.DefaultSrc.Sources, nonceValue);
         value += GetDirective(_directives.ScriptSrc.Header, _directives.ScriptSrc.Sources, nonceValue, scriptHashes);
         value += GetDirective(_directives.ScriptSrcElem.Header, _directives.ScriptSrc.Sources, nonceValue, scriptHashes);
         value += GetDirective(_directives.ScriptSrcAttr.Header, _directives.ScriptSrc.Sources, nonceValue, scriptHashes);
         value += GetDirective(_directives.StyleSrc.Header, _directives.StyleSrc.Sources, nonceValue, styleHashes);
         value += GetDirective(_directives.StyleSrcElem.Header, _directives.StyleSrc.Sources, nonceValue, styleHashes);
         value += GetDirective(_directives.StyleSrcAttr.Header, _directives.StyleSrc.Sources, nonceValue, styleHashes);
         value += GetDirective(_directives.ImgSrc.Header, _directives.ImgSrc.Sources, nonceValue);
         value += GetDirective(_directives.FontSrc.Header, _directives.FontSrc.Sources, nonceValue);
         value += GetDirective(_directives.MediaSrc.Header, _directives.MediaSrc.Sources, nonceValue);
         value += GetDirective(_directives.ObjectSrc.Header, _directives.ObjectSrc.Sources, nonceValue);
         value += GetDirective(_directives.ConnectSrc.Header, _directives.ConnectSrc.Sources, nonceValue);
         value += GetDirective(_directives.FrameAncestors.Header, _directives.FrameAncestors.Sources, nonceValue);

         value += GetDirective(_directives.FrameSrc.Header, _directives.FrameSrc.Sources, nonceValue);
         value += GetDirective(_directives.FormAction.Header, _directives.FormAction.Sources, nonceValue);
         value += GetDirective(_directives.BaseUri.Header, _directives.BaseUri.Sources, nonceValue);
         value += GetDirective(_directives.ReportTo.Header, _directives.ReportTo.Sources, nonceValue);
         value += GetDirective(_directives.WorkerSrc.Header, _directives.WorkerSrc.Sources, nonceValue);
         value += GetDirective(_directives.ManifestSrc.Header, _directives.ManifestSrc.Sources, nonceValue);
         value += GetDirective(_directives.PrefetchSrc.Header, _directives.PrefetchSrc.Sources, nonceValue);
         value += GetDirective(_directives.UpgradeInsecureRequests.Header, _directives.UpgradeInsecureRequests.Sources, nonceValue);
         
         return value;
      }

      /// <summary>
      /// Supportive Function to compile a directive for Header Value
      /// </summary>
      /// <param name="directive">Directive Name as <see cref="string"/></param>
      /// <param name="sources">List of acceptable sources as <see cref="IList{String}"/></param>
      /// <param name="nonceValue">Dynamic Value of Nonce as <see cref="IList{String}"/></param>
      /// <param name="hashValues">List of hashes as <see cref="IList{String}"/></param>
      /// <returns>Compiled directive as a <see cref="string"/></returns>
      private static string GetDirective(string directive, IList<string> sources, string nonceValue,
         IEnumerable<string> hashValues = null)
      {
         var src = new List<string>();
         sources.ToList().ForEach(s => src.Add(s.Replace("nonceValue", nonceValue)));

         if (hashValues != null)
            src.AddRange(hashValues);

         return sources.Count > 0 ? $"{directive} {string.Join(" ", src)}; " : "";

      }

      private static bool MustGenerateNonce(ICspDirectives directives)
      {
         if (directives.ScriptSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.StyleSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.ImgSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.FontSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.MediaSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.ObjectSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         if (directives.ConnectSrc.Sources.Any(s => s.Contains("nonce")))
            return true;

         return directives.ScriptSrc.Sources.Any(s => s.Contains("nonce"));

      }


   }

}
