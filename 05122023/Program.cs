// 1) Median of Two Sorted Arrays
// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
// The overall run time complexity should be O(log (m+n)).

// Example1:
// Input:nums1 = [1,3], nums2 = [2]
// Output:2.00000
// Explanation: merged array = [1,2,3] and median is 2.

// Example2:
// Input:nums1 = [1,2], nums2 = [3,4]
// Output:2.50000
// Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

// Constraints:
// nums1.length == m
// nums2.length == n
// 0 <= m <= 1000
// 0 <= n <= 1000	
// 1 <= m + n <= 2000
// -106 <= nums1[i], nums2[i] <= 106

Console.WriteLine("Input first array length!");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input second array length!");
int m = Int32.Parse(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[m];
int[] arr = new int[n+m];
Console.WriteLine("Input first array elements!");
for (int i=0; i<n; i++) {
    arr1[i]=Int32.Parse(Console.ReadLine());
    arr[i]=arr1[i];
}

Console.WriteLine("Input second array elements!");
for (int i=0; i<m; i++) {
    arr2[i]=Int32.Parse(Console.ReadLine());
    arr[i+n]=arr2[i];
}

Array.Sort(arr);
Console.WriteLine("[{0}]", string.Join(",",arr));

double res = 0.0;

if ((n+m)%2==0)
    res=(Convert.ToDouble(arr[(m+n)/2-1])+Convert.ToDouble(arr[(m+n)/2]))/2;
else
    res=(double)(arr[(m+n)/2]);

Console.WriteLine("Median is: {0}", res);




