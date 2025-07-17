# 🛡️ Token Bazlı Kimlik Doğrulama ve Yetkilendirme - Katmanlı Mimari Projesi

Bu proje, .NET 9 ile **katmanlı mimari** kullanılarak geliştirilmiş bir **JWT token bazlı kimlik doğrulama ve yetkilendirme** sistemidir. Kullanıcı ve client girişleri için token üretimi, refresh token yönetimi, kullanıcı işlemleri ve basit ürün yönetimi gibi temel işlevleri içerir.

---

## 📁 Proje Yapısı

Proje aşağıdaki katmanlardan oluşmaktadır:

- **UdemyAuthServer.API**: API uç noktalarının yer aldığı ana uygulama
- **UdemyAuthServer.Core**: Entity ve Interface tanımları
- **UdemyAuthServer.Service**: Business Logic (Servis katmanı)
- **UdemyAuthServer.Data**: Repository ve EF Core işlemleri
- **SharedLibrary**: Ortak kullanılan DTO’lar, Response modelleri, hata yönetimi, token konfigürasyonları vb.

---

## 🔐 Özellikler

- ✅ JWT Token ile kimlik doğrulama
- 🔄 Refresh Token mekanizması
- 👤 ASP.NET Core Identity ile kullanıcı yönetimi
- 🧾 Katmanlı mimari (SOLID prensiplerine uygun)
- 🧪 FluentValidation ile giriş doğrulama
- 🔐 Client bazlı yetkilendirme
- 📦 Generic Repository & Unit of Work pattern kullanımı
- 🛠️ Swagger/OpenAPI desteği (isteğe bağlı)

---

🛠️ Kullanılan Teknolojiler
.NET 9

ASP.NET Core Identity

Entity Framework Core

SQL Server

AutoMapper

FluentValidation

JWT Bearer Authentication

Swagger (Swashbuckle)

Postman
Geliştirici
İrem Şentürk
