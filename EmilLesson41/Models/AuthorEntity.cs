using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilLesson41.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public Guid CourseID { get; set; }
        public CourseEntity? Course { get; set; }
        public CourseEntity[]? Courses { get; set; }
    }
}
