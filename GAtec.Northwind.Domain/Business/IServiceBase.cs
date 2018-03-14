using GAtec.Northwind.Util;

namespace GAtec.Northwind.Domain.Business
{
    public interface IServiceBase
    {
        IValidationError Validator { get; set; }
    }
}
