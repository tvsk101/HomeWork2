using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    // Интерфейс, объявляющий Имя, Фамилию, Отчество и Инициалы
    interface IWorkerInterface
    {
        string iname { get; set; }
        string isurname { get; set; }
        string ilastname { get; set; }
        string ipost { get; set; }
        string GetInitials();
        string GetPost();
    }
}
