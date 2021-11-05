using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodoItem = new TodoItem("Novo todo", DateTime.Now, "Leonardo");

        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_estar_concuido()
        {
            Assert.AreEqual(_validTodoItem.Done, false);
        }

    }
}
