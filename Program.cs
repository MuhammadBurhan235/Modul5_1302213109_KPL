using modul5_1302213109;


long angka1 = new Console.ReadLine();
long angka2 = new Console.ReadLine();
long angka3 = new Console.ReadLine();

Penjumlahan<long> ab = new Penjumlahan<long>(angka1, angka2, angka3);

String data = new Console.ReadLine();
String tanggal = new Console.ReadLine();
SimpleDataBase<String, String> bz = new SimpleDataBase<String, String>(data, tanggal);

