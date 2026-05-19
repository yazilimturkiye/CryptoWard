using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tr.gov.tubitak.uekae.esya.api.common.util;
// MA3API:
// Namespace  : tr.gov.tubitak.uekae.esya.api.common.util
// Class      : LicenseUtil
// Feature    : MA3API Initialization

namespace CryptoWard
{
    //internal class MA3Environment
    //{
    //}

    public static class MA3Environment
    {
        public static bool IsInitialized = false;

        public static string LoadedLicensePath = "";

        public static DateTime LicenseExpirationDate;

        public static bool Initialize(string licensePath)
        {
            try
            {
                if (!File.Exists(licensePath))
                {
                    throw new Exception("License file not found.");
                }

                LicenseUtil.setLicenseXml(new FileStream(licensePath,FileMode.Open,FileAccess.Read));
                LicenseExpirationDate =LicenseUtil.getExpirationDate();
                LoadedLicensePath = licensePath;
                IsInitialized = true;
                return true;
            }
            catch
            {
                IsInitialized = false;
                return false;
            }
        }
    }

}
