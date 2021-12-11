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
    public abstract class Worker : Human
    {
        public Worker(string name, string surname, string lastname, string post) : base(name, surname, lastname)
        {
            this.post = post;
        }
        private string post;
        public string Post
        {
            get
            {
                return (this.post);
            }
        }
        public string GetPost()
        {
            return this.post;
        }
    }
}
