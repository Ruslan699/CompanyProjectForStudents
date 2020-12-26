using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerfonProject.Models
{
   public class Vacancy : CommonModel
    {
        public string Requirement { get; set; }

        public void ShowVacancyOptions(Vacancy vacancy)
        {
            Console.WriteLine(" Vakansiyanin nomresi {0}\n Vakansiyanin adi {1}\n Vakansiyanin telebleri {2}",vacancy.Id,vacancy.Name,vacancy.Requirement);
        }
    }
}
