using ca_sln_media_health.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace ca_sln_media_health.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
