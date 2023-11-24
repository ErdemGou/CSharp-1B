using System;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
                _instructorDal = instructorDal;
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll());
        }

        public IDataResult<Instructor> GetById(int instructorId)
        {           
            return new SuccessDataResult<Instructor>(_instructorDal.Get(c => c.Id == instructorId));
        }

        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new Result(true, "Eğitmen eklendi.");
        }
        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new Result(true, "Eğitmen Silindi.");
        }
        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new Result(true, "Eğitmen Güncellendi.");
        }
    }
}

