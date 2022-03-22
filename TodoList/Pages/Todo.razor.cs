namespace TodoList.Pages
{
    partial class Todo
    {
        public List<TodoItem> todos = new();
        public string? newTodo { get; set; }
        
        public string? Titel { get; set; }

        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }

        protected override void OnInitialized()
        {
            Titel = "EUX H5 Todo list";
            base.OnInitialized();
        }
    }
}
