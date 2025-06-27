namespace FilePickerHang
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private readonly List<Task<FileResult?>> _tasks = [];

        private async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            var completedTasks = _tasks.Where(t => t.IsCompleted).Count();
            var inProgressTasks = _tasks.Where(t => !t.IsCompleted).Count();
            TaskCountLabel.Text = $"Picked tasks: {completedTasks}, Hanging tasks: {inProgressTasks}";

            var fileResultTask = FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Please select a file"
            });

            _tasks.Add(fileResultTask);
            var fileResult = await fileResultTask;

            if (fileResult == null)
            {
                return;
            }

            FileNameLabel.Text = fileResult.FileName;
        }
    }
}
