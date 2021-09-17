using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal
    {
        void BlogAdd(Blog blog);
        List<Blog> GetAllBlog();
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        Blog GetBlogById(int id);
    }
}
