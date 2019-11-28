using System.Collections.Generic;
using Abp.Application.Services;

namespace TestMultipleDB.Services
{
    public interface ITestAppService : IApplicationService
    {
        List<string> GetPeople();

        List<string> GetCourses();

        List<string> GetPeopleAndCourses();

        void CreatePerson(string name);

        void CreateCourse(string name);
    }
}
