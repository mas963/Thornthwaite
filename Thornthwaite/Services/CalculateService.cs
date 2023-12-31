using System.Text.RegularExpressions;
using Thornthwaite.Models;
using Thornthwaite.Services.Interface;

namespace Thornthwaite.Services;

public class CalculateService : ICalculateService
{
    public TableModel SicaklikIndisi(InputModel model)
    {
        double[,] matris = new double[40, 10];

        #region Matris values
        matris[0, 0] = 0;
        matris[0, 1] = 0;
        matris[0, 2] = 0.01;
        matris[0, 3] = 0.01;
        matris[0, 4] = 0.02;
        matris[0, 5] = 0.03;
        matris[0, 6] = 0.04;
        matris[0, 7] = 0.05;
        matris[0, 8] = 0.06;
        matris[0, 9] = 0.07;
        matris[1, 0] = 0.09;
        matris[1, 1] = 0.10;
        matris[1, 2] = 0.12;
        matris[1, 3] = 0.13;
        matris[1, 4] = 0.15;
        matris[1, 5] = 0.16;
        matris[1, 6] = 0.18;
        matris[1, 7] = 0.20;
        matris[1, 8] = 0.21;
        matris[1, 9] = 0.23;
        matris[2, 0] = 0.25;
        matris[2, 1] = 0.27;
        matris[2, 2] = 0.29;
        matris[2, 3] = 0.31;
        matris[2, 4] = 0.33;
        matris[2, 5] = 0.35;
        matris[2, 6] = 0.37;
        matris[2, 7] = 0.39;
        matris[2, 8] = 0.42;
        matris[2, 9] = 0.44;
        matris[3, 0] = 0.46;
        matris[3, 1] = 0.48;
        matris[3, 2] = 0.51;
        matris[3, 3] = 0.53;
        matris[3, 4] = 0.56;
        matris[3, 5] = 0.58;
        matris[3, 6] = 0.61;
        matris[3, 7] = 0.63;
        matris[3, 8] = 0.66;
        matris[3, 9] = 0.69;
        matris[4, 0] = 0.71;
        matris[4, 1] = 0.74;
        matris[4, 2] = 0.77;
        matris[4, 3] = 0.80;
        matris[4, 4] = 0.82;
        matris[4, 5] = 0.85;
        matris[4, 6] = 0.88;
        matris[4, 7] = 0.91;
        matris[4, 8] = 0.94;
        matris[4, 9] = 0.97;
        matris[5, 0] = 1;
        matris[5, 1] = 1.03;
        matris[5, 2] = 1.06;
        matris[5, 3] = 1.09;
        matris[5, 4] = 1.12;
        matris[5, 5] = 1.16;
        matris[5, 6] = 1.19;
        matris[5, 7] = 1.22;
        matris[5, 8] = 1.25;
        matris[5, 9] = 1.29;
        matris[6, 0] = 1.32;
        matris[6, 1] = 1.35;
        matris[6, 2] = 1.39;
        matris[6, 3] = 1.42;
        matris[6, 4] = 1.45;
        matris[6, 5] = 1.49;
        matris[6, 6] = 1.52;
        matris[6, 7] = 1.56;
        matris[6, 8] = 1.59;
        matris[6, 9] = 1.63;
        matris[7, 0] = 1.66;
        matris[7, 1] = 1.70;
        matris[7, 2] = 1.74;
        matris[7, 3] = 1.77;
        matris[7, 4] = 1.81;
        matris[7, 5] = 1.85;
        matris[7, 6] = 1.89;
        matris[7, 7] = 1.92;
        matris[7, 8] = 1.96;
        matris[7, 9] = 2;
        matris[8, 0] = 2.04;
        matris[8, 1] = 2.08;
        matris[8, 2] = 2.12;
        matris[8, 3] = 2.15;
        matris[8, 4] = 2.19;
        matris[8, 5] = 2.23;
        matris[8, 6] = 2.27;
        matris[8, 7] = 2.31;
        matris[8, 8] = 2.35;
        matris[8, 9] = 2.39;
        matris[9, 0] = 2.44;
        matris[9, 1] = 2.48;
        matris[9, 2] = 2.52;
        matris[9, 3] = 2.56;
        matris[9, 4] = 2.60;
        matris[9, 5] = 2.64;
        matris[9, 6] = 2.69;
        matris[9, 7] = 2.73;
        matris[9, 8] = 2.77;
        matris[9, 9] = 2.81;
        matris[10, 0] = 2.86;
        matris[10, 1] = 2.90;
        matris[10, 2] = 2.94;
        matris[10, 3] = 2.99;
        matris[10, 4] = 3.03;
        matris[10, 5] = 3.08;
        matris[10, 6] = 3.12;
        matris[10, 7] = 3.16;
        matris[10, 8] = 3.21;
        matris[10, 9] = 3.25;
        matris[11, 0] = 3.30;
        matris[11, 1] = 3.34;
        matris[11, 2] = 3.39;
        matris[11, 3] = 3.44;
        matris[11, 4] = 3.48;
        matris[11, 5] = 3.53;
        matris[11, 6] = 3.58;
        matris[11, 7] = 3.62;
        matris[11, 8] = 3.67;
        matris[11, 9] = 3.72;
        matris[12, 0] = 3.76;
        matris[12, 1] = 3.81;
        matris[12, 2] = 3.86;
        matris[12, 3] = 3.91;
        matris[12, 4] = 3.96;
        matris[12, 5] = 4;
        matris[12, 6] = 4.05;
        matris[12, 7] = 4.10;
        matris[12, 8] = 4.15;
        matris[12, 9] = 4.20;
        matris[13, 0] = 4.25;
        matris[13, 1] = 4.30;
        matris[13, 2] = 4.35;
        matris[13, 3] = 4.40;
        matris[13, 4] = 4.45;
        matris[13, 5] = 4.50;
        matris[13, 6] = 4.55;
        matris[13, 7] = 4.60;
        matris[13, 8] = 4.65;
        matris[13, 9] = 4.70;
        matris[14, 0] = 4.75;
        matris[14, 1] = 4.81;
        matris[14, 2] = 4.86;
        matris[14, 3] = 4.91;
        matris[14, 4] = 4.96;
        matris[14, 5] = 5.01;
        matris[14, 6] = 5.07;
        matris[14, 7] = 5.12;
        matris[14, 8] = 5.17;
        matris[14, 9] = 5.22;
        matris[15, 0] = 5.28;
        matris[15, 1] = 5.33;
        matris[15, 2] = 5.38;
        matris[15, 3] = 5.44;
        matris[15, 4] = 5.49;
        matris[15, 5] = 5.55;
        matris[15, 6] = 5.60;
        matris[15, 7] = 5.65;
        matris[15, 8] = 5.71;
        matris[15, 9] = 5.76;
        matris[16, 0] = 5.82;
        matris[16, 1] = 5.87;
        matris[16, 2] = 5.93;
        matris[16, 3] = 5.98;
        matris[16, 4] = 6.04;
        matris[16, 5] = 6.10;
        matris[16, 6] = 6.15;
        matris[16, 7] = 6.21;
        matris[16, 8] = 6.26;
        matris[16, 9] = 6.32;
        matris[17, 0] = 6.38;
        matris[17, 1] = 6.44;
        matris[17, 2] = 6.49;
        matris[17, 3] = 6.55;
        matris[17, 4] = 6.61;
        matris[17, 5] = 6.66;
        matris[17, 6] = 6.72;
        matris[17, 7] = 6.78;
        matris[17, 8] = 6.84;
        matris[17, 9] = 6.90;
        matris[18, 0] = 6.95;
        matris[18, 1] = 7.01;
        matris[18, 2] = 7.07;
        matris[18, 3] = 7.13;
        matris[18, 4] = 7.19;
        matris[18, 5] = 7.25;
        matris[18, 6] = 7.31;
        matris[18, 7] = 7.37;
        matris[18, 8] = 7.43;
        matris[18, 9] = 7.49;
        matris[19, 0] = 7.55;
        matris[19, 1] = 7.61;
        matris[19, 2] = 7.67;
        matris[19, 3] = 7.73;
        matris[19, 4] = 7.79;
        matris[19, 5] = 7.85;
        matris[19, 6] = 7.91;
        matris[19, 7] = 7.97;
        matris[19, 8] = 8.03;
        matris[19, 9] = 8.10;
        matris[20, 0] = 8.16;
        matris[20, 1] = 8.22;
        matris[20, 2] = 8.28;
        matris[20, 3] = 8.34;
        matris[20, 4] = 8.41;
        matris[20, 5] = 8.47;
        matris[20, 6] = 8.53;
        matris[20, 7] = 8.59;
        matris[20, 8] = 8.66;
        matris[20, 9] = 8.72;
        matris[21, 0] = 8.78;
        matris[21, 1] = 8.85;
        matris[21, 2] = 8.91;
        matris[21, 3] = 8.97;
        matris[21, 4] = 9.04;
        matris[21, 5] = 9.10;
        matris[21, 6] = 9.17;
        matris[21, 7] = 9.23;
        matris[21, 8] = 9.29;
        matris[21, 9] = 9.36;
        matris[22, 0] = 9.42;
        matris[22, 1] = 9.49;
        matris[22, 2] = 9.55;
        matris[22, 3] = 9.62;
        matris[22, 4] = 9.68;
        matris[22, 5] = 9.75;
        matris[22, 6] = 9.82;
        matris[22, 7] = 9.88;
        matris[22, 8] = 9.95;
        matris[22, 9] = 10.01;
        matris[23, 0] = 10.08;
        matris[23, 1] = 10.15;
        matris[23, 2] = 10.21;
        matris[23, 3] = 10.28;
        matris[23, 4] = 10.35;
        matris[23, 5] = 10.41;
        matris[23, 6] = 10.48;
        matris[23, 7] = 10.55;
        matris[23, 8] = 10.62;
        matris[23, 9] = 10.68;
        matris[24, 0] = 10.75;
        matris[24, 1] = 10.82;
        matris[24, 2] = 10.89;
        matris[24, 3] = 10.95;
        matris[24, 4] = 11.02;
        matris[24, 5] = 11.09;
        matris[24, 6] = 11.15;
        matris[24, 7] = 11.23;
        matris[24, 8] = 11.30;
        matris[24, 9] = 11.37;
        matris[25, 0] = 11.44;
        matris[25, 1] = 11.50;
        matris[25, 2] = 11.57;
        matris[25, 3] = 11.64;
        matris[25, 4] = 11.71;
        matris[25, 5] = 11.78;
        matris[25, 6] = 11.85;
        matris[25, 7] = 11.92;
        matris[25, 8] = 11.99;
        matris[25, 9] = 12.06;
        matris[26, 0] = 12.13;
        matris[26, 1] = 12.21;
        matris[26, 2] = 12.28;
        matris[26, 3] = 12.35;
        matris[26, 4] = 12.42;
        matris[26, 5] = 12.49;
        matris[26, 6] = 12.56;
        matris[26, 7] = 12.63;
        matris[26, 8] = 12.70;
        matris[26, 9] = 12.78;
        matris[27, 0] = 12.85;
        matris[27, 1] = 12.92;
        matris[27, 2] = 12.99;
        matris[27, 3] = 13.07;
        matris[27, 4] = 13.14;
        matris[27, 5] = 13.21;
        matris[27, 6] = 13.26;
        matris[27, 7] = 13.36;
        matris[27, 8] = 13.43;
        matris[27, 9] = 13.50;
        matris[28, 0] = 13.58;
        matris[28, 1] = 13.65;
        matris[28, 2] = 13.72;
        matris[28, 3] = 13.80;
        matris[28, 4] = 13.87;
        matris[28, 5] = 13.94;
        matris[28, 6] = 14.02;
        matris[28, 7] = 14.09;
        matris[28, 8] = 14.17;
        matris[28, 9] = 14.24;
        matris[29, 0] = 14.32;
        matris[29, 1] = 14.39;
        matris[29, 2] = 14.47;
        matris[29, 3] = 14.54;
        matris[29, 4] = 14.62;
        matris[29, 5] = 14.69;
        matris[29, 6] = 14.77;
        matris[29, 7] = 14.84;
        matris[29, 8] = 14.92;
        matris[29, 9] = 14.99;
        matris[30, 0] = 15.07;
        matris[30, 1] = 15.15;
        matris[30, 2] = 15.22;
        matris[30, 3] = 15.30;
        matris[30, 4] = 15.38;
        matris[30, 5] = 15.45;
        matris[30, 6] = 15.53;
        matris[30, 7] = 15.61;
        matris[30, 8] = 15.68;
        matris[30, 9] = 15.76;
        matris[31, 0] = 15.84;
        matris[31, 1] = 15.92;
        matris[31, 2] = 15.99;
        matris[31, 3] = 16.07;
        matris[31, 4] = 16.15;
        matris[31, 5] = 16.23;
        matris[31, 6] = 16.30;
        matris[31, 7] = 16.38;
        matris[31, 8] = 16.46;
        matris[31, 9] = 16.54;
        matris[32, 0] = 16.61;
        matris[32, 1] = 16.70;
        matris[32, 2] = 16.78;
        matris[32, 3] = 16.85;
        matris[32, 4] = 16.93;
        matris[32, 5] = 17.01;
        matris[32, 6] = 17.09;
        matris[32, 7] = 17.17;
        matris[32, 8] = 17.25;
        matris[32, 9] = 17.33;
        matris[33, 0] = 17.41;
        matris[33, 1] = 17.49;
        matris[33, 2] = 17.57;
        matris[33, 3] = 17.65;
        matris[33, 4] = 17.73;
        matris[33, 5] = 17.81;
        matris[33, 6] = 17.89;
        matris[33, 7] = 17.97;
        matris[33, 8] = 18.05;
        matris[33, 9] = 18.13;
        matris[34, 0] = 18.22;
        matris[34, 1] = 18.30;
        matris[34, 2] = 18.38;
        matris[34, 3] = 18.46;
        matris[34, 4] = 18.54;
        matris[34, 5] = 18.62;
        matris[34, 6] = 18.70;
        matris[34, 7] = 18.79;
        matris[34, 8] = 18.87;
        matris[34, 9] = 18.95;
        matris[35, 0] = 19.03;
        matris[35, 1] = 19.11;
        matris[35, 2] = 19.20;
        matris[35, 3] = 19.28;
        matris[35, 4] = 19.36;
        matris[35, 5] = 19.45;
        matris[35, 6] = 19.53;
        matris[35, 7] = 19.61;
        matris[35, 8] = 19.69;
        matris[35, 9] = 19.78;
        matris[36, 0] = 19.86;
        matris[36, 1] = 19.95;
        matris[36, 2] = 20.03;
        matris[36, 3] = 20.11;
        matris[36, 4] = 20.20;
        matris[36, 5] = 20.28;
        matris[36, 6] = 20.36;
        matris[36, 7] = 20.45;
        matris[36, 8] = 20.53;
        matris[36, 9] = 20.62;
        matris[37, 0] = 20.70;
        matris[37, 1] = 20.79;
        matris[37, 2] = 20.87;
        matris[37, 3] = 20.96;
        matris[37, 4] = 21.04;
        matris[37, 5] = 21.13;
        matris[37, 6] = 21.21;
        matris[37, 7] = 21.30;
        matris[37, 8] = 21.38;
        matris[37, 9] = 21.47;
        matris[38, 0] = 21.56;
        matris[38, 1] = 21.64;
        matris[38, 2] = 21.73;
        matris[38, 3] = 21.81;
        matris[38, 4] = 21.90;
        matris[38, 5] = 21.99;
        matris[38, 6] = 22.07;
        matris[38, 7] = 22.16;
        matris[38, 8] = 22.25;
        matris[38, 9] = 22.33;
        matris[39, 0] = 22.42;
        matris[39, 1] = 22.51;
        matris[39, 2] = 22.59;
        matris[39, 3] = 22.68;
        matris[39, 4] = 22.77;
        matris[39, 5] = 22.86;
        matris[39, 6] = 22.95;
        matris[39, 7] = 23.03;
        matris[39, 8] = 23.12;
        matris[39, 9] = 23.21;
        #endregion

        int ocakTamSayi;
        int ocakOndaBirler;
        ProcessProperty(model.Ocak, out ocakTamSayi, out ocakOndaBirler);

        int subatTamSayi;
        int subatOndaBirler;
        ProcessProperty(model.Subat, out subatTamSayi, out subatOndaBirler);

        int martTamSayi;
        int martOndaBirler;
        ProcessProperty(model.Mart, out martTamSayi, out martOndaBirler);

        int nisanTamSayi;
        int nisanOndaBirler;
        ProcessProperty(model.Nisan, out nisanTamSayi, out nisanOndaBirler);

        int mayisTamSayi;
        int mayisOndaBirler;
        ProcessProperty(model.Mayis, out mayisTamSayi, out mayisOndaBirler);

        int haziranTamSayi;
        int haziranOndaBirler;
        ProcessProperty(model.Haziran, out haziranTamSayi, out haziranOndaBirler);

        int temmuzTamSayi;
        int temmuzOndaBirler;
        ProcessProperty(model.Temmuz, out temmuzTamSayi, out temmuzOndaBirler);

        int agustosTamSayi;
        int agustosOndaBirler;
        ProcessProperty(model.Agustos, out agustosTamSayi, out agustosOndaBirler);

        int eylulTamSayi;
        int eylulOndaBirler;
        ProcessProperty(model.Eylul, out eylulTamSayi, out eylulOndaBirler);

        int ekimTamSayi;
        int ekimOndaBirler;
        ProcessProperty(model.Ekim, out ekimTamSayi, out ekimOndaBirler);

        int kasimTamSayi;
        int kasimOndaBirler;
        ProcessProperty(model.Kasim, out kasimTamSayi, out kasimOndaBirler);

        int aralikTamSayi;
        int aralikOndaBirler;
        ProcessProperty(model.Aralik, out aralikTamSayi, out aralikOndaBirler);

        var calculate = new TableModel
        {
            Name = "Sıcaklık İndisi",
            Ocak = matris[ocakTamSayi, ocakOndaBirler],
            Subat = matris[subatTamSayi, subatOndaBirler],
            Mart = matris[martTamSayi, martOndaBirler],
            Nisan = matris[nisanTamSayi, nisanOndaBirler],
            Mayis = matris[mayisTamSayi, mayisOndaBirler],
            Haziran = matris[haziranTamSayi, haziranOndaBirler],
            Temmuz = matris[temmuzTamSayi, temmuzOndaBirler],
            Agustos = matris[agustosTamSayi, agustosOndaBirler],
            Eylul = matris[eylulTamSayi, eylulOndaBirler],
            Ekim = matris[ekimTamSayi, ekimOndaBirler],
            Kasim = matris[kasimTamSayi, kasimOndaBirler],
            Aralik = matris[aralikTamSayi, aralikOndaBirler],
        };

        calculate.Yillik = calculate.Ocak + calculate.Subat + calculate.Mart + calculate.Nisan + calculate.Mayis + calculate.Haziran + calculate.Temmuz + calculate.Agustos + calculate.Eylul + calculate.Ekim + calculate.Kasim + calculate.Aralik;

        return calculate;
    }

    private void ProcessProperty(double value, out int tamSayi, out int ondaBirler)
    {
        string pattern = @"(\d+)(?:\.(\d+))?";
        Match match = Regex.Match(value.ToString(), pattern);

        tamSayi = 0;
        ondaBirler = 0;

        if (match.Success && value > 0 && value < 40)
        {
            tamSayi = int.Parse(match.Groups[1].Value);

            if (match.Groups[2].Success)
            {
                ondaBirler = int.Parse(match.Groups[2].Value);
            }
        }
    }

    private double DuzeltilmemisPEProcessProperty(double value, double sicaklikIndisYillik)
    {
        double sonuc;

        if (sicaklikIndisYillik > 0 && value > 0)
        {
            var x = (value * 10) / sicaklikIndisYillik;
            var y = (0.016 * sicaklikIndisYillik) + 0.5;
            sonuc = Math.Pow(x, y) * 16;
        }
        else
        {
            sonuc = 0;
        }

        return sonuc;
    }

    public TableModel DuzeltilmemisPE(InputModel model, double sicaklikIndisYillik)
    {
        double ocakDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Ocak, sicaklikIndisYillik);
        double subatDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Subat, sicaklikIndisYillik);
        double martDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Mart, sicaklikIndisYillik);
        double nisanDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Nisan, sicaklikIndisYillik);
        double mayisDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Mayis, sicaklikIndisYillik);
        double haziranDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Haziran, sicaklikIndisYillik);
        double temmuzDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Temmuz, sicaklikIndisYillik);
        double agustosDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Agustos, sicaklikIndisYillik);
        double eylulDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Eylul, sicaklikIndisYillik);
        double ekimDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Ekim, sicaklikIndisYillik);
        double kasimDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Kasim, sicaklikIndisYillik);
        double aralikDuzeltilmemisPE = DuzeltilmemisPEProcessProperty(model.Aralik, sicaklikIndisYillik);

        var calculate = new TableModel
        {
            Name = "Düzeltilmemiş PE",
            Ocak = ocakDuzeltilmemisPE,
            Subat = subatDuzeltilmemisPE,
            Mart = martDuzeltilmemisPE,
            Nisan = nisanDuzeltilmemisPE,
            Mayis = mayisDuzeltilmemisPE,
            Haziran = haziranDuzeltilmemisPE,
            Temmuz = temmuzDuzeltilmemisPE,
            Agustos = agustosDuzeltilmemisPE,
            Eylul = eylulDuzeltilmemisPE,
            Ekim = ekimDuzeltilmemisPE,
            Kasim = kasimDuzeltilmemisPE,
            Aralik = aralikDuzeltilmemisPE,
        };

        return calculate;
    }
}
