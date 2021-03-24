using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = 0;
            // int[] ar = new int[] {10, 20, 20, 10, 10, 30, 50, 10, 20};
            // int [,] ars = new int [,] {};

            // var distinctlist = ar.Distinct();
//FunWithAnagrams();
int  i = 0;//UDDDUDUUDD
i = CountingValleys(8,"UDUUUDUDDD");
Console.WriteLine(i);
        }
    
// static void FunWithAnagrams()
// {
//  List<String> a = new List<string>();
//         //["code", "aaagmnrs", "anagrams", "doce"]
//         a.Add("code");
//         a.Add("aaagmnrs");
//         a.Add("anagrams");
//         a.Add("doce");
//         funWithAnagrams(a);
//             foreach(string item in a)
//             {
//                 Console.WriteLine(item);
//             }
//         }

 static int CountingValleys(int steps, string path)
    {
        int iCounter = 0;
        int iResult = 0;
        
        for(int i = 0; i < steps; i++)
        {
            if(path[i] == 'U'){
                if(++iCounter == 0){
                    iResult++;
                }
            }
            else{
                iCounter--;
            }
        }
        
        return iResult;
    }

//    static String GetKey(String word) {
//         char[] chrs = word.ToCharArray();
//         Array.Sort(chrs);
//         return new String(chrs);
//     }

    // static List<String> funWithAnagrams(List<String> s) {
    //     List<String> ans = new List<String>();
    //     List<String> found = new List<String>();
    //    for (int i=0; i<s.Count(); i++) {
    //         String word = s[i];
    //         String key = GetKey(word);
    //         if (!found.Contains(key)) {
    //             ans.Add(word);
    //             found.Add(key);
    //         }
    //     }

    //     //Collections.sort(ans);
    //    return ans;
    // }
    }
}
