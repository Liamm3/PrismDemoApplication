using System.Collections.Generic;
using Prism.Commands;
using Prism.Mvvm;

namespace PrismApplicationDemo.TodoModule.ViewModels {
    public class TodolistViewModel : BindableBase {
        public List<Todo> Todolist { get; } = new() {
            new Todo() {Text = "Prism wiederholen"},
            new Todo() {Text = "Videothek mit Prism und EFCore"},
            new Todo() {Text = "IDisposable wiederholen"},
            new Todo() {Text = "Chillen", Completed = true}
        };

        public Todo SelectedTodo { get; set; }

        public DelegateCommand<Todo> SelectTodoCommand { get; private set; }

        public TodolistViewModel() {
            SelectedTodo = Todolist[0];
            SelectTodoCommand = new DelegateCommand<Todo>(SelectTodo);
        }

        private void SelectTodo(Todo todo) => SelectedTodo = todo;
    }
}
