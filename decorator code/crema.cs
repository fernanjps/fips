
public class crema : agregadodecorator
{
    public crema(bebidacomponent bebida) : base(bebida) { }
    public override double costo => _bebida.costo + 4;
    public override string descripcion => string.Format($"{_bebida.descripcion}, crema");
        
}
