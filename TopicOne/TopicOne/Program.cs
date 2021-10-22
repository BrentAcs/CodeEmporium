using System;
using TopicOne.Core;

namespace TopicOne
{
   class Program
   {
      static void Main(string[] args)
      {
         // NOTES:
         // 1. IMyService would be injected in proper app, NOT new'd up.
         // 2. Code in the TopicOne.IterationX library projects are all in one file,
         //    again wouldn't not be case in proper app

         DemoIteration1();

      }

      private static void DemoIteration1()
      {
         IMyService service = new Core.Iteration1.MyService();
         var model = new MyModel
         {
            Id = "0",
            SourceSystem = string.Empty,
            Name = "Brent",
            Address = "123 Main St."
         };
         var work = service.DoWork(model);

         // demo 'DoWork' w a 'legacy' system.
         model.SourceSystem = "legacy-system";
         work = service.DoWork(model);
         Console.WriteLine($"Work complete:\r\n\r\n{work}\r\n\r\n");

         // demo 'DoWork' w a 'new' system.
         model.SourceSystem = "new-system";
         work = service.DoWork(model);
         Console.WriteLine($"Work complete:\r\n\r\n{work}\r\n\r\n");

         // demo 'DoWork' w/o a source system.
         model.SourceSystem = string.Empty;
         Console.WriteLine($"Work complete:\r\n\r\n{work}\r\n\r\n");
      }
   }
}
