using System.ComponentModel.DataAnnotations;

namespace Banquinho.Models.Response;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public string? Message { get; set; } 
    public bool Success { get; set; } 
    public DateTime dateTime { get; set; } 

    public ServiceResponse()
    {
        this.dateTime = DateTime.Now;
        this.Message = String.Empty;
        this.Success = true;
    }
}