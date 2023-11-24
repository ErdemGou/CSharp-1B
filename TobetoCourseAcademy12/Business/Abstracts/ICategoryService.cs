using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
namespace Business.Abstracts
{
	public interface ICategoryService
	{
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);

        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}

