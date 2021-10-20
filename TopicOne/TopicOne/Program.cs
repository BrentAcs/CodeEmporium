using System;

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
         Iteration1.IMyService service = new Iteration1.MyFirstService();
         var model = new Iteration1.MyModel
         {
            Id = "0",
            SourceSystem = "New-System",
            Name = "Brent",
            Address = "123 Main St."
         };

         var work = service.DoWork(model);

         Console.WriteLine($"Work complete: {work}");
      }
   }
}
