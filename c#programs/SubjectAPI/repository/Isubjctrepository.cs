


using System.ComponentModel;
using System.Runtime.CompilerServices;

public interface Isubjectrepository
{
    Task<List<subjectmodel>> GetAllSubjects();
}