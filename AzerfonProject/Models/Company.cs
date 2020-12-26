using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerfonProject.Models
{
   public class Company : CommonModel
    {
        public string Address { get; set; }

        public bool GetAcceptedCandidates(Candidate candidate)
        {
            if (candidate.CertificateName == CertificateEnum.MicrosoftCertificate.ToString())
            {
                Console.WriteLine("Hormetli yoldash siz namized olaraq sechildiz");
                return true;
            }
            return false;
        }

        public void InviteCandidatesToInterview(Candidate candidate)
        {
            Console.WriteLine(" {0} - adli namizedi musahibeye devet edirik, hansi musahibe vasitesini sechirsiz?",candidate.FullName);
        }
    }
}
