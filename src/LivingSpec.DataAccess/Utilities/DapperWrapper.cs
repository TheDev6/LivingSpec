namespace LivingSpec.DataAccess.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;
    using Dapper;
    using RootContracts.BehaviorContracts.DataAccess;

    public class DapperWrapper : IDapperWrapper
    {
        private readonly IDatabaseProvider _databaseProvider;

        public DapperWrapper(IDatabaseProvider databaseProvider)
        {
            this._databaseProvider = databaseProvider;
        }

        public IEnumerable<TResult> CallProcedure<TResult>(string procedureName, object inputParams) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                return sqlConnection.Query<TResult>(sql: procedureName, param: inputParams, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<TResult>> CallProcedureAsync<TResult>(string procedureName, object inputParams) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                return await sqlConnection.QueryAsync<TResult>(sql: procedureName, param: inputParams, commandType: CommandType.StoredProcedure)
                    .ConfigureAwait(false);
            }
        }

        public void ExecuteProcedure(string procedureName, object inputParams)
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                sqlConnection.Execute(sql: procedureName, param: inputParams, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task ExecuteProcedureAsync(string procedureName, object inputParams)
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                await sqlConnection.ExecuteAsync(sql: procedureName, param: inputParams, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }

        public IEnumerable<TResult> Call<TResult>(Func<IDbConnection, IEnumerable<TResult>> func) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                return func(sqlConnection);
            }
        }

        public async Task<IEnumerable<TResult>> CallAsync<TResult>(Func<IDbConnection, Task<IEnumerable<TResult>>> func) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                return await func(sqlConnection).ConfigureAwait(false);
            }
        }

        public IEnumerable<TResult> CallwithTransaction<TResult>(
            Func<IDbConnection, IEnumerable<TResult>> func,
            IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                using (var transaction = sqlConnection.BeginTransaction(iso: isolationLevel))
                {
                    var result = func(sqlConnection);
                    transaction.Commit();
                    return result;
                }
            }
        }

        public async Task<IEnumerable<TResult>> CallwithTransactionAsync<TResult>(
            Func<IDbConnection, Task<IEnumerable<TResult>>> func,
            IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted) where TResult : class, new()
        {
            using (var sqlConnection = this._databaseProvider.GetConnection())
            {
                using (var transaction = sqlConnection.BeginTransaction(iso: isolationLevel))
                {
                    var result = await func(sqlConnection).ConfigureAwait(false);
                    transaction.Commit();
                    return result;
                }
            }
        }
    }
}