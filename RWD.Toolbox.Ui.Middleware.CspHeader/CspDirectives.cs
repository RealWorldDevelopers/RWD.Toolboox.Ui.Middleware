
namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
    /// <inheritdoc/>
    public sealed class CspDirectives : ICspDirectives
    {        
        /// <inheritdoc/>
        public IDirective Default_Src { get; set; } = new Directive { Header = "default-src" };

        /// <inheritdoc/>
        public IDirective Script_Src { get; set; } = new Directive { Header = "script-src" };

        /// <inheritdoc/>
        public IDirective Style_Src { get; set; } = new Directive { Header = "style-src" };

        /// <inheritdoc/>
        public IDirective Img_Src { get; set; } = new Directive { Header = "img-src" };

        /// <inheritdoc/>
        public IDirective Font_Src { get; set; } = new Directive { Header = "font-src" };

        /// <inheritdoc/>
        public IDirective Media_Src { get; set; } = new Directive { Header = "media-src" };

        /// <inheritdoc/>
        public IDirective Object_Src { get; set; } = new Directive { Header = "object-src" };

        /// <inheritdoc/>
        public IDirective Connect_Src { get; set; } = new Directive { Header = "connect-src" };

        /// <inheritdoc/>
        public IDirective Frame_Ancestors { get; set; } = new Directive { Header = "frame-ancestors" };

        /// <inheritdoc/>
        public string ReportUri { get; set; }
    }

}
