using System;
using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqSelect : MonoBehaviour
    {
        private void Start()
        {
            // クエリ構文
            // var bs = from b in AppTables.Books
            //     select new
            //     {
            //         ShortTitle = b.Title.Substring(0, 5),
            //         DiscountPrice = b.Price * 0.9,
            //         Released = b.Published <= DateTime.Now ? "発売中" : "発売予定"
            //     };

            // メソッド構文
            var bs = AppTables.Books
                .Select(b => new
                {
                    ShortTitle = b.Title.Substring(0, 5),
                    DiscountPrice = b.Price * 0.9,
                    Released = b.Published <= DateTime.Now ? "発売中" : "発売予定"
                });
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}