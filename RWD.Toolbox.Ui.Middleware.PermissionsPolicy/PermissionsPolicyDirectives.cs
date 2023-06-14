
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <inheritdoc/>
   public sealed class PermissionsPolicyDirectives : IPermissionsPolicyDirectives
   {
      /// <inheritdoc/>
      public IDirective Accelerometer { get; set; } = new Directive { Header = "accelerometer" };

      /// <inheritdoc/>
      public IDirective Autoplay { get; set; } = new Directive { Header = "autoplay" };

      /// <inheritdoc/>
      public IDirective BlueTooth { get; set; } = new Directive { Header = "bluetooth" };

      /// <inheritdoc/>
      public IDirective Geolocation { get; set; } = new Directive { Header = "geolocation" };

      /// <inheritdoc />
      public IDirective Midi { get; set; } = new Directive { Header = "midi" };

      /// <inheritdoc />
      public IDirective PictureInPicture { get; set; } = new Directive { Header = "picture-in-picture" };

      /// <inheritdoc />
      public IDirective Serial { get; set; } = new Directive { Header = "serial" };

      /// <inheritdoc />
      public IDirective SyncXhr { get; set; } = new Directive { Header = "sync-xhr" };

      /// <inheritdoc />
      public IDirective Microphone { get; set; } = new Directive { Header = "microphone" };

      /// <inheritdoc />
      public IDirective Camera { get; set; } = new Directive { Header = "camera" };

      /// <inheritdoc />
      public IDirective Magnetometer { get; set; } = new Directive { Header = "magnetometer" };

      /// <inheritdoc />
      public IDirective Gyroscope { get; set; } = new Directive { Header = "gyroscope" };

      /// <inheritdoc />
      public IDirective Usb { get; set; } = new Directive { Header = "usb" };

      /// <inheritdoc />
      public IDirective Fullscreen { get; set; } = new Directive { Header = "fullscreen" };

      /// <inheritdoc />
      public IDirective Payment { get; set; } = new Directive { Header = "payment" };

         /// <inheritdoc/>
      public IEnumerable<Directive> DirectiveList
      {
         get
         {
            return new Directive[]
            {
                (Directive)Accelerometer,
                (Directive)Autoplay,
                (Directive)BlueTooth,
                (Directive)Camera,
                (Directive)Fullscreen,
                (Directive)Geolocation,
                (Directive)Gyroscope,
                (Directive)Magnetometer,
                (Directive)Microphone,
                (Directive)Midi,
                (Directive)Payment,
                (Directive)PictureInPicture,
                (Directive)Serial,
                (Directive)SyncXhr,
                (Directive)Usb
            };
         }
      }
   }
}
