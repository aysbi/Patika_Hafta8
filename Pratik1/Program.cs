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

// Controller: MVC yap�s�nda i� mant���n� y�neten bir bile�endir. Kullan�c�dan gelen talepleri i�ler ve uygun bir View veya veri d�nd�r�r.

// Action: Controller i�indeki bir metottur. Her bir Action, belirli bir kullan�c� talebini i�ler ve sonucunda bir View d�nd�r�r veya i�lem yapar.

// Model: Uygulaman�n verilerini temsil eden s�n�flard�r. Veritaban� i�lemleri veya i� kurallar� i�in kullan�l�r.

// View: Kullan�c�ya g�sterilecek olan aray�z� temsil eder. HTML, CSS ve Razor kodlar�n� i�erebilir. Action'dan gelen veriler burada g�sterilir.

// Razor: .NET framework'�nde kullan�lan, HTML ile C# kodunu birle�tiren bir view motorudur. View'lerin dinamik olarak veri i�leyip g�stermesini sa�lar.

// RazorView: Razor dosyalar�n�n (.cshtml) i�lendi�i ve kullan�c�ya sunulan HTML ��kt�s�n� �reten yap�.

// wwwroot: Projenin statik dosyalar�n� (CSS, JavaScript, resimler vb.) i�eren klas�rd�r. Bu dosyalar do�rudan taray�c�ya sunulabilir.

// builder.Build(): Uygulama yap�land�rmas�n�n tamamlanmas�n� sa�lar ve uygulama nesnesini (`WebApplication`) olu�turur.

// app.Run(): Uygulamay� �al��t�r�r ve gelen HTTP isteklerini i�lemeye ba�lar.
