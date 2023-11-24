using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
namespace Business.Abstracts
{
	public interface IInstructorService
	{
		IDataResult<List<Instructor>> GetAll();
		IDataResult<Instructor> GetById(int instructorId);

        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);
    }
}

