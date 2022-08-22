using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter CTC : ");
            int ctc = int.Parse(Console.ReadLine());
            CalculateTax(ctc);
            //string m = Console.ReadLine();
            //DisplayMessage(m,false);
        }

        static float CalculateTaxPer(int ctc /*Regular Parameter*/
            ,bool isGovtEmployee=false /*Optional Parameter */
            ,bool isSeniorCitizen = false /*Optional Parameter */
            )
        {
            float taxPer = 0.0F;

            if (!isGovtEmployee) {
                if (ctc >= 200000 && ctc < 500000)
                    taxPer = .10F;
                else if (ctc >= 500000 && ctc < 700000)
                    taxPer = .20F;
                else if (ctc >= 700000)
                    taxPer = .30F;
            }

            if (isSeniorCitizen && ctc > 200000)
                taxPer = .01F;

            return taxPer;
        }

        static void CalculateTax(int ctc)
        {
            var taxPer = CalculateTaxPer(
                 isSeniorCitizen: true /*Named Parameter*/
                , ctc: ctc,
                 isGovtEmployee : true
                );
            var taxAmount = ctc * taxPer;

            DiplayTaxInfo(ctc:ctc, per:taxPer, taxamount:taxAmount);
        }

        /// <summary>
        /// Displays the information of tax and tax amount
        /// </summary>
        /// <param name="ctc">Original CTC</param>
        /// <param name="per">Tax Percentage</param>
        /// <param name="taxamount">Total Tax amount deduced</param>
        static void DiplayTaxInfo(int ctc,float per, float taxamount)
        {
            Console.WriteLine($"CTC:{ctc}, Per : {per}, TaxAmount : {taxamount}");
        }

        //static void DisplayMessage(string message,bool showDateTime)
        //{
        //    string modifyMessage = showDateTime ? ComposeWithDateTime(message) : message;
        //    Console.WriteLine(modifyMessage);
        //}
        
        //static string ComposeWithDateTime(string message)
        //{
        //    string newMessage = $"DATETIME :{DateTime.Now}, Message : {message}";
        //    return newMessage;
        //}
    }
}
