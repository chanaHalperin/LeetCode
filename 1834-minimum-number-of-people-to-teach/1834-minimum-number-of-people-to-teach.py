class Solution(object):
    def minimumTeachings(self, n, languages, friendships):

        langs = [set(l) for l in languages]

        problematic = set()
        for u, v in friendships:
            if langs[u - 1].intersection(langs[v - 1]):
                continue
            problematic.add(u)
            problematic.add(v)

        if not problematic:
            return 0

        ans = float('inf')
        
        for lang in range(1, n + 1):
            teach_count = 0
            for user in problematic:
                if lang not in langs[user - 1]:
                    teach_count += 1
            ans = min(ans, teach_count)

        return ans
