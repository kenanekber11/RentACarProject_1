using DataAccess.Abstract;
using Core.DataAccess;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : EFEntityRepositoryBase<Color, RentCarDbContext>,IColorDal
    {
       
    }
}
