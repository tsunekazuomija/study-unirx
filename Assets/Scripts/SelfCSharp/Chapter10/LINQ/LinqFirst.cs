using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqFirst : MonoBehaviour
    {
        private void Start()
        {
            // var bs = AppTables.Books
            //     .OrderBy(b => b.Price)
            //     .First();

            var bs = AppTables.Books
                .Where(b => b.Price > 10000)
                .OrderBy(b => b.Price)
                .FirstOrDefault(); // 該当する要素がない場合はnullを返す
        
            Debug.Log(bs);
        }
    }
}