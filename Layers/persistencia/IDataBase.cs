using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
/// <summary>
/// Interfaz que define las operaciones comunes para el acceso y manipulación de una base de datos.
/// </summary>
public interface IDataBase: IDisposable 
{
    IDbConnection _Conexion { get; set; }
    double ExecuteNonQuery(IDbCommand pCommand);
    int ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel);
    int  ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel);
    double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel);
    IDataReader ExecuteReader(IDbCommand pCommand);
    DataSet ExecuteReader(IDbCommand pCommand, string pTabla);
    double ExecuteScalar(IDbCommand pCommand, IsolationLevel readCommitted);

    Task<DataTable> ExecuteReaderAsync(SqlCommand pCommand, String pTabla);

    Task<SqlDataReader> ExecuteReaderAsync(SqlCommand pCommand);

    Task<int> ExecuteNonQueryAsync(SqlCommand pCommand, IsolationLevel pIsolationLevel);

    Task<double> ExecuteScalarAsync(SqlCommand pCommand);


}