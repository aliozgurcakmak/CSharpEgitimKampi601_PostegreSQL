# PostgreSQL Tabanlı Müşteri ve Çalışan Yönetim Sistemi

## Proje Hakkında
Bu proje, PostgreSQL kullanarak geliştirilen basit bir Müşteri ve Çalışan Yönetim Sistemi uygulamasıdır. Uygulama, kullanıcıların müşteri ve çalışan bilgilerini kolayca ekleyip, silebileceği, güncelleyebileceği ve listeleyebileceği bir ortam sunuyor. Windows Forms üzerinde geliştirilmiş olan bu sistem, PostgreSQL ile veri yönetimini hem hızlı hem de pratik hale getiriyor.

Veritabanı tarafında PostgreSQL kullanarak güçlü ve güvenilir bir yapı sağladık ve kullanıcıların temel veritabanı işlemlerini rahatça yapmalarını hedefledik.

## Özellikler

### Müşteri Bilgileri Yönetimi:
- Yeni bir müşteri ekleyebilir, mevcut müşterileri silebilir, güncelleyebilir ve listeleyebilirsiniz.
- Müşteri bilgilerini ID ile arayarak kolayca sorgulayabilirsiniz.

### Çalışan Bilgileri Yönetimi:
- Yeni bir çalışan ekleyebilir, mevcut çalışanları silebilir, güncelleyebilir ve listeleyebilirsiniz.
- Çalışan bilgilerini ID ile arayarak kolayca sorgulayabilirsiniz.

### Veritabanı Yönetimi:
- PostgreSQL ile verilerin hızlı ve güvenilir bir şekilde yönetilmesini sağladık.
- C# üzerinden PostgreSQL'e kolayca bağlanarak veriler üzerinde işlemler yaptık.

### Kullanıcı Dostu Arayüz:
- Windows Forms ile basit ama işlevsel bir kullanıcı arayüzü tasarladık. Kullanıcılar tüm işlemleri birkaç tıklama ile yapabiliyor.

## Kullanılan Teknolojiler
- **PostgreSQL**: Veritabanı olarak PostgreSQL kullanıldı.
- **C# & Windows Forms**: Uygulama Windows Forms üzerinde geliştirilmiş olup, C# ile kodlanmıştır.
- **Npgsql**: PostgreSQL ile etkileşime geçmek için Npgsql kütüphanesi kullanıldı.

## Teknik Detaylar

### PostgreSQL ve Veri İşlemleri:
PostgreSQL, güçlü ve güvenilir yapısıyla veri yönetimi sağladı. C# ile PostgreSQL arasındaki bağlantıyı `connectionString` ile yönettik.

### CRUD İşlemleri:
Uygulamada temel CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilmiştir. Müşteri ve çalışan ID’sine göre veri sorgulama ve listeleme işlemleri de eklenmiştir.

### Arayüz Tasarımı:
Windows Forms kullanarak kolay anlaşılır bir arayüz tasarlandı. Tüm işlemler, kullanıcıların rahatça erişebileceği butonlarla yapıldı.

## Neler Öğrendim?
PostgreSQL ile çalışmak gerçekten heyecan vericiydi. Veritabanı işlemlerinde PostgreSQL’in güvenilirlik ve hız sağlama avantajlarını keşfettim. Özellikle, PostgreSQL ile veri eklemek, silmek, güncellemek ve sorgulamak işlemlerini nasıl daha verimli yapabileceğimi öğrendim. Ayrıca, C# ile PostgreSQL'e bağlanmayı ve Windows Forms üzerinde basit bir kullanıcı arayüzü oluşturmayı deneyimledim.

## Uygulama İle Yapılabilecekler:
### Müşteri İşlemleri:
- **Müşteri Ekleme**: `Add` butonunu kullanarak yeni müşteri bilgilerini ekleyebilirsiniz.
- **Listeleme**: `List` butonunu kullanarak tüm müşterileri listeleyebilirsiniz.
- **Müşteri Güncelleme**: Mevcut bir müşteri bilgisini güncellemek için `Update` butonunu kullanabilirsiniz.
- **Müşteri Silme**: `Delete` butonuyla müşteri bilgilerini silebilirsiniz.
- **ID ile Arama**: Bir müşteriyi ID’siyle aramak için `Get by ID` butonunu kullanabilirsiniz.

### Çalışan İşlemleri:
- **Çalışan Ekleme**: `Add` butonunu kullanarak yeni çalışan bilgilerini ekleyebilirsiniz.
- **Listeleme**: `List` butonunu kullanarak tüm çalışanları listeleyebilirsiniz.
- **Çalışan Güncelleme**: Mevcut bir çalışan bilgisini güncellemek için `Update` butonunu kullanabilirsiniz.
- **Çalışan Silme**: `Delete` butonuyla çalışan bilgilerini silebilirsiniz.
- **ID ile Arama**: Bir çalışanı ID’siyle aramak için `Get by ID` butonunu kullanabilirsiniz.

