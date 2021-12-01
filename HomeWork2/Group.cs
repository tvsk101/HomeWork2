using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Класс, реализующий группу студентов
    /// </summary>
    public class Group
    {
        private string namegroup;
        private Teacher teacher;
        private List<Student> students = new List<Student>();

        // Назначить учителя для группы
        public void SetTeacher(Teacher teacher)
        {
            teacher.SetGroup(this);
            this.teacher = teacher;
        }
        // Добавить студента в группу
        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.group = this;
        }

        // Ввод названия группы и закрепление группы за студентами
        public string NameGroup
        {
            get
            {
                return (namegroup);
            }
            set
            {
                this.namegroup = value;
                foreach (Student student in students) student.group = this;
            }
        }
        // Получить количество студентов
        public int GetNumberOfStudents()
        {
            return (this.students.Count);
        }
        // Обновить количество студентов в случае отчисления
        public void UpData()
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.studies == false) students.Remove(student);
                }
            }
            catch { }
        }
        //// Список студентов
        //public List<Student> GroupList()
        //{
        //    return (this.students);
        //}
    }
}
