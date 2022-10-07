//Definimos variables de Ramon
int edadRamon = 35;
string cocheRamon = "Jaguar";
float alturaRamon = 188.5f;

//Probamos los operadores relacionales
bool resultado;

resultado = 18 < 30;

resultado = 19 > 30;

resultado = 25 <= 25;

resultado = 26 >= 44;

resultado = 66 == 66;

resultado = "Hola" != "Hola";

//Probamos los operadores lógicos

//Queremos saber si Ramón mide más de 180 Y si nació antes del 1960
resultado = alturaRamon > 180 && edadRamon > 62;

//Queremos saber si Ramón mide más de 180 O si nació antes del 1960
resultado = alturaRamon > 180 || edadRamon > 62;

//Queremos saber si Ramón no tiene un Maserati
resultado = !(cocheRamon == "Maserati");