using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyGame.Models
{
    public class RoleProvider
    {
        private StrategyGameEntities db = new StrategyGameEntities();

        //public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string ApplicationName
        //{
        //    get { throw new NotImplementedException(); }
        //    set { throw new NotImplementedException(); }
        //}

        //public override void CreateRole(string roleName)
        //{
        //    throw new NotImplementedException();
        //}

        //public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string[] GetAllRoles()
        //{
        //    throw new NotImplementedException();
        //}

        //public override string[] GetRolesForUser(string username)
        //{
        //    string sRoles = db.Gamer.Where(p => p.Email_GMR == username).FirstOrDefault().Email_GMR;
        //    string[] retorno = { sRoles };
        //    return retorno;
        //    throw new NotImplementedException();
        //}

        //public override string[] GetUsersInRole(string roleName) { throw new NotImplementedException(); }
        //public override bool IsUserInRole(string username, string roleName) { throw new NotImplementedException(); }
        //public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames) { throw new NotImplementedException(); }
        //public override bool RoleExists(string roleName) { throw new NotImplementedException(); }

    }
}