using System;
public static class Challenge
{
  public static long PalindromeChainLength(long n) 
  {
    int counter = 0;
    while(n != reverse(n)){
      n = n+reverse(n);
      counter ++;
    }
    return counter;
  }
  
  public static long reverse(long x){
    long rev = 0;
    while(x!=0){
      rev = rev*10;
      rev = rev+ x%10;
      x = x/10;
    }
    return rev;
  }
}