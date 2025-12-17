using system;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class SubjectRepository : ISubjectRepository
{
    private readonly Iconfiguration _configuration;
    private readonly string _connectionString;

    public SubjectRepository(Iconfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetconnectionString("DefaultConnection");
    }


    public async Task<List<subjectmodel>> GetAllSubjects()
    {
        List<subjectmodel> subjects = new List<subjectmodel>();

        String query = "@ select* from subjects";
        
    MySqlConnection connection = new MySqlConnection(connectionstring);
    MySqlCommand command = new MySqlCommand (query, connection);

        try
        {
            await connection.OpenAsync();
            
        }


        
    }
}