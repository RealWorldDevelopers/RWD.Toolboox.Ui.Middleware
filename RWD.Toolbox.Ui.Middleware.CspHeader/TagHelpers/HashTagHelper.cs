using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace RWD.Toolbox.Ui.Middleware.CspHeader.TagHelpers
{
   /// <summary>
   /// Generates a Hash of the content of the script
   /// </summary>
   [HtmlTargetElement("script", Attributes = AttributeName)]
   [HtmlTargetElement("style", Attributes = AttributeName)]
   public class HashTagHelper : TagHelper
   {
      private const string AttributeName = "asp-add-content-to-csp";
      private const string CspHashTypeAttributeName = "csp-hash-type";


      /// <summary>
      /// Add a <code>nonce</code> attribute to the element
      /// </summary>
      [HtmlAttributeName(CspHashTypeAttributeName)]
      // ReSharper disable once InconsistentNaming
      public CSPHashType CSPHashType { get; set; } = CSPHashType.SHA256;


      /// <summary>
      /// Provides access to the <see cref="ViewContext"/>
      /// </summary>
      [ViewContext]
      public ViewContext ViewContext { get; set; }


      /// <inheritdoc />
      public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
      {
         Process(context, output);
         return Task.CompletedTask;
      }

      /// <inheritdoc />
      public override void Process(TagHelperContext context, TagHelperOutput output)
      {

         if (ViewContext is null)
         {
            throw new InvalidOperationException("ViewContext was null");
         }

         using var sha = CryptographyAlgorithms.Create(CSPHashType);
         var childContent = output.GetChildContentAsync().Result;

         // the hash is calculated based on unix line endings, not windows endings, so account for that
         var content = childContent.GetContent().Replace("\r\n", "\n");
         var contentBytes = Encoding.UTF8.GetBytes(content);
         var hashedBytes = sha.ComputeHash(contentBytes);
         var hash = Convert.ToBase64String(hashedBytes);

         output.Attributes.RemoveAll(AttributeName);
         output.Attributes.RemoveAll(CspHashTypeAttributeName);

         switch (context.TagName)
         {
            case "script":
               ViewContext.HttpContext.SetScriptCspHash(CSPHashType, hash);
               break;
            case "style":
               ViewContext.HttpContext.SetStylesCspHash(CSPHashType, hash);
               break;
            default:
               throw new InvalidOperationException("Unexpected tag name: " + context.TagName);
         }


      }

   }
}
