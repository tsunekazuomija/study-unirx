using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqInto2 : MonoBehaviour
    {
        private void Start()
        {
            // グループ化キーで結果をソートする
            var bs = from b in AppTables.Books
                group b by new {
                    PublishYear = b.Published.Year,
                    PublishMonth = b.Published.Month
                } into pubs
                orderby pubs.Key.PublishYear, pubs.Key.PublishMonth
                select pubs;
            
            foreach (var b in bs)
            {
                Debug.Log($"[{b.Key.PublishYear}年 - {b.Key.PublishMonth}月]");
                foreach (var book in b)
                {
                    Debug.Log(book.Title);
                }
            }
        }
    }
}