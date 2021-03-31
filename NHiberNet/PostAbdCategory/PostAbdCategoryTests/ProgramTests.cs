using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostAbdCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAbdCategory.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
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

                    Post post1 = new Post { Title = "Vntartica" };
                    Category category = new Category { Id = 23, Name = "Reography" };

                    category.Post.Add(post1);
                    post1.Category = category;


                    session.Save(category); ;

                    transaction.Commit();
                    Assert.Fail();
                }
            }
        
        }
    }
}