using tr.gov.tubitak.uekae.esya.api.common.crypto;
using tr.gov.tubitak.uekae.esya.api.crypto.alg;
using tr.gov.tubitak.uekae.esya.api.smartcard.pkcs11;
using tr.gov.tubitak.uekae.esya.api.smartcard.util;

namespace tr.gov.tubitak.uekae.esya.api.src.smartcard.signer
{
    class CreateBaseSigner
    {
        public void createSignerWithKeyLabel()
        {
            SmartCard sc = new SmartCard(CardType.DIRAKHSM);
            long slot = sc.getSlotList()[0];
            long session = sc.openSession(slot);
            sc.login(session, "slotPIN");

            BaseSigner signer = new SCSignerWithKeyLabel(sc, session, slot, "keyLabel",
                                                         SignatureAlg.RSA_SHA256.getName());
        }
    }
}
