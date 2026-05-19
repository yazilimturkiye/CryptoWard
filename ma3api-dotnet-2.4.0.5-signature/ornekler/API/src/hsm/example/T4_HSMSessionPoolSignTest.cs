using System;
using NUnit.Framework;
using tr.gov.tubitak.uekae.esya.api.asn.x509;
using tr.gov.tubitak.uekae.esya.api.cades.example;
using tr.gov.tubitak.uekae.esya.api.common.tools;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11.sessionpool;

namespace tr.gov.tubitak.uekae.esya.api.hsm.example
{
    /*
     * HSMSessionPool nesnesi yaratildigi HSM'de birkac tane session acilmaktadir. Ihtiyac halinde HSMSessionPool.DEFAULT_MAX_CAPACITY_PER_KEY degerine kadar
     * yeni session acilmaktadir.
     * Tek bir thread uzerinden kullanimda, tek bir session'in cache'lenip kullanilmasi durumuna (T3_HSMSignTestWithCache) gore daha fazla kontrole sahip oldugu icin
     * daha kotu performans sergileyecektir. Aktif Aktif Dirak HSM kullaniminda birden fazla session acildigindan ve islemler farkli session'lar uzerinden yapildigindan
     * yuk dagitimi olacaktir. Bir HSM'in hata durumuna gectiginde HSMSessionPool yaptigi islemde basarisiz olacak ve yeni bir session ile tekrar deneyecektir. Yeni
     * session aktif HSM(ler)den acilacagi icin hata durumu olusmadan islemler devam edecektir. Hata durumuna gecen HSM duzeldiginde session'larin tekrardan dagitilma
     * isi su anda yapilmamaktadir. Ileriki versiyonlara eklenecektir.
     * Performans arttirimi icin multithread bir yapi kullanilabilir. Yalniz her bir thread'de ayni HSMSessionPool nesnesi kullanilmalidir.
     * HSMPoolSigner sertifikalari icerisinde cache'lemektedir. Eger tek sertifika ile islem yapilacaksa HSMPoolBaseSigner kullanilabilir.
     * */
    public class T4_HSMSessionPoolSignTest : CadesSampleBase
    {
        private static readonly object _lock = new object();

        private static HSMSessionPool hsmSessionPool;

        [Test]
        public void signCAdESWithSessionPool()
        {
            HSMSessionPool sessionPool = getInstance();

            Chronometer c = new Chronometer("HSMSessionPool CAdES Test");
            c.start();
            for (int i = 0; i < 10; i++)
            {
                HSMPoolSigner signer = new HSMPoolSigner(sessionPool, TZ_HSMTestUtil.LABEL);
                ECertificate cert = signer.getCertificate();
                new TZ_HSMTestUtil().signAndVerifyCAdES(signer, cert);
            }
            Console.Out.WriteLine(c.stopSingleRun());
        }

        protected static HSMSessionPool getInstance()
        {
            lock (_lock)
            {
                if (hsmSessionPool == null)
                {
                    hsmSessionPool = new HSMSessionPool(TZ_HSMTestUtil.CARD_TYPE, TZ_HSMTestUtil.SLOT_ID, TZ_HSMTestUtil.SLOT_PIN);
                }
                return hsmSessionPool;
            }
        }
    }
}
