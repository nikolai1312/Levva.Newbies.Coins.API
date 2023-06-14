﻿using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface ICategoryService
    {
        Category Create(CategoryDto category);

        CategoryDto Get(Guid id);

        List<CategoryDto> GetAll();

        void Update(CategoryDto category);

        void Delete(Guid id);

    }
}