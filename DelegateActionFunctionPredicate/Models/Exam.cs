using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateActionFunctionPredicate.Models
{
    public class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public void Start()
        {
            StartDate = DateTime.Now;
            EndDate = StartDate.AddMinutes(ExamDuration); 

        }
        public Exam(string subject,int examDuration, DateTime dateTime)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = dateTime;
            EndDate = dateTime;
        }

    }
}
