namespace HoneyRaesAPI.Models.DTOs;

public class ServiceTicketDTO
{
    public int Id { get; set; }
    public string CustomerId { get; set; }
    public string EmployeeId { get; set; }
    public string Description { get; set; }
    public Boolean Emergency { get; set; }
    public DateTime DateCompleted { get; set; }
}