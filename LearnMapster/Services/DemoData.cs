using LearnMapster.Models;
using System;
using System.Collections.Generic;

namespace LearnMapster.Services
{
    public class DemoData
    {
        public static Person CreatePerson()
        {
            return new Person()
            {
                Title = "Mr.",
                FirstName = "Peter",
                LastName = "Pan",
                DateOfBirth = new DateTime(2000, 1, 1),
                Address = new Address()
                {
                    Country = "Neverland",
                    PostCode = "123N",
                    Street = "Funny Street 2",
                    City = "Neverwood"
                },
            };
        }
        public static ICollection<Person> CreatePeople()
        {
            ICollection<Person> opp = new List<Person>();
            var pp = new Person()
            {
                Title = "Mr.",
                FirstName = "Peter",
                LastName = "Pan",
                DateOfBirth = new DateTime(2000, 1, 1),
                Address = new Address()
                {
                    Country = "Neverland",
                    PostCode = "123N",
                    Street = "Funny Street 2",
                    City = "Neverwood"
                },
            };

            opp.Add(pp);
            opp.Add(pp);
            opp.Add(pp);
            opp.Add(pp);
            opp.Add(pp);
            opp.Add(pp);
            opp.Add(pp);

            return opp;
        }
        public static ICollection<ParentPoco> CreateParentPoco()
        {
            ICollection<ParentPoco> data = new List<ParentPoco>();
            for (int i = 0; i < 30; i++)
            {
                var grand = new List<ChildrenChildPoco>();
                var child = new List<ChildPoco>();

                for (int j = 0; j < 10; j++)
                {
                    grand.Add(
                          new ChildrenChildPoco
                          {
                              Id = j+1, Name="Grand_"+ Guid.NewGuid().ToString("P"),
                          });
                };

                for (int j = 0; j < 10; j++)
                {
                    child.Add(
                          new ChildPoco
                          {
                              Id = j + 1,
                              Name = "Child_" + Guid.NewGuid().ToString("P"),
                          });
                };


                var opp = new ParentPoco()
                {
                    Id = i + 1,
                    Name = "Parent_" + Guid.NewGuid().ToString("D"),
                    Children = new List<ChildPoco>
                 {
                     new ChildPoco(){ Id = i+1, Name ="Child_"+ Guid.NewGuid().ToString("N"),

                         GrandChildren=grand
                         } }
                };
                data.Add(opp);
            }
               
            
            return data;


        }
    }
}
