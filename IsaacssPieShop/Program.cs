//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using IsaacssPieShop;

Console.WriteLine("Creating Employee");
Console.WriteLine("-----------------\n");

Employee isaac = new Employee("Isaac", "ojigho", "isaac.ojigho@newreaz.loan", new DateTime(1999, 12, 12), 75, employeeType.Manager); // you can use var to start this instead of employee

//isaac.PerformWork(40);
//isaac.PerformWork(20);
//isaac.PerformWork(10);
//isaac.PerformWork(5);

string isaacAsJson = isaac.ConvertToJson();
Console.WriteLine(isaacAsJson);

WorkTask task; // dont need to use "new" since its a value type
task.description = "bake pies";
task.hours = 3;
task.PerformWorkTask();
