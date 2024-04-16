// See https://aka.ms/new-console-template for more information
Storm s = new Storm("wind", false, "Zul'rajas");
s.Announce();

Pupil p = new Pupil("Mezil-kree");
Storm windStorm = p.CastWindStorm();
Console.WriteLine(windStorm.Announce());

Mage m = new Mage("Gul'dan");
Storm rainStorm = m.CastRainStorm();
Console.WriteLine(rainStorm.Announce());

Archmage a = new Archmage("Nielas Aran");
Storm lightningStorm = a.CastLightningStorm();
Console.WriteLine(lightningStorm.Announce());
