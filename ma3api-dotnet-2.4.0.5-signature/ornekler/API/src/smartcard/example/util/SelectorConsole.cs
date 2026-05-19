using System;
using tr.gov.tubitak.uekae.esya.api.common.util;

namespace tr.gov.tubitak.uekae.esya.api.smartcard.example.util
{
    public class SelectorConsole: ISelector
    {

        public int Select(string description, string[] inputs)
        {
            while (true)
            {
                printMenu(description, inputs);
                try
                {
                    int selection = Int32.Parse(Console.ReadLine());

                    if (1 <= selection && selection <= inputs.Length) {
                        return selection - 1;
                    }
                    else {
                        Console.WriteLine("Yanlış Seçim!!! Seçiminizi: 1-" + inputs.Length + " arasında bir rakam olarak girin ve 'Enter' tuşuna basın.");
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Yanlış Seçim!!! Seçiminizi: 1-" + inputs.Length + " arasında bir rakam olarak girin ve 'Enter' tuşuna basın.");
                }
            }
        }

        private void printMenu(string description, string[] inputs) {

            Console.WriteLine(description);
            
            int i = 1;
            
            foreach (string input in inputs) { 
                Console.WriteLine (i + "- " + input);
                i++;
            }

        }
    }
}
