using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IDbContext
    {
        /// <summary>
        /// Get DbSets
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns>DbSet</returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// Save changes
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText,params object[] parameters) 
            where TEntity : BaseEntity,new();

        IEnumerable<TElement> SqlQuery<TElement>(string sql,params object[] parameters);

        int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters);

        /// <summary>
        /// Detach an entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Detach(object entity);

        /// <summary>
        /// Gets or sets a value indicating whether proxy creation setting is enabled (used in EF)
        /// </summary>
        bool ProxyCreationEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto detect changes setting is enabled (used in EF)
        /// </summary>
        bool AutoDetectChangesEnabled { get; set; }
    }
}
