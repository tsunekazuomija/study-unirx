using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqJoin : MonoBehaviour
    {
        private void Start()
        {
            // var bs = from b in AppTables.Books
            //     join r in AppTables.Reviews on b.Isbn equals r.Isbn // ここまででAppTables.BooksとReciewsを関連づける
            //     select new { // rに関してループを回しているっぽい。rを複製すると、出力も増える。
            //         Title = b.Title,
            //         Reviewer = r.Name,
            //         Body = r.Body
            //     };

            // メソッド構文
            var bs = AppTables.Books
                .Join(
                    AppTables.Reviews,
                    b => b.Isbn,
                    r => r.Isbn,
                    (b, r) => new
                    {
                        Title = b.Title,
                        Reviewer = r.Name,
                        Body = r.Body
                    }
                );

            foreach (var b in bs)
            {
                Debug.Log($"「{b.Title}」({b.Reviewer})");
                Debug.Log(b.Body);
                Debug.Log("-----");
            }
                
            
        }
    }
}