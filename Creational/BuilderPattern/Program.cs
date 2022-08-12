// Builder deseni, karmaşık yapıdaki nesnelerin oluşturulmasında istemcinin sadece nesne tipini belirterek üretimi gerçekleştirebilmesini sağlamak için kullanılan bir desendir. Bu desende istemcinin kullanmak istediği gerçek ürünün birden fazla sunumunun olduğu durumlarda kullanılır.

using BuilderPattern;

LessonBuilder builder1=new NewStudentLessonBuilder();
LessonBuilder builder2=new OldStudentLessonBuilder();

LessonDirector lessonDirector1 = new LessonDirector(builder1);
LessonDirector lessonDirector2 =new LessonDirector(builder2);

lessonDirector1.Make();
lessonDirector2.Make();

Lesson lesson1 = builder1.GetResult();
Lesson lesson2 =builder2.GetResult();

Console.WriteLine($"{lesson1.Name} - {lesson1.Price} - {lesson1.DiscountedPrice} - {lesson1.LessonNote}");
Console.WriteLine($"{lesson2.Name} - {lesson2.Price} - {lesson2.DiscountedPrice} - {lesson2.LessonNote}");
