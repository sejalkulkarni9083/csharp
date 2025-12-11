using system;
using System.Collections.Generic;
using System.Linq;

public class SubjectRepository : ISubjectRepository
{
    private readonly Iconfiguration _configuration;
    private readonly string _connectionString;
}