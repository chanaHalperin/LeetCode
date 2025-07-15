public class Solution {
     public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1, nums2.Length, nums1.Length);
        return FindMedianSortedArrays(nums1, nums2, nums1.Length, nums2.Length);
    }
     public double FindMedianSortedArrays(int[] A, int[] B, int m, int n) {
        int low = 0, high = m;
        while (low <= high) {
            int partitionA = (low + high) / 2;
            int partitionB = (m + n + 1) / 2 - partitionA;

            int maxLeftA = (partitionA == 0) ? int.MinValue : A[partitionA - 1];
            int minRightA = (partitionA == m) ? int.MaxValue : A[partitionA];

            int maxLeftB = (partitionB == 0) ? int.MinValue : B[partitionB - 1];
            int minRightB = (partitionB == n) ? int.MaxValue : B[partitionB];

            if (maxLeftA <= minRightB && maxLeftB <= minRightA) {
                if ((m + n) % 2 == 0)
                    return (Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2.0;
                else
                    return Math.Max(maxLeftA, maxLeftB);
            } else if (maxLeftA > minRightB) {
                high = partitionA - 1;
            } else {
                low = partitionA + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted or invalid.");
    }
    public double FindMedianInArray(int[] arr, int i, int j) {
        if((j - i) % 2 == 0)
          return arr[(i+j)/2];
        return (arr[(i+j)/2] + arr[(i+j)/2 + 1])/2;
    }
}