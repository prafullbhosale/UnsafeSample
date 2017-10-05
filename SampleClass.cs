using System;

namespace UnsafeSample
{
    public class Sample
    {
        unsafe static void DoSomething()
        {
            fixed(char* value = "Safe")
            {
                char* ptr = value;
                while (*ptr != '\0')
                {  
                    Console.WriteLine(*ptr);
                    ++ptr;
                }  
            }
        }
    }
}