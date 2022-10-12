namespace LearnMapster.Models
{
    public class ParentPoco
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<ChildPoco> Children { get; set; }

    }
    

    public class ChildPoco
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public List<ChildrenChildPoco>? GrandChildren{ get; set; }

    }
  
    public class ChildrenChildPoco
    {
        public string? Name { get; set; }
        public int Id { get; set; }

    }
    public class ParentPocoDTO
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public List<ChildPocoDTO>? Children { get; set; }

    }
    public class ParentPocoDTO2
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public List<ChildPocoDTO>? Children { get; set; }

    }
    public class ChildPocoDTO
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public List<ChildrenChildPocoDTO>? GrandChildren { get; set; }

    }
    public class ChildrenChildPocoDTO
    {
        public string? Name { get; set; }
        public int Id { get; set; }

    }


}
