using UnityEngine;
using System.Linq;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqBetween : MonoBehaviour
    {
        private void Start()
        {
            // var bs = from b in AppTables.Books
            //     where 2000 <= b.Price && b.Price <= 3500
            //     select b;

            // 列記しても良い
            var bs = from b in AppTables.Books
                where b.Price >=2000
                where b.Price <= 3500
                select b;
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}