using Thornthwaite.Models;

namespace Thornthwaite.Services.Interface;

public interface ICalculateService
{
    TableModel SicaklikIndisi(InputModel model);
    TableModel DuzeltilmemisPE(InputModel model, double sicaklikIndisYillik);
}
