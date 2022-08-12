using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class NewStudentLessonBuilder : LessonBuilder
    {
        public override void GetLesson()
        {
            lesson=new Lesson();
            lesson.Id = 1;
            lesson.Name = "Artificial Intelligence - Beginner to Advanced";
            lesson.Price = 49.99D;
        }
        public override void ApplyDiscount()
        {
            lesson.DiscountedPrice = lesson.Price * 0.5;
            lesson.IsDiscountApplied = true;
        }

        public override void AddLessonNote()
        {
            lesson.LessonNote = "Lesson for new student. discount applied!";
        }

        public override Lesson GetResult()
        {
            return lesson;
        }
    }
}
