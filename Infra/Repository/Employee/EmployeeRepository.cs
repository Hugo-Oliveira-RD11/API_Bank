using Banquinho.Infra.DataConnection.Postgres;
using Banquinho.Models.Employeeses;
using Banquinho.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Banquinho.Infra.Repository.Employee;

public class EmployeeRepository : IEmployeeRepository
{
    /*private async void SaveDB(AppDbContextPSQL db)
    {
        await db.SaveChangesAsync();
    }*/
    private readonly AppDbContextPSQL _context;

    public EmployeeRepository(AppDbContextPSQL context)
    {
        _context = context;
    }


    public async Task<ServiceResponse<List<Employees>>> GetEmployeesAsync()
    {
         ServiceResponse<List<Employees>> response = new ServiceResponse<List<Employees>>();
        
        response.Data = await _context.Employee.ToListAsync();
        
        return response;

    }

    public async Task<ServiceResponse<Employees>> GetEmployeesByIdAsync(Guid id)
    {
        ServiceResponse<Employees> response = new ServiceResponse<Employees>();
        try
        {
            response.Data = await _context.Employee.FirstOrDefaultAsync(e => e.Id == id);
            if (response.Data is null)
            {
                response.Success = false;
                response.Message = "O funcionario não foi encontrado ";
                return response;
            }
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<List<Employees>>> CreateEmployeesReturnListAsync(Employees employee)
    {
        ServiceResponse<List<Employees>> response = new ServiceResponse<List<Employees>>();
        try
        {
            _context.Employee.Add(employee);
            response.Message = "foi criado com sucesso";
            response.Data = await _context.Employee.ToListAsync();
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }
        return response;
    }

    public async Task<ServiceResponse<Employees>> CreateEmployeesAsync(Employees employee)
    {
        ServiceResponse<Employees> response = new ServiceResponse<Employees>();
        try
        {
            response.Data = _context.Employee.Single(e => e.Id == employee.Id);
            if (response.Data is not null)
            {
            response.Success = false;
            response.Message = "Funcionario ja existe";
            }
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            response.Data = _context.Employee.Single(e => e.Id == employee.Id);
            response.Message = "foi criado com sucesso";
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }
        return response;
    }

    public async Task<ServiceResponse<List<Employees>>> DeleteEmployeesByIdReturnListAsync(Guid id)
    {
        ServiceResponse<List<Employees>> response = new ServiceResponse<List<Employees>>();
        ServiceResponse<Employees> data = new ServiceResponse<Employees>();
        try
        {
             data.Data = _context.Employee.Single(e => e.Id == id);
            if (data.Data is null)
            {
                response.Success = false;
                response.Message = "O funcionario não foi achado";
                return response;
            }
            _context.Employee.Remove(data.Data);
            response.Data = await _context.Employee.ToListAsync();
            response.Message = "foi deletado com sucesso";
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }
        return response;
    }

    public async Task<ServiceResponse<Employees>> DeleteEmployeesAsync(Guid id)
    {
        ServiceResponse<Employees> response = new ServiceResponse<Employees>();
        try
        {
             response.Data = _context.Employee.Single(e => e.Id == id);
            if (response.Data is null)
            {
                response.Success = false;
                response.Message = "O funcionario não foi achado";
                return response;
            }
            _context.Employee.Remove(response.Data);
            await _context.SaveChangesAsync();
            response.Message = "foi deletado com sucesso";
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }
        return response;
    }

    public async Task<ServiceResponse<Employees>> UpdateEmployeesAsync(Employees employee)
    {
        ServiceResponse<Employees> response = new ServiceResponse<Employees>();
        try
        {
             response.Data = _context.Employee.Single(e => e.Id == employee.Id);
            if (response.Data is null)
            {
                response.Success = false;
                response.Message = "O funcionario não foi achado";
                return response;
            }
            
            response.Data.agencia = employee.agencia; 
            response.Data.cargo = employee.cargo; 
            response.Data.codigo = employee.codigo;
            response.Data.Modified = DateTime.Now;
            response.Data.Ativo = employee.Ativo;
            
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
        }
        return response;
    }

    public Task<ServiceResponse<List<Employees>>> UpdateEmployeesReturnListAsync(Employees employee)
    {
        throw new NotImplementedException();
    }
}