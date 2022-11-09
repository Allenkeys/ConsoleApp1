using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BestPractice
    {
        ///<summary>
        ///This is a C sharp class for Describing Best Coding practices with C#
        /// </summary>
        /// 
        /// <para>
        /// Here, I'll take you through the best coding practices I learnt 
        /// </para>
        /// 
        /// <list>
        /// <item>
        /// 
        /// 1. Use Descriptive variabe names to prevent confusion
        /// 
        /// <example>
        /// This is a good example
        /// <code>
        /// int Age = 3;
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// int a = 3;
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// <item>
        /// 
        /// 2. A function should have a sigle responsibility
        /// 
        /// <example>
        /// This is a good example
        /// <code>
        ///  public void UpdateAddress(Address address) {}  
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// public void SaveAddress(Address address) {  
        ///     if (address.AddressId == 0) {} else {}  
        ///         }
        ///
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// <item>
        /// 
        /// 3. Avoid using common type system. Use the language specific aliases
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// int age;  
        /// string firstName;
        /// object addressInfo;
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// System.Int32 age; String firstName;  
        /// Object addressInfo;  
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// <item>
        /// 
        /// 4. Use String.Empty instead of " "
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  if (firstName == String.Empty) {}
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  if (firstName == "") {}   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        /// 
        ///  <item>
        /// 
        /// 5. Use enums wherever required. Don't use numbers or strings to indicate discrete values.

        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  public enum LoggerType {  
        ///        Event,  
        ///    File,  
        ///    Database
        ///    }
        ///    public void LogException(string message, LoggerType loggerType)
        ///    {
        ///        switch (loggerType)
        ///        {
        ///            case LoggerType.Event:
        ///            // Do something break;  
        ///            case LoggerType.File:
        ///            // Do something break;  
        ///            case LoggerType.Database:
        ///            // Do something break;  
        ///            default:
        ///                // Do something break;  
        ///        }
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   public void LogException(string message, LoggerType loggerType) {  
        ///        switch (loggerType) {  
        ///            case "Event":  
        ///                // Do something break;  
        ///            case "File":  
        ///                // Do something break;  
        ///            case "Database":  
        ///                // Do something break;  
        ///            default:  
        ///                // Do something break;  
        ///        }
        ///    }   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        /// 
        ///  <item>
        /// 
        /// 6.Always do null check for objects and complex objects before accessing them
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///   public Contact GetContactDetails(Address address) {  
        ///        if (address != null && address.Contact != null) {  
        ///            return address.Contact;  
        ///        }
        ///    }  
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   public Contact GetContactDetails(Address address) {  
        ///             return address.Contact;  
        ///         }
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        ///  <item>
        /// 
        /// 
        /// 
        /// 7. Error message to end use should be user friendly and
        /// self-explanatory but log the actual exception details using logger.
        /// Create constants for this and use them in application.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///   "Your session has been expired. Please login again."
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// " There is an error" 
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        ///  8.Avoid passing many parameters to function.
        ///  If you have more than 4-5 parameters use class or structure to pass it.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  if (firstName == String.Empty) {}
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  if (firstName == "") {}   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// </list>
        /// 
        /// 
        ///
    }
}
