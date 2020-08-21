using ca_sln_media_health.Application.Common.Mappings;
using ca_sln_media_health.Domain.Entities;

namespace ca_sln_media_health.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
