using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqOrder : MonoBehaviour
    {
        private void Start()
        {
            // クエリ構文
            // var bs = from b in AppTables.Books
            //     orderby b.Price descending, b.Published
            //     select b;
            
            // foreach (var b in bs)
            // {
            //     Debug.Log(b);
            // }

            // メソッド構文
            var bs = AppTables.Books
                .OrderByDescending(b => b.Price)
                .ThenBy(b => b.Published)
                .Select(b => b);
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}