using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /// <summary>
    /// Преподаватель, унаследованный от работника
    /// Может назначаться на лекции
    /// </summary>
    public class Teacher : Worker
    {
        public Teacher(string name, string surname, string lastname) : base(name, surname, lastname, "Преподаватель")
        {

        }
        // Количество лекций
        private int lecture;
        // По умолчанию групп нет
        private Group group = null;
        // Возвращает количество лекций
        public int Lecture
        {
            set
            {
                if (group != null)
                {
                    this.lecture = value;
                }
            }
            get
            {
                return (this.lecture);
            }
        }
        // Лекция проведена
        public void Lectured()
        {
            this.lecture--;
        }
        // Назначение группы
        public void SetGroup(Group group)
        {
            this.group = group;
        }
    }
}
