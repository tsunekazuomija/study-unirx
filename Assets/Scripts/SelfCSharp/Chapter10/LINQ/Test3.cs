using System;
using System.Collections.Generic;
using UnityEngine;


namespace SelfCSharp.Chapter10.LINQ
{
    public class Test3 : MonoBehaviour
    {
        public static T[] Grep<T>(T[] data, Predicate<T> condition)
        {
            var result = new List<T>();
            foreach (var value in data)
            {
                if (condition(value))
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }

        void Start()
        {
            var data = new[] { 1, 2, 7, 10, 15, 19};
            // 偶数だけ抽出
            var result = Grep(data, v => v % 2 == 0);
            foreach (var value in result)
            {
                Debug.Log(value);
            }
        }
    }
}