using Flunt.Notifications;
using Flunt.Validations;
using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public CreateTodoCommand() { }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Title", "O título deve conter mais de 3 caracteres")
                .HasMinLen(User, 3, "User", "Usuário deve conter mais de 3 caracteres")
                );
        }
    }
}
