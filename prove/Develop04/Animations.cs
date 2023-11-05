using System;
using System.Collections.Generic;
using System.Threading;

public class Animation
{
    public void RunAnimation()
    {
        List<string> animationStrings = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }
}
