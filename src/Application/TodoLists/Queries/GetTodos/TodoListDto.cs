using ca_sln_media_health.Application.Common.Mappings;
using ca_sln_media_health.Domain.Entities;
using System.Collections.Generic;

namespace ca_sln_media_health.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
}
