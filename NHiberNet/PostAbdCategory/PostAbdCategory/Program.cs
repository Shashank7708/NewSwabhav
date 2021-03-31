using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAbdCategory
{
   public class Program
    {
        public static void Main(string[] args)
        {

            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {/*
                    var post = session.Query<Post>().ToList();
                    var categorylist = session.Query<Category>().ToList();
                    foreach(var i in post)
                    {
                        session.Delete(i);
                    }
                    foreach (var i in categorylist)
                    {
                        session.Delete(i);
                    }
                    */
                    var category = new Category
                    {
                        Id = 344,
                        Name = "yonkey"
                    };
                    var post = new Post
                    {
                        Id = 466,
                        Title = "tesson"

                    };
                    post.Category = category;
                    category.Post.Add(post);



                    
                    
                    session.Save(category);
                    transaction.Commit();
                    Console.WriteLine("Success");
                }
                Console.ReadKey();
            }
        }
   }
}
