using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Teste passando um comando válido", "Leonardo de Freitas Ferreira", DateTime.Now);


        //Primeira parte dos testes onde tudo deve ser errado - RED

        /* 
                [TestMethod]
                public void Dado_um_comando_invalido()
                 {
                     Assert.Fail();
                 }
                 [TestMethod]
                 public void Dado_um_comando_valido()
                 {

                     Assert.Fail();
                 }
        */

        //Segunda parte dos testes onde tudo deve ser certo - GREEN

        /*        
                [TestMethod]
                public void Dado_um_comando_invalido()
                {
                    var command = new CreateTodoCommand("", "", DateTime.Now);
                    command.Validate();
                    Assert.AreEqual(command.Invalid, true);
                }

                [TestMethod]
                public void Dado_um_comando_valido()
                {
                    var command = new CreateTodoCommand("Teste passando um comando válido", "Leonardo de Freitas Ferreira", DateTime.Now);
                    command.Validate();
                    Assert.AreEqual(command.Invalid, false);
                }
        */

        //Refatorando os testes

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            _invalidCommand.Validate();
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            _validCommand.Validate();
            Assert.AreEqual(_validCommand.Valid, true);
        }

    }
}
