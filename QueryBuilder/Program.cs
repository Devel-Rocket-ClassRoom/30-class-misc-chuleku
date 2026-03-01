using System;
using System.Text;
QueryBuilder builder = new QueryBuilder();
Console.WriteLine("=== 기본 쿼리 ===");
string basicQuery = builder.Select("*").From("Users").Build();
Console.WriteLine(basicQuery);
Console.WriteLine();

Console.WriteLine("=== 조건 쿼리 ===");
string conditionQuery = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18")
    .Build();
Console.WriteLine(conditionQuery);
Console.WriteLine();

Console.WriteLine("=== 정렬 쿼리 ===");
string orderQuery = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18")
    .Build();
Console.WriteLine(orderQuery);

public class QueryBuilder
{
    private string _selectClause = "";
    private string _fromClause = "";
    private string _whereClause = "";
    private string _orderByClause = "";

    public QueryBuilder Select(string columns)
    {
        _selectClause = $"SELECT {columns}";
        return this;
    }

    public QueryBuilder From(string table)
    {
        _fromClause = $"FROM {table}";
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        _whereClause = $"WHERE {condition}";
        return this;
    }

    public QueryBuilder OrderBy(string column)
    {
        _orderByClause = $"ORDER BY {column}";
        return this;
    }

    public string Build()
    {
        StringBuilder sb = new StringBuilder();
        if (!string.IsNullOrEmpty(_selectClause)) sb.Append(_selectClause);
        if (!string.IsNullOrEmpty(_fromClause)) sb.Append(" " + _fromClause);
        if (!string.IsNullOrEmpty(_whereClause)) sb.Append(" " + _whereClause);
        if (!string.IsNullOrEmpty(_orderByClause)) sb.Append(" " + _orderByClause);

        return sb.ToString().Trim();
    }
}