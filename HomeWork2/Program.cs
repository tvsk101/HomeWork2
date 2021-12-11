using System;
using System.Collections.Generic;

namespace HomeWork2
{
    /// <summary>
    /// Работа программы
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем кадровика
            HeadOfHR headofHR = new HeadOfHR("Иван", "Иванов", "Иванович");

            // Объявляем учителя
            Teacher teacher1 = headofHR.MakeTeacher("Дмитрий", "Дмитров", "Дмитриевич", true);
            Teacher teacher2 = headofHR.MakeTeacher("Дмитрий", "Дмитров", "Дмитриевич", false);

            // Объявляем двух студентов
            Student student1 = headofHR.MakeStudent("Данил", "Данилов", "Данилович");
            Student student2 = headofHR.MakeStudent("Даниил", "Даниилов", "Даниилович");


            // Выводим ФИО и должности всех людей
            Console.WriteLine($"ФИО: {headofHR.GetInitials()} | Должность: {headofHR.GetPost()}");
            Console.WriteLine($"ФИО: {teacher1.GetInitials()} | Должность: {teacher1.GetPost()}");
            Console.WriteLine($"ФИО: {teacher2.GetInitials()} | Должность: {teacher2.GetPost()}");


            // Создаем новую группу студентов
            Group group = headofHR.MakeGroup();

            // Задаем имя группы
            group.NameGroup = "Э-1";

            // Назначаем учителя в группу
            group.SetTeacher(teacher1);

            // Добавляем в группу двух студентов
            group.AddStudent(student1);
            group.AddStudent(student2);

            // Вывод названия группы
            Console.WriteLine($"Группа студента {student1.GetInitials()} : {student1.GetGroup()}");;

            // Назначаем учителю количество лекций
            teacher1.Lecture = 50;
            Console.WriteLine("Назначено лекций преподавателю: " + teacher1.Lecture);

            // Учитель провел несколько лекций
            teacher1.Lectured();
            teacher1.Lectured();
            teacher1.Lectured();
            teacher1.Lectured();
            teacher1.Lectured();

            Console.WriteLine("После проведения лекций: " + teacher1.Lecture);


            // Вывод количества студентов группы
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());
            
            // Студент отчислился
            student2.DroppedOut();

            // Вывод количества студентов группы
            Console.WriteLine("Студент отчислился");
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());


        }
    }
}
