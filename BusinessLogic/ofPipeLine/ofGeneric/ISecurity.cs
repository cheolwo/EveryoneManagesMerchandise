using System;
using BusinessData;
using Microsoft.AspNetCore.Identity;
using BusinessData.ofFinancial.Model;

namespace BusinessLogic.ofPipeLine.ofInterface
{
    public interface ISecuritable
    {
        string GetIPAddress();
        string GetMacAddress();
        IdentityRole GetRoles();
    }
    public interface IRelationable
    {
        Type GetRelationType();
    }
    public interface IJournable
    {
        Journal GetJournal(Entity entity);
    }
    
}