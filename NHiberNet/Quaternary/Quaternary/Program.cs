using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaternary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session2 = Helper10.OpenSession())
            {
                using (var transaction = session2.BeginTransaction())
                {
                    var category = new Category { name = "yomy" };
                    var post = new Post { title = "GtAway" };


                    post.Category=category;
                    session2.Save(post);
                    if (post is Post)
                    {
                        category.Post.Add(post);
                    }
                    session2.Save(category);
                   
                    transaction.Commit();
                    Console.WriteLine("hello");



                }
            }
            Console.ReadLine();

        }
    }
}
