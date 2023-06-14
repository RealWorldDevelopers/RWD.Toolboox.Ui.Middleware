
namespace RWD.Toolbox.Ui.Middleware.PermissionsPolicy
{
   /// <summary>
   /// Directive Portions of Permissions Policy
   /// </summary>
   public interface IPermissionsPolicyDirectives
   {
      /// <summary>
      /// Geolocation Src Directive
      /// </summary>
      IDirective Geolocation { get; set; }

      /// <summary>
      /// Midi Src Directive
      /// </summary>
      IDirective Midi { get; set; }

      /// <summary>
      /// Accelerometer Src Directive
      /// </summary>
      IDirective Accelerometer { get; set; }

      /// <summary>
      /// Autoplay Src Directive
      /// </summary>
      IDirective Autoplay { get; set; }

      /// <summary>
      /// SyncXhr Src Directive
      /// </summary>
      IDirective SyncXhr { get; set; }

      /// <summary>
      /// Microphone Src Directive
      /// </summary>
      IDirective Microphone { get; set; }

      /// <summary>
      /// Camera Src Directive
      /// </summary>
      IDirective Camera { get; set; }

      /// <summary>
      /// Magnetometer Src Directive
      /// </summary>
      IDirective Magnetometer { get; set; }

      /// <summary>
      /// Gyroscope Src Directive
      /// </summary>
      IDirective Gyroscope { get; set; }

      /// <summary>
      /// BlueTooth Src Directive
      /// </summary>
      IDirective BlueTooth { get; set; }

      /// <summary>
      /// PictureInPicture Src Directive
      /// </summary>
      IDirective PictureInPicture { get; set; }

      /// <summary>
      /// Serial Src Directive
      /// </summary>
      IDirective Serial { get; set; }

      /// <summary>
      /// Usb Src Directive
      /// </summary>
      IDirective Usb { get; set; }

      /// <summary>
      /// Fullscreen Src Directive
      /// </summary>
      IDirective Fullscreen { get; set; }

      /// <summary>
      /// PaymentRequest Src Directive
      /// </summary>
      IDirective Payment { get; set; }

      /// <summary>
      /// Collection of all IDirective Properties to verify if selected to be added
      /// </summary>
      IEnumerable<Directive> DirectiveList { get; }
   }
}
