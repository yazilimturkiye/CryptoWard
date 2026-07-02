### 🇹🇷 CryptoWard

CryptoWard, Windows işletim sistemleri için geliştirilmiş, dijital imzalama ve kriptografik işlemler gerçekleştirebilen hafif ve genişletilebilir bir masaüstü uygulamasıdır.

Uygulama, PFX sertifikaları, Akıllı Kartlar (Smart Card) ve MA3API altyapısını kullanarak güvenli elektronik imzalama işlemlerini kolay ve kullanıcı dostu bir arayüz üzerinden gerçekleştirmenizi sağlar.

### CryptoWard Nedir?

CryptoWard, elektronik imza süreçlerini basitleştirmek amacıyla geliştirilmiş bir Windows masaüstü uygulamasıdır.

Kullanıcılar herhangi bir komut satırı bilgisine ihtiyaç duymadan PFX sertifikaları veya Akıllı Kartlar ile güvenli dijital imza oluşturabilir, sertifika bilgilerini görüntüleyebilir ve gelecekte eklenecek yeni kriptografik teknolojileri tek bir uygulama üzerinden kullanabilirler.

Modüler yapısı sayesinde ilerleyen sürümlerde HSM, PKCS#11, Zaman Damgası (TSA), İmza Doğrulama, Şifreleme / Şifre Çözme gibi yeni özellikler kolayca eklenebilecektir.

### Nasıl Çalışır?

Uygulama ilk açıldığında kullanıcıdan MA3API lisans yapılandırmasını tamamlaması istenir.

Daha sonra kullanıcı;

İmzalama yöntemini seçer (PFX veya Smart Card)
Sertifikasını yükler veya Akıllı Kartını doğrular
İmzalanacak dosyayı seçer
İmzalama formatını belirler
Dijital imza işlemini gerçekleştirir

CryptoWard, seçilen sertifikanın algoritmasını otomatik olarak algılayarak uygun imzalama algoritmasını seçer.

Desteklenen Özellikler (v1.0)
MA3API Lisans Yönetimi
PFX ile Dijital İmzalama
Smart Card ile Dijital İmzalama
Sertifika Bilgilerini Görüntüleme
Otomatik RSA / ECDSA Algoritma Tespiti
Otomatik Digest Algoritması Seçimi
CAdES Dijital İmza Desteği
Modern ve Kullanıcı Dostu Arayüz
Sistem Gereksinimleri
Windows 10 / Windows 11
.NET Framework 4.8
MA3API Runtime
Geçerli MA3API Lisansı

### MA3API Lisansı

CryptoWard'ın MA3API tabanlı özelliklerini kullanabilmek için geçerli bir MA3API lisansı gereklidir.

MA3API lisansına sahip değilseniz lisanslama ve teknik destek hakkında bilgi almak için TÜBİTAK BİLGEM Kamu Sertifikasyon Merkezi (Kamu SM) ile iletişime geçebilir veya aşağıdaki adresi ziyaret edebilirsiniz.

https://yazilim.kamusm.gov.tr

### 🇬🇧 CryptoWard

CryptoWard is a lightweight and extensible desktop application developed for secure cryptographic operations and digital signature management on Microsoft Windows.

The application provides a simple and unified interface for working with PFX certificates, Smart Cards, and the MA3API infrastructure, allowing users to perform secure digital signing operations with ease.

### What is CryptoWard?

CryptoWard is a Windows desktop application designed to simplify digital signature workflows.

Users can securely create digital signatures using PFX certificates or Smart Cards without requiring command-line tools or advanced cryptographic knowledge.

Its modular architecture allows future integration of additional cryptographic technologies such as Hardware Security Modules (HSM), PKCS#11 devices, Timestamp Services (TSA), Signature Verification, and Encryption / Decryption.

### How Does It Work?

When the application starts for the first time, users are asked to complete the MA3API license configuration.

The signing workflow consists of the following steps:

Select the signing method (PFX or Smart Card)
Load the certificate or unlock the Smart Card
Select the document to be signed
Choose the signature format
Perform the digital signing operation

CryptoWard automatically detects the certificate algorithm and selects the most appropriate signing algorithm.

Current Features (v1.0)
MA3API License Management
PFX Digital Signing
Smart Card Digital Signing
Certificate Information Viewer
Automatic RSA / ECDSA Detection
Automatic Digest Algorithm Selection
CAdES Digital Signature Support
Modern and User-Friendly Interface
System Requirements
Windows 10 / Windows 11
.NET Framework 4.8
MA3API Runtime
Valid MA3API License

### MA3API License

A valid MA3API license is required to use MA3API-based features within CryptoWard.

If you do not have a valid MA3API license, please contact TÜBİTAK BİLGEM Public Certification Center (Kamu SM) or visit the following website for licensing information and technical support.

https://yazilim.kamusm.gov.tr