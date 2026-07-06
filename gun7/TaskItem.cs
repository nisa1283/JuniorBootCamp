namespace gun7
{
    class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public TaskItem(string title, string description, bool isCompleted, DateTime createdDate)
        {
            this.Description = description;
            this.Title = title;
            this.IsCompleted = isCompleted;
            this.CreatedDate = createdDate;
        }

        public override string ToString()
        {
            return $"{Title} | {Description} | {(IsCompleted ? "Tamamlandı" : "Bekliyor")} | {CreatedDate}";
        }
    }


}

