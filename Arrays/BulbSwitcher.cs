//https://leetcode.com/problems/bulb-switcher-iii/submissions/
public class BulbSwitcher {
    public int NumTimesAllBlue(int[] light) {
        int moments = 0;
        int yellow = 0;
        char[] tracker = new char[light.Length];
        
        for(int i = 0; i < light.Length; i++)
        {
            if(light[i] == 1)
            {
                tracker[0] = 'B';
                TriggerBlue(tracker,ref yellow,ref moments);
            }
            else
            {
                if(tracker[light[i]-2] != 'B')
                {
                    tracker[light[i]-1] = 'Y';
                    yellow++;
                }
                else
                {
                    tracker[light[i]-1] = 'B';
                    TriggerBlue(tracker,ref yellow,ref moments);
                }
            }
        }
        return moments;
    }
    
    public void TriggerBlue(char[] tracker,ref int yellow, ref int moments)
    {
        if(yellow > 0)
        {
       for(int i=0;i<tracker.Length;i++)
       {
           if(i>0 && tracker[i-1] == 'B' && tracker[i] == 'Y')
           {
               tracker[i]='B';
               yellow--;
           }  
       }
        }
       if(yellow == 0)
           moments++;
    }
}