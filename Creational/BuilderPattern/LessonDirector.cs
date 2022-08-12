using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class LessonDirector
    {
        private LessonBuilder _lessonBuilder;

        public LessonDirector(LessonBuilder lessonBuilder)
        {
            _lessonBuilder = lessonBuilder;
        }

        public void Make()
        {
            _lessonBuilder.GetLesson();
            _lessonBuilder.ApplyDiscount();
            _lessonBuilder.AddLessonNote();
        }
    }
}
