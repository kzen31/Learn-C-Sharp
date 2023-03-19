// type casting is convert to another data type
// Input from user console program is always string

double age = 25.5;
Console.WriteLine(age);
Console.WriteLine("Data type age is " + age.GetTypeCode() + "\n");

int ageFromDouble = Convert.ToInt32(age);
Console.WriteLine(ageFromDouble);
Console.WriteLine("Data type from double is " + ageFromDouble.GetTypeCode() + "\n");

string ageString = "22";
Console.WriteLine(ageString);
Console.WriteLine("Data type ageString is " + ageString.GetTypeCode() + "\n");

int ageFromString = Convert.ToInt32(ageString);
Console.WriteLine(ageFromString);
Console.WriteLine("Data type ageFromString is " + ageFromString.GetTypeCode() + "\n");

double ageToDouble = Convert.ToDouble(ageString);
Console.WriteLine(ageToDouble);
Console.WriteLine("Data type ageString is " + ageToDouble.GetTypeCode() + "\n");

string oneAgeOnly = "9";

char ageToChar = Convert.ToChar(oneAgeOnly);
Console.WriteLine(ageToChar);
Console.WriteLine("Data type ageToChar is " + ageToChar.GetTypeCode() + "\n");

int ageFromChar = Convert.ToInt32(ageToChar);
Console.WriteLine(ageFromChar);
Console.WriteLine("Data type ageFromChar is " + ageFromChar.GetTypeCode() + "\n");

string ageToString = Convert.ToString(age);
Console.WriteLine(ageToString);
Console.WriteLine("Data type ageToString is " + ageToString.GetTypeCode() + "\n");

string alive = "TruE";

bool aliveBool = Convert.ToBoolean(alive);
Console.WriteLine(aliveBool);
Console.WriteLine("Data type aliveBool is " + aliveBool.GetTypeCode() + "\n");


// Catatan
// string 3.12 dikonvert ke int = error >> tidak bisa ada karakter lain selain angka
// string 3.12 dikonvert ke double = 312 >> titik tidak terbaca
// string 3.12 dikonvert ke char = error >> harus satu karakter
// double 25.5 dikonvert ke int = 26 >> maka akan dibulatkan + 1 jika >= 0.5
// string dikonvert ke boolean >> akan error jika sintaks selain "true" dan "false" // Huruf besar & kecil tidak berpengaruh

// yg tidak bermasalah: 
// tipe data apa saja di konvert ke string
// tipe data int ke double
// tipe data double ke int

