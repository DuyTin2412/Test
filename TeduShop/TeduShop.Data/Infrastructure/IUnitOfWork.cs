using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Data.Infrastructure
{
    public interface IUnitOfWork // dinh nghia cho cac giao tiep giua cac class
    {
        void Commit();
    }
}
