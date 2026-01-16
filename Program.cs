using System;
using System;
namespace TaskMaster { 
    // Value Type (Stored on the Stack)
    struct TaskPriority { 
        public int priorityLevel; 
    } 

    class UserTask { 
        public string taskTitle;
        public TaskPriority Priority; 
    } 

    class Program { 
        static void Main(string[] args) { 

           TaskPriority taskPriority; 
           taskPriority.priorityLevel = 1; 
           UserTask userTask = new UserTask(); 

           userTask.taskTitle = "Complete Programming Assignment"; 
           userTask.Priority = taskPriority; 
            
           Console.WriteLine("Task Title: " + userTask.taskTitle); 
           Console.WriteLine("Task Priority Level: " + userTask.Priority.priorityLevel); 
        } 
    } 
}