using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _todoItems;

        public TodoQueryTests()
        {
            _todoItems = new List<TodoItem>();

            _todoItems.Add(new TodoItem("Tarefa 1", DateTime.Now, "user A"));
            _todoItems.Add(new TodoItem("Tarefa 2", DateTime.Now, "user A"));
            _todoItems.Add(new TodoItem("Tarefa 3", DateTime.Now, "leonardoferreira"));
            _todoItems.Add(new TodoItem("Tarefa 4", DateTime.Now, "user A"));
            _todoItems.Add(new TodoItem("Tarefa 5", DateTime.Now, "user A"));

        }


        [TestMethod]
        public void Deve_retornar_tarefas_somente_do_usuario_indicado()
        {
            var result = _todoItems.AsQueryable().Where(TodoQueries.GetAll("leonardoferreira"));

            Assert.AreEqual(1, result.Count());
        }
    }
}
