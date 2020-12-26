using AzerfonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerfonProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company
            {
                Id = 1,
                Name = "Azerfon",
                Address = "Baku city, Reshid Behbudov street"
            };

            CompanyPosition companyPosition = new CompanyPosition
            {
                Id = 1,
                Name = "HR"
            };

            Candidate candidate = new Candidate
            {
                Id = 1,
                Name = "Ilkin",
                Surname = "Eliyev",
                IsZoomMeeting = true,
                CertificateName = CertificateEnum.MicrosoftCertificate.ToString()
            };

            Vacancy vacancy = new Vacancy
            {
                Id = 1,
                Name = AnnouncedWorkEnum.SoftwareDeveloper.ToString(),
                Requirement = "Sertifikati olmalidir, kaprizli olmamalidi"
            };
            
            Console.WriteLine("Sene uygun vakansiya :\n");
            vacancy.ShowVacancyOptions(vacancy);
            company.GetAcceptedCandidates(candidate);
            company.InviteCandidatesToInterview(candidate);
            candidate.SelectCompanyOption(candidate);
        }
    }
}
