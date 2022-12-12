namespace ChatApplication.Model
{
    public class FileModel
    {
        public string file_name { get; set; }
        public byte[] file_content { get; set; }
        public FileModel(string file_name, byte[] file_content)
        {
            this.file_name = file_name;
            this.file_content = file_content;
        }
    }
}
