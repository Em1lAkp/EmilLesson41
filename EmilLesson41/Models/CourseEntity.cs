using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilLesson41.Models
{
    public  class CourseEntity
    {
        public Guid Id { get; set; }
        public string? Title { get; set; } 
        public string? Description { get; set; }
        public decimal? Price { get; set; } 
        public Guid AuthorID {  get; set; } 
        public AuthorEntity? Author { get; set; }
        public List<LessonsEntity>? Lessons { get; set; } 
        public List<StudentEntity>? Students { get; set; }
    }
}
