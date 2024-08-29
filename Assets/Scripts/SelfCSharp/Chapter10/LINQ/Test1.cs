using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class Test1 : MonoBehaviour
    {
        private void Start()
        {
            var bs = from b in AppTables.Books
                where b.Title.EndsWith("入門")
                orderby b.Price descending
                select new
                {
                    Title = b.Title,
                    DiscountPrice = b.Price * 0.9
                };
            
            foreach (var b in bs)
            {
                Debug.Log($"{b.Title} {b.DiscountPrice}円");
            }
        }
    }
}