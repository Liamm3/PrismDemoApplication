using Prism.Mvvm;

namespace PrismApplicationDemo.TodoModule.ViewModels {
    public class TodoDetailsViewModel : BindableBase {
        private Todo? _todo;

        public string? Text {
            get => _todo?.Text;
            set {
                if (_todo != null) {
                    _todo.Text = value;
                }
            }
        }

        public bool Completed {
            get => _todo != null && _todo.Completed;
            set {
                if (_todo != null) {
                    _todo.Completed = value;
                }
            }
        }
    }
}
