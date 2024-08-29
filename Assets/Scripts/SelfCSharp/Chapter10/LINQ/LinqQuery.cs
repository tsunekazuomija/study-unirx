using UnityEngine;
using System.Linq;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqQuery : MonoBehaviour
    {
        private void Start()
        {
            // var bs = from b in AppTables.Books
            //     where b.Price < 3000
            //     select new { Title = b.Title, Price = b.Price };

            // メソッド構文
            var bs = AppTables.Books
                .Where(b => b.Price < 3000)
                .Select(b => b.Title);
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}