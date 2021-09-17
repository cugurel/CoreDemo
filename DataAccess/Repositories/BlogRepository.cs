using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void BlogAdd(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void BlogDelete(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void BlogUpdate(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }

        public List<Blog> GetAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public Blog GetBlogById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }
    }
}
