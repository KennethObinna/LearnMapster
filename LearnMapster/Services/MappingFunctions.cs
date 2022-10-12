using LearnMapster.Models;
using LearnMapster.Models.DTOs;
using Mapster;
using System.Collections.Generic;
using System.Linq;

namespace LearnMapster.Services
{
    public static class MappingFunctions
    {
        private static readonly Person _person = DemoData.CreatePerson();
        private static readonly ICollection<Person> _people = DemoData.CreatePeople();
        private static readonly ICollection<ParentPoco> _parentPoco = DemoData.CreateParentPoco();
        public static PersonDto MapPersonToNewDto()
        {
            var personDto = _person.Adapt<PersonDto>();

            return personDto;
        }
        public static PersonDto MapPersonToExistingDto()
        {
            var personDto = new PersonDto();
            _person.Adapt(personDto);

            return personDto;
        }
        public static IQueryable<PersonDto> MapPersonQueryableToDtoQueryable()
        {
            var peopleQueryable = _people.AsQueryable();
            var personDtos = peopleQueryable.ProjectToType<PersonDto>();

            return personDtos;
        }
        public static PersonShortInfoDto CustomMapPersonToShortInfoDto()
        {
            var personShortInfoDto = _person.Adapt<PersonShortInfoDto>();

            return personShortInfoDto;
        }

 public static PersonShortInfoWithAddress CustomMapPersonToShortInfoDtoWithAddress()
        {
            var personShortInfoDto = _person.Adapt<PersonShortInfoWithAddress>();

            return personShortInfoDto;
        }

 public static IQueryable<ParentPocoDTO> CustomParentPoco()
        {
            var parentPoco = _parentPoco.AsQueryable()
                .ProjectToType<ParentPocoDTO>();

            return parentPoco;
        }
 public static IQueryable<ParentPocoDTO2> CustomParentPoco2()
        {
            var parentPoco = _parentPoco.AsQueryable()
                .ProjectToType<ParentPocoDTO2>();

            return parentPoco;
        }


    }
}
