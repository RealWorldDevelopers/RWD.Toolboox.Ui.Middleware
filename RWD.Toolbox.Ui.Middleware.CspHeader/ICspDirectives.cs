
namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
   /// <summary>
   /// Directive Portions of CSP
   /// </summary>
   public interface ICspDirectives
   {
      /// <summary>
      /// Default Src Directive
      /// </summary>
      IDirective DefaultSrc { get; set; }

      /// <summary>
      /// Script Src Directive
      /// </summary>
      IDirective ScriptSrc { get; set; }

      /// <summary>
      /// Script Src Element Directive
      /// </summary>
      IDirective ScriptSrcElem { get; set; }

      /// <summary>
      /// Script Src Attribute Directive
      /// </summary>
      IDirective ScriptSrcAttr { get; set; }


      /// <summary>
      /// Style Src Directive
      /// </summary>
      IDirective StyleSrc { get; set; }

      /// <summary>
      /// Style Src Element Directive
      /// </summary>
      IDirective StyleSrcElem { get; set; }

      /// <summary>
      /// Style Src Attribute Directive
      /// </summary>
      IDirective StyleSrcAttr { get; set; }

      /// <summary>
      /// Image Src Directive
      /// </summary>
      IDirective ImgSrc { get; set; }

      /// <summary>
      /// Font Src Directive
      /// </summary>
      IDirective FontSrc { get; set; }

      /// <summary>
      /// Media Src Directive
      /// </summary>
      IDirective MediaSrc { get; set; }

      /// <summary>
      /// Object Src Directive
      /// </summary>
      IDirective ObjectSrc { get; set; }

      /// <summary>
      /// Connection Src Directive
      /// </summary>
      IDirective ConnectSrc { get; set; }

      /// <summary>
      /// Frames Src Directive
      /// </summary>
      IDirective FrameAncestors { get; set; }

      /// <summary>
      /// Frames Src Directive
      /// </summary>
      /// <remarks>
      /// Defines valid sources for loading frames.In CSP Level 2 frame-src was deprecated in favor of the child-src directive. 
      /// CSP Level 3, has undeprecated frame-src and it will continue to defer to child-src if not present.
      /// </remarks>
      IDirective FrameSrc { get; set; }

      /// <summary>
      /// Form Action Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 2 - Defines valid sources that can be used as an HTML{form} action.
      /// </remarks>
      IDirective FormAction { get; set; }

      /// <summary>
      /// Base Uri Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 2 - Defines a set of allowed URLs which can be used in the src attribute of a HTML base tag.
      /// </remarks>
      IDirective BaseUri { get; set; }

      /// <summary>
      /// Report To Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 3 - Defines a reporting group name defined by a Report-To HTTP response header. See the Reporting API for more info.
      /// </remarks>
      IDirective ReportTo { get; set; }

      /// <summary>
      /// Worker Src Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 3 - Restricts the URLs which may be loaded as a Worker, SharedWorker or ServiceWorker.
      /// </remarks>
      IDirective WorkerSrc { get; set; }

      /// <summary>
      /// Manifest Src Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 3 - Restricts the URLs that application manifests can be loaded.
      /// </remarks>
      IDirective ManifestSrc { get; set; }

      /// <summary>
      /// Prefetch Src Directive
      /// </summary>
      /// <remarks>
      /// CSP Level 3 - Defines valid sources for request prefetch and prerendering, for example via the link tag with rel="prefetch" or rel="prerender":
      /// </remarks>
      IDirective PrefetchSrc { get; set; }

      ///// <summary>
      ///// Navigate To Directive
      ///// </summary>
      ///// <remarks>
      ///// CSP Level 3 - Restricts the URLs that the document may navigate to by any means. 
      ///// For example when a link is clicked, a form is submitted, or window.location is invoked. 
      ///// If form-action is present then this directive is ignored for form submissions. Implementation Status
      ///// </remarks>
      //IDirective NavigateTo { get; set; }

      /// <summary>
      /// Upgrade Insecure Requests Directive
      /// </summary>
      /// <remarks>
      /// The HTTP Upgrade-Insecure-Requests request header sends a signal to the server expressing the client's preference for an encrypted
      /// and authenticated response, and that it can successfully handle the upgrade-insecure-requests CSP directive.
      /// </remarks>
      IDirective UpgradeInsecureRequests { get; set; }


   }

}
