namespace QuickSort;

/// <summary>
/// The general premise behind QuickSort is getting the last element, separating two separate instances of QuickSort,
/// then pushing every value that's less than the pivot to the front of the array, then placing the pivot in front
/// of those values. Rinse and repeat (recursion). Maybe I'll actually document something worth while when it's not
/// 1:57 AM on 2022/03/07 YYYY/MM/DD
/// </summary>
public static class Program
{
	public static void Swap(int[] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}
	
	public static void Main(string[] args)
	{
		int[] arr = { 6, 5, 3, 9, 2, 1, 7, 8, 4, 10 };
		QuickSort(arr, 0, arr.Length - 1);

		foreach (int val in arr)
			Console.Write(val + " ");
	}

	public static void QuickSort(int[] arr, int low, int high)
	{
		if (low < high)
		{
			int partitionIndex = Partition(arr, low, high);
			
			// the partitionIndex element should already be correctly placed, so don't access it
			QuickSort(arr, low, partitionIndex - 1);
			QuickSort(arr, partitionIndex + 1, high);
		}
	}

	public static int Partition(int[] arr, int low, int high)
	{
		int pivot = arr[high];
		int i = (low - 1);

		for (int j = low; j < high; ++j)
		{
			if (arr[j] < pivot)
			{
				++i;
				Swap(arr, i, j);
			}
		}
		
		Swap(arr, i + 1, high);
		return (i + 1);
	}
}