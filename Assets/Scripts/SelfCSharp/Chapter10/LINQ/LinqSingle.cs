using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqSingle : MonoBehaviour
    {
        private void Start()
        {
            var bs = AppTables.Books
                .SingleOrDefault(b => b.Isbn == "978-4-7981-6849-4");
            
            Debug.Log(bs);
        }
    }
}