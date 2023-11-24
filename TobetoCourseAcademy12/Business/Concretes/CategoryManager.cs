using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


namespace Business.Concretes
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
                _categoryDal=categoryDal;
        }
        public IDataResult<Category> GetById(int categoryId)
        {
           return new SuccessDataResult<Category>(_categoryDal.Get(ct =>ct.Id == categoryId));
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        }

        public IResult Add(Category category)
        {
            if (category.Name.Length < 2)
            {
                return new ErrorResult(Messages.CourseAdded);
            }
            _categoryDal.Add(category);
            return new Result(true, "Kategori eklendi.");
        }
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new Result(true, "Kategori Silindi.");
        }
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new Result(true, "Kategori Güncellendi.");
        }
    }
}
