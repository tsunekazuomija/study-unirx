using UnityEngine;
using System.Linq;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqIn : MonoBehaviour
    {
        private void Start()
        {
            var bs = from b in AppTables.Books
                where new int[] {3, 6}.Contains(b.Published.Month)
                select b;
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}