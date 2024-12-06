﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib;

public class Sorting
{
    public static void BubbleSort(int[] array)
    {
        for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
        {
            for (int i = 0; i < partIndex; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                }
            }
        }
    }

    public static void SelectionSort(int[] array)
    {
        // [2, 4, 1, 3]
        int largestAt;
        for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
        {
            largestAt = 0;
            for (int i = 1; i <= partIndex; i++)
            {
                if (array[i] > array[largestAt])
                {
                    largestAt = i;
                }
            }
            Swap(array, largestAt, partIndex);
        }
    }

    public static void SelectionSort2(int[] a)
    {
        int minIndex;
        int minValue;
        for (int i = 0; i < a.Length - 1; i++)
        {
            minIndex = i;
            minValue = a[i];

            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] < minValue)
                {
                    minIndex = j;
                    minValue = a[j];
                }
            }
            (a[i], a[minIndex]) = (a[minIndex], a[i]);
        }
    }

    public static void InsertionSort(int[] array)
    {
        for (int partIndex = 1; partIndex < array.Length; partIndex++)
        {
            int curUnsorted = array[partIndex];
            int i = 0;
            for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
            {
                array[i] = array[i - 1];
            }
            array[i] = curUnsorted;
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        if (i == j) return;

        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

