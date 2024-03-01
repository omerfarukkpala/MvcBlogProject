# Asp.Net Mvc ile Katmanlı  Mimaride 3 Panelli (Blog-Yazar-Admin)  Blog Projesi 
Bu proje, Asp.Net Mvc5 kullanılarak geliştirilmiş ve katmanlı mimariye uygun bir blog sitesidir.
 
### Proje Detayları

Bu projede, katmanlı mimariye uygun bir şekilde tasarlanmış ve OOP (Object-Oriented Programming) prensiplerine bağlı kalarak geliştirilmiştir. Kullanıcılar, blogları görüntüleyebilir, yorum yapabilir ve yöneticiler de bütün içeriğe erişebilir.
Projede, kullanıcılar ana sayfada öne çıkan postları görebilirler. Menüde yer alan kategorilere erişim sağlanabilir ve filtreleme ile sadece ilgili kategoriye ait postlar görüntülenebilir. Sayfalama sistemi kullanılarak postlar sayfalara bölünmüştür. Post detaylarına tıklandığında detaylı inceleme yapılabilir. Ayrıca projede mail bülteni ve footer bulunmaktadır.

## Kullanılan Teknolojiler

- **Layout kontrolü:** Bootstrap tabanlı bir kullanıcı arayüzü tasarlanmıştır.
- **Controller Yapısı:** MVC (Model-View-Controller) mimarisi kullanılmıştır.
- **N Katmanlı Mimari:** Mantıksal katmanları düzenlemek ve işlevleri modülerleştirmek amacıyla uygulanmıştır.
- **Entity Framework (Code First):** Veritabanı işlemleri ve ilişkisel tablolar için Entity Framework kullanılmıştır.
- **View Yapısı:** Ayrıntılı ve modüler bir görüntüleme yapısı oluşturulmuştur.
- **Bootstrap:** Duyarlı tasarım ve kullanıcı arayüzü bileşenleri için Bootstrap çerçevesi kullanılmıştır.
- **İlişkili Tablolar:** Veritabanı tabloları arasında ilişkiler kurulmuş ve veri bütünlüğü sağlanmıştır.
- **Partial View:** Tekrar kullanılabilir ve modüler görünümler oluşturmak için parçalı görünümler kullanılmıştır.
- **Dashboard yapısı:** Genel bir kontrol ve özet paneli oluşturulmuştur.
- **Linq Sorguları:** Veri sorgulama ve manipülasyonu için Linq sorguları kullanılmıştır.
- **Generic Repository:** Veritabanı işlemlerini soyutlamak ve tekrar kullanılabilirlik sağlamak için Generic Repository deseni uygulanmıştır.
- **PagedList (Sayfalama):** Veri kümesini sayfalar halinde görüntülemek için PagedList kütüphanesi kullanılmıştır.
## Blog İçeriği

Bu blog projesi , blog yazarları  tarafından oluşturulan içeriklerden oluşmaktadır. Ana sayfa üzerinde öne çıkan yazılar ve kategorilere erişim sağlanabilir. Kullanıcılar, ilgili kategoriye ait yazıları filtreleyebilir ve sayfalama sistemiyle yazıları sayfalara bölünmüş bir şekilde görüntüleyebilirler. Her yazının detaylı incelemesi yapılabilir.

## Admin Paneli Sayfaları

- **Kategoriler:** Kategorilerin yönetildiği ve altındaki başlıkların görüntülendiği sayfa.
- **Başlıklar:** Başlıkların listelendiği, güncellendiği, silindiği ve yeni başlık eklemenin yapıldığı sayfa.
- **Yazılar:** Tüm yazıların listelendiği ve arama yapılabildiği sayfa.
- **Yazarlar:** Yazarların listelendiği, güncellendiği ve yeni yazar eklenmesinin yapıldığı sayfa.
- **Grafikler:** Google Grafikler kullanılarak oluşturulan grafiklerin bulunduğu sayfa.
- **Hakkımızda:** Vitrinde yer alan "Hakkımızda" kısmının yönetildiği sayfa.
- **İletişim & Mesajlar:** İletişim formundan gelen mesajların görüntülendiği ve yönetildiği sayfa.
- **Yetkilendirmeler:** Admin yetkilerinin yönetildiği sayfa.
- **Galeri:** Sözlük galerisinin yönetildiği sayfa.
- **Yeteneklerim:** Admin yeteneklerinin yönetildiği sayfa.
- **Login:** Kullanıcı girişinin yapıldığı sayfa.
- **Register:** Yeni kullanıcı kaydının yapıldığı sayfa.


## Yazar Paneli Sayfaları
Yazarlar, kendi profil bilgilerini düzenleyebilirler. Ayrıca, kendi yazılarını görüntüleyebilir, güncelleyebilir, silebilir ve yeni yazılar ekleyebilirler. Tüm aktif yazılar listelenebilir ve yazarlar yazılara yorum yapabilirler.
- **Profilim:** Yazarların kişisel bilgilerini ve şifrelerini değiştirebildiği sayfa.
- **Başlıklarım:** Yazarların kendi başlıklarını görebildiği, başlıklara yapılan yorumları yönetebildiği sayfa.
- **Tüm Başlıklar:** Tüm başlıkların listelendiği, başlıklara yapılan yorumları görebildiği sayfa.
- **Yazılarım:** Yazarların kendi yazılarını görebildiği sayfa.
- **Mesajlar:** Yazarların diğer kullanıcılara ve yöneticilere mesaj gönderebildiği, aldığı ve gönderdiği mesajları yönetebildiği sayfa.
- **Login:** Kullanıcı girişinin yapıldığı sayfa.
- **Register:** Yeni kullanıcı kaydının yapıldığı sayfa.

## Yorumlar
Kullanıcılar, blog yazılarına yorum yapabilirler. Yorumlar, yöneticiler tarafından incelenebilir ve onaylanabilir. Yorumlar, blog yazılarının altında görüntülenir ve okuyucular tarafından görülebilir.
## Not
Blogun yönetimi ve içeriği blog yöneticileri(admin) tarafından kontrol edilir.

## Veritabanı ![image](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/f8b086ab-333b-46f9-9b86-816bee0d580d)

# Index Sayfası Görünümü  ![screencapture-localhost-44354-Blog-Index-2024-03-01-11_58_49](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/50a047df-e27e-4ede-82ac-d8f8b67d8d9f)

# Index 2 ![index2](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/437e63bd-e8fa-4bce-88cf-92ef289b986c)

# Veritabanı Kategorisi![veritabanikategorisi](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/401062b7-0efd-4c55-8a2f-0ace3ebc98d2)

# Algoritma Kategorisi![algoritma](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/f4df858f-eb93-4ba7-b6de-60d4cea1bb68)

# Programlama Dilleri ![programlamadilleri](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/e0248023-0ca9-4b07-b868-25994268a6fc)
# Oyun Programlama ![oyunprogramlama](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/a5ac120e-4ec6-43ed-8d1b-a15f7f7baaf2)
# API Kategorisi ![api](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/c5f6e233-93f0-4f35-bed8-57a3b4727841)
# Hakkımızda ![hakkimizda](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/4d9ef326-e199-442d-962b-c87097ca2107)
# İletişim ![iletisim](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/c2455c53-04c7-4ec5-9eeb-4987e1f6a299)
# Bir Blog Yazısı Detayları Yazarı , Yorumları ve  Örnek Resimleri ![örnek](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/f97f5bbb-d335-4f5b-b62f-e45031c821e8)
# Admin Girişi![admin girişi](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/d703125f-55aa-4f93-8bad-b0c210f58e54)
# Yazar Girişi![yazar girişi](https://github.com/omerfarukkpala/MvcBlogProject/assets/101570820/e1fab338-c006-4817-9b9c-b6bb266f3549)


