class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if s == "":
            return 0

        max_len = 1
        start, end, cur_sub = 0, 0, ""

        while start < len(s):
            print(cur_sub)
            if(end < len(s) and s[end] not in cur_sub):
                cur_sub += s[end]
                end += 1
            elif(end < len(s) and s[end] in cur_sub):
                max_len = max(max_len, end - start)
                cur_sub = cur_sub[1:]
                start += 1
            else:
                max_len = max(max_len, end - start)
                break
            


        
        return max_len