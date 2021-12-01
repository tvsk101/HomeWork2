using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Класс Кадровик, унаследованный от работника
    /// </summary>
    public class HeadOfHR : Worker
    {
        public HeadOfHR(string name, string surname, string lastname) : base(name, surname, lastname, "Кадровик")
        {

        }
        // Действия кадровика:

        // Создать студента и добавить ФИО
        public Student MakeStudent(string name, string surname, string lastname)
        {
            return (new Student(name, surname, lastname));
        }
        // Добавить студента в группу
        public void AddStudent(Group group, Student student)
        {
            group.AddStudent(student);
        }
        // Создать учителя
        public Teacher MakeTeacher(string name, string surname, string lastname)
        {
            return (new Teacher(name, surname, lastname));
        }
        // Создать группу
        public Group MakeGroup()
        {
            return (new Group());
        }
    }
}
