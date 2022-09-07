
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


        /// <summary>
        /// Frames Src Directive
        /// </summary>
        /// <remarks>
        /// Defines valid sources for loading frames.In CSP Level 2 frame-src was deprecated in favor of the child-src directive. 
        /// CSP Level 3, has undeprecated frame-src and it will continue to defer to child-src if not present.
        /// </remarks>
        IDirective Frame_Src { get; set; }

        /// <summary>
        /// Form Action Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 2 - Defines valid sources that can be used as an HTML{form} action.
        /// </remarks>
        IDirective Form_Action { get; set; }

        /// <summary>
        /// Base Uri Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 2 - Defines a set of allowed URLs which can be used in the src attribute of a HTML base tag.
        /// </remarks>
        IDirective Base_Uri { get; set; }

        /// <summary>
        /// Report To Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 3 - Defines a reporting group name defined by a Report-To HTTP response header. See the Reporting API for more info.
        /// </remarks>
        IDirective Report_To { get; set; }

        /// <summary>
        /// Worker Src Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 3 - Restricts the URLs which may be loaded as a Worker, SharedWorker or ServiceWorker.
        /// </remarks>
        IDirective Worker_Src { get; set; }

        /// <summary>
        /// Manifest Src Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 3 - Restricts the URLs that application manifests can be loaded.
        /// </remarks>
        IDirective Manifest_Src { get; set; }

        /// <summary>
        /// Prefetch Src Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 3 - Defines valid sources for request prefetch and prerendering, for example via the link tag with rel="prefetch" or rel="prerender":
        /// </remarks>
        IDirective Prefetch_Src { get; set; }

        /// <summary>
        /// Navigate To Directive
        /// </summary>
        /// <remarks>
        /// CSP Level 3 - Restricts the URLs that the document may navigate to by any means. 
        /// For example when a link is clicked, a form is submitted, or window.location is invoked. 
        /// If form-action is present then this directive is ignored for form submissions. Implementation Status
        /// </remarks>
        IDirective Navigate_To { get; set; }




    }

}
