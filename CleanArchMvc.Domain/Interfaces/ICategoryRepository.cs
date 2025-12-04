using System;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetCategorties();
    Task<Category> GetById(int id);
    Task Add(Category category);
    Task Update(Category category);
    Task Delete(Category category);
}
