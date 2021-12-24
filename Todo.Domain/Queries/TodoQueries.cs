using System;
using System.Linq.Expressions;
using Todo.Domain.Entities;

namespace Todo.Domain.Queries
{
    public static class TodoQueries
    {
        public static Expression<Func<TodoItem, bool>> GetAll(string user)
        {
            return todos => todos.User == user;
        }

        public static Expression<Func<TodoItem, bool>> GetAllDone(string user)
        {
            return todos => todos.User == user && todos.Done == true;
        }

        public static Expression<Func<TodoItem, bool>> GetAllUndone(string user)
        {
            return todos => todos.User == user && todos.Done == false;
        }

        public static Expression<Func<TodoItem, bool>> GetByDate(string user, DateTime date, bool done)
        {
            return todos => todos.User == user &&
                            todos.Date == date.Date &&
                            todos.Done == done;
        }

    }
}
