using p1bpoo.MisClases;

Chofer piloto1 = new("Monica", 25, "A");
Chofer piloto2 = new("Andrea", 21, "M");
Chofer piloto3 = new("Juana", 30, "B"); 

Vehiculo sedan = new(2025, "Azul", "Honda");

String respuesta;
respuesta = sedan.AsignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.Acelerar(25);

Moto honda = new(2025, "Rojo", "Honda Africa Twin CRF1100L");
Console.WriteLine(honda.AsignarPiloto(piloto3));

Trailer1 kenworth = new(2025, "Blanco", "Kenworth T680", 10000);
Console.WriteLine(kenworth.AsignarPiloto(piloto3));

Bus1 mercedes = new(2025, "Negro", "Mercedes-Benz Tourismo", 50);
Console.WriteLine(mercedes.AsignarPiloto(piloto3));
//Vehiculo miCarrito = new(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();