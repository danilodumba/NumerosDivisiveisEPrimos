
namespace NumerosDivisiveisEPrimos.Lib;
public static class NumerosDivisiveisEPrimosExtension
{
    public static List<long> NumerosDivisiveis(this long number)
    {
        List<long> numerosDivisiveis = [];    

        for (long i = number; i > 0; i--)
        {
            if (number % i == 0)
            {
                numerosDivisiveis.Add(i);
            }
        }

        return numerosDivisiveis.Order().ToList();
    }

    public static List<long> NumerosPrimos(this List<long> numbers)
    {
        List<long> numerosPrimos = [];    

        foreach (var number in numbers)
        {
            for (long i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    if (i == 1)
                    {
                        numerosPrimos.Add(number);
                        break;
                    }

                    if (number == i)
                        continue;
                    
                    break;
                }
            }
        }

        return numerosPrimos.Order().ToList();
    }
}