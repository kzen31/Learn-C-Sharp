Console.WriteLine("Input your name here ");
string name = Console.ReadLine();

Console.WriteLine("Your name is " + name);

Console.WriteLine("Input your age here");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your age is " + age);

/* Catatan:
 * input yang dimasukkan melalui console selalu string,
 * oleh sebab itu perlu dikonversi dan perlu handle exception jika format input tidak sesuai dengan yang ditentukan
*/