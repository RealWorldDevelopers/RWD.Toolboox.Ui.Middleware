

namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
   /// <summary>
   /// CSP Directives Builder
   /// </summary>
   /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/Sources"/></remarks>
   public sealed class CspDirectivesBuilder
   {
      private readonly ICspDirectives _directives = new CspDirectives();

      internal CspDirectivesBuilder() { }

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) default-src directive serves as a fallback for the other CSP fetch directives.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/default-src"/></remarks>
      public CspSourceBuilder DefaultSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) script-src directive specifies valid sources for JavaScript.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/script-src"/></remarks>
      public CspSourceBuilder ScriptSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) script-src-elem directive specifies valid sources for JavaScript {script} elements.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/script-src-elem"/></remarks>
      public CspSourceBuilder ScriptSrcElem { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) script-src-attr directive specifies valid sources for JavaScript inline event handlers.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/script-src-attr"/></remarks>
      public CspSourceBuilder ScriptSrcAttr { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) style-src directive specifies valid sources for stylesheets.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src"/></remarks>
      public CspSourceBuilder StyleSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) style-src-elem directive specifies valid sources for stylesheet {style} elements and {link} elements with rel="stylesheet".
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src-elem"/></remarks>
      public CspSourceBuilder StyleSrcElem { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) style-src-attr directive specifies valid sources for inline styles applied to individual DOM elements.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/style-src-attr"/></remarks>
      public CspSourceBuilder StyleSrcAttr { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy img-src directive specifies valid sources of images and favicons.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/img-src"/></remarks>
      public CspSourceBuilder ImgSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) font-src directive specifies valid sources for fonts loaded using @font-face.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/font-src"/></remarks>
      public CspSourceBuilder FontSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) media-src directive specifies valid sources for loading media using the {audio} and {video} elements.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/media-src"/></remarks>
      public CspSourceBuilder MediaSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy object-src directive specifies valid sources for the {object}, {embed}, and {applet} elements.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/object-src"/></remarks>
      public CspSourceBuilder ObjectSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) connect-src directive restricts the URLs which can be loaded using script interfaces.
      /// </summary>
      /// <remarks><see href=""/>https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/connect-src</remarks>
      public CspSourceBuilder ConnectSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) frame-ancestors directive specifies valid parents that may embed a page using {frame}, {iframe}, {object}, {embed}, or {applet}.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/frame-ancestors"/></remarks>
      public CspSourceBuilder FrameAncestors { get; set; } = new CspSourceBuilder();

     
      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) frame-src directive specifies valid sources for nested browsing contexts loading using elements such as {frame} and {iframe}.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/frame-src"/></remarks>
      public CspSourceBuilder FrameSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) form-action directive restricts the URLs which can be used as the target of form submissions from a given context.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/form-action"/></remarks>
      public CspSourceBuilder FormAction { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy base-uri directive restricts the URLs which can be used in a document's {base} element.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/base-uri"/></remarks>
      public CspSourceBuilder BaseUri { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The Content-Security-Policy Report-To HTTP response header field instructs the user agent to store reporting endpoints for an origin.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/report-to"/></remarks>
      public CspSourceBuilder ReportTo { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) worker-src directive specifies valid sources for Worker, SharedWorker, or ServiceWorker scripts.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/worker-src"/></remarks>
      public CspSourceBuilder WorkerSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy: manifest-src directive specifies which manifest can be applied to the resource.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/manifest-src"/></remarks>
      public CspSourceBuilder ManifestSrc { get; set; } = new CspSourceBuilder();

      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) prefetch-src directive specifies valid resources that may be pre-fetched or pre-rendered.
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/prefetch-src"/></remarks>
      public CspSourceBuilder PrefetchSrc { get; set; } = new CspSourceBuilder();

     
      /// <summary>
      /// The HTTP Content-Security-Policy (CSP) upgrade-insecure-requests directive instructs user agents to treat all of a site's insecure URLs (those served over HTTP) as though they have been replaced with secure URLs (those served over HTTPS).
      /// </summary>
      /// <remarks><see href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy/upgrade-insecure-requests"/></remarks>
      public CspSourceBuilder UpgradeInsecureRequests { get; set; } = new CspSourceBuilder();


      internal ICspDirectives Build()
      {
         _directives.DefaultSrc.Sources = DefaultSrc.Sources;
         _directives.ScriptSrc.Sources = ScriptSrc.Sources;
         _directives.ScriptSrcElem.Sources = ScriptSrcElem.Sources;
         _directives.ScriptSrcAttr.Sources = ScriptSrcAttr.Sources;
         _directives.StyleSrc.Sources = StyleSrc.Sources;
         _directives.StyleSrcElem.Sources = StyleSrcElem.Sources;
         _directives.StyleSrcAttr.Sources = StyleSrcAttr.Sources;
         _directives.ImgSrc.Sources = ImgSrc.Sources;
         _directives.FontSrc.Sources = FontSrc.Sources;
         _directives.MediaSrc.Sources = MediaSrc.Sources;
         _directives.ConnectSrc.Sources = ConnectSrc.Sources;
         _directives.ObjectSrc.Sources = ObjectSrc.Sources;
         _directives.FrameAncestors.Sources = FrameAncestors.Sources;

         _directives.FrameSrc.Sources = FrameSrc.Sources;
         _directives.FormAction.Sources = FormAction.Sources;
         _directives.BaseUri.Sources = BaseUri.Sources;
         _directives.ReportTo.Sources = ReportTo.Sources;
         _directives.WorkerSrc.Sources = WorkerSrc.Sources;
         _directives.ManifestSrc.Sources = ManifestSrc.Sources;
         _directives.PrefetchSrc.Sources = PrefetchSrc.Sources;
         _directives.UpgradeInsecureRequests.Sources = UpgradeInsecureRequests.Sources;

         return _directives;
      }

   }
}

