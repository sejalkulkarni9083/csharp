using system;
using System.Collections.Generic;
using System.Linq;

public class SubjectRepository : ISubjectRepository
{
    private readonly Iconfiguration _configuration;
    private readonly string _connectionString;

    public SubjectRepository(Iconfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }
}