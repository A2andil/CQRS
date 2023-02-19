using Application.Common.Mapping;
using Domain.Entities;

namespace Application.TodoLists.Queries.ExportToDtos;

public record TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}

