class ElfoNegro : Monstro
{
    public ElfoNegro() : base("Elfo Negro", 200, 4, 2, 100, 100) { }

    public override Monstro EncontrarMonstro()
    {
        return new ElfoNegro();
    }
}
