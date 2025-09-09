class Solution(object):
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        if x == 0:
            return 0
        newX = 0
        un = x < 0
        if un:
            x = -x
        while (x % 10) == 0:
            x //= 10
        while x != 0 :
            newX *= 10
            newX += x % 10
            x //= 10
        if un:
            newX *= -1
        if newX < -2**31 or newX > 2**31 - 1:
            return 0
        return newX
        