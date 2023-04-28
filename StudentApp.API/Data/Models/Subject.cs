using StudentApp.API.Data.Base;

namespace StudentApp.API.Data.Models
{
    public class Subject : BaseClass
    {
        public string Code { get; set; }
        public string Name { get; set; }

        //Define Reference with Student table
        public List<Student> Students { get; set; }
    }
}
