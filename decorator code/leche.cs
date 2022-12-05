
public class leche : agregadodecorator
{
    public leche(bebidacomponent bebida) : base(bebida) {}
    public override double costo => _bebida.costo + 2;
    public override string descripcion => string.Format($"{_bebida.descripcion}, leche");
}
    
