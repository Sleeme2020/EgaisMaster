using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IEntityHelpers<T>
    {
        T Copy(T enty);
    }
}
