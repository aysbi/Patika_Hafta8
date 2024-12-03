var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute (
        name : "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.Run();

// Controller: MVC yapýsýnda iþ mantýðýný yöneten bir bileþendir. Kullanýcýdan gelen talepleri iþler ve uygun bir View veya veri döndürür.

// Action: Controller içindeki bir metottur. Her bir Action, belirli bir kullanýcý talebini iþler ve sonucunda bir View döndürür veya iþlem yapar.

// Model: Uygulamanýn verilerini temsil eden sýnýflardýr. Veritabaný iþlemleri veya iþ kurallarý için kullanýlýr.

// View: Kullanýcýya gösterilecek olan arayüzü temsil eder. HTML, CSS ve Razor kodlarýný içerebilir. Action'dan gelen veriler burada gösterilir.

// Razor: .NET framework'ünde kullanýlan, HTML ile C# kodunu birleþtiren bir view motorudur. View'lerin dinamik olarak veri iþleyip göstermesini saðlar.

// RazorView: Razor dosyalarýnýn (.cshtml) iþlendiði ve kullanýcýya sunulan HTML çýktýsýný üreten yapý.

// wwwroot: Projenin statik dosyalarýný (CSS, JavaScript, resimler vb.) içeren klasördür. Bu dosyalar doðrudan tarayýcýya sunulabilir.

// builder.Build(): Uygulama yapýlandýrmasýnýn tamamlanmasýný saðlar ve uygulama nesnesini (`WebApplication`) oluþturur.

// app.Run(): Uygulamayý çalýþtýrýr ve gelen HTTP isteklerini iþlemeye baþlar.
