using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }


        public void Update(TodoItem todo)
        {
        }
        public TodoItem GetByIdAndUser(Guid id, string user)
        {
            return new TodoItem("Nova tarefa", DateTime.Now, "leonardo");
        }
    }
}
