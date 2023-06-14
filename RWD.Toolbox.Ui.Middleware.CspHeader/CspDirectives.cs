
namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
   /// <inheritdoc/>
   public sealed class CspDirectives : ICspDirectives
   {
      /// <inheritdoc/>
      public IDirective DefaultSrc { get; set; } = new Directive { Header = "default-src" };

      /// <inheritdoc/>
      public IDirective ScriptSrc { get; set; } = new Directive { Header = "script-src" };
      /// <inheritdoc/>
      public IDirective ScriptSrcElem { get; set; } = new Directive { Header = "script-src-elem" };
      /// <inheritdoc/>
      public IDirective ScriptSrcAttr { get; set; } = new Directive { Header = "script-src-attr" };

      /// <inheritdoc/>
      public IDirective StyleSrc { get; set; } = new Directive { Header = "style-src" };
      /// <inheritdoc/>
      public IDirective StyleSrcElem { get; set; } = new Directive { Header = "style-src-elem" };
      /// <inheritdoc/>
      public IDirective StyleSrcAttr { get; set; } = new Directive { Header = "style-src-attr" };


      /// <inheritdoc/>
      public IDirective ImgSrc { get; set; } = new Directive { Header = "img-src" };

      /// <inheritdoc/>
      public IDirective FontSrc { get; set; } = new Directive { Header = "font-src" };

      /// <inheritdoc/>
      public IDirective MediaSrc { get; set; } = new Directive { Header = "media-src" };

      /// <inheritdoc/>
      public IDirective ObjectSrc { get; set; } = new Directive { Header = "object-src" };

      /// <inheritdoc/>
      public IDirective ConnectSrc { get; set; } = new Directive { Header = "connect-src" };

      /// <inheritdoc/>
      public IDirective FrameAncestors { get; set; } = new Directive { Header = "frame-ancestors" };

       /// <inheritdoc/>
      public IDirective FrameSrc { get; set; } = new Directive { Header = "frame-src" };

      /// <inheritdoc/>
      public IDirective FormAction { get; set; } = new Directive { Header = "form-action" };

      /// <inheritdoc/>
      public IDirective BaseUri { get; set; } = new Directive { Header = "base-uri" };

      /// <inheritdoc/>
      public IDirective ReportTo { get; set; } = new Directive { Header = "report-to" };

      /// <inheritdoc/>
      public IDirective WorkerSrc { get; set; } = new Directive { Header = "worker-src" };

      /// <inheritdoc/>
      public IDirective ManifestSrc { get; set; } = new Directive { Header = "manifest-src" };

      /// <inheritdoc/>
      public IDirective PrefetchSrc { get; set; } = new Directive { Header = "prefetch-src" };

      ///// <inheritdoc/>
      //public IDirective NavigateTo { get; set; } = new Directive { Header = "navigate-to" };

      /// <inheritdoc/>
      public IDirective UpgradeInsecureRequests { get; set; } = new Directive { Header = "upgrade-insecure-requests" };

   }

}
