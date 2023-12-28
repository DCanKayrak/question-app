using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Response
{
    public class ErrorResponse
    {
        public readonly ErrorResponse NOT_FOUND = new ErrorResponse(1001,"Bulunamadı!");
        public readonly ErrorResponse USER_NOT_FOUND = new ErrorResponse(1002, "Kullanıcı Bulunamadı!");

        public int Code { get; set; }
        public string Message { get; set; }
        public ErrorResponse(int Code, string Message)
        {
            this.Code = Code;
            this.Message = Message;
        }
    }

}
