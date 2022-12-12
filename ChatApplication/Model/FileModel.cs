using System;

namespace ChatApplication.Model
{
    [Serializable]
    public class FileModel
    {
        public string file_name;
        public byte[] file_content;
        public string Name
        {
            get { return file_name; }
            set { file_name = value; }
        }
        public byte[] Content 
        { 
            get { return file_content; } 
            set { file_content = value; } 
        }
        public FileModel(string file_name, byte[] file_content)
        {
            this.file_name = file_name;
            this.file_content = file_content;
        }
    }
}
