using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Класс, реализующий должности преподавателей
    /// </summary>
    public class TeacherPost
    {
        private string namepost;
        private List<Teacher> teachers = new List<Teacher>();

        // Добавить преподавателя на должность
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
            teacher.teacherpost = this;
        }

        // Ввод названия должности и закрепление должности за преподавателями
        public string NamePost
        {
            get
            {
                return (namepost);
            }
            set
            {
                this.namepost = value;
                foreach (Teacher teacher in teachers) teacher.teacherpost = this;
            }
        }

        // Обновить количество преподавателей в случае увольнения
        public void UpTeacherData()
        {
            try
            {
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.thispost == false) teachers.Remove(teacher);
                }
            }
            catch { }
        }
        //// Список преподавателей
        //public List<Teacher> GroupTeacherList()
        //{
        //    return (this.teachers);
        //}
    }
}
