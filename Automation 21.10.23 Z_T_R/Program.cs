﻿using Automation_21._10._23_Z_T_R;
using System;

namespace Automation_21._10._23_Z_T_R
{
    class Задание
    {
        public static void Exercise()
        {
            Employee _Semon = new Employee("Семён");
            Employee _Rashid = new Employee("Рашид");
            Employee _OIlkham = new Employee("О Ильхам");
            Employee _Lukas = new Employee("Лукас");
            Employee _Orkadiy = new Employee("Оркадий");
            Employee _Volodya = new Employee("Володя");
            Employee _Ilshat = new Employee("Ильшат");
            Employee _Ivanich = new Employee("Иваныч");
            Employee _Iliya = new Employee("Илюха");
            Employee _Vitya = new Employee("Витя");
            Employee _Jenya = new Employee("Женя");
            Employee _Sergay = new Employee("Серега");
            Employee _Laisan = new Employee("Ляйсан");
            Employee _Ildar = new Employee("Ильдар");
            Employee _Anton = new Employee("Антон");

            _Semon.Add(_Rashid);
            _Semon.Add(_OIlkham);
            _Rashid.Add(_Lukas);
            _OIlkham.Add(_Orkadiy);
            _Orkadiy.Add(_Volodya);
            _Volodya.Add(_Ilshat);
            _Volodya.Add(_Sergay);
            _Ilshat.Add(_Ivanich);
            _Ivanich.Add(_Iliya, _Vitya, _Jenya);
            _Sergay.Add(_Laisan);


            TaskAssignment.AssignTask(_Semon, _Rashid, "Автоматизировать бухгалтерию");
            TaskAssignment.AssignTask(_Semon, _OIlkham, "Автоматизировать бухгалтерию");
            TaskAssignment.AssignTask(_Rashid, _Lukas, "Обновить серверы");
            TaskAssignment.AssignTask(_Lukas, _OIlkham, "Установить ПО");
            TaskAssignment.AssignTask(_Semon, _Vitya, "Принести кофе");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Exercise();
        }
    }
}