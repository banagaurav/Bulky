using System;

namespace Bulky.DataAccess.Repository.IRepository;

public interface IUnitofWork
{
    ICategoryRepository Category { get; }
    void Save();
}
