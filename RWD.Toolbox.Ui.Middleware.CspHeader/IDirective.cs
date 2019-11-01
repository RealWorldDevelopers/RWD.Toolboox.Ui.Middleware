using System.Collections.Generic;

namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
    /// <summary>
    /// CSP Directive
    /// </summary>
    public interface IDirective
    {
        /// <summary>
        /// CSP Directive Header Value
        /// </summary>
        string Header { get; set; }

        /// <summary>
        /// CSP Directive Source Value
        /// </summary>
        IList<string> Sources { get; set; }
    }
}
