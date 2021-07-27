using System.Collections.Generic;
using Prism.Commands;
using Prism.Mvvm;

namespace PrismApplicationDemo.TodoModule.ViewModels {
    public class TodoListViewModel : BindableBase {
        public List<Todo> TodoList { get; } = new() {
            new Todo() {Text = "Prism wiederholen"},
            new Todo() {Text = "Videothek mit Prism und EFCore"},
            new Todo() {Text = "IDisposable wiederholen"},
            new Todo() {Text = "Chillen", Completed = true}
        };

        public DelegateCommand<Todo> SelectTodoCommand { get; private set; }

        public TodoListViewModel() {
            SelectTodoCommand = new DelegateCommand<Todo>(SelectTodo);
        }

        private void SelectTodo(Todo todo) {
            // TODO: send message to TodoDetailsView
            // SelectedTodo = todo;
        }
    }
}
