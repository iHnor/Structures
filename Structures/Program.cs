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

            public Task(int id, bool doneUndone,string task): this(id, doneUndone,task, new DateTime(), null){}
            public Task(int id, bool doneUndone,string task, DateTime date): this(id, doneUndone,task, date, null){}

            public Task(int id, bool doneUndone,string task, string descript): this(id, doneUndone,task, new DateTime(), descript){}

            public Task(int id, bool doneUndone,string task, DateTime date, string descript){
                this.id = id;
                this.doneUndone = doneUndone;
                this.task = task;
                this.date = date;
                this.descript = descript;
            }

            public override string ToString()
            {
                String result = $"{id}. [" + (doneUndone == false ? ' ' : 'x') + "] " + task;

                if(date == new DateTime()){
                    result += $"(" + date.ToString("MMM dd") + ")";
                }
                if(descript != null){
                    result += Environment.NewLine + "   " + descript;
                }
                return result;
            }

        }
        static void Main(string[] args)
        {
            Task[] tasklist = {new Task(1,true, "vndzfjnvk", new DateTime(2020,8,5), "vdzfjk")};
            

            Console.WriteLine(tasklist[0].ToString());
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
