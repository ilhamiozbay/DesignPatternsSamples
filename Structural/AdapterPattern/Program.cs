// Bir sınıfın arayüzünü istemcinin beklediği arayüze çevirmeye yarar.
// Farklı sistemleri kendi sistemimize dahil ederken bazen yapılar uyuşmayabiliyor. Buradaki yapılar arayüzler olabilir. Bu desenin amacı arayüz için bir adapter oluşturarak sanki kendi sistemimize aitmiş gibi çalıştırmayı sağlar. Özetle; uyumsuz bir yapıyı, istemcinin beklediği bir yapıya getirir.

using AdapterPattern;

var customOperation = new CustomOperation(new CustomSerializerAdapter());
string serializedObject = customOperation.SerializeObject(new object());

Console.WriteLine(serializedObject); // output: serialized with CustomSerializer
