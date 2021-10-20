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

            public override string ToString()
            {
                String result = $"{id}. [" + (doneUndone == false ? ' ' : 'x') + "] " + task;
                if(date != new DateTime()){
                    result += $" ({date.ToString("MMM dd")})";
                }
                if(descript != null){
                    result += $"{Environment.NewLine}   {descript}";
                }
                return result;
            }

        }
        static void Main(string[] args)
        {
            Task[] newTask = {
                (new Task(1, false, "Implement task output", new DateTime(2008, 1, 25), "Use fields: title, desc, done, dueDate")),
                (new Task(2, true, "Implement task output", "Use fields: title, desc, done, dueDate")),
                (new Task(3, false, "Implement task output", new DateTime(2008, 1, 25))),
                (new Task(4, true, "Implement task output"))
            };

            foreach(var task in newTask){
                Console.WriteLine(task);
                Console.WriteLine();
            }
        }
    }
}