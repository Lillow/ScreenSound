namespace ScreenSound.Modelos
{
    internal interface IAvaliavel
    {
        public float Media { get; }

        public void AdicionarNota(Avaliacao nota);
    }
}
