using Thornthwaite.Models;

namespace Thornthwaite.Services.Interface;

public interface IAylikOralamaSicaklikService
{
    TableModel SicaklikIndisi(InputModel model);
    TableModel DuzeltilmemisPE(InputModel model, double sicaklikIndisYillik);
    TableModel EnlemKatsayisi(int selectedLatitude);
    TableModel DuzeltilmisPE(TableModel duzeltilmemisPE, TableModel enlemKatsayisi);
}
