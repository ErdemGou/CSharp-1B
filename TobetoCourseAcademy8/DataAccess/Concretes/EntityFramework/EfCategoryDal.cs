﻿using System;
using System.Linq.Expressions;
using Core.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, CourseAcademyContext>, ICategoryDal
    {       
        
    }
}

