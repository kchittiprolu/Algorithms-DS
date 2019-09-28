using System;
using System.Collections;
using System.Text;
namespace Algorithms_DS.Strings
{
    public class DecodeString
    {
        public string DecodeStringProblem(string s) 
        {
            Stack st = new Stack();
            StringBuilder sb = new StringBuilder();
            int ctr = 0;
            for(int i=0; i<s.Length;i++)
            {
                if(Char.IsNumber(s[i]) && ctr <= 1){
                    if(sb.Length == 0)
                     st.Push(s[i].ToString());
                    else
                    {
                        st.Push("1");
                        st.Push(sb.ToString());
                        st.Push(s[i].ToString());
                    }
                }
                else if(s[i] == '['){
                    ctr++;
                    sb.Clear();
                }
               else if(s[i]==']'){
                if(sb.Length > 0)
                 st.Push(sb.ToString());
                 ctr--;
                 sb.Clear();
                }
                else{
                    sb.Append(s[i]);
                }
            }

            while(st.Count > 0){
                var str = st.Pop().ToString();
                int n = 0;
                int loop = int.TryParse(str, out n) ? n-1 : Convert.ToInt32(st.Pop());
                while(loop > 0){
                    if(sb.Length == 0)
                       sb.Append(str);
                    else if(n >0){
                      sb.Insert(0,sb.ToString());
                    }
                    else
                     sb.Insert(0,str);
                    loop--;
                }
              }

            return sb.ToString();
        }
    }
}