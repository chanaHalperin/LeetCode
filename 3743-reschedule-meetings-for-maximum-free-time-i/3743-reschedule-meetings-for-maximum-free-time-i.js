/**
 * @param {number} eventTime
 * @param {number} k
 * @param {number[]} startTime
 * @param {number[]} endTime
 * @return {number}
 */
var maxFreeTime = function(eventTime, k, startTime, endTime) {
    const n = startTime.length;
    const gaps = [];
    for (let i = 1; i < n; i++) {
        gaps.push(startTime[i] - endTime[i - 1]);
    }
    gaps.unshift(startTime[0] - 0);
    gaps.push(eventTime - endTime[n - 1]);

    let maxSum = 0, sum = 0;
    for (let i = 0; i < gaps.length; i++) {
        sum += gaps[i];
        if (i > k) sum -= gaps[i - (k + 1)];
        if (i >= k) maxSum = Math.max(maxSum, sum);
    }
    return maxSum;
};
maxFreeTime(5,1,[1,3],[2,5])