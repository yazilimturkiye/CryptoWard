# HSM Ornekleri
HSM orneklerinde kullanmak istediginiz HSM'e ait bilgileri HSMTestUtil sinifi icerisinden ayarlayabilirsiniz.
HSM testleri performans ve karmasikliklarina gore siralanmistir. Her imzadan sonra olusturulan imza dosyasi
dogrulanmaktadir. Imza dogrulama sirasinda sertifika dogrulama icin OCSP ve CRL indirildigi icin performansi
asil belirleyen islem olmaktadir. Olusan imzanin dogrulanmasi ve imza atma sirasinda sertifika dogrulama
islemi kapatilirsa performans artisi saglanacaktir. Yalniz hatali imzalarin olusmamasi adina onerilmemektedir.
Yaklasik imza dogrulama ile birlikte bir imzanin olusmasi 2.5 sn surmektedir. Tek thread ile ilerlediginde
gunde 34560 imza atilabilmektedir. Paralel islemler ile bu sayi arttirilabilir.<br/>
Aktif Aktif HSM kullaniminda hangi HSM'in kullanilacagina openSession sirasinda karar verilmektedir, sonrasinda
sessionId ile kullanilacak HSM eslestirilmektedir. Ornekler altinda Aktif Aktif icin de aciklamalar bulunmaktadir.