using RWD.Toolbox.Ui.Middleware.SecurityHeaders;
using RWD.Toolbox.Ui.Middleware.CspHeader;
using RWD.Toolbox.Ui.Middleware.PermissionsPolicy;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// security header
app.UseSecurityHeadersMiddleware(new SecurityHeadersBuilder()
   .AddDefaultSecurePolicy()
   .AddStrictTransportSecurity()
   );

// CSP header
app.UseCspMiddleware(builder =>
{
    builder.UpgradeInsecureRequests.Allow("");
    builder.DefaultSrc.AllowNone();

    // todo allow nonce and hash
    builder.ScriptSrc.AllowNonceTagHelper().AllowHashTagHelper();
    builder.ScriptSrcElem.AllowNonceTagHelper().AllowHashTagHelper();
    builder.ScriptSrcAttr.AllowNonceTagHelper().AllowHashTagHelper();

    builder.StyleSrc.Allow("https://localhost:*");
    builder.StyleSrcElem.AllowNone();
    builder.StyleSrcAttr.AllowNone();
    builder.FontSrc.AllowNone();
    builder.ImgSrc.AllowNone();
    builder.ManifestSrc.AllowNone();
    builder.MediaSrc.AllowNone();
    builder.ConnectSrc.AllowNone();
    builder.ObjectSrc.AllowNone();
    builder.FrameAncestors.AllowNone();
    builder.FrameSrc.AllowNone();
    builder.WorkerSrc.AllowNone();
    builder.PrefetchSrc.AllowNone();

});

// permissions policy header
app.UsePermissionsPolicyMiddleware(opt =>
{
    opt.Accelerometer.AllowSelf();
    opt.Autoplay.AllowSelf();
    opt.BlueTooth.AllowSelf();
    opt.Camera.AllowSelf();
    opt.Fullscreen.AllowSelf();
    opt.Geolocation.AllowSelf();
    opt.Gyroscope.AllowNone();
    opt.Magnetometer.AllowNone();
    opt.Microphone.AllowSelf();
    opt.Midi.AllowSelf();
    opt.Payment.AllowSelf();
    opt.PictureInPicture.AllowSelf();
    opt.Serial.AllowSelf();
    opt.SyncXhr.AllowSelf();
    opt.Usb.AllowSelf();

});




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
