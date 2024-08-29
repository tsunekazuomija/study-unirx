using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqGroup : MonoBehaviour
    {
        private void Start()
        {
            // var bs = from b in AppTables.Books
            //     group b by b.Publisher;

            // var bs = AppTables.Books
            //     .GroupBy(b => b.Publisher);

            var bs = AppTables.Books
                .GroupBy(
                    b => b.Publisher,
                    b => new {Title=b.Title, Price=b.Price}
                );
            
            foreach (var b in bs)
            {
                Debug.Log($"[{b.Key}]");
                foreach (var book in b)
                {
                    Debug.Log($"{book.Title} ({book.Price}円)");
                }
            }
        }
    }
}