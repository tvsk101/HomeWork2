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
        public enum Posts
        {
            Assistant,
            ElderTeacher
        }
        static string[] PostsArr = new string[] { "Ассистент", "Старший преподаватель" };

        //public void GetDictPost()
        //{
        //    Dictionary<string, Posts> postsvalues = new Dictionary<string, Posts>();
        //    postsvalues.Add("Ассистент", Posts.Assistant);
        //    postsvalues.Add("Старший преподаватель", Posts.ElderTeacher);
        //}
        

        public Teacher(string name, string surname, string lastname, Posts post) 
            : base(name, surname, lastname, PostsArr[(int)post])
        {

        }
        // Должность
        public TeacherPost teacherpost;
        
        // Учится ли
        public bool thispost = true;
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
        public void Retirement()
        {
            this.thispost = false;
            teacherpost.UpTeacherData();
        }
        // Вывести группу студента
        public string GetNewPost()
        {
            return (this.teacherpost.NamePost);
        }
    }
}
