using System.Diagnostics;

namespace TopicOne.Core.Iteration1
{
   public class MyService : IMyService
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

   // 1. Magic strings
   // 2. string comparisons not 'best practiced'
   // 3. Lack of unit tests
   // 4. Code isn't really self documenting

   // Refs:
   //  https://en.wikipedia.org/wiki/Code_smell
   //  https://en.wikipedia.org/wiki/Self-documenting_code
   //   Thought on the criticism. This is true to an extent, however it's possible to use practices to assist/test code.
   //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices-strings

}
