using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class Test2 : MonoBehaviour
    {
        private void Start()
        {
            var bs = AppTables.Books
                .Where(b => b.Published < new System.DateTime(2021, 10, 1))
                .OrderBy(b => b.Publisher)
                .ThenBy(b => b.Title)
                .Select(b => new
                {
                    Title = b.Title[..5],
                    Price = b.Price,
                    Publisher = b.Publisher
                });
            
            foreach (var b in bs)
            {
                Debug.Log($"{b.Publisher} {b.Title} ({b.Price}円)");
            }
        }
    }
}