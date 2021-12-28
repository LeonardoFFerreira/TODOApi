using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Queries;
using Todo.Domain.Repositories;

namespace Todo.Domain.Infra.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public void Create(TodoItem todo)
        {
            _context.Add(todo);
            _context.SaveChanges();

        }
        public void Update(TodoItem todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IEnumerable<TodoItem> GetAll(string user)
        {
            return _context.Todos.AsNoTracking() //Não cria obj em memo.
                                 .Where(TodoQueries.GetAll(user))
                                 .OrderBy(todos => todos.Date);
        }
        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            return _context.Todos.AsNoTracking()
                                 .Where(TodoQueries.GetAllDone(user))
                                 .OrderBy(todos => todos.Date);
        }
        public IEnumerable<TodoItem> GetAllUndone(string user)
        {
            return _context.Todos.AsNoTracking()
                                 .Where(TodoQueries.GetAllUndone(user))
                                 .OrderBy(todos => todos.Date);
        }
        public IEnumerable<TodoItem> GetByDate(string user, DateTime date, bool done)
        {
            return _context.Todos.AsNoTracking()
                                 .Where(TodoQueries.GetByDate(user, date, done))
                                 .OrderBy(todos => todos.Date);
        }
        public TodoItem GetByIdAndUser(Guid id, string user)
        {
            return _context.Todos.Where(todo => todo.Id == id && 
                                        todo.User == user)
                                  .FirstOrDefault();
        }
    }
}
