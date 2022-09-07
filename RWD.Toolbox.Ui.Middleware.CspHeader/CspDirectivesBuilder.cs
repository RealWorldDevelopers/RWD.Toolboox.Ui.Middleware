

namespace RWD.Toolbox.Ui.Middleware.CspHeader
{
    /// <summary>
    /// CSP Directives Builder
    /// </summary>
    public sealed class CspDirectivesBuilder
    {
        private readonly ICspDirectives _directives = new CspDirectives();

        internal CspDirectivesBuilder() { }

        /// <summary>
        /// Builder for Default Src
        /// </summary>
        public CspSourceBuilder Default_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Scripts Src
        /// </summary>
        public CspSourceBuilder Scripts_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Styles Src
        /// </summary>
        public CspSourceBuilder Styles_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Images Src
        /// </summary>
        public CspSourceBuilder Imgs_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Fonts Src
        /// </summary>
        public CspSourceBuilder Fonts_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Media Src
        /// </summary>
        public CspSourceBuilder Medias_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Objects Src
        /// </summary>
        public CspSourceBuilder Object_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Connections Src
        /// </summary>
        public CspSourceBuilder Connect_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Frames Src
        /// </summary>
        public CspSourceBuilder Frame_Ancestors { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Report Uri Src
        /// </summary>
        public string ReportUri { get; set; }
        /// <summary>
        /// Builder for Frame Src
        /// </summary>
        public CspSourceBuilder Frame_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Form Action
        /// </summary>
        public CspSourceBuilder Form_Action { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Base Uri
        /// </summary>
        public CspSourceBuilder Base_Uri { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Report To
        /// </summary>
        public CspSourceBuilder Report_To { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Worker Src
        /// </summary>
        public CspSourceBuilder Worker_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Manifest Src
        /// </summary>
        public CspSourceBuilder Manifest_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Prefetch Src
        /// </summary>
        public CspSourceBuilder Prefetch_Src { get; set; } = new CspSourceBuilder();

        /// <summary>
        /// Builder for Navigate To
        /// </summary>
        public CspSourceBuilder Navigate_To { get; set; } = new CspSourceBuilder();


        internal ICspDirectives Build()
        {
            _directives.Default_Src.Sources = Default_Src.Sources;
            _directives.Script_Src.Sources = Scripts_Src.Sources;
            _directives.Style_Src.Sources = Styles_Src.Sources;
            _directives.Img_Src.Sources = Imgs_Src.Sources;
            _directives.Font_Src.Sources = Fonts_Src.Sources;
            _directives.Media_Src.Sources = Medias_Src.Sources;
            _directives.Connect_Src.Sources = Connect_Src.Sources;
            _directives.Object_Src.Sources = Object_Src.Sources;
            _directives.Frame_Ancestors.Sources = Frame_Ancestors.Sources;
            _directives.ReportUri = ReportUri;

            _directives.Frame_Src.Sources = Frame_Src.Sources;
            _directives.Form_Action.Sources = Form_Action.Sources;
            _directives.Base_Uri.Sources = Base_Uri.Sources;
            _directives.Report_To.Sources = Report_To.Sources;
            _directives.Worker_Src.Sources = Worker_Src.Sources;
            _directives.Manifest_Src.Sources = Manifest_Src.Sources;
            _directives.Prefetch_Src.Sources = Prefetch_Src.Sources;
            _directives.Navigate_To.Sources = Navigate_To.Sources;

            return _directives;
        }
    }
}

