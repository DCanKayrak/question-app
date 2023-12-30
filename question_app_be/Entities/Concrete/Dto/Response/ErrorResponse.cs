using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Response
{
    public class ErrorResponse
    {
        public static readonly ErrorResponse NOT_FOUND = new(1001,"Bulunamadı!");
        public static readonly ErrorResponse UPDATE_FAILED = new(1002, "Güncelleme sırasında bir hata meydana geldi");
        public static readonly ErrorResponse DELETE_FAILED = new(1003, "Silerken bir hata meydana geldi");
        public static readonly ErrorResponse GET_FAILED = new(1004, "Veriler gelirken bir hata meydana geldi");
        public int Code { get; set; }
        public string Message { get; set; }
        public ErrorResponse(int Code, string Message)
        {
            this.Code = Code;
            this.Message = Message;
        }
    }

}
