/*3. Longest Substring Without Repeating Characters*/


/*Given a string s, find the length of the longest 
substring
 without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
       int longest = 0;
       for(int x=0; x < s.Length; x++){
          List<char> letters = new List<char>();
          int currentLength = 0;
          for(int i = x; i < s.Length; i++){
            if(letters.IndexOf(s[i]) == -1){
                letters.Add(s[i]);
                currentLength++;
                if(currentLength > longest)
                    longest = currentLength;
            }
            else{
                break;
            }
          }
       } 
       return longest;
    }
}