using System;
using System.Collections.Generic;
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

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByDate(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }
    }
}
