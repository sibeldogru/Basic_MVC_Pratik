📦 Basic_MVC: Müşteri ve Sipariş Bilgi Sistemi

Bu proje, ASP.NET Core MVC mimarisi kullanılarak hazırlanmış basit bir müşteri ve sipariş görüntüleme uygulamasıdır. Uygulama, örnek verilerle bir müşterinin bilgilerini ve o müşteriye ait siparişleri listeleyen bir arayüz sunar.

📁 Proje Yapısı
pgsql
Kopyala
Düzenle
Basic_MVC/
│
├── Controllers/
│   └── CustomerOrdersController.cs
│
├── Models/
│   ├── Customer.cs
│   ├── Order.cs
│   └── CustomerOrderViewModel.cs
│
├── Views/
│   └── CustomerOrders/
│       └── Index.cshtml
│
└── Program.cs

🚀 Özellikler

MVC (Model-View-Controller) mimarisiyle geliştirilmiştir.

ViewModel kullanılarak müşteri ve sipariş bilgileri tek bir modelde birleştirilmiştir.

Razor view kullanılarak dinamik HTML sayfası oluşturulmuştur.

Örnek verilerle çalışır (veritabanı bağlantısı içermez).

