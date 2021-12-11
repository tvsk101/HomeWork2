using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Студент, унаследованный от человека
    /// Имеет ФИО
    /// Имеет группу
    /// Может отчислиться
    /// </summary>
    public class Student : Human
    {
        public Student(string name, string surname, string lastname) : base(name, surname, lastname)
        {

        }
        // Объявляем группу
        public Group group;
        // Учится ли
        public bool studies = true;

        // Вывести группу студента
        public string GetGroup()
        {
            return (this.group.NameGroup);
        }
        // Студент отчислился
        public void DroppedOut()
        {
            this.studies = false;
            group.UpData();
        }
    }
}
