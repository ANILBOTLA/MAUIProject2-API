using TodoAPI.Interfaces;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoList;

        public TodoRepository() => InitializeData();

        public IEnumerable<TodoItem> All
        {
            get { return _todoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _todoList.Any(item => item.ID == id);
        }

        public TodoItem Find(string id)
        {
            return _todoList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(TodoItem item)
        {
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var todoItem = this.Find(item.ID);
            var index = _todoList.IndexOf(todoItem);
            _todoList.RemoveAt(index);
            _todoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _todoList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _todoList = new List<TodoItem>();

            var todoItem1 = new TodoItem
            {
                ID = "1",
                Expression = "5/2",
                Option1 = "2.5",
                Option2 = "6",
                Option3="7"
            };

            var todoItem2 = new TodoItem
            {
                ID = "2",
                Expression = "0+0",
                Option1 = "88",
                Option2 = "0",
                Option3 = "2"
            };

            var todoItem3 = new TodoItem
            {
                ID = "3",
                Expression = "6-9",
                Option1 = "00",
                Option2 = "-3",
                Option3 = "6"
            };

            var todoItem4 = new TodoItem
            {
                ID = "4",
                Expression = "6*9",
                Option1 = "99",
                Option2 = "54",
                Option3 = "6"
            };

            var todoItem5 = new TodoItem
            {
                ID = "5",
                Expression = "√4",
                Option1 = "2",
                Option2 = "54",
                Option3 = "6"
            };

            var todoItem6 = new TodoItem
            {
                ID = "6",
                Expression = "4%2",
                Option1 = "0",
                Option2 = "5",
                Option3 = "2"
            };

            var todoItem7 = new TodoItem
            {
                ID = "7",
                Expression = "(3-1)*2",
                Option1 = "99",
                Option2 = "09",
                Option3 = "04"
            };

            var todoItem8 = new TodoItem
            {
                ID = "8",
                Expression = "(6/3)*2",
                Option1 = "04",
                Option2 = "44",
                Option3 = "98"
            };


            var todoItem9 = new TodoItem
            {
                ID = "9",
                Expression = "(6*3)*2",
                Option1 = "04",
                Option2 = "36",
                Option3 = "98"
            };

            var todoItem10 = new TodoItem
            {
                ID = "10",
                Expression = "(6-3)-2",
                Option1 = "1",
                Option2 = "11",
                Option3 = "111"
            };

            _todoList.Add(todoItem1);
            _todoList.Add(todoItem2);
            _todoList.Add(todoItem3);
            _todoList.Add(todoItem4);
            _todoList.Add(todoItem5);
            _todoList.Add(todoItem6);
            _todoList.Add(todoItem7);
            _todoList.Add(todoItem8);
            _todoList.Add(todoItem9);
            _todoList.Add(todoItem10);
        }
    }
}
