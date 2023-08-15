# BillingSystemProject

BillingSystemProject, n-tier mimarisi ve nesne tabanlı programlama prensiplerine dayalı olarak geliştirilmiş kapsamlı bir uygulamadır. Faturalama ve fatura yönetimi süreçlerini verimli ve düzenli bir şekilde yönetmeyi sağlar.

## İçindekiler

- [Proje Hakkında](#proje-hakkında)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Katmanlar](#katmanlar)
- [Kütüphaneler ve NuGet Paketleri](#kütüphaneler-ve-nuget-paketleri)
- [Prensipler ve Uygulamalar](#prensipler-ve-uygulamalar)

## Proje Hakkında

BillingSystemProject, n-tier mimarisini benimseyerek oluşturulmuş bir fatura ve fatura yönetimi uygulamasıdır. Projeyi ayrı katmanlara bölmek, modüler, bakımı kolay ve ölçeklenebilir bir kod tabanı sağlar.

## Kullanılan Teknolojiler

BillingSystemProject, aşağıdaki teknolojileri kullanmaktadır:

- Asp.Net Core 6.0
- Entity Framework Core
- SQL Server
- Autofac
- FluentValidation

## Katmanlar

BillingSystemProject, aşağıdaki katmanlardan oluşmaktadır:

- **BillingSystemProject.Business:** İş kurallarını uygulayan bu katman, temel iş mantığı operasyonlarını gerçekleştirir. Autofac bağımlılık çözücü ve AOP (Aspect-Oriented Programming) prensipleri kullanır.FluentValidation geçerlilik kuralları kullanırarak geliştirilmiştir.
- **BillingSystemProject.Core:** Bu temel katman, iş mantığı bileşenlerini içerir. Modelleri, servisleri, DTO'ları (Veri Aktarma Nesneleri) ve repository arayüzlerini içerir.
- **BillingSystemProject.DataAccess:** Veritabanı erişim işlemlerinden sorumlu olan bu katman, veritabanıyla etkileşimde bulunur. Entity Framework Core'u kullanarak bağlantıyı ve CRUD işlemlerini yönetir.
- **BillingSystemProject.Entities:** Bu katman, projede kullanılan varlık modellerini tanımlar. Uygulamanın işlediği veri yapılarını kapsar.
- **BillingSystemProject.WebApi:** Kullanıcı arayüzünü sunan web API katmanı, gelen istekleri işler, ilgili iş mantığı işlemlerini çağırır ve uygun yanıtları döndürür.

## Kütüphaneler ve NuGet Paketleri

Proje, aşağıdaki kütüphaneleri ve NuGet paketlerini kullanmaktadır:

- Autofac: Bağımlılık enjeksiyonunu uygulamak ve bileşen ömürlerini yönetmek için.
- Autofac.Extensions.DependencyInjection: Asp.Net Core bağımlılık enjeksiyonunu Autofac ile entegre etmek için.
- Autofac.Extras.DynamicProxy: Dinamik proxy'leri kullanarak AOP (Aspect-Oriented Programming) prensiplerini uygulamak için.
- FluentValidation: Düzgün doğrulama kurallarını kullanarak girdi verilerini doğrulamak için.
- Microsoft.AspNetCore.Authentication.JwtBearer: JWT tabanlı kimlik doğrulamasını uygulamak için.
- Microsoft.AspNetCore.Http: HTTP isteklerini ve yanıtlarını yönetmek için.
- Microsoft.AspNetCore.Mvc: Denetleyiciler oluşturmak ve HTTP tabanlı etkileşimleri yönetmek için.
- Microsoft.EntityFrameworkCore.SqlServer: SQL Server veritabanlarına bağlanmak ve etkileşimde bulunmak için.
- Microsoft.Extensions.Configuration.Binder: Yapılandırma ayarlarını nesnelere bağlamak için.
- Swashbuckle.AspNetCore: Swagger UI'yi entegre ederek API'ları belgelemek ve keşfetmek için.

## Prensipler ve Uygulamalar

BillingSystemProject, nesne tabanlı programlama (OOP) prensipleri, yönetsel programlama (AOP) prensipleri, temiz kod uygulamaları, SOLID prensipleri ve diğer sektör standartları izleyerek geliştirilmiştir. Bu, bakımı yapılabilir, genişletilebilir ve sağlam bir kod tabanını sağlarken sorunları ayırır ve kod yeniden kullanılabilirliğini teşvik eder.

İyi yapılandırılmış bir n-tier mimarisini benimseyerek ve bu prensiplere uyarak, BillingSystemProject, fatura ve fatura yönetimi süreçlerini verimli bir şekilde yönetmek için kullanıcı dostu bir çözüm sunar.


