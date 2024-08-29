using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqGroupMulti : MonoBehaviour
    {
        private void Start()
        {
            var bs = from b in AppTables.Books
                group b by new
                {
                    Publisher = b.Publisher,
                    PublishYear = b.Published.Year
                };
            
            foreach (var b in bs)
            {
                Debug.Log($"[{b.Key.Publisher} - {b.Key.PublishYear}年]");
                foreach (var book in b)
                {
                    Debug.Log(book.Title);
                }
            }
        }
    }
}