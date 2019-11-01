
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
        IDirective Default_Src { get; set; }

        /// <summary>
        /// Script Src Directive
        /// </summary>
        IDirective Script_Src { get; set; }

        /// <summary>
        /// Style Src Directive
        /// </summary>
        IDirective Style_Src { get; set; }

        /// <summary>
        /// Image Src Directive
        /// </summary>
        IDirective Img_Src { get; set; }

        /// <summary>
        /// Font Src Directive
        /// </summary>
        IDirective Font_Src { get; set; }

        /// <summary>
        /// Media Src Directive
        /// </summary>
        IDirective Media_Src { get; set; }

        /// <summary>
        /// Object Src Directive
        /// </summary>
        IDirective Object_Src { get; set; }

        /// <summary>
        /// Connection Src Directive
        /// </summary>
        IDirective Connect_Src { get; set; }

        /// <summary>
        /// Frames Src Directive
        /// </summary>
        IDirective Frame_Ancestors { get; set; }

        /// <summary>
        /// Reporting Uri Src Directive
        /// </summary>
        string ReportUri { get; set; }
    }

}
