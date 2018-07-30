#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.ToDo.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MostDev
{
    public class ToDo
    {
        public ToDo()
        {
            Date = DateTime.Now;
        }

        public ToDo(string name, EActivityType activityType)
            : this(name, DateTime.Now, activityType)
        {
        }

        public ToDo(string name, DateTime date, EActivityType activityType)
        {
            Name = name;
            Date = date;
            ActivityType = activityType;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public EActivityType ActivityType { get; set; }
    }
}