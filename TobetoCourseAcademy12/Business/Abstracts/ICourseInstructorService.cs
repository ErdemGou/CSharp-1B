using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
namespace Business.Abstracts
{
	public interface ICourseInstructorService
	{
        IDataResult<List<CourseInstructor>> GetAll();
        IDataResult<CourseInstructor> GetById(int courseInstructorId);

        IResult Add(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
    }
}

