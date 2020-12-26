using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerfonProject.Models
{
   public class Candidate : CommonModel
    {
        public string Surname { get; set; }
        public string CertificateName { get; set; }

        public bool IsZoomMeeting { get; set; }

        #region helper properties 
        public string FullName => $"{Name} {Surname}";
        #endregion
    
        public void SelectCompanyOption(Candidate candidate)
        {
            if (candidate.IsZoomMeeting == false)
            {
                Console.WriteLine(" Ofisde gorushmek uchun yaxinlashacam");
            }
            else
            {
                Console.WriteLine(" Zoom meetingde ishtrak edecem");
            }
        }
    }
}
