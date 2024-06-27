namespace Solution.DTO;

public class PrescriptionDTO
{
    public string FristNamePatient { get; set; }
    public string LastNamePatient { get; set; }
    public DateOnly BirthDatePatient { get; set; }
    
    public string FirstNameDoctor { get; set; }
    public string LastNameDoctor { get; set; }
    public string EmailDoctor { get; set; }
    

    public List<MedicamentDTO> Medicaments { get; set; }
}