using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void CategoryAdd(Category category);
        List<Category> GetAllCategory();
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        Category GetCategoryById(int id);
    }
}
