using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Класс Работник, содержащий ФИО, Инициалы, Должность
    /// </summary>
    public abstract class Worker : IWorkerInterface
    {
        public string iname { get; set; }
        public string isurname { get; set; }
        public string ilastname { get; set; }
        public string ipost { get; set; }

        // Работник с ФИО
        public Worker(string name, string surname, string lastname, string post)
        {
            iname = name;
            isurname = surname;
            ilastname = lastname;
            ipost = post;
        }
        // Метод, возвращающий ФИО (Инициалы)
        public string GetInitials()
        {
            string initials = iname + " " + isurname + " " + ilastname;
            return initials;
        }
        // Метод, возвращающий должность
        public string GetPost()
        {
            return this.ipost;
        }
    }
}
