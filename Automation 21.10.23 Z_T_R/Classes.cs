using System;
using System.Collections.Generic;

namespace Automation_21._10._23_Z_T_R;

class Employee
{
    public string Name { get; set; }
    public List<Employee> Subordinates { get; set; }

    public Employee(string name)
    {
        Name = name;
        Subordinates = new List<Employee>();
    }
    public void Add(params Employee[] employees)
    {
        foreach (var employee in employees)
        {
            Subordinates.Add(employee);
        }
    }
}
class TaskAssignment
{
    public static bool AssignTask(Employee supervisor, Employee employee, string task)
    {
        if (IsSupervisor(supervisor, employee))
        {
            Console.WriteLine($"{supervisor.Name} назначает таск '{task}' {employee.Name}.");
            return true;
        }
        Console.WriteLine($"{supervisor.Name} невозможно, чтобы {employee.Name} его учитывал(а).");
        return false;
    }
    public static bool IsSupervisor(Employee supervisor, Employee employee)
    {
        if (supervisor == employee)
            return true;

        foreach (var subordinate in supervisor.Subordinates)
        {
            if (IsSupervisor(subordinate, employee))
                return true;
        }
        return false;
    }
}
