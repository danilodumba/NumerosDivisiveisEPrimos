using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumerosDivisiveisEPrimos.Lib;

namespace NumerosDivisiveisEPrimos.Test;

public class DivisorNumberExtensionTest
{
    [Fact]
    public void Deve_Retornar_Numeros_Divisiveis_Dado_Um_Numero_Aleatorio()
    {
        const long numeroAleatorio = 45;
        List<long> numerosQueDevemSerGerados = [1, 3, 5, 9, 15, 45];

        var numerosDivisiveis = numeroAleatorio.NumerosDivisiveis();

        Assert.Equal(numerosQueDevemSerGerados, numerosDivisiveis);
    }
}


public class PrimeNumberExtensionTest
{
    [Fact]
    public void Deve_Retornar_Numeros_Primos_Dado_Uma_Colecao_Aleatoria()
    {
        List<long> colecaoAleatoria = [1, 3, 5, 9, 15, 45];
        List<long> numerosPrimos = [1, 3, 5];

        var numerosPrimosGerados = colecaoAleatoria.NumerosPrimos();

        Assert.Equal(numerosPrimos, numerosPrimosGerados);
    }
}