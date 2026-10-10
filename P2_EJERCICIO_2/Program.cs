using System;

class CilindroNeumatico
{
    public double PresionKPa { get; set; }
    public double AreaCm2 { get; set; }
    public double FuerzaMinima { get; set; }

    public double ConvertirPresion()
    {
        double presionPa;

        presionPa = PresionKPa * 1000;

        return presionPa;
    }

    public double ConvertirArea()
    {
        double areaM2;

        areaM2 = AreaCm2 * 0.0001;

        return areaM2;
    }

    public double CalcularFuerza()
    {
        double presionPa;
        double areaM2;
        double fuerza;

        presionPa = ConvertirPresion();
        areaM2 = ConvertirArea();

        fuerza = presionPa * areaM2;

        return fuerza;
    }

    public bool CumpleRequerimiento()
    {
        double fuerza;

        fuerza = CalcularFuerza();

        if (fuerza >= FuerzaMinima)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        CilindroNeumatico cilindro1 = new CilindroNeumatico();

        Console.Write("Ingrese la presión en kPa: ");
        cilindro1.PresionKPa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el área del pistón en cm2: ");
        cilindro1.AreaCm2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la fuerza mínima requerida en N: ");
        cilindro1.FuerzaMinima = Convert.ToDouble(Console.ReadLine());

        double presionPa;
        double areaM2;
        double fuerza;
        bool cumple;

        presionPa = cilindro1.ConvertirPresion();
        areaM2 = cilindro1.ConvertirArea();
        fuerza = cilindro1.CalcularFuerza();
        cumple = cilindro1.CumpleRequerimiento();

        Console.WriteLine();
        Console.WriteLine("--- RESULTADOS ---");
        Console.WriteLine("Presión: " + presionPa + " Pa");
        Console.WriteLine("Área: " + areaM2 + " m2");
        Console.WriteLine("Fuerza: " + fuerza + " N");

        if (cumple == true)
        {
            Console.WriteLine("Resultado: La fuerza CUMPLE con el requerimiento.");
        }
        else
        {
            Console.WriteLine("Resultado: La fuerza NO CUMPLE con el requerimiento.");
        }
    }
}