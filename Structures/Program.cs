using System;

namespace Structures
{
    class Program
    {
        struct Task
        {
            public double id;
            public bool doneUndone;
            public string task;
            public DateTime date;
            public string descript;

            public Task(int id, bool doneUndone, string task) : this(id, doneUndone, task, new DateTime(), null) { }
            public Task(int id, bool doneUndone, string task, DateTime date) : this(id, doneUndone, task, date, null) { }

            public Task(int id, bool doneUndone, string task, string descript) : this(id, doneUndone, task, new DateTime(), descript) { }

            public Task(int id, bool doneUndone, string task, DateTime date, string descript)
            {
                this.id = id;
                this.doneUndone = doneUndone;
                this.task = task;
                this.date = date;
                this.descript = descript;
            }
        }
        static void Main(string[] args)
        {
            Task newTask = new Task(1, false, "Implement task output", new DateTime(2008, 1, 25), "Use fields: title, desc, done, dueDate");
            
            Print(newTask);
        }

        static void Print(Task createTask)
        {
            string checkBox = CreateCheckBox(createTask.doneUndone);
            string date = CreateDate(createTask.date);
            Console.WriteLine($"{createTask.id}. {checkBox} {createTask.task} {date}\n   {createTask.descript}");
        }
        static string CreateDate(DateTime date)
        {
            if (date.Year == 1)
                return "";
            else
            {
                return $"({date.ToString("MMM dd")})";
            }
        }

        static string CreateCheckBox(bool doneUndone)
        {
            if (doneUndone) return "[x]";
            else return "[ ]";
        }

    }
}