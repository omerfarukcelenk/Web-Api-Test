using Dapper;
using System.Data;

namespace Sinav
{
    public class DapperRepository : IDapperRepository
    {
        private readonly IDbConnection _dbConnection;

        public DapperRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<TDto> QueryFirstOrDefaultAsync<TDto>(string sql, object param = null)
        {

            return await _dbConnection.QueryFirstOrDefaultAsync<TDto>(sql, param);
        }

        public async Task<IEnumerable<TDto>> QueryAsync<TDto>(string sql, object param = null)
        {

            return await _dbConnection.QueryAsync<TDto>(sql, param);
        }

        public async Task<SqlMapper.GridReader> GetMultipleAsync(string sql, object param = null)
        {
            return await _dbConnection.QueryMultipleAsync(sql, param);
        }

        public async Task<int> ExecuteAsync(string sql, object param = null)
        {

            return await _dbConnection.ExecuteAsync(sql, param);
        }
    }
}
