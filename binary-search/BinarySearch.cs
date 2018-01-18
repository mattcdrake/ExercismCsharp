using System;

public class BinarySearch
{
    int[] _array;

    public BinarySearch(int[] input) {
        _array = input;
    }

    public int Find(int value) {
        int left = 0, right = _array.Length - 1;
        int mid = (left + right) / 2;

        while (left <= right) {
            if (_array[mid] == value) {
                return mid;
            }
            else {
                if (_array[mid] > value) {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
                mid = (left + right) / 2;
            }
        }

        return -1;
    }
}