
using Microsoft.AspNetCore.Builder;

namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// The <see cref="IApplicationBuilder"/> extensions for adding Permissions Policy middleware support.
   /// </summary>
   public static class PermissionsPolicyMiddlewareExtensions
   {
      /// <summary>
      /// Adds middleware to your web application pipeline to automatically add PermissionsPolicy headers to requests
      /// </summary>
      /// <param name="app">The IApplicationBuilder passed to your Configure method</param>
      /// <param name="builder">A configured policy builder to build a policy.</param>
      /// <returns>The original app parameter</returns>
      public static IApplicationBuilder UsePermissionsPolicyMiddleware(this IApplicationBuilder app, Action<PermissionsPolicyDirectivesBuilder> builder)
      {
         if (app == null)
            throw new ArgumentNullException(nameof(app));

         if (builder == null)
            throw new ArgumentNullException(nameof(builder));

         var newBuilder = new PermissionsPolicyDirectivesBuilder();
         builder(newBuilder);

         var options = newBuilder.Build();
         return app.UseMiddleware<PermissionsPolicyMiddleware>(options);

      }
   }
}
