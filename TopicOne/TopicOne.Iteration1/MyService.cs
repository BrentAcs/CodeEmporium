﻿using System.Diagnostics;

namespace TopicOne.Iteration1
{
   public class MyModel
   {
      public string Id { get; set; }
      public string SourceSystem { get; set; }
      public string Name { get; set; }
      public string Address { get; set; }
   }

   public interface IMyService
   {
      string DoWork(MyModel model);
   }

   public class MyFirstService : IMyService
   {
      public string DoWork(MyModel model)
      {
         if (model.SourceSystem.ToLower() == "legacy-system" && model.Id != "0")
         {
            // ... lots of cool code and snazzy logic here ...
            
            return $"Doing work for legacy system. Welcome {model.Name} @ {model.Address}";
         }
         else
         {
            // ... lots of IMPROVED cool code and snazzy logic here ...

            return $"Doing work for new system...\r\nWelcome, {model.Name}.\r\nAddress: {model.Address}";
         }
      }
   }

   // What are the code smells in this sample implementation?  

   // 1. Lack of unit tests
   // 2. Magic strings
   // 3. string comparisons not 'best practiced'
   // 3. Code isn't really self documenting

   // Refs:
   //  https://en.wikipedia.org/wiki/Code_smell
   //  https://en.wikipedia.org/wiki/Self-documenting_code
   //   Thought on the criticism. This is true to an extent, however it's possible to use practices to assist/test code.
   //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices-strings

}
