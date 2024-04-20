namespace ScreenSound.Outros
{
    internal class Logo(string logoStr)
    {
        public void ExibirLogo()
        {
            
            Console.Write(LogStr);

        }

        public string LogStr { get; } = logoStr;


    }
}
