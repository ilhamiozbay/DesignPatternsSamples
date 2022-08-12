using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class OldStudentLessonBuilder : LessonBuilder
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
            lesson.DiscountedPrice = lesson.Price;
            lesson.IsDiscountApplied = false;
        }

        public override void AddLessonNote()
        {
            lesson.LessonNote = "Lesson for old student. Welcome again!";
        }

        public override Lesson GetResult()
        {
            return lesson;
        }
    }
}
