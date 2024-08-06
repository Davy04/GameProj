using Microsoft.Data.SqlClient;
using System.Collections.Generic;
namespace GameProj.DB;
internal class CompanyDAL
{
    private readonly GameProjContext context;

    public CompanyDAL(GameProjContext context)
    {
         this.context = context;
    }
    
    public IEnumerable<Company> Listar()
    {
        return context.Companies.ToList();
    }

    public void Adicionar(Company company)
    {
        context.Companies.Add(company);
        context.SaveChanges();
    }
        
    public void Atualizar(Company company)
    {
        context.Companies.Update(company);
        context.SaveChanges();
    }
    
    public void Deletar(Company company)
    {
        context.Companies.Remove(company);
        context.SaveChanges();
    }
}