/* Copyright (C) Grupo Kyoka SAS - All Rights Reserved. Proprietary and confidential.
 * Unauthorized copying of this file, via any medium is strictly prohibited.  
 * File Author:     Felipe Suarez <suarez.a.felipe@gmail.com>
 * Date Created:    November 2017
 * Description:     Database Context to handle all the business objects related to the domain USERS.
 *                  All the classes that are going to be mapped to the DB are registered here.
 *                  For more information Google: "ORM", "Entity Framework", "EF DbContext"
 */

using AdminCore.BusinessLogic.Users.Models;
using AdminCore.Persistence.Audit;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Domain.Users
{
    public class UserContext : MainContext, IUserContext
    {
        public UserContext(ISessionManager sessionManager) : base(sessionManager)
        {
        }

        public DbSet<Persons> Persons { get; set; }
    }
}
