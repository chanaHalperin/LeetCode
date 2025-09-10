class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        hash_table = dict()
        max_len = 0
        start = 0
        for index, ch in enumerate(s):
            if ch in hash_table and hash_table[ch] >= start:
                start = hash_table[ch] + 1
            hash_table[ch] = index
            max_len = max(max_len, index - start + 1)
        return max_len
