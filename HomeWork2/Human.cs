using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public abstract class Human
    {
        private string name;
        private string surname;
        private string lastname;
        // Работник с ФИО
        public Human(string name, string surname, string lastname)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
        }
        // Метод, возвращающий ФИО (Инициалы)
        public string GetInitials()
        {
            string initials = name + " " + surname + " " + lastname;
            return initials;
        }
        // Метод, возвращающий должность

    }
}
