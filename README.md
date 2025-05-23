# 🚀 ASP.NET Core 8.0 ve Identity ile Mail Uygulaması
Bu repository, M&Y Yazılım Akademi bünyesinde yaptığım ikinci proje olan Identity ile Mail Uygulaması projesini içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

Bu proje, ASP.NET Core 8.0 ve Identity altyapısı kullanılarak geliştirilen kullanıcı tabanlı bir e-posta gönderme ve alma uygulamasıdır. Kullanıcıların sisteme kayıt olup giriş yaptıktan sonra birbirlerine güvenli şekilde mesaj göndermelerini sağlayan bu yapı, kimlik doğrulama, parola işlemleri ve rol yönetimi gibi özellikleri ASP.NET Core Identity ile özelleştirilmiş olarak sunar. 

Veritabanı işlemleri Entity Framework Core ile gerçekleştirilmiş ve kullanıcı bilgileri güvenli biçimde saklanmıştır. Projede gelen kutusu, gönderilen kutusu, mesaj detayı ve yeni mesaj oluşturma gibi temel mesajlaşma bileşenleri yer almakta; 403 yetkisiz erişim yönlendirmeleri ve parola politikaları gibi güvenlik ayarları da yapılandırılmıştır. Uygulama her ne kadar tek katmanlı bir projede geliştirilmiş olsa da, iç yapısında Entity Layer (veritabanı modelleri), Data Access Layer (veri etkileşimi) ve UI Layer (kullanıcı arayüzü) olacak şekilde katmanlı mimari prensipleri uygulanmıştır. Dosya yapısı Entities, Controllers, Models, Views ve ViewComponents klasörleriyle organize edilerek SOLID prensiplerine uygun şekilde düzenlenmiştir. 

Arayüz tarafında modern ve mobil uyumlu bir tasarım için Bootstrap 5 tercih edilmiş, parçalı yapıların yönetimi ise ViewComponent yapıları ile sağlanmıştır. Bu yönleriyle proje, .NET Core teknolojileriyle kimlik doğrulama sistemleri ve back-end mimarilerinin uygulamalı olarak öğrenilmesi için kapsamlı, yönetilebilir ve geliştirilebilir bir temel sunmaktadır.<br>

### Bu projenin asıl konusu olan Identity Nedir?
ASP.NET Core Identity, .NET uygulamalarında kullanıcı kimlik doğrulama (authentication) ve yetkilendirme (authorization) işlemlerini kolaylaştırmak amacıyla Microsoft tarafından sunulan, esnek ve genişletilebilir bir kimlik yönetim sistemidir. Web uygulamalarında kullanıcıların güvenli bir şekilde sisteme giriş yapmasını, rollerle yetkilendirilmesini ve oturumlarının yönetilmesini sağlar.

Temel Özellikleri
Kullanıcı Yönetimi: Kayıt olma, giriş yapma, çıkış yapma, e-posta doğrulama, telefon numarası doğrulama gibi işlemleri destekler.
Şifreleme ve Güvenlik: Şifreler otomatik olarak hash’lenerek güvenli şekilde saklanır. ASP.NET Core Identity, varsayılan olarak güçlü parola politikaları (büyük harf, küçük harf, rakam, özel karakter vb.) sunar.
Roller ve Yetkilendirme: Kullanıcılara roller atanabilir ve bu roller aracılığıyla farklı sayfalara erişim kontrolü sağlanabilir (örneğin: Admin, User).
Claims ve Policy Tabanlı Yetkilendirme: Daha esnek bir yapı isteyen projeler için claims (talep) ve policy (ilke) bazlı yetkilendirme seçenekleri sunar.
Entity Framework Core ile Entegrasyon: Kullanıcı ve rol bilgileri veritabanında Entity Framework Core ile yönetilir.
Cookie Authentication Desteği: Kullanıcı oturumu çerezler üzerinden yönetilir. LoginPath, AccessDeniedPath gibi ayarlarla oturum yönlendirmeleri yapılabilir.

Projedeki Kullanımı
Bu projede ASP.NET Core Identity, kullanıcıların sisteme kayıt olması, giriş yapması, kendi profillerini görüntülemesi ve yetkilendirme kurallarına göre erişim sağlaması amacıyla entegre edilmiştir. Ayrıca, belirli sayfalara yalnızca giriş yapmış kullanıcıların erişmesi için global olarak AuthorizeFilter uygulanmıştır. Yetkisiz erişimlerde kullanıcılar giriş sayfasına ya da 403 Access Denied sayfasına yönlendirilmektedir.

ASP.NET Core Identity, projeyi hem güvenli hem de genişletilebilir hale getirerek, kullanıcı tabanlı uygulamalar için sağlam bir temel sunmuştur.

Projede genel anlamda 1 bölüm bulunmaktadır.<br>
Ana Sayfa: Burada Profilim, Gelen Mesajlar, Gönderilen Mesajlar, Giriş Yapma, Kayıt Olma ve Çıkış Yapma işlemleri yer alıyor.

Kullandığım Teknolojiler <br>
⚙️ ASP.NET Core 8.0 Web Application (MVC Yapısı) <br>
🛢️ Entity Framework Core (Code First) <br>
🎨 HTML5, CSS3, Bootstrap 5 ve JavaScript <br>
🗂️ Katmanlı yapı: Entities, Controllers, Models, Views <br>
🧩 ViewComponent kullanımı <br>
🔐 Identity <br><br>

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Ana Sayfa
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/profile2.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/inbox2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/inboxdetail2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/sendbox2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/sendboxdetail2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/dustbin2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/createmessage2.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/1fe820118214e7c5a60536ff17c4121ca3d9493d/ss2/messageconfirmed.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Diğer Sayfalar
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/96f25b583311c059e7fc3f5afe41424345953e67/ss/login.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/96f25b583311c059e7fc3f5afe41424345953e67/ss/register.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/96f25b583311c059e7fc3f5afe41424345953e67/ss/page401.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/IdentityEmail/blob/96f25b583311c059e7fc3f5afe41424345953e67/ss/page403.jpg" alt="image alt">
</div>
