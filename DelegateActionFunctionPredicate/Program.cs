using DelegateActionFunctionPredicate.Models;

namespace DelegateActionFunctionPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person alik = new Person("Ali", "Shukurov", 20);
            Person garib = new Person("garib", "garibzade", 21);
            Person mestan = new Person("mestan", "mesiova", 1);
            List<Person> list = new List<Person>();
            list.Add(alik);
            list.Add(garib);
            list.Add(mestan);

            Console.WriteLine("Ad ile axtaris vermek");
            list.FindAll(s => s.Name == "Ali").ForEach(s => Console.WriteLine(s.Age + " " + s.Name + " " + s.Surname));
            Console.WriteLine("yasi 20`den boy olanlar");
            list.FindAll(s => s.Age > 20).ForEach(s => Console.WriteLine(s.Age + " " + s.Name + " " + s.Surname));
            Console.WriteLine("familiyasi sonu ov/ova olanlar");
            list.FindAll(s => s.Surname.ToLower().Contains("ov") | s.Surname.ToLower().Contains("ova")).ForEach(s => Console.WriteLine(s.Age + " " + s.Name + " " + s.Surname));

            Console.WriteLine("-------------------------------------------------------------------------------------------");

            List<Exam> exams=new List<Exam>();
            Exam exam = new Exam("Kollekium",70,DateTime.Now);
            Exam exam1 = new Exam("imtahan",91,DateTime.Now);
            Exam exam2 = new Exam("sdf",50,DateTime.Now);
            Exam exam3 = new Exam("serbest is",8,DateTime.Now);

            exams.Add(exam);
            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);
            exam.Start();
            exam1.Start();
            exam2.Start();
            exam3.Start();


            exams.FindAll(s=>s.ExamDuration>120).ForEach(s=>Console.WriteLine(s.Subject+" "+s.ExamDuration));
            Console.WriteLine(exam.StartDate);
            Console.WriteLine(exam.EndDate);
        }
    }
}
