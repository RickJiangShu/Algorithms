/*
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
}