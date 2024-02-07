using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Concrete;

namespace Business.Abstract
{
    public interface IRoleService : ICrudService<OperationClaim,OperationClaim>
    {
    }
}
