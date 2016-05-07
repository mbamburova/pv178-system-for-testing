using System;
using System.Linq;
using DAL.Entities;

namespace DAL {
    class Program {
        static void Main(string[] args) {

            Console.Write("New student group: ");
            string newStudentGroup = Console.ReadLine();

            using (var db = new StudentsContext()) {
                var s = new StudentGroup() { Name = newStudentGroup };
                db.StudentGroups.Add(s);
                db.SaveChanges();

                var studentGroups = db.StudentGroups.OrderBy(gr => gr.Name);

                Console.WriteLine();
                Console.WriteLine("Student groups are: ");
                foreach (var item in studentGroups) {
                    Console.WriteLine(item.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
