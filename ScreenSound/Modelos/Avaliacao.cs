namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(float nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }
    public float Nota { get;}

    public static Avaliacao Parse(string s)
    {
        float.TryParse(s, out float nota);

        return new Avaliacao(nota);
    }
}
