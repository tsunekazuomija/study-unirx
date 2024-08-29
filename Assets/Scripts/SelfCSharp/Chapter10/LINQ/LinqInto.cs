using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqInto : MonoBehaviour
    {
        private void Start()
        {
            var bs = from b in AppTables.Books
                group b by b.Publisher into pubs
                where pubs.Average(b => b.Price) > 3500
                select new
                {
                    Publisher = pubs.Key,
                    AveragePrice = pubs.Average(b => b.Price)
                };
            
            foreach (var b in bs)
            {
                Debug.Log($"{b.Publisher} {b.AveragePrice}円");
            }
        }
    }
}