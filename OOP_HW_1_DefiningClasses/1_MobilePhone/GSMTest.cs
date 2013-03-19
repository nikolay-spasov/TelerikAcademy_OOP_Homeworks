using System;

class GSMTest
{
    public static void Test()
    {
        GSM[] phones = new GSM[]
        {
            new GSM("3310", "Nokia", 200m, "John",
                new Battery("123-23AFF", BatteryType.LiIon, 24, 3),
                new Display(4, 1)),
            new GSM("k700i", "Sony-Ericsson", 50m, "Me",
                new Battery("Ox-315F", BatteryType.Unknown, 48, 5),
                new Display(4, 65000)),
            new GSM("Lumnia", "Nokia"),
            new GSM("iPhone", "Apple",
                new Battery("aa-22", 100, 10),
                new Display(8, 2000000)),
            new GSM("M-35", "Siemens", 50m, "Radi predi 10 godini")
        };

        foreach (var gsm in phones)
        {
            Console.WriteLine("=========================");
            Console.WriteLine(gsm);
        }

        Console.WriteLine("=========================");
        Console.WriteLine(GSM.IPhone4S);
    }
}

