using System.Globalization;
using Application.TodoLists.Queries.ExportToDtos;
using CsvHelper.Configuration;

namespace Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done); // .ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}

