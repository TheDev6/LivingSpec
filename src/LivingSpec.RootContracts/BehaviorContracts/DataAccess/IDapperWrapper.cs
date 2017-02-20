namespace LivingSpec.RootContracts.BehaviorContracts.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public interface IDapperWrapper
    {
        IEnumerable<TResult> Call<TResult>(Func<IDbConnection, IEnumerable<TResult>> func) where TResult : class, new();
        Task<IEnumerable<TResult>> CallAsync<TResult>(Func<IDbConnection, Task<IEnumerable<TResult>>> func) where TResult : class, new();
        IEnumerable<TResult> CallProcedure<TResult>(string procedureName, object inputParams) where TResult : class, new();
        Task<IEnumerable<TResult>> CallProcedureAsync<TResult>(string procedureName, object inputParams) where TResult : class, new();
        IEnumerable<TResult> CallwithTransaction<TResult>(Func<IDbConnection, IEnumerable<TResult>> func, IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted) where TResult : class, new();
        Task<IEnumerable<TResult>> CallwithTransactionAsync<TResult>(Func<IDbConnection, Task<IEnumerable<TResult>>> func, IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted) where TResult : class, new();
        void ExecuteProcedure(string procedureName, object inputParams);
        Task ExecuteProcedureAsync(string procedureName, object inputParams);
    }
}