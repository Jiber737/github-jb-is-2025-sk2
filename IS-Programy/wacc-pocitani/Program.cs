Console.WriteLine("Hej kamo jdeme si spocitat wacc, coz jse vazeny aritmeticky prumer");
Console.WriteLine("vzorec pro jeho vypocet je tento wacc=(E/V)*Re + (D/V)*Rd*(1-Tc)");
Console.WriteLine("Zadej E (tržní hodnota vlastního kapitálu): ");
double E = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Zadej D (tržní hodnota dluhu): ");
double D = Convert.ToDouble(Console.ReadLine());
double V = E + D;
Console.WriteLine(" V (celková tržní hodnota kapitálu) se tedy rovná: {0}", V);
Console.WriteLine("Zadej Re (náklady na vlastní kapitál v procentech): ");
double Re = Convert.ToDouble(Console.ReadLine()) / 100;
Console.WriteLine("Zadej Rd (náklady na dluh v procentech): ");
double Rd = Convert.ToDouble(Console.ReadLine()) / 100;
Console.WriteLine("Zadej Tc (daňová sazba v procentech) (obvykle 21%): ");
double Tc = Convert.ToDouble(Console.ReadLine()) / 100;
double wacc = (E / V) * Re + (D / V) * Rd * (1 - Tc);
Console.WriteLine("WACC (vážený průměr nákladů na kapitál) je tedy: {0} %", wacc * 100);
Console.ReadLine();

