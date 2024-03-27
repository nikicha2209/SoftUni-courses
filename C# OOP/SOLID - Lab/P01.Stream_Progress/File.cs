namespace P01.Stream_Progress
{
    public class File : StreamableFile
    {
        private string name;

        public File(string name, int length, int bytesSent) 
            : base(length, bytesSent)
        {
            this.name = name;
        }

    }
}
