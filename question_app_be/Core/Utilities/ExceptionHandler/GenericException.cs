using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.ExceptionHandler
{
    public class GenericException : Exception
    {
        public ErrorResponse ErrorResponse { get; set; }
        public GenericException(ErrorResponse errorResponse)
        {
            ErrorResponse = errorResponse;
        }
    }
}
