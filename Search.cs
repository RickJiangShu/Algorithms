﻿/*
 * Author:  Rick
 * Create:  2017/12/8 15:45:44
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */
using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 搜索算法
/// </summary>
public static class Search
{
    #region 线性查找程序
    public static int Linear<T>(IList<T> a, T x) where T : IEquatable<T>
    {
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i].Equals(x))
            {
                return i;
            }
        }
        return -1;
    }
    #endregion

    /// <summary>
    /// 二分查找
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    /// <param name="a">数组</param>
    /// <param name="x">查找的元素</param>
    /// <returns>索引</returns>
    public static int Binary<T>(IList<T> a, T x) where T : IEquatable<T>, IComparable<T>
    {
        int p = 0;
        int r = a.Count;
        while (p < r)
        {
            int q = (p + r) / 2;
            if (a[q].Equals(x))
                return q;

            int result = a[q].CompareTo(x);
            if (result > 0)
                r = q - 1;
            else
                p = q + 1;
        }
        return -1;
    }

    public static int RecursiveBinary<T>(IList<T> a, int p, int r, T x) where T : IEquatable<T>, IComparable<T>
    {
        if (p >= r)
            return -1;

        int q = (p + r) / 2;
        if (a[q].Equals(x))
            return q;

        int result = a[q].CompareTo(x);
        if (result > 0)
            return RecursiveBinary<T>(a, p, q - 1, x);
        else
            return RecursiveBinary<T>(a, q + 1, r, x);
    }
}