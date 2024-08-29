using System.Linq;
using UnityEngine;


namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqLike : MonoBehaviour
    {
        private void Start()
        {
            // クエリ構文
            // var bs = from b in AppTables.Books
            //     where b.Title.Contains("Android")
            //     select b;

            // メソッド構文
            var bs = AppTables.Books
                .Where(b => b.Title.Contains("Android"))
                .Select(b => b);
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}